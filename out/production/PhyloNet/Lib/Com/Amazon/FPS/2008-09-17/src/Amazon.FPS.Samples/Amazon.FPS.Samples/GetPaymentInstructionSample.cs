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
    /// Get Payment Instruction  Samples
    /// </summary>
    public class GetPaymentInstructionSample
    {
    
                                                                                     
        /// <summary>
        /// 
        /// Gets the payment instruction of a token.
        /// 
        /// </summary>
        /// <param name="service">Instance of AmazonFPS service</param>
        /// <param name="request">GetPaymentInstructionRequest request</param>
        public static void InvokeGetPaymentInstruction(AmazonFPS service, GetPaymentInstructionRequest request)
        {
            try 
            {
                GetPaymentInstructionResponse response = service.GetPaymentInstruction(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetPaymentInstructionResponse");
                if (response.IsSetGetPaymentInstructionResult())
                {
                    Console.WriteLine("            GetPaymentInstructionResult");
                    GetPaymentInstructionResult  getPaymentInstructionResult = response.GetPaymentInstructionResult;
                    if (getPaymentInstructionResult.IsSetToken())
                    {
                        Console.WriteLine("                Token");
                        Token  token = getPaymentInstructionResult.Token;
                        if (token.IsSetTokenId())
                        {
                            Console.WriteLine("                    TokenId");
                            Console.WriteLine("                        {0}", token.TokenId);
                        }
                        if (token.IsSetFriendlyName())
                        {
                            Console.WriteLine("                    FriendlyName");
                            Console.WriteLine("                        {0}", token.FriendlyName);
                        }
                        if (token.IsSetTokenStatus())
                        {
                            Console.WriteLine("                    TokenStatus");
                            Console.WriteLine("                        {0}", token.TokenStatus);
                        }
                        if (token.IsSetDateInstalled())
                        {
                            Console.WriteLine("                    DateInstalled");
                            Console.WriteLine("                        {0}", token.DateInstalled);
                        }
                        if (token.IsSetCallerReference())
                        {
                            Console.WriteLine("                    CallerReference");
                            Console.WriteLine("                        {0}", token.CallerReference);
                        }
                        if (token.IsSetTokenType())
                        {
                            Console.WriteLine("                    TokenType");
                            Console.WriteLine("                        {0}", token.TokenType);
                        }
                        if (token.IsSetOldTokenId())
                        {
                            Console.WriteLine("                    OldTokenId");
                            Console.WriteLine("                        {0}", token.OldTokenId);
                        }
                        if (token.IsSetPaymentReason())
                        {
                            Console.WriteLine("                    PaymentReason");
                            Console.WriteLine("                        {0}", token.PaymentReason);
                        }
                    }
                    if (getPaymentInstructionResult.IsSetPaymentInstruction())
                    {
                        Console.WriteLine("                PaymentInstruction");
                        Console.WriteLine("                    {0}", getPaymentInstructionResult.PaymentInstruction);
                    }
                    if (getPaymentInstructionResult.IsSetCallerReference())
                    {
                        Console.WriteLine("                CallerReference");
                        Console.WriteLine("                    {0}", getPaymentInstructionResult.CallerReference);
                    }
                    if (getPaymentInstructionResult.IsSetTokenFriendlyName())
                    {
                        Console.WriteLine("                TokenFriendlyName");
                        Console.WriteLine("                    {0}", getPaymentInstructionResult.TokenFriendlyName);
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
