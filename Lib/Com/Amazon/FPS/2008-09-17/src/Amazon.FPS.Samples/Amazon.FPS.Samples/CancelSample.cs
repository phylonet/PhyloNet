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
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.FPS;
using Amazon.FPS.Model;



namespace Amazon.FPS.Samples
{

    /// <summary>
    /// Cancel  Samples
    /// </summary>
    public class CancelSample
    {
    
                             
        /// <summary>
        /// 
        /// Cancels an ongoing transaction and puts it in cancelled state.
        /// 
        /// </summary>
        /// <param name="service">Instance of AmazonFPS service</param>
        /// <param name="request">CancelRequest request</param>
        public static void InvokeCancel(AmazonFPS service, CancelRequest request)
        {
            try 
            {
                CancelResponse response = service.Cancel(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        CancelResponse");
                if (response.IsSetCancelResult())
                {
                    Console.WriteLine("            CancelResult");
                    CancelResult  cancelResult = response.CancelResult;
                    if (cancelResult.IsSetTransactionId())
                    {
                        Console.WriteLine("                TransactionId");
                        Console.WriteLine("                    {0}", cancelResult.TransactionId);
                    }
                    if (cancelResult.IsSetTransactionStatus())
                    {
                        Console.WriteLine("                TransactionStatus");
                        Console.WriteLine("                    {0}", cancelResult.TransactionStatus);
                    }
                }
                if (response.IsSetResponseMetadata())
                {
                    Console.WriteLine("            ResponseMetadata");
                    ResponseMetadata  responseMetadata = response.ResponseMetadata;
                    if (responseMetadata.IsSetRequestId())
                    {
                        Console.WriteLine("                RequestId");
                        Console.WriteLine("                    {0}", responseMetadata.RequestId);
                    }
                }

            } 
            catch (AmazonFPSException ex) 
            {
                Console.WriteLine("Caught Exception: " + ex.Message);
                Console.WriteLine("Response Status Code: " + ex.StatusCode);
                Console.WriteLine("Error Code: " + ex.ErrorCode);
                Console.WriteLine("Error Type: " + ex.ErrorType);
                Console.WriteLine("Request ID: " + ex.RequestId);
                Console.WriteLine("XML: " + ex.XML);
            }
        }
                                                                                                }
}
