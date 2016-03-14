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
    /// Get Token Usage  Samples
    /// </summary>
    public class GetTokenUsageSample
    {
    
                                                                 
        /// <summary>
        /// 
        /// Returns the usage of a token.
        /// 
        /// </summary>
        /// <param name="service">Instance of AmazonFPS service</param>
        /// <param name="request">GetTokenUsageRequest request</param>
        public static void InvokeGetTokenUsage(AmazonFPS service, GetTokenUsageRequest request)
        {
            try 
            {
                GetTokenUsageResponse response = service.GetTokenUsage(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetTokenUsageResponse");
                if (response.IsSetGetTokenUsageResult())
                {
                    Console.WriteLine("            GetTokenUsageResult");
                    GetTokenUsageResult  getTokenUsageResult = response.GetTokenUsageResult;
                    List<TokenUsageLimit> tokenUsageLimitsList = getTokenUsageResult.TokenUsageLimits;
                    foreach (TokenUsageLimit tokenUsageLimits in tokenUsageLimitsList)
                    {
                        Console.WriteLine("                TokenUsageLimits");
                        if (tokenUsageLimits.IsSetCount())
                        {
                            Console.WriteLine("                    Count");
                            Console.WriteLine("                        {0}", tokenUsageLimits.Count);
                        }
                        if (tokenUsageLimits.IsSetAmount())
                        {
                            Console.WriteLine("                    Amount");
                            Amount  amount = tokenUsageLimits.Amount;
                            if (amount.IsSetCurrencyCode())
                            {
                                Console.WriteLine("                        CurrencyCode");
                                Console.WriteLine("                            {0}", amount.CurrencyCode);
                            }
                            if (amount.IsSetValue())
                            {
                                Console.WriteLine("                        Value");
                                Console.WriteLine("                            {0}", amount.Value);
                            }
                        }
                        if (tokenUsageLimits.IsSetLastResetCount())
                        {
                            Console.WriteLine("                    LastResetCount");
                            Console.WriteLine("                        {0}", tokenUsageLimits.LastResetCount);
                        }
                        if (tokenUsageLimits.IsSetLastResetAmount())
                        {
                            Console.WriteLine("                    LastResetAmount");
                            Amount  lastResetAmount = tokenUsageLimits.LastResetAmount;
                            if (lastResetAmount.IsSetCurrencyCode())
                            {
                                Console.WriteLine("                        CurrencyCode");
                                Console.WriteLine("                            {0}", lastResetAmount.CurrencyCode);
                            }
                            if (lastResetAmount.IsSetValue())
                            {
                                Console.WriteLine("                        Value");
                                Console.WriteLine("                            {0}", lastResetAmount.Value);
                            }
                        }
                        if (tokenUsageLimits.IsSetLastResetTimestamp())
                        {
                            Console.WriteLine("                    LastResetTimestamp");
                            Console.WriteLine("                        {0}", tokenUsageLimits.LastResetTimestamp);
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
