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

        public class AmazonFPSSingleUsePipeline : AmazonFPSCBUIPipeline
        {
            /**
             * Default constructor
             * 
             * @param awsAccessKey    Amazon Web Services Access Key ID.
             * @param awsSecretKey   Amazon Web Services Secret Access Key.
             */
            public AmazonFPSSingleUsePipeline(String awsAccessKey, String awsSecretKey):
                base("SingleUse", awsAccessKey, awsSecretKey)
            {
            }

            public void setMandatoryParameters(String callerReference, String returnUrl, String transactionAmount)
            {
                addParameter("callerReference", callerReference);
                addParameter("returnURL", returnUrl);
                addParameter("transactionAmount", transactionAmount);
            }


            protected override void validateParameters(IDictionary<String, String> map)
            {
                //mandatory parameters for single use pipeline
                if (!parameters.ContainsKey("transactionAmount"))
                {
                    throw new AmazonCBUIException("transactionAmount is missing in parameters.");
                }
            }
        }
}