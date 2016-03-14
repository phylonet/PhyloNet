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
    /// Get Total Prepaid Liability  Samples
    /// </summary>
    public class GetTotalPrepaidLiabilitySample
    {
    
                                                                         
        /// <summary>
        /// 
        /// Returns the total liability held by the given account corresponding to all the prepaid instruments owned by the account.
        /// 
        /// </summary>
        /// <param name="service">Instance of AmazonFPS service</param>
        /// <param name="request">GetTotalPrepaidLiabilityRequest request</param>
        public static void InvokeGetTotalPrepaidLiability(AmazonFPS service, GetTotalPrepaidLiabilityRequest request)
        {
            try 
            {
                GetTotalPrepaidLiabilityResponse response = service.GetTotalPrepaidLiability(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetTotalPrepaidLiabilityResponse");
                if (response.IsSetGetTotalPrepaidLiabilityResult())
                {
                    Console.WriteLine("            GetTotalPrepaidLiabilityResult");
                    GetTotalPrepaidLiabilityResult  getTotalPrepaidLiabilityResult = response.GetTotalPrepaidLiabilityResult;
                    if (getTotalPrepaidLiabilityResult.IsSetOutstandingPrepaidLiability())
                    {
                        Console.WriteLine("                OutstandingPrepaidLiability");
                        OutstandingPrepaidLiability  outstandingPrepaidLiability = getTotalPrepaidLiabilityResult.OutstandingPrepaidLiability;
                        if (outstandingPrepaidLiability.IsSetOutstandingBalance())
                        {
                            Console.WriteLine("                    OutstandingBalance");
                            Amount  outstandingBalance = outstandingPrepaidLiability.OutstandingBalance;
                            if (outstandingBalance.IsSetCurrencyCode())
                            {
                                Console.WriteLine("                        CurrencyCode");
                                Console.WriteLine("                            {0}", outstandingBalance.CurrencyCode);
                            }
                            if (outstandingBalance.IsSetValue())
                            {
                                Console.WriteLine("                        Value");
                                Console.WriteLine("                            {0}", outstandingBalance.Value);
                            }
                        }
                        if (outstandingPrepaidLiability.IsSetPendingInBalance())
                        {
                            Console.WriteLine("                    PendingInBalance");
                            Amount  pendingInBalance = outstandingPrepaidLiability.PendingInBalance;
                            if (pendingInBalance.IsSetCurrencyCode())
                            {
                                Console.WriteLine("                        CurrencyCode");
                                Console.WriteLine("                            {0}", pendingInBalance.CurrencyCode);
                            }
                            if (pendingInBalance.IsSetValue())
                            {
                                Console.WriteLine("                        Value");
                                Console.WriteLine("                            {0}", pendingInBalance.Value);
                            }
                        }
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
