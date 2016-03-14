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
    /// Get Account Balance  Samples
    /// </summary>
    public class GetAccountBalanceSample
    {
    
                                         
        /// <summary>
        /// 
        /// Returns the account balance for an account in real time.
        /// 
        /// </summary>
        /// <param name="service">Instance of AmazonFPS service</param>
        /// <param name="request">GetAccountBalanceRequest request</param>
        public static void InvokeGetAccountBalance(AmazonFPS service, GetAccountBalanceRequest request)
        {
            try 
            {
                GetAccountBalanceResponse response = service.GetAccountBalance(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetAccountBalanceResponse");
                if (response.IsSetGetAccountBalanceResult())
                {
                    Console.WriteLine("            GetAccountBalanceResult");
                    GetAccountBalanceResult  getAccountBalanceResult = response.GetAccountBalanceResult;
                    if (getAccountBalanceResult.IsSetAccountBalance())
                    {
                        Console.WriteLine("                AccountBalance");
                        AccountBalance  accountBalance = getAccountBalanceResult.AccountBalance;
                        if (accountBalance.IsSetTotalBalance())
                        {
                            Console.WriteLine("                    TotalBalance");
                            Amount  totalBalance = accountBalance.TotalBalance;
                            if (totalBalance.IsSetCurrencyCode())
                            {
                                Console.WriteLine("                        CurrencyCode");
                                Console.WriteLine("                            {0}", totalBalance.CurrencyCode);
                            }
                            if (totalBalance.IsSetValue())
                            {
                                Console.WriteLine("                        Value");
                                Console.WriteLine("                            {0}", totalBalance.Value);
                            }
                        }
                        if (accountBalance.IsSetPendingInBalance())
                        {
                            Console.WriteLine("                    PendingInBalance");
                            Amount  pendingInBalance = accountBalance.PendingInBalance;
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
                        if (accountBalance.IsSetPendingOutBalance())
                        {
                            Console.WriteLine("                    PendingOutBalance");
                            Amount  pendingOutBalance = accountBalance.PendingOutBalance;
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
                        if (accountBalance.IsSetAvailableBalances())
                        {
                            Console.WriteLine("                    AvailableBalances");
                            AvailableBalances  availableBalances = accountBalance.AvailableBalances;
                            if (availableBalances.IsSetDisburseBalance())
                            {
                                Console.WriteLine("                        DisburseBalance");
                                Amount  disburseBalance = availableBalances.DisburseBalance;
                                if (disburseBalance.IsSetCurrencyCode())
                                {
                                    Console.WriteLine("                            CurrencyCode");
                                    Console.WriteLine("                                {0}", disburseBalance.CurrencyCode);
                                }
                                if (disburseBalance.IsSetValue())
                                {
                                    Console.WriteLine("                            Value");
                                    Console.WriteLine("                                {0}", disburseBalance.Value);
                                }
                            }
                            if (availableBalances.IsSetRefundBalance())
                            {
                                Console.WriteLine("                        RefundBalance");
                                Amount  refundBalance = availableBalances.RefundBalance;
                                if (refundBalance.IsSetCurrencyCode())
                                {
                                    Console.WriteLine("                            CurrencyCode");
                                    Console.WriteLine("                                {0}", refundBalance.CurrencyCode);
                                }
                                if (refundBalance.IsSetValue())
                                {
                                    Console.WriteLine("                            Value");
                                    Console.WriteLine("                                {0}", refundBalance.Value);
                                }
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
