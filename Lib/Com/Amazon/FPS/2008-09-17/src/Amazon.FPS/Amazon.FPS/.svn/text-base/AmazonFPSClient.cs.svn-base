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

using System;
using System.Web;
using System.Net;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Globalization;
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.FPS.Model;
using Amazon.FPS;


namespace Amazon.FPS
{


   /**

    *
    * AmazonFPSClient is an implementation of AmazonFPS
    *
    */
    public class AmazonFPSClient : AmazonFPS
    {

        private String awsAccessKeyId = null;
        private String awsSecretAccessKey = null;
        private AmazonFPSConfig config = null;

        /// <summary>
        /// Constructs AmazonFPSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonFPSClient(String awsAccessKeyId, String awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonFPSConfig())
        {
        }


        /// <summary>
        /// Constructs AmazonFPSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">configuration</param>
        public AmazonFPSClient(String awsAccessKeyId, String awsSecretAccessKey, AmazonFPSConfig config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = config;
        }


        // Public API ------------------------------------------------------------//

        
        /// <summary>
        /// Cancel Token 
        /// </summary>
        /// <param name="request">Cancel Token  request</param>
        /// <returns>Cancel Token  Response from the service</returns>
        /// <remarks>
        /// 
        /// Cancels any token installed by the calling application on its own account.
        /// 
        /// </remarks>
        public CancelTokenResponse CancelToken(CancelTokenRequest request)
        {
            return Invoke<CancelTokenResponse>(ConvertCancelToken(request));
        }

        
        /// <summary>
        /// Cancel 
        /// </summary>
        /// <param name="request">Cancel  request</param>
        /// <returns>Cancel  Response from the service</returns>
        /// <remarks>
        /// 
        /// Cancels an ongoing transaction and puts it in cancelled state.
        /// 
        /// </remarks>
        public CancelResponse Cancel(CancelRequest request)
        {
            return Invoke<CancelResponse>(ConvertCancel(request));
        }

        
        /// <summary>
        /// Fund Prepaid 
        /// </summary>
        /// <param name="request">Fund Prepaid  request</param>
        /// <returns>Fund Prepaid  Response from the service</returns>
        /// <remarks>
        /// 
        /// Funds the prepaid balance on the given prepaid instrument.
        /// 
        /// </remarks>
        public FundPrepaidResponse FundPrepaid(FundPrepaidRequest request)
        {
            return Invoke<FundPrepaidResponse>(ConvertFundPrepaid(request));
        }

        
        /// <summary>
        /// Get Account Activity 
        /// </summary>
        /// <param name="request">Get Account Activity  request</param>
        /// <returns>Get Account Activity  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns transactions for a given date range.
        /// 
        /// </remarks>
        public GetAccountActivityResponse GetAccountActivity(GetAccountActivityRequest request)
        {
            return Invoke<GetAccountActivityResponse>(ConvertGetAccountActivity(request));
        }

        
        /// <summary>
        /// Get Account Balance 
        /// </summary>
        /// <param name="request">Get Account Balance  request</param>
        /// <returns>Get Account Balance  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the account balance for an account in real time.
        /// 
        /// </remarks>
        public GetAccountBalanceResponse GetAccountBalance(GetAccountBalanceRequest request)
        {
            return Invoke<GetAccountBalanceResponse>(ConvertGetAccountBalance(request));
        }

        
        /// <summary>
        /// Get Debt Balance 
        /// </summary>
        /// <param name="request">Get Debt Balance  request</param>
        /// <returns>Get Debt Balance  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the balance corresponding to the given credit instrument.
        /// 
        /// </remarks>
        public GetDebtBalanceResponse GetDebtBalance(GetDebtBalanceRequest request)
        {
            return Invoke<GetDebtBalanceResponse>(ConvertGetDebtBalance(request));
        }

        
        /// <summary>
        /// Get Outstanding Debt Balance 
        /// </summary>
        /// <param name="request">Get Outstanding Debt Balance  request</param>
        /// <returns>Get Outstanding Debt Balance  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the total outstanding balance for all the credit instruments for the given creditor account.
        /// 
        /// </remarks>
        public GetOutstandingDebtBalanceResponse GetOutstandingDebtBalance(GetOutstandingDebtBalanceRequest request)
        {
            return Invoke<GetOutstandingDebtBalanceResponse>(ConvertGetOutstandingDebtBalance(request));
        }

        
        /// <summary>
        /// Get Prepaid Balance 
        /// </summary>
        /// <param name="request">Get Prepaid Balance  request</param>
        /// <returns>Get Prepaid Balance  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the balance available on the given prepaid instrument.
        /// 
        /// </remarks>
        public GetPrepaidBalanceResponse GetPrepaidBalance(GetPrepaidBalanceRequest request)
        {
            return Invoke<GetPrepaidBalanceResponse>(ConvertGetPrepaidBalance(request));
        }

        
        /// <summary>
        /// Get Token By Caller 
        /// </summary>
        /// <param name="request">Get Token By Caller  request</param>
        /// <returns>Get Token By Caller  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the details of a particular token installed by this calling application using the subway co-branded UI.
        /// 
        /// </remarks>
        public GetTokenByCallerResponse GetTokenByCaller(GetTokenByCallerRequest request)
        {
            return Invoke<GetTokenByCallerResponse>(ConvertGetTokenByCaller(request));
        }

        
        /// <summary>
        /// Cancel Subscription And Refund 
        /// </summary>
        /// <param name="request">Cancel Subscription And Refund  request</param>
        /// <returns>Cancel Subscription And Refund  Response from the service</returns>
        /// <remarks>
        /// 
        /// Cancels a subscription.
        /// 
        /// </remarks>
        public CancelSubscriptionAndRefundResponse CancelSubscriptionAndRefund(CancelSubscriptionAndRefundRequest request)
        {
            return Invoke<CancelSubscriptionAndRefundResponse>(ConvertCancelSubscriptionAndRefund(request));
        }

        
        /// <summary>
        /// Get Token Usage 
        /// </summary>
        /// <param name="request">Get Token Usage  request</param>
        /// <returns>Get Token Usage  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the usage of a token.
        /// 
        /// </remarks>
        public GetTokenUsageResponse GetTokenUsage(GetTokenUsageRequest request)
        {
            return Invoke<GetTokenUsageResponse>(ConvertGetTokenUsage(request));
        }

        
        /// <summary>
        /// Get Tokens 
        /// </summary>
        /// <param name="request">Get Tokens  request</param>
        /// <returns>Get Tokens  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns a list of tokens installed on the given account.
        /// 
        /// </remarks>
        public GetTokensResponse GetTokens(GetTokensRequest request)
        {
            return Invoke<GetTokensResponse>(ConvertGetTokens(request));
        }

        
        /// <summary>
        /// Get Total Prepaid Liability 
        /// </summary>
        /// <param name="request">Get Total Prepaid Liability  request</param>
        /// <returns>Get Total Prepaid Liability  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the total liability held by the given account corresponding to all the prepaid instruments owned by the account.
        /// 
        /// </remarks>
        public GetTotalPrepaidLiabilityResponse GetTotalPrepaidLiability(GetTotalPrepaidLiabilityRequest request)
        {
            return Invoke<GetTotalPrepaidLiabilityResponse>(ConvertGetTotalPrepaidLiability(request));
        }

        
        /// <summary>
        /// Get Transaction 
        /// </summary>
        /// <param name="request">Get Transaction  request</param>
        /// <returns>Get Transaction  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns all details of a transaction.
        /// 
        /// </remarks>
        public GetTransactionResponse GetTransaction(GetTransactionRequest request)
        {
            return Invoke<GetTransactionResponse>(ConvertGetTransaction(request));
        }

        
        /// <summary>
        /// Get Transaction Status 
        /// </summary>
        /// <param name="request">Get Transaction Status  request</param>
        /// <returns>Get Transaction Status  Response from the service</returns>
        /// <remarks>
        /// 
        /// Gets the latest status of a transaction.
        /// 
        /// </remarks>
        public GetTransactionStatusResponse GetTransactionStatus(GetTransactionStatusRequest request)
        {
            return Invoke<GetTransactionStatusResponse>(ConvertGetTransactionStatus(request));
        }

        
        /// <summary>
        /// Get Payment Instruction 
        /// </summary>
        /// <param name="request">Get Payment Instruction  request</param>
        /// <returns>Get Payment Instruction  Response from the service</returns>
        /// <remarks>
        /// 
        /// Gets the payment instruction of a token.
        /// 
        /// </remarks>
        public GetPaymentInstructionResponse GetPaymentInstruction(GetPaymentInstructionRequest request)
        {
            return Invoke<GetPaymentInstructionResponse>(ConvertGetPaymentInstruction(request));
        }

        
        /// <summary>
        /// Install Payment Instruction 
        /// </summary>
        /// <param name="request">Install Payment Instruction  request</param>
        /// <returns>Install Payment Instruction  Response from the service</returns>
        /// <remarks>
        /// Installs a payment instruction for caller.
        /// 
        /// </remarks>
        public InstallPaymentInstructionResponse InstallPaymentInstruction(InstallPaymentInstructionRequest request)
        {
            return Invoke<InstallPaymentInstructionResponse>(ConvertInstallPaymentInstruction(request));
        }

        
        /// <summary>
        /// Pay 
        /// </summary>
        /// <param name="request">Pay  request</param>
        /// <returns>Pay  Response from the service</returns>
        /// <remarks>
        /// 
        /// Allows calling applications to move money from a sender to a recipient.
        /// 
        /// </remarks>
        public PayResponse Pay(PayRequest request)
        {
            return Invoke<PayResponse>(ConvertPay(request));
        }

        
        /// <summary>
        /// Refund 
        /// </summary>
        /// <param name="request">Refund  request</param>
        /// <returns>Refund  Response from the service</returns>
        /// <remarks>
        /// 
        /// Refunds a previously completed transaction.
        /// 
        /// </remarks>
        public RefundResponse Refund(RefundRequest request)
        {
            return Invoke<RefundResponse>(ConvertRefund(request));
        }

        
        /// <summary>
        /// Reserve 
        /// </summary>
        /// <param name="request">Reserve  request</param>
        /// <returns>Reserve  Response from the service</returns>
        /// <remarks>
        /// 
        /// Reserve API is part of the Reserve and Settle API conjunction that serve the purpose of a pay where the authorization and settlement have a timing 				difference.
        /// 
        /// </remarks>
        public ReserveResponse Reserve(ReserveRequest request)
        {
            return Invoke<ReserveResponse>(ConvertReserve(request));
        }

        
        /// <summary>
        /// Settle 
        /// </summary>
        /// <param name="request">Settle  request</param>
        /// <returns>Settle  Response from the service</returns>
        /// <remarks>
        /// 
        /// The Settle API is used in conjunction with the Reserve API and is used to settle previously reserved transaction.
        /// 
        /// </remarks>
        public SettleResponse Settle(SettleRequest request)
        {
            return Invoke<SettleResponse>(ConvertSettle(request));
        }

        
        /// <summary>
        /// Settle Debt 
        /// </summary>
        /// <param name="request">Settle Debt  request</param>
        /// <returns>Settle Debt  Response from the service</returns>
        /// <remarks>
        /// 
        /// Allows a caller to initiate a transaction that atomically transfers money from a sender’s payment instrument to the recipient, while decreasing corresponding 				debt balance.
        /// 
        /// </remarks>
        public SettleDebtResponse SettleDebt(SettleDebtRequest request)
        {
            return Invoke<SettleDebtResponse>(ConvertSettleDebt(request));
        }

        
        /// <summary>
        /// Write Off Debt 
        /// </summary>
        /// <param name="request">Write Off Debt  request</param>
        /// <returns>Write Off Debt  Response from the service</returns>
        /// <remarks>
        /// 
        /// Allows a creditor to write off the debt balance accumulated partially or fully at any time.
        /// 
        /// </remarks>
        public WriteOffDebtResponse WriteOffDebt(WriteOffDebtRequest request)
        {
            return Invoke<WriteOffDebtResponse>(ConvertWriteOffDebt(request));
        }

        
        /// <summary>
        /// Verify Signature 
        /// </summary>
        /// <param name="request">Verify Signature  request</param>
        /// <returns>Verify Signature  Response from the service</returns>
        /// <remarks>
        /// 
        /// Verify the signature that FPS sent in IPN or callback urls.
        /// 
        /// </remarks>
        public VerifySignatureResponse VerifySignature(VerifySignatureRequest request)
        {
            return Invoke<VerifySignatureResponse>(ConvertVerifySignature(request));
        }

        // Private API ------------------------------------------------------------//

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonFPSConfig instance
         */
        private HttpWebRequest ConfigureWebRequest(int contentLength)
        {
            HttpWebRequest request = WebRequest.Create(config.ServiceURL) as HttpWebRequest;

            if (config.IsSetProxyHost())
            {
                request.Proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
            }
            request.UserAgent = config.UserAgent;
            request.Method = "POST";
            request.Timeout = 50000;
            request.ContentType = "application/x-www-form-urlencoded; charset=utf-8";
            request.ContentLength = contentLength;

            return request;
        }

        /**
         * Invoke request and return response
         */
        private T Invoke<T>(IDictionary<String, String> parameters)
        {
            String actionName = parameters["Action"];
            T response = default(T);
            String responseBody = null;
            HttpStatusCode statusCode = default(HttpStatusCode);

            /* Add required request parameters */
            AddRequiredParameters(parameters);

            String queryString = GetParametersAsString(parameters);

            byte[] requestData = new UTF8Encoding().GetBytes(queryString);
            bool shouldRetry = true;
            int retries = 0;
            do
            {
                HttpWebRequest request = ConfigureWebRequest(requestData.Length);
                /* Submit the request and read response body */
                try
                {
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(requestData, 0, requestData.Length);
                    }
                    using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse)
                    {
                        statusCode = httpResponse.StatusCode;
                        StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8);
                        responseBody = reader.ReadToEnd();
                    }

                    /* Attempt to deserialize response into <Action> Response type */
                    XmlSerializer serlizer = new XmlSerializer(typeof(T));
                    response = (T)serlizer.Deserialize(new StringReader(responseBody));
                    shouldRetry = false;
                }
                /* Web exception is thrown on unsucessful responses */
                catch (WebException we)
                {
                    shouldRetry = false;
                    using (HttpWebResponse httpErrorResponse = (HttpWebResponse)we.Response as HttpWebResponse)
                    {
                        if (httpErrorResponse == null)
                        {
                            throw new AmazonFPSException(we);
                        }
                        statusCode = httpErrorResponse.StatusCode;
                        StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8);
                        responseBody = reader.ReadToEnd();
                    }

                    if (statusCode == HttpStatusCode.InternalServerError || statusCode == HttpStatusCode.ServiceUnavailable)
                    {
                        shouldRetry = true;
                        PauseOnRetry(++retries, statusCode);
                    }
                    else
                    {

                        /* Attempt to deserialize response into ErrorResponse type */
                        try
                        {
                            XmlSerializer serlizer = new XmlSerializer(typeof(ErrorResponse));
                            ErrorResponse errorResponse = (ErrorResponse)serlizer.Deserialize(new StringReader(responseBody));
                            Error error = errorResponse.Error[0];

                            /* Throw formatted exception with information available from the error response */
                            throw new AmazonFPSException(
                                error.Message,
                                statusCode,
                                error.Code,
                                error.Type,
                                errorResponse.RequestId,
                                errorResponse.ToXML());
                        }
                        /* Rethrow on deserializer error */
                        catch (Exception e)
                        {
                            if (e is AmazonFPSException)
                            {
                                throw e;
                            }
                            else
                            {
                                AmazonFPSException se = ReportAnyErrors(responseBody, statusCode, e);
                                throw se;
                            }
                        }
                    }
                }

                /* Catch other exceptions, attempt to convert to formatted exception,
                 * else rethrow wrapped exception */
                catch (Exception e)
                {
                    throw new AmazonFPSException(e);
                }
            } while (shouldRetry);

            return response;
        }


        /**
         * Look for additional error strings in the response and return formatted exception
         */
        private AmazonFPSException ReportAnyErrors(String responseBody, HttpStatusCode status, Exception e)
        {

            AmazonFPSException ex = null;

            if (responseBody != null && responseBody.StartsWith("<"))
            {
                Match errorMatcherOne = Regex.Match(responseBody, "<RequestId>(.*)</RequestId>.*<Error>" +
                        "<Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?", RegexOptions.Multiline);
                Match errorMatcherTwo = Regex.Match(responseBody, "<Error><Code>(.*)</Code><Message>(.*)" +
                        "</Message></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>", RegexOptions.Multiline);

                if (errorMatcherOne.Success)
                {
                    String requestId = errorMatcherOne.Groups[1].Value;
                    String code = errorMatcherOne.Groups[2].Value;
                    String message = errorMatcherOne.Groups[3].Value;

                    ex = new AmazonFPSException(message, status, code, "Unknown", requestId, responseBody);

                }
                else if (errorMatcherTwo.Success)
                {
                    String code = errorMatcherTwo.Groups[1].Value;
                    String message = errorMatcherTwo.Groups[2].Value;
                    String requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new AmazonFPSException(message, status, code, "Unknown", requestId, responseBody);
                }
                else
                {
                    ex = new AmazonFPSException("Internal Error", status);
                }
            }
            else
            {
                ex = new AmazonFPSException("Internal Error", status);
            }
            return ex;
        }

        /**
         * Exponential sleep on failed request
         */
        private void PauseOnRetry(int retries, HttpStatusCode status)
        {
            if (retries <= config.MaxErrorRetry)
            {
                int delay = (int)Math.Pow(4, retries) * 100;
                System.Threading.Thread.Sleep(delay);
            }
            else
            {
                throw new AmazonFPSException("Maximum number of retry attempts reached : " + (retries - 1), status);
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<String, String> parameters)
        {
            parameters.Add("AWSAccessKeyId", this.awsAccessKeyId);
            parameters.Add("Timestamp", GetFormattedTimestamp());
            parameters.Add("Version", config.ServiceVersion);
            parameters.Add("SignatureVersion", config.SignatureVersion);
            parameters.Add("Signature", SignParameters(parameters, this.awsSecretAccessKey));
        }

        /**
         * Convert Dictionary of paremeters to Url encoded query string
         */
        private string GetParametersAsString(IDictionary<String, String> parameters)
        {
            StringBuilder data = new StringBuilder();
            foreach (String key in (IEnumerable<String>)parameters.Keys)
            {
                String value = parameters[key];
                if (value != null)
                {
                    data.Append(key);
                    data.Append('=');
                    data.Append(UrlEncode(value, false));
                    data.Append('&');
                }
            }
            String result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        /**
         * Computes RFC 2104-compliant HMAC signature for request parameters
         * Implements AWS Signature, as per following spec:
         *
         * If Signature Version is 0, it signs concatenated Action and Timestamp
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
        private String SignParameters(IDictionary<String, String> parameters, String key)
        {
            String signatureVersion = parameters["SignatureVersion"];

            KeyedHashAlgorithm algorithm = new HMACSHA1();

            String stringToSign = null;
            if ("0".Equals(signatureVersion))
            {
                stringToSign = CalculateStringToSignV0(parameters);
            }
            else if ("1".Equals(signatureVersion))
            {
                stringToSign = CalculateStringToSignV1(parameters);
            }
            else if ("2".Equals(signatureVersion))
            {
                String signatureMethod = config.SignatureMethod;
                algorithm = KeyedHashAlgorithm.Create(signatureMethod.ToUpper());
                parameters.Add("SignatureMethod", signatureMethod);
                stringToSign = CalculateStringToSignV2(parameters);
            }
            else
            {
                throw new Exception("Invalid Signature Version specified");
            }

            return Sign(stringToSign, key, algorithm);
        }

        private String CalculateStringToSignV0(IDictionary<String, String> parameters)
        {
            StringBuilder data = new StringBuilder();
            return data.Append(parameters["Action"]).Append(parameters["Timestamp"]).ToString();

        }

        private String CalculateStringToSignV1(IDictionary<String, String> parameters)
        {
            StringBuilder data = new StringBuilder();
                IDictionary<String, String> sorted =
                  new SortedDictionary<String, String>(parameters, StringComparer.OrdinalIgnoreCase);
                foreach (KeyValuePair<String, String> pair in sorted)
                {
                    if (pair.Value != null)
                    {
                        data.Append(pair.Key);
                        data.Append(pair.Value);
                    }
                }
            return data.ToString();
        }

        private String CalculateStringToSignV2(IDictionary<String, String> parameters)
        {
            StringBuilder data = new StringBuilder();
            IDictionary<String, String> sorted =
                  new SortedDictionary<String, String>(parameters, StringComparer.Ordinal);
            data.Append("POST");
            data.Append("\n");
            Uri endpoint = new Uri(config.ServiceURL.ToLower());

            data.Append(endpoint.Host);
            data.Append("\n");
            String uri = endpoint.AbsolutePath;
            if (uri == null || uri.Length == 0)
            {
                uri = "/";
            }
            data.Append(UrlEncode(uri, true));
            data.Append("\n");
            foreach (KeyValuePair<String, String> pair in sorted)
            {
                if (pair.Value != null)
                {
                    data.Append(UrlEncode(pair.Key, false));
                    data.Append("=");
                    data.Append(UrlEncode(pair.Value, false));
                    data.Append("&");
                }

            }

            String result = data.ToString();
            return result.Remove(result.Length - 1);
        }

        private String UrlEncode(String data, bool path)
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
        private String Sign(String data, String key, KeyedHashAlgorithm algorithm)
        {
            Encoding encoding = new UTF8Encoding();
            algorithm.Key = encoding.GetBytes(key);
            return Convert.ToBase64String(algorithm.ComputeHash(
                encoding.GetBytes(data.ToCharArray())));
        }


        /**
         * Formats date as ISO 8601 timestamp
         */
        private String GetFormattedTimestamp()
        {
            DateTime dateTime = DateTime.Now;
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day,
                                 dateTime.Hour, dateTime.Minute, dateTime.Second,
                                 dateTime.Millisecond
                                 , DateTimeKind.Local
                               ).ToUniversalTime().ToString("yyyy-MM-dd\\THH:mm:ss.fff\\Z",
                                CultureInfo.InvariantCulture);
        }

        
        /**
         * Convert CancelRequest to name value pairs
         */
        private IDictionary<String, String> ConvertCancel(CancelRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "Cancel");
            if (request.IsSetTransactionId())
            {
                parameters.Add("TransactionId", request.TransactionId);
            }
            if (request.IsSetDescription())
            {
                parameters.Add("Description", request.Description);
            }

            return parameters;
        }
        
                        
        /**
         * Convert CancelTokenRequest to name value pairs
         */
        private IDictionary<String, String> ConvertCancelToken(CancelTokenRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "CancelToken");
            if (request.IsSetTokenId())
            {
                parameters.Add("TokenId", request.TokenId);
            }
            if (request.IsSetReasonText())
            {
                parameters.Add("ReasonText", request.ReasonText);
            }

            return parameters;
        }
        
                        
        /**
         * Convert CancelSubscriptionAndRefundRequest to name value pairs
         */
        private IDictionary<String, String> ConvertCancelSubscriptionAndRefund(CancelSubscriptionAndRefundRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "CancelSubscriptionAndRefund");
            if (request.IsSetSubscriptionId())
            {
                parameters.Add("SubscriptionId", request.SubscriptionId);
            }
            if (request.IsSetRefundAmount())
            {
                Amount  cancelSubscriptionAndRefundRequestRefundAmount = request.RefundAmount;
                if (cancelSubscriptionAndRefundRequestRefundAmount.IsSetCurrencyCode())
                {
                    parameters.Add("RefundAmount" + "." + "CurrencyCode", cancelSubscriptionAndRefundRequestRefundAmount.CurrencyCode + "");
                }
                if (cancelSubscriptionAndRefundRequestRefundAmount.IsSetValue())
                {
                    parameters.Add("RefundAmount" + "." + "Value", cancelSubscriptionAndRefundRequestRefundAmount.Value);
                }
            }
            if (request.IsSetCallerReference())
            {
                parameters.Add("CallerReference", request.CallerReference);
            }
            if (request.IsSetCancelReason())
            {
                parameters.Add("CancelReason", request.CancelReason);
            }

            return parameters;
        }
        
                        
        /**
         * Convert FundPrepaidRequest to name value pairs
         */
        private IDictionary<String, String> ConvertFundPrepaid(FundPrepaidRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "FundPrepaid");
            if (request.IsSetSenderTokenId())
            {
                parameters.Add("SenderTokenId", request.SenderTokenId);
            }
            if (request.IsSetPrepaidInstrumentId())
            {
                parameters.Add("PrepaidInstrumentId", request.PrepaidInstrumentId);
            }
            if (request.IsSetFundingAmount())
            {
                Amount  fundPrepaidRequestFundingAmount = request.FundingAmount;
                if (fundPrepaidRequestFundingAmount.IsSetCurrencyCode())
                {
                    parameters.Add("FundingAmount" + "." + "CurrencyCode", fundPrepaidRequestFundingAmount.CurrencyCode + "");
                }
                if (fundPrepaidRequestFundingAmount.IsSetValue())
                {
                    parameters.Add("FundingAmount" + "." + "Value", fundPrepaidRequestFundingAmount.Value);
                }
            }
            if (request.IsSetCallerReference())
            {
                parameters.Add("CallerReference", request.CallerReference);
            }
            if (request.IsSetSenderDescription())
            {
                parameters.Add("SenderDescription", request.SenderDescription);
            }
            if (request.IsSetCallerDescription())
            {
                parameters.Add("CallerDescription", request.CallerDescription);
            }
            if (request.IsSetDescriptorPolicy())
            {
                DescriptorPolicy  fundPrepaidRequestDescriptorPolicy = request.DescriptorPolicy;
                if (fundPrepaidRequestDescriptorPolicy.IsSetSoftDescriptorType())
                {
                    parameters.Add("DescriptorPolicy" + "." + "SoftDescriptorType", fundPrepaidRequestDescriptorPolicy.SoftDescriptorType + "");
                }
                if (fundPrepaidRequestDescriptorPolicy.IsSetCSOwner())
                {
                    parameters.Add("DescriptorPolicy" + "." + "CSOwner", fundPrepaidRequestDescriptorPolicy.CSOwner + "");
                }
            }
            if (request.IsSetTransactionTimeoutInMins())
            {
                parameters.Add("TransactionTimeoutInMins", request.TransactionTimeoutInMins + "");
            }

            return parameters;
        }
        
                        
        /**
         * Convert GetAccountActivityRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetAccountActivity(GetAccountActivityRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetAccountActivity");
            if (request.IsSetMaxBatchSize())
            {
                parameters.Add("MaxBatchSize", request.MaxBatchSize + "");
            }
            if (request.IsSetStartDate())
            {
                parameters.Add("StartDate", request.StartDate.ToString("yyyy-MM-dd"));
            }
            if (request.IsSetEndDate())
            {
                parameters.Add("EndDate", request.EndDate.ToString("yyyy-MM-dd"));
            }
            if (request.IsSetSortOrderByDate())
            {
                parameters.Add("SortOrderByDate", request.SortOrderByDate + "");
            }
            if (request.IsSetFPSOperation())
            {
                parameters.Add("FPSOperation", request.FPSOperation + "");
            }
            if (request.IsSetPaymentMethod())
            {
                parameters.Add("PaymentMethod", request.PaymentMethod + "");
            }
            List<TransactionalRole> getAccountActivityRequestRoleList  =  request.Role;
            int getAccountActivityRequestRoleListIndex = 1;
            foreach  (TransactionalRole getAccountActivityRequestRole in getAccountActivityRequestRoleList)
            {
                parameters.Add("Role" + "."  + getAccountActivityRequestRoleListIndex, getAccountActivityRequestRole + "");
                getAccountActivityRequestRoleListIndex++;
            }
            if (request.IsSetTransactionStatus())
            {
                parameters.Add("TransactionStatus", request.TransactionStatus + "");
            }

            return parameters;
        }
        
                        
        /**
         * Convert GetAccountBalanceRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetAccountBalance(GetAccountBalanceRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetAccountBalance");

            return parameters;
        }
        
                        
        /**
         * Convert GetDebtBalanceRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetDebtBalance(GetDebtBalanceRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetDebtBalance");
            if (request.IsSetCreditInstrumentId())
            {
                parameters.Add("CreditInstrumentId", request.CreditInstrumentId);
            }

            return parameters;
        }
        
                        
        /**
         * Convert GetOutstandingDebtBalanceRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetOutstandingDebtBalance(GetOutstandingDebtBalanceRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetOutstandingDebtBalance");

            return parameters;
        }
        
                        
        /**
         * Convert GetPrepaidBalanceRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetPrepaidBalance(GetPrepaidBalanceRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetPrepaidBalance");
            if (request.IsSetPrepaidInstrumentId())
            {
                parameters.Add("PrepaidInstrumentId", request.PrepaidInstrumentId);
            }

            return parameters;
        }
        
                        
        /**
         * Convert GetTokenByCallerRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetTokenByCaller(GetTokenByCallerRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetTokenByCaller");
            if (request.IsSetTokenId())
            {
                parameters.Add("TokenId", request.TokenId);
            }
            if (request.IsSetCallerReference())
            {
                parameters.Add("CallerReference", request.CallerReference);
            }

            return parameters;
        }
        
                        
        /**
         * Convert GetTokenUsageRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetTokenUsage(GetTokenUsageRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetTokenUsage");
            if (request.IsSetTokenId())
            {
                parameters.Add("TokenId", request.TokenId);
            }

            return parameters;
        }
        
                        
        /**
         * Convert GetTokensRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetTokens(GetTokensRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetTokens");
            if (request.IsSetTokenStatus())
            {
                parameters.Add("TokenStatus", request.TokenStatus + "");
            }
            if (request.IsSetTokenType())
            {
                parameters.Add("TokenType", request.TokenType + "");
            }
            if (request.IsSetCallerReference())
            {
                parameters.Add("CallerReference", request.CallerReference);
            }
            if (request.IsSetTokenFriendlyName())
            {
                parameters.Add("TokenFriendlyName", request.TokenFriendlyName);
            }

            return parameters;
        }
        
                        
        /**
         * Convert GetTotalPrepaidLiabilityRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetTotalPrepaidLiability(GetTotalPrepaidLiabilityRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetTotalPrepaidLiability");

            return parameters;
        }
        
                        
        /**
         * Convert GetTransactionRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetTransaction(GetTransactionRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetTransaction");
            if (request.IsSetTransactionId())
            {
                parameters.Add("TransactionId", request.TransactionId);
            }

            return parameters;
        }
        
                        
        /**
         * Convert GetTransactionStatusRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetTransactionStatus(GetTransactionStatusRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetTransactionStatus");
            if (request.IsSetTransactionId())
            {
                parameters.Add("TransactionId", request.TransactionId);
            }

            return parameters;
        }
        
                        
        /**
         * Convert GetPaymentInstructionRequest to name value pairs
         */
        private IDictionary<String, String> ConvertGetPaymentInstruction(GetPaymentInstructionRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "GetPaymentInstruction");
            if (request.IsSetTokenId())
            {
                parameters.Add("TokenId", request.TokenId);
            }

            return parameters;
        }
        
                        
        /**
         * Convert InstallPaymentInstructionRequest to name value pairs
         */
        private IDictionary<String, String> ConvertInstallPaymentInstruction(InstallPaymentInstructionRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "InstallPaymentInstruction");
            if (request.IsSetPaymentInstruction())
            {
                parameters.Add("PaymentInstruction", request.PaymentInstruction);
            }
            if (request.IsSetTokenFriendlyName())
            {
                parameters.Add("TokenFriendlyName", request.TokenFriendlyName);
            }
            if (request.IsSetCallerReference())
            {
                parameters.Add("CallerReference", request.CallerReference);
            }
            if (request.IsSetTokenType())
            {
                parameters.Add("TokenType", request.TokenType + "");
            }
            if (request.IsSetPaymentReason())
            {
                parameters.Add("PaymentReason", request.PaymentReason);
            }

            return parameters;
        }
        
                        
        /**
         * Convert PayRequest to name value pairs
         */
        private IDictionary<String, String> ConvertPay(PayRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "Pay");
            if (request.IsSetSenderTokenId())
            {
                parameters.Add("SenderTokenId", request.SenderTokenId);
            }
            if (request.IsSetRecipientTokenId())
            {
                parameters.Add("RecipientTokenId", request.RecipientTokenId);
            }
            if (request.IsSetTransactionAmount())
            {
                Amount  payRequestTransactionAmount = request.TransactionAmount;
                if (payRequestTransactionAmount.IsSetCurrencyCode())
                {
                    parameters.Add("TransactionAmount" + "." + "CurrencyCode", payRequestTransactionAmount.CurrencyCode + "");
                }
                if (payRequestTransactionAmount.IsSetValue())
                {
                    parameters.Add("TransactionAmount" + "." + "Value", payRequestTransactionAmount.Value);
                }
            }
            if (request.IsSetChargeFeeTo())
            {
                parameters.Add("ChargeFeeTo", request.ChargeFeeTo + "");
            }
            if (request.IsSetCallerReference())
            {
                parameters.Add("CallerReference", request.CallerReference);
            }
            if (request.IsSetCallerDescription())
            {
                parameters.Add("CallerDescription", request.CallerDescription);
            }
            if (request.IsSetSenderDescription())
            {
                parameters.Add("SenderDescription", request.SenderDescription);
            }
            if (request.IsSetDescriptorPolicy())
            {
                DescriptorPolicy  payRequestDescriptorPolicy = request.DescriptorPolicy;
                if (payRequestDescriptorPolicy.IsSetSoftDescriptorType())
                {
                    parameters.Add("DescriptorPolicy" + "." + "SoftDescriptorType", payRequestDescriptorPolicy.SoftDescriptorType + "");
                }
                if (payRequestDescriptorPolicy.IsSetCSOwner())
                {
                    parameters.Add("DescriptorPolicy" + "." + "CSOwner", payRequestDescriptorPolicy.CSOwner + "");
                }
            }
            if (request.IsSetTransactionTimeoutInMins())
            {
                parameters.Add("TransactionTimeoutInMins", request.TransactionTimeoutInMins + "");
            }
            if (request.IsSetMarketplaceFixedFee())
            {
                Amount  payRequestMarketplaceFixedFee = request.MarketplaceFixedFee;
                if (payRequestMarketplaceFixedFee.IsSetCurrencyCode())
                {
                    parameters.Add("MarketplaceFixedFee" + "." + "CurrencyCode", payRequestMarketplaceFixedFee.CurrencyCode + "");
                }
                if (payRequestMarketplaceFixedFee.IsSetValue())
                {
                    parameters.Add("MarketplaceFixedFee" + "." + "Value", payRequestMarketplaceFixedFee.Value);
                }
            }
            if (request.IsSetMarketplaceVariableFee())
            {
                parameters.Add("MarketplaceVariableFee", request.MarketplaceVariableFee + "");
            }

            return parameters;
        }
        
                        
        /**
         * Convert RefundRequest to name value pairs
         */
        private IDictionary<String, String> ConvertRefund(RefundRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "Refund");
            if (request.IsSetTransactionId())
            {
                parameters.Add("TransactionId", request.TransactionId);
            }
            if (request.IsSetRefundAmount())
            {
                Amount  refundRequestRefundAmount = request.RefundAmount;
                if (refundRequestRefundAmount.IsSetCurrencyCode())
                {
                    parameters.Add("RefundAmount" + "." + "CurrencyCode", refundRequestRefundAmount.CurrencyCode + "");
                }
                if (refundRequestRefundAmount.IsSetValue())
                {
                    parameters.Add("RefundAmount" + "." + "Value", refundRequestRefundAmount.Value);
                }
            }
            if (request.IsSetCallerReference())
            {
                parameters.Add("CallerReference", request.CallerReference);
            }
            if (request.IsSetCallerDescription())
            {
                parameters.Add("CallerDescription", request.CallerDescription);
            }
            if (request.IsSetMarketplaceRefundPolicy())
            {
                parameters.Add("MarketplaceRefundPolicy", request.MarketplaceRefundPolicy + "");
            }

            return parameters;
        }
        
                        
        /**
         * Convert ReserveRequest to name value pairs
         */
        private IDictionary<String, String> ConvertReserve(ReserveRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "Reserve");
            if (request.IsSetSenderTokenId())
            {
                parameters.Add("SenderTokenId", request.SenderTokenId);
            }
            if (request.IsSetRecipientTokenId())
            {
                parameters.Add("RecipientTokenId", request.RecipientTokenId);
            }
            if (request.IsSetTransactionAmount())
            {
                Amount  reserveRequestTransactionAmount = request.TransactionAmount;
                if (reserveRequestTransactionAmount.IsSetCurrencyCode())
                {
                    parameters.Add("TransactionAmount" + "." + "CurrencyCode", reserveRequestTransactionAmount.CurrencyCode + "");
                }
                if (reserveRequestTransactionAmount.IsSetValue())
                {
                    parameters.Add("TransactionAmount" + "." + "Value", reserveRequestTransactionAmount.Value);
                }
            }
            if (request.IsSetChargeFeeTo())
            {
                parameters.Add("ChargeFeeTo", request.ChargeFeeTo + "");
            }
            if (request.IsSetCallerReference())
            {
                parameters.Add("CallerReference", request.CallerReference);
            }
            if (request.IsSetCallerDescription())
            {
                parameters.Add("CallerDescription", request.CallerDescription);
            }
            if (request.IsSetSenderDescription())
            {
                parameters.Add("SenderDescription", request.SenderDescription);
            }
            if (request.IsSetDescriptorPolicy())
            {
                DescriptorPolicy  reserveRequestDescriptorPolicy = request.DescriptorPolicy;
                if (reserveRequestDescriptorPolicy.IsSetSoftDescriptorType())
                {
                    parameters.Add("DescriptorPolicy" + "." + "SoftDescriptorType", reserveRequestDescriptorPolicy.SoftDescriptorType + "");
                }
                if (reserveRequestDescriptorPolicy.IsSetCSOwner())
                {
                    parameters.Add("DescriptorPolicy" + "." + "CSOwner", reserveRequestDescriptorPolicy.CSOwner + "");
                }
            }
            if (request.IsSetTransactionTimeoutInMins())
            {
                parameters.Add("TransactionTimeoutInMins", request.TransactionTimeoutInMins + "");
            }
            if (request.IsSetMarketplaceFixedFee())
            {
                Amount  reserveRequestMarketplaceFixedFee = request.MarketplaceFixedFee;
                if (reserveRequestMarketplaceFixedFee.IsSetCurrencyCode())
                {
                    parameters.Add("MarketplaceFixedFee" + "." + "CurrencyCode", reserveRequestMarketplaceFixedFee.CurrencyCode + "");
                }
                if (reserveRequestMarketplaceFixedFee.IsSetValue())
                {
                    parameters.Add("MarketplaceFixedFee" + "." + "Value", reserveRequestMarketplaceFixedFee.Value);
                }
            }
            if (request.IsSetMarketplaceVariableFee())
            {
                parameters.Add("MarketplaceVariableFee", request.MarketplaceVariableFee + "");
            }

            return parameters;
        }
        
                        
        /**
         * Convert SettleRequest to name value pairs
         */
        private IDictionary<String, String> ConvertSettle(SettleRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "Settle");
            if (request.IsSetReserveTransactionId())
            {
                parameters.Add("ReserveTransactionId", request.ReserveTransactionId);
            }
            if (request.IsSetTransactionAmount())
            {
                Amount  settleRequestTransactionAmount = request.TransactionAmount;
                if (settleRequestTransactionAmount.IsSetCurrencyCode())
                {
                    parameters.Add("TransactionAmount" + "." + "CurrencyCode", settleRequestTransactionAmount.CurrencyCode + "");
                }
                if (settleRequestTransactionAmount.IsSetValue())
                {
                    parameters.Add("TransactionAmount" + "." + "Value", settleRequestTransactionAmount.Value);
                }
            }

            return parameters;
        }
        
                        
        /**
         * Convert SettleDebtRequest to name value pairs
         */
        private IDictionary<String, String> ConvertSettleDebt(SettleDebtRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "SettleDebt");
            if (request.IsSetSenderTokenId())
            {
                parameters.Add("SenderTokenId", request.SenderTokenId);
            }
            if (request.IsSetCreditInstrumentId())
            {
                parameters.Add("CreditInstrumentId", request.CreditInstrumentId);
            }
            if (request.IsSetSettlementAmount())
            {
                Amount  settleDebtRequestSettlementAmount = request.SettlementAmount;
                if (settleDebtRequestSettlementAmount.IsSetCurrencyCode())
                {
                    parameters.Add("SettlementAmount" + "." + "CurrencyCode", settleDebtRequestSettlementAmount.CurrencyCode + "");
                }
                if (settleDebtRequestSettlementAmount.IsSetValue())
                {
                    parameters.Add("SettlementAmount" + "." + "Value", settleDebtRequestSettlementAmount.Value);
                }
            }
            if (request.IsSetCallerReference())
            {
                parameters.Add("CallerReference", request.CallerReference);
            }
            if (request.IsSetSenderDescription())
            {
                parameters.Add("SenderDescription", request.SenderDescription);
            }
            if (request.IsSetCallerDescription())
            {
                parameters.Add("CallerDescription", request.CallerDescription);
            }
            if (request.IsSetDescriptorPolicy())
            {
                DescriptorPolicy  settleDebtRequestDescriptorPolicy = request.DescriptorPolicy;
                if (settleDebtRequestDescriptorPolicy.IsSetSoftDescriptorType())
                {
                    parameters.Add("DescriptorPolicy" + "." + "SoftDescriptorType", settleDebtRequestDescriptorPolicy.SoftDescriptorType + "");
                }
                if (settleDebtRequestDescriptorPolicy.IsSetCSOwner())
                {
                    parameters.Add("DescriptorPolicy" + "." + "CSOwner", settleDebtRequestDescriptorPolicy.CSOwner + "");
                }
            }
            if (request.IsSetTransactionTimeoutInMins())
            {
                parameters.Add("TransactionTimeoutInMins", request.TransactionTimeoutInMins + "");
            }

            return parameters;
        }
        
                        
        /**
         * Convert WriteOffDebtRequest to name value pairs
         */
        private IDictionary<String, String> ConvertWriteOffDebt(WriteOffDebtRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "WriteOffDebt");
            if (request.IsSetCreditInstrumentId())
            {
                parameters.Add("CreditInstrumentId", request.CreditInstrumentId);
            }
            if (request.IsSetAdjustmentAmount())
            {
                Amount  writeOffDebtRequestAdjustmentAmount = request.AdjustmentAmount;
                if (writeOffDebtRequestAdjustmentAmount.IsSetCurrencyCode())
                {
                    parameters.Add("AdjustmentAmount" + "." + "CurrencyCode", writeOffDebtRequestAdjustmentAmount.CurrencyCode + "");
                }
                if (writeOffDebtRequestAdjustmentAmount.IsSetValue())
                {
                    parameters.Add("AdjustmentAmount" + "." + "Value", writeOffDebtRequestAdjustmentAmount.Value);
                }
            }
            if (request.IsSetCallerReference())
            {
                parameters.Add("CallerReference", request.CallerReference);
            }
            if (request.IsSetCallerDescription())
            {
                parameters.Add("CallerDescription", request.CallerDescription);
            }

            return parameters;
        }
        
                        
        /**
         * Convert VerifySignatureRequest to name value pairs
         */
        private IDictionary<String, String> ConvertVerifySignature(VerifySignatureRequest request)
        {
            
            IDictionary<String, String> parameters = new Dictionary<String, String>();
            parameters.Add("Action", "VerifySignature");
            if (request.IsSetUrlEndPoint())
            {
                parameters.Add("UrlEndPoint", request.UrlEndPoint);
            }
            if (request.IsSetHttpParameters())
            {
                parameters.Add("HttpParameters", request.HttpParameters);
            }

            return parameters;
        }
        
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
    }
}
