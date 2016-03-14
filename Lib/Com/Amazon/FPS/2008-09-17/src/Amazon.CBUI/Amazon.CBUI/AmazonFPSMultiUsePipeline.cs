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

namespace Amazon.CBUI
{
        using System;
        using System.Text;
        using System.Collections.Generic;
        using System.IO;
        using System.Security.Cryptography;
        using System.Web;

        public class AmazonFPSMultiUsePipeline : AmazonFPSCBUIPipeline
        {
            /**
             * Default constructor
             * 
             * @param awsAccessKey    Amazon Web Services Access Key ID.
             * @param awsSecretKey   Amazon Web Services Secret Access Key.
             */
            public AmazonFPSMultiUsePipeline(String awsAccessKey, String awsSecretKey):
                base("MultiUse", awsAccessKey, awsSecretKey)
            {
            }

            public void setMandatoryParameters(String callerReference, String returnUrl, String globalAmountLimit)
            {
                addParameter("callerReference", callerReference);
                addParameter("returnURL", returnUrl);
                addParameter("globalAmountLimit", globalAmountLimit);
            }

            public void setUsageLimit1(String limitType, String limitValue, String limitPeriod)
            {
                addParameter("usageLimitType1", limitType);
                addParameter("usageLimitValue1", limitValue);
                if (limitPeriod != null)
                {
                    addParameter("usageLimitPeriod1", limitPeriod);
                }
            }

            public void setUsageLimit2(String limitType, String limitValue, String limitPeriod)
            {
                addParameter("usageLimitType1", limitType);
                addParameter("usageLimitValue1", limitValue);
                if (limitPeriod != null)
                {
                    addParameter("usageLimitPeriod1", limitPeriod);
                }
            }

            public void setRecipientTokenList(bool isRecipientCobranding, List<String> tokens)
            {
                addParameter("isRecipientCobranding", (isRecipientCobranding ? "True" : "False"));

                if (tokens == null || tokens.Count == 0) return;

                StringBuilder tokenListBuilder = new StringBuilder();
                foreach (String token in tokens)
                {
                    tokenListBuilder.Append(token); tokenListBuilder.Append(",");
                }

                String tokenList = tokenListBuilder.ToString();
                tokenList = tokenList.Substring(0, tokenList.Length - 1);

                addParameter("recipientTokenList", tokenList);
            }

            protected override void validateParameters(IDictionary<String, String> map)
            {
                //mandatory parameters for multi use pipeline
                if (!parameters.ContainsKey("globalAmountLimit"))
                {
                    throw new AmazonCBUIException("globalAmountLimit is missing in parameters.");
                }

                //conditional parameters for multi use pipeline
                if (parameters.ContainsKey("isRecipientCobranding") && !parameters.ContainsKey("recipientTokenList"))
                {
                    throw new AmazonCBUIException("recipientTokenList is missing in parameters.");
                }

                if (parameters.ContainsKey("usageLimitType1") && !parameters.ContainsKey("usageLimitValue1"))
                {
                    throw new AmazonCBUIException("usageLimitValue1 is missing in parameters.");
                }

                if (parameters.ContainsKey("usageLimitType2") && !parameters.ContainsKey("usageLimitValue2"))
                {
                    throw new AmazonCBUIException("usageLimitValue2 is missing in parameters.");
                }

            }
        }
}