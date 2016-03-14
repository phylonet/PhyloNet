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

        public class CBUIEditTokenPipelineSample 
        {

            public static void invoke(String accessKey, String secretKey) 
            {
                AmazonFPSEditTokenPipeline pipeline= new AmazonFPSEditTokenPipeline(accessKey, secretKey);

                pipeline.setMandatoryParameters("callerReferenceEditToken", "http://www.mysite.com/call_back.jsp",
                        "H6VWDM8TPZYCGBJY5W3P3QYK7HZNYQ7NPHVV2SYKW19MIY2G4BG4YQTVDYW3I1SM");

                //EditToken url
                Console.WriteLine("Sample CBUI url for EditToken pipeline :" + pipeline.getURL());
            }

       }
}