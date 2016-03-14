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
    using System.Collections.Generic;

    public class AmazonFPSRecipientTokenPipeline : AmazonFPSCBUIPipeline
        {
            /**
             * Default constructor
             * 
             * @param awsAccessKey    Amazon Web Services Access Key ID.
             * @param awsSecretKey   Amazon Web Services Secret Access Key.
             */
            public AmazonFPSRecipientTokenPipeline(String awsAccessKey, String awsSecretKey):
                base("Recipient", awsAccessKey, awsSecretKey)
            {
            }

            public void setMandatoryParameters(String callerReference, String returnUrl, 
                long maxFixedFee, long maxVariableFee, bool recipientPaysFee)
            {
                addParameter("callerReference", callerReference);
                addParameter("returnURL", returnUrl);
                addParameter("maxFixedFee", maxFixedFee.ToString());
                addParameter("maxVariableFee", maxVariableFee.ToString());
                addParameter("recipientPaysFee", (recipientPaysFee ? "True" : "False"));
            }


            protected override void validateParameters(IDictionary<String, String> map)
            {
                //mandatory parameters for recipient token pipeline
                if (!parameters.ContainsKey("maxFixedFee"))
                {
                    throw new AmazonCBUIException("maxFixedFee is missing in parameters.");
                }

                if (!parameters.ContainsKey("maxVariableFee"))
                {
                    throw new AmazonCBUIException("maxVariableFee is missing in parameters.");
                }

                if (!parameters.ContainsKey("recipientPaysFee"))
                {
                    throw new AmazonCBUIException("recipientPaysFee is missing in parameters.");
                }
            }
        }
}