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

        public class CBUISingleUsePipelineSample 
        {

            public static void invoke(String accessKey, String secretKey) 
            {
                AmazonFPSSingleUsePipeline pipeline= new AmazonFPSSingleUsePipeline(accessKey, secretKey);

                pipeline.setMandatoryParameters("callerReferenceSingleUse",  "http://www.mysite.com/call_back.jsp", "5");
        
                //optional parameters
                pipeline.addParameter("currencyCode", "USD");
                pipeline.addParameter("paymentReason", "HarryPotter 1-5 DVD set");
        
                //SingleUse url signed using signature version
                Console.WriteLine("Sample CBUI url for SingleUse pipeline :" + pipeline.getURL());
            }

       }
}