/******************************************************************************* 
 *  Copyright 2008 Amazon Technologies, Inc.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 *    __  _    _  ___ 
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 * 
 *  Amazon FPS CSharp Library
 *  API Version: 2008-09-17
 *  Generated: Wed Sep 23 02:51:11 PDT 2009 
 * 
 */

/**
 * CBUI Utility class to sign and validate query string  
 */
namespace Amazon.CBUI
{
        using System;
        using System.Text;
        using System.Collections.Generic;
        using System.IO;
        using System.Security.Cryptography;
        using System.Web;
        
        public abstract class AmazonFPSCBUIPipeline
        {
            public static readonly String SIGNATURE_KEYNAME = "signature";
            public static readonly String SIGNATURE_METHOD_KEYNAME = "signatureMethod";
            public static readonly String SIGNATURE_VERSION_KEYNAME = "signatureVersion";
            public static readonly String SIGNATURE_VERSION_1 = "1";
            public static readonly String SIGNATURE_VERSION_2 = "2";
            public static readonly String HMAC_SHA1_ALGORITHM = "HmacSHA1";
            public static readonly String HMAC_SHA256_ALGORITHM = "HmacSHA256";

            public static readonly String HTTP_GET_METHOD = "GET";
            public static readonly String EMPTY_STRING = "";

            // Constants used when constructing the string to sign for v2
            public static readonly String NewLine = "\n";
            public static readonly String EmptyUriPath = "/";
            public static String equals = "=";
            public static readonly String And = "&";
            public static readonly String UTF_8_Encoding = "UTF-8";

            /**
             * Amazon Web Services Access Key ID.
             * @var string|bool 20-character, alphanumeric string, or false if this is an anonymous account
             */
            protected String awsAccessKey; 
        
            /**
             * Amazon Web Services Secret Access Key.
             * @var string 40-character string
             */
            protected String awsSecretKey;

            /**
             * The default URL corresponds to production environment. Change the URL for sandbox environment.
             */ 
            protected static String CBUI_URL = "https://authorize.payments-sandbox.amazon.com/cobranded-ui/actions/start";

            protected String pipelineName;
            /**
             * Array to store the name value pairs of the request. Sorting is required to sign the request
             */
            protected IDictionary<String, String> parameters = new SortedDictionary<String, String>();
        
            /**
             * Version parameter for consistent signature for incoming and outgoing requests
             */
            protected static String VERSION = "2009-01-09";

            /**
             * SignatureVersion parameter to sign the cbui pipeline requests
             */
            protected static String SIGNATURE_VERSION = "2";

            /**
             * Default SignatureMethod parameter to sign the cbui pipeline requests
             */
            protected static String SIGNATURE_METHOD = "HmacSHA256";

            /**
             * Default constructor
             * 
             * @param awsAccessKey    Amazon Web Services Access Key ID.
             * @param awsSecretKey   Amazon Web Services Secret Access Key.
             */
            public AmazonFPSCBUIPipeline(String pipelineName, String awsAccessKey, String awsSecretKey)
            {
                this.awsSecretKey = awsSecretKey;
                this.awsAccessKey = awsAccessKey;
                this.pipelineName = pipelineName;

                //Add default parameters
                addParameter("callerKey", awsAccessKey);
                addParameter("pipelineName", pipelineName);
                addParameter("version", VERSION);
                addParameter("signatureVersion", SIGNATURE_VERSION);
                addParameter("signatureMethod", SIGNATURE_METHOD);
            }
        
            /**
             * Adds any custom name value pair to the query string
             *
             * @param key    Key of the key-value pair in querystring
             * @param value  Value of the key-value pair in querystring
             */
            public void addParameter(String key, String value)
            {
                this.parameters[key] = value;
            }

            /**
             * Adds a set of parameters to existing parameters.
             *
             * @param params
             */
            public void addOptionalParameters(Dictionary<String, String> map)
            {
                foreach (String key in map.Keys)
                {
                    this.addParameter(key, map[key]);
                }
            }

            protected void validateCommonMandatoryParameters(IDictionary<String, String> map)
            {
                if (!parameters.ContainsKey("callerKey"))
                {
                    throw new AmazonCBUIException("callerKey is missing in parameters.");
                }

                if (!parameters.ContainsKey("pipelineName"))
                {
                    throw new AmazonCBUIException("pipelineName is missing in parameters.");
                }

                if (!parameters.ContainsKey("version"))
                {
                    throw new AmazonCBUIException("version is missing in parameters.");
                }

                if (!parameters.ContainsKey("returnURL"))
                {
                    throw new AmazonCBUIException("returnURL is missing in parameters.");
                }

                if (!parameters.ContainsKey("callerReference"))
                {
                    throw new AmazonCBUIException("callerReference is missing in parameters.");
                }
            }

            protected abstract void validateParameters(IDictionary<String, String> map);

            protected String constructUrl(IDictionary<String, String> map)
            {
                if (parameters == null || parameters.Count == 0)
                {
                    throw new AmazonCBUIException("Parameters can not be empty.");
                }

                Uri uri = new Uri(CBUI_URL);
                String hostHeader = getHostHeader(uri);
                String requestURI = getRequestURI(uri);

                String signature = signParameters(parameters, HTTP_GET_METHOD, hostHeader, requestURI);
                parameters.Add("signature", signature);

                String queryString = constructQueryString(parameters);

                return CBUI_URL + "?" + queryString;
            }

            protected String constructQueryString(IDictionary<String, String> map)
            {
                String queryString = "";
                foreach (String key in map.Keys)
                {
                    if (queryString.Length > 0) queryString += "&";
                    queryString += key + "=" + UrlEncode(map[key], false);
                }

                if (queryString.Length > 0) queryString += "&";
                return queryString;
            }

            /**
             * Constructs the query string for the parameters added to this class
             *
             * This function also calculates the signature of the all the name value pairs
             * added to the class. 
             *
             * @return string  URL 
             */
            public String getURL()
            {
                validateCommonMandatoryParameters(parameters);
                validateParameters(parameters);
                return constructUrl(parameters);
            }

            /**
	         * Computes RFC 2104-compliant HMAC signature for request parameters
	         * Implements AWS Signature, as per following spec:
	         *
	         * If Signature Version is 0, then V1 algorithm is used for ASP and CBUI apps only.
	         *
	         * If Signature Version is 1, it performs the following:
	         *
	         * Sorts all  parameters (including SignatureVersion and excluding Signature,
	         * the value of which is being created), ignoring case.
	         *
	         * Iterate over the sorted list and append the parameter name (in original case)
	         * and then its value. It will not URL-encode the parameter values before
	         * constructing this string. There are no separators.
	         *
	         * If Signature Version is 2, string to sign is based on following:
	         *
	         *    1. The HTTP Request Method followed by an ASCII newline (%0A)
	         *    2. The HTTP Host header in the form of lowercase host, followed by an ASCII newline.
	         *    3. The URL encoded HTTP absolute path component of the URI
	         *       (up to but not including the query string parameters);
	         *       if this is empty use a forward '/'. This parameter is followed by an ASCII newline.
	         *    4. The concatenation of all query string components (names and values)
	         *       as UTF-8 characters which are URL encoded as per RFC 3986
	         *       (hex characters MUST be uppercase), sorted using lexicographic byte ordering.
	         *       Parameter names are separated from their values by the '=' character
	         *       (ASCII character 61), even if the value is empty.
	         *       Pairs of parameter and values are separated by the '&' character (ASCII code 38).
	         *
	         */
            public String signParameters(IDictionary<String, String> parameters, String HttpMethod, String Host, String RequestURI) //throws Exception
            {
                String algorithm = HMAC_SHA1_ALGORITHM;
                String stringToSign = null;
                if (parameters.ContainsKey(SIGNATURE_VERSION_KEYNAME)
                    && String.Compare("2", parameters[SIGNATURE_VERSION_KEYNAME], true) == 0)
                {
                    algorithm = parameters[SIGNATURE_METHOD_KEYNAME];
                    stringToSign = calculateStringToSignV2(parameters, HttpMethod, Host, RequestURI);
                }
                else
                {
                    stringToSign = calculateStringToSignV1(parameters);
                }
                return sign(stringToSign, this.awsSecretKey, algorithm);
            }

            /**
            * Calculate String to Sign for SignatureVersion 1
            * @param parameters request parameters
            * @return String to Sign
            */
            private static String calculateStringToSignV1(IDictionary<String, String> parameters)
            {
                StringBuilder data = new StringBuilder();
                IDictionary<String, String> sorted =
                  new SortedDictionary<String, String>(parameters, StringComparer.OrdinalIgnoreCase);
                foreach (KeyValuePair<String, String> pair in sorted)
                {
                    if (pair.Value != null)
                    {
                        if (String.Compare(pair.Key, SIGNATURE_KEYNAME, true) == 0) continue;
                        data.Append(pair.Key);
                        data.Append(pair.Value);
                    }
                }
                return data.ToString();
            }

            /**
             * Calculate String to Sign for SignatureVersion 2
             * @param parameters
             * @param httpMethod - POST or GET
             * @param hostHeader - Service end point
             * @param requestURI - Path
             * @return
             */
            private static String calculateStringToSignV2(IDictionary<String, String> parameters, String httpMethod, String hostHeader, String requestURI)// throws SignatureException
            {
                StringBuilder stringToSign = new StringBuilder();
                if (httpMethod == null) throw new AmazonCBUIException("HttpMethod cannot be null");
                stringToSign.Append(httpMethod);
                stringToSign.Append(NewLine);

                // The host header - must eventually convert to lower case
                // Host header should not be null, but in Http 1.0, it can be, in that
                // case just append empty string ""
                if (hostHeader == null)
                    stringToSign.Append("");
                else
                    stringToSign.Append(hostHeader.ToLower());
                stringToSign.Append(NewLine);

                if (requestURI == null || requestURI.Length == 0)
                    stringToSign.Append(EmptyUriPath);
                else
                    stringToSign.Append(UrlEncode(requestURI, true));
                stringToSign.Append(NewLine);

                IDictionary<String, String> sortedParamMap = new SortedDictionary<String, String>(parameters, StringComparer.Ordinal);
                foreach (String key in sortedParamMap.Keys)
                {
                    if (String.Compare(key, SIGNATURE_KEYNAME, true) == 0) continue;
                    stringToSign.Append(UrlEncode(key, false));
                    stringToSign.Append(equals);
                    stringToSign.Append(UrlEncode(sortedParamMap[key], false));
                    stringToSign.Append(And);
                }

                String result = stringToSign.ToString();
                return result.Remove(result.Length - 1);
            }

            public String urlDecode(String value)
            {
                return HttpUtility.UrlDecode(value, Encoding.UTF8);
            }

            private String getHostHeader(Uri uri)
            {
                int port = uri.Port;
                if (port != -1)
                {
                    if (uri.Scheme.Equals(Uri.UriSchemeHttps) && port == 443
                        || uri.Scheme.Equals(Uri.UriSchemeHttp) && port == 80)
                        port = -1;
                }
                return uri.Host.ToLower() + (port != -1 ? ":" + port : "");
            }

            private String getRequestURI(Uri uri)
            {
                String requestURI = uri.LocalPath;
                if (requestURI == null || requestURI.Equals(EMPTY_STRING))
                {
                    requestURI = "/";
                }
                else
                {
                    requestURI = urlDecode(requestURI);
                }
                return requestURI;
            }

            public static String UrlEncode(String data, bool path)
            {
                StringBuilder encoded = new StringBuilder();
                String unreservedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~" + (path ? "/" : "");

                foreach (char symbol in System.Text.Encoding.UTF8.GetBytes(data))
                {
                    if (unreservedChars.IndexOf(symbol) != -1)
                    {
                        encoded.Append(symbol);
                    }
                    else
                    {
                        encoded.Append("%" + String.Format("{0:X2}", (int)symbol));
                    }
                }

                return encoded.ToString();

            }

            /**
             * Computes RFC 2104-compliant HMAC signature.
             */
            public static String sign(String data, String key, String signatureMethod)// throws SignatureException
            {
                try
                {
                    ASCIIEncoding encoding = new ASCIIEncoding();
                    HMAC Hmac = HMAC.Create(signatureMethod);
                    Hmac.Key = encoding.GetBytes(key);
                    Hmac.Initialize();
                    CryptoStream cs = new CryptoStream(Stream.Null, Hmac, CryptoStreamMode.Write);
                    cs.Write(encoding.GetBytes(data), 0, encoding.GetBytes(data).Length);
                    cs.Close();
                    byte[] rawResult = Hmac.Hash;
                    String sig = Convert.ToBase64String(rawResult, 0, rawResult.Length);
                    return sig;
                }
                catch (Exception e)
                {
                    throw new AmazonCBUIException("Failed to generate signature: " + e.Message);
                }
            }

        }
}
