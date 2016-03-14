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
    /// Get Debt Balance  Samples
    /// </summary>
    public class GetDebtBalanceSample
    {
    
                                             
        /// <summary>
        /// 
        /// Returns the balance corresponding to the given credit instrument.
        /// 
        /// </summary>
        /// <param name="service">Instance of AmazonFPS service</param>
        /// <param name="request">GetDebtBalanceRequest request</param>
        public static void InvokeGetDebtBalance(AmazonFPS service, GetDebtBalanceRequest request)
        {
            try 
            {
                GetDebtBalanceResponse response = service.GetDebtBalance(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetDebtBalanceResponse");
                if (response.IsSetGetDebtBalanceResult())
                {
                    Console.WriteLine("            GetDebtBalanceResult");
                    GetDebtBalanceResult  getDebtBalanceResult = response.GetDebtBalanceResult;
                    if (getDebtBalanceResult.IsSetDebtBalance())
                    {
                        Console.WriteLine("                DebtBalance");
                        DebtBalance  debtBalance = getDebtBalanceResult.DebtBalance;
                        if (debtBalance.IsSetAvailableBalance())
                        {
                            Console.WriteLine("                    AvailableBalance");
                            Amount  availableBalance = debtBalance.AvailableBalance;
                            if (availableBalance.IsSetCurrencyCode())
                            {
                                Console.WriteLine("                        CurrencyCode");
                                Console.WriteLine("                            {0}", availableBalance.CurrencyCode);
                            }
                            if (availableBalance.IsSetValue())
                            {
                                Console.WriteLine("                        Value");
                                Console.WriteLine("                            {0}", availableBalance.Value);
                            }
                        }
                        if (debtBalance.IsSetPendingOutBalance())
                        {
                            Console.WriteLine("                    PendingOutBalance");
                            Amount  pendingOutBalance = debtBalance.PendingOutBalance;
                            if (pendingOutBalance.IsSetCurrencyCode())
                            {
                                Console.WriteLine("                        CurrencyCode");
                                Console.WriteLine("                            {0}", pendingOutBalance.CurrencyCode);
                            }
                            if (pendingOutBalance.IsSetValue())
                            {
                                Console.WriteLine("                        Value");
                                Console.WriteLine("                            {0}", pendingOutBalance.Value);
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
