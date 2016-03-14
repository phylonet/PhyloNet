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

namespace Amazon.IpnReturnUrlValidation.Samples
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class IPNVerificationSampleCode
    {
        public static void Main(String[] args)
        {
            IDictionary<String, String> parameters = new Dictionary<String, String>();

            SignatureUtilsForOutbound utils = new SignatureUtilsForOutbound();

            //Parameters present in ipn.
            parameters.Add("transactionId", "14DRG2JGR7LK4J54P544DKKNDLQFFZLE323");
            parameters.Add("transactionDate", "1251832057");
            parameters.Add("status", "INITIATED");
            parameters.Add("notificationType", "TransactionStatus");
            parameters.Add("callerReference", "callerReference=ReferenceStringJYI1251832057319108");
            parameters.Add("operation", "PAY");
            parameters.Add("transactionAmount", "USD 1.00");
            parameters.Add("buyerName", "BuyerName-SsUo3oDjHx");
            parameters.Add("paymentMethod", "CC");
            parameters.Add("paymentReason", "DescriptionString-1251832057319108");
            parameters.Add("recipientEmail", "recipientemail@amazon.com");
            parameters.Add("signatureMethod", "RSA-SHA1");
            parameters.Add("signatureVersion", "2");
            parameters.Add("certificateUrl", "https://fps.amazonaws.com/certs/090909/PKICert.pem");
            parameters.Add("signature", "vKXXCbtxvSkRR+Zn8YNW6DNGpbi474h2iM4L+xaOi16kYKdYpuGbvKyXQ36uTZTVHdUGAAcvpXFL"
                    + "wDfnTcqcckr2IUElrVJKQeT0WeWR+IqmABwSRGo+YqjzPNISSNXNzg6LFhouhUvmmwY15X3YgXfc"
                    + "ERN5IhPwv04YkyCLPCA9P0/QgD8Jum/hc9jj0HYjj3s3MuuQ3yoIhf2x+2CBZRm5lslRqnoF/8OJ"
                    + "1ZHmAHt9VvQSZ+QC3fwJgeqzJPAvtuOm930BP6hPYZVhXE5w7ByLt0qLk1ZFE/vzQ4io4vOyie6W"
                    + "bhp5+AuNyAs+QrGMYO8VZruZJfkZO4b6QOgV2A==");

            String urlEndPoint = "http://www.mysite.com/ipn.jsp"; //Your url end point receiving the ipn. 
            Console.WriteLine("Verifying IPN signed using signature v2 ....");
            //IPN is sent as a http POST request and hence we specify POST as the http method.
            //Signature verification does not require your secret key
            Console.WriteLine("Is signature correct: " + utils.validateRequest(parameters, urlEndPoint, "POST"));
            Console.ReadLine();
        }
    }
}
