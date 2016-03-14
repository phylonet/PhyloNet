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

namespace Amazon.IpnReturnUrlValidation
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Text;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;
    using System.Web;

    public class SignatureUtilsForOutbound
    {
        private static readonly String SIGNATURE_KEYNAME = "signature";
        private static readonly String SIGNATURE_METHOD_KEYNAME = "signatureMethod";
        private static readonly String SIGNATURE_VERSION_KEYNAME = "signatureVersion";
        private static readonly String SIGNATURE_VERSION_2 = "2";
        private static readonly String RSA_SHA1_ALGORITHM = "SHA1withRSA";
        private static readonly String CERTIFICATE_URL_KEYNAME = "certificateUrl";
        private static readonly String EMPTY_STRING = "";

        // Constants used when constructing the string to sign for v2
        public static readonly String NewLine = "\n";
        public static readonly String EmptyUriPath = "/";
        public static readonly String equals = "=";
        public static readonly String And = "&";

        public static readonly String UTF_8_Encoding = "UTF-8";
        public static IDictionary<String, String> keyStore = new Dictionary<String, String>();

        /**
         * Your aws access key. 
         */
        private String awsAccessKey;

        /**
         * Your 40 character aws secret key. Required only for ipn or return url verification signed using signature version1.
         */
        private String awsSecretKey;

        /**
         *  Use this for verifying IPNs or return urls signed using signature version 2.
         */
        public SignatureUtilsForOutbound()
        {
        }

        /**
         *  Use this for verifying IPNs or return urls signed using signature version 1.
         */
        public SignatureUtilsForOutbound(String awsAccessKey, String awsSecretKey)
        {
            this.awsAccessKey = awsAccessKey;
            this.awsSecretKey = awsSecretKey;
        }

        /**
         * Validates the request by checking the integrity of its parameters.
         * @param parameters - all the http parameters sent in IPNs or return urls. 
         * @param urlEndPoint should be the url which recieved this request. 
         * @param httpMethod should be either POST (IPNs) or GET (returnUrl redirections)
         */
        public Boolean validateRequest(IDictionary<String, String> parameters,
               String urlEndPoint, String httpMethod) 
        {
            String signatureVersion = null;
            //This is present only in case of signature version 2. If this is not present we assume this is signature version 1.
            try
            {
                signatureVersion = parameters[SIGNATURE_VERSION_KEYNAME];
            }
            catch (KeyNotFoundException e)
            {
                signatureVersion = null;
            }

            if(SIGNATURE_VERSION_2.Equals(signatureVersion))
                return validateSignatureV2(parameters, urlEndPoint, httpMethod);
            else
                return validateSignatureV1(parameters);
         }

        /**
          * Verifies the signature using PKI.
          */
        private Boolean validateSignatureV2(IDictionary<String, String> parameters,
            String urlEndPoint, String httpMethod)
        {
            //1. input validation.
            String signature = parameters[SIGNATURE_KEYNAME];
            if (signature == null)
            {
                throw new Exception("'signature' is missing from the parameters.");
            }

            String signatureMethod = parameters[SIGNATURE_METHOD_KEYNAME];
            if (signatureMethod == null)
            {
                throw new Exception("'signatureMethod' is missing from the parameters.");
            }

            String signatureAlgorithm = getSignatureAlgorithm(signatureMethod);
            if (signatureAlgorithm == null)
            {
                throw new Exception("'signatureMethod' present in parameters is invalid. " +
                        "Valid signatureMethods are : 'RSA-SHA1'");
            }

            String certificateUrl = parameters[CERTIFICATE_URL_KEYNAME];
            if (certificateUrl == null)
            {
                throw new Exception("'certificateUrl' is missing from the parameters.");
            }

            String certificate = getPublicKeyCertificateAsString(certificateUrl);
            if (certificate == null)
            {
                throw new Exception("public key certificate could not fetched from url: " + certificateUrl);
            }

            //2. calculating the string to sign
            String stringToSign = EMPTY_STRING;
            try
            {
                Uri uri = new Uri(urlEndPoint);
                String hostHeader = getHostHeader(uri);
                String requestURI = getRequestURI(uri);
                stringToSign = calculateStringToSignV2(parameters, httpMethod, hostHeader, requestURI);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            //3. verify signature 
            try
            {
                byte[] signatureBytes = base64DecodeToBytes(signature);
                X509Certificate2 x509Cert = new X509Certificate2(StrToByteArray(certificate));
                RSACryptoServiceProvider RSA = (RSACryptoServiceProvider)x509Cert.PublicKey.Key;
                return RSA.VerifyData(StrToByteArray(stringToSign), new SHA1Managed(), signatureBytes);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Boolean validateSignatureV1(IDictionary<String, String> parameters)
        {
            if (this.awsSecretKey == null)
            {
                throw new Exception("Secret key should be set");
            }
            String stringToSign = calculateStringToSignV1(parameters);
            String signature = parameters[SIGNATURE_KEYNAME];
            String sig;
            try
            {
                ASCIIEncoding encoding = new ASCIIEncoding();
                HMAC Hmac = HMAC.Create("HmacSHA1");
                Hmac.Key = encoding.GetBytes(this.awsSecretKey);
                Hmac.Initialize();
                CryptoStream cs = new CryptoStream(Stream.Null, Hmac, CryptoStreamMode.Write);
                cs.Write(encoding.GetBytes(stringToSign), 0, encoding.GetBytes(stringToSign).Length);
                cs.Close();
                byte[] rawResult = Hmac.Hash;
                sig = Convert.ToBase64String(rawResult, 0, rawResult.Length);

            }
            catch (Exception e)
            {
                throw new Exception("Failed to generate HMAC : " + e.Message);
            }
            return sig.Equals(signature);
        }


        /**
        * Calculate String to Sign for SignatureVersion 1
        * 
        * @param parameters
        *            request parameters
        * @return String to Sign
        */
        private String calculateStringToSignV1(IDictionary<String, String> parameters)
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
         * 
         * @param parameters
         * @param httpMethod
         *            - POST or GET
         * @param hostHeader
         *            - Service end point
         * @param requestURI
         *            - Path
         * @return String to Sign
         */
        private String calculateStringToSignV2(IDictionary<String, String> parameters, String httpMethod, String hostHeader, String requestURI)
        {
            StringBuilder stringToSign = new StringBuilder();
            if (httpMethod == null) throw new Exception("HttpMethod cannot be null");
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
                stringToSign.Append(v2UrlEncode(requestURI, true));
            stringToSign.Append(NewLine);

            IDictionary<String, String> sortedParamMap = new SortedDictionary<String, String>(parameters, StringComparer.Ordinal);
            foreach (String key in sortedParamMap.Keys)
            {
                if (String.Compare(key, SIGNATURE_KEYNAME, true) == 0) continue;
                stringToSign.Append(v2UrlEncode(key, false));
                stringToSign.Append(equals);
                stringToSign.Append(v2UrlEncode(sortedParamMap[key], false));
                stringToSign.Append(And);
            }

            String result = stringToSign.ToString();
            return result.Remove(result.Length - 1);
        }


        public String v2UrlEncode(String data, bool path)
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


        
        public String urlDecode(String value)
        {
            return HttpUtility.UrlDecode(value, Encoding.UTF8);
        }

        private String getHostHeader(Uri uri)
        {
            int port = uri.Port;
            if (port != -1)
            {
                if(uri.Scheme.Equals(Uri.UriSchemeHttps) && port ==443
                    || uri.Scheme.Equals(Uri.UriSchemeHttp) && port == 80)
                    port = -1;
            }
            return uri.Host.ToLower() + (port != -1 ? ":" + port : "");
        }

        private String getRequestURI(Uri uri) {
            String requestURI = uri.LocalPath;
            if (requestURI == null || requestURI.Equals(EMPTY_STRING)) {
                requestURI = "/";
            } else {
                requestURI = urlDecode(requestURI);
            }
            return requestURI;
        }

        private String getSignatureAlgorithm(String signatureMethod) {
            if ("RSA-SHA1".Equals(signatureMethod)) {
                return RSA_SHA1_ALGORITHM;
            }
            return null;
        }

        private String getPublicKeyCertificateAsString(String certificateUrl) {

            if (keyStore.ContainsKey(certificateUrl)) return keyStore[certificateUrl];
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(certificateUrl);
            request.AllowAutoRedirect = false;
            HttpWebResponse resp = (HttpWebResponse)request.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader read = new StreamReader(stream);
            String data = read.ReadToEnd();
            try
            {
                keyStore.Add(certificateUrl, data);
            }
            catch (ArgumentException e)
            {
                // Parallel calls to this method will write duplicate entry into keystore
            } 
            return data;
        }

        // Base64 decode a string
        public static byte[] base64DecodeToBytes(String data)
        {
            return Convert.FromBase64String(data);
        }

        // Convert a string to a byte array.
        public static byte[] StrToByteArray(String str)
        {
            return new UTF8Encoding().GetBytes(str);
        }

    }
}
