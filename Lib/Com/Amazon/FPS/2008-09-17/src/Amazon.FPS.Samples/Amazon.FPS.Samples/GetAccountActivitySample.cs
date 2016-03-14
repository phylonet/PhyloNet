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
    /// Get Account Activity  Samples
    /// </summary>
    public class GetAccountActivitySample
    {
    
                                     
        /// <summary>
        /// 
        /// Returns transactions for a given date range.
        /// 
        /// </summary>
        /// <param name="service">Instance of AmazonFPS service</param>
        /// <param name="request">GetAccountActivityRequest request</param>
        public static void InvokeGetAccountActivity(AmazonFPS service, GetAccountActivityRequest request)
        {
            try 
            {
                GetAccountActivityResponse response = service.GetAccountActivity(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetAccountActivityResponse");
                if (response.IsSetGetAccountActivityResult())
                {
                    Console.WriteLine("            GetAccountActivityResult");
                    GetAccountActivityResult  getAccountActivityResult = response.GetAccountActivityResult;
                    if (getAccountActivityResult.IsSetBatchSize())
                    {
                        Console.WriteLine("                BatchSize");
                        Console.WriteLine("                    {0}", getAccountActivityResult.BatchSize);
                    }
                    List<Transaction> transactionList = getAccountActivityResult.Transaction;
                    foreach (Transaction transaction in transactionList)
                    {
                        Console.WriteLine("                Transaction");
                        if (transaction.IsSetTransactionId())
                        {
                            Console.WriteLine("                    TransactionId");
                            Console.WriteLine("                        {0}", transaction.TransactionId);
                        }
                        if (transaction.IsSetCallerTransactionDate())
                        {
                            Console.WriteLine("                    CallerTransactionDate");
                            Console.WriteLine("                        {0}", transaction.CallerTransactionDate);
                        }
                        if (transaction.IsSetDateReceived())
                        {
                            Console.WriteLine("                    DateReceived");
                            Console.WriteLine("                        {0}", transaction.DateReceived);
                        }
                        if (transaction.IsSetDateCompleted())
                        {
                            Console.WriteLine("                    DateCompleted");
                            Console.WriteLine("                        {0}", transaction.DateCompleted);
                        }
                        if (transaction.IsSetTransactionAmount())
                        {
                            Console.WriteLine("                    TransactionAmount");
                            Amount  transactionAmount = transaction.TransactionAmount;
                            if (transactionAmount.IsSetCurrencyCode())
                            {
                                Console.WriteLine("                        CurrencyCode");
                                Console.WriteLine("                            {0}", transactionAmount.CurrencyCode);
                            }
                            if (transactionAmount.IsSetValue())
                            {
                                Console.WriteLine("                        Value");
                                Console.WriteLine("                            {0}", transactionAmount.Value);
                            }
                        }
                        if (transaction.IsSetFPSOperation())
                        {
                            Console.WriteLine("                    FPSOperation");
                            Console.WriteLine("                        {0}", transaction.FPSOperation);
                        }
                        if (transaction.IsSetTransactionStatus())
                        {
                            Console.WriteLine("                    TransactionStatus");
                            Console.WriteLine("                        {0}", transaction.TransactionStatus);
                        }
                        if (transaction.IsSetStatusMessage())
                        {
                            Console.WriteLine("                    StatusMessage");
                            Console.WriteLine("                        {0}", transaction.StatusMessage);
                        }
                        if (transaction.IsSetStatusCode())
                        {
                            Console.WriteLine("                    StatusCode");
                            Console.WriteLine("                        {0}", transaction.StatusCode);
                        }
                        if (transaction.IsSetOriginalTransactionId())
                        {
                            Console.WriteLine("                    OriginalTransactionId");
                            Console.WriteLine("                        {0}", transaction.OriginalTransactionId);
                        }
                        List<TransactionPart> transactionPartList = transaction.TransactionPart;
                        foreach (TransactionPart transactionPart in transactionPartList)
                        {
                            Console.WriteLine("                    TransactionPart");
                            if (transactionPart.IsSetInstrumentId())
                            {
                                Console.WriteLine("                        InstrumentId");
                                Console.WriteLine("                            {0}", transactionPart.InstrumentId);
                            }
                            if (transactionPart.IsSetRole())
                            {
                                Console.WriteLine("                        Role");
                                Console.WriteLine("                            {0}", transactionPart.Role);
                            }
                            if (transactionPart.IsSetName())
                            {
                                Console.WriteLine("                        Name");
                                Console.WriteLine("                            {0}", transactionPart.Name);
                            }
                            if (transactionPart.IsSetReference())
                            {
                                Console.WriteLine("                        Reference");
                                Console.WriteLine("                            {0}", transactionPart.Reference);
                            }
                            if (transactionPart.IsSetDescription())
                            {
                                Console.WriteLine("                        Description");
                                Console.WriteLine("                            {0}", transactionPart.Description);
                            }
                            if (transactionPart.IsSetFeesPaid())
                            {
                                Console.WriteLine("                        FeesPaid");
                                Amount  feesPaid = transactionPart.FeesPaid;
                                if (feesPaid.IsSetCurrencyCode())
                                {
                                    Console.WriteLine("                            CurrencyCode");
                                    Console.WriteLine("                                {0}", feesPaid.CurrencyCode);
                                }
                                if (feesPaid.IsSetValue())
                                {
                                    Console.WriteLine("                            Value");
                                    Console.WriteLine("                                {0}", feesPaid.Value);
                                }
                            }
                        }
                        if (transaction.IsSetPaymentMethod())
                        {
                            Console.WriteLine("                    PaymentMethod");
                            Console.WriteLine("                        {0}", transaction.PaymentMethod);
                        }
                        if (transaction.IsSetSenderName())
                        {
                            Console.WriteLine("                    SenderName");
                            Console.WriteLine("                        {0}", transaction.SenderName);
                        }
                        if (transaction.IsSetCallerName())
                        {
                            Console.WriteLine("                    CallerName");
                            Console.WriteLine("                        {0}", transaction.CallerName);
                        }
                        if (transaction.IsSetRecipientName())
                        {
                            Console.WriteLine("                    RecipientName");
                            Console.WriteLine("                        {0}", transaction.RecipientName);
                        }
                        if (transaction.IsSetFPSFees())
                        {
                            Console.WriteLine("                    FPSFees");
                            Amount  FPSFees = transaction.FPSFees;
                            if (FPSFees.IsSetCurrencyCode())
                            {
                                Console.WriteLine("                        CurrencyCode");
                                Console.WriteLine("                            {0}", FPSFees.CurrencyCode);
                            }
                            if (FPSFees.IsSetValue())
                            {
                                Console.WriteLine("                        Value");
                                Console.WriteLine("                            {0}", FPSFees.Value);
                            }
                        }
                        if (transaction.IsSetBalance())
                        {
                            Console.WriteLine("                    Balance");
                            Amount  balance = transaction.Balance;
                            if (balance.IsSetCurrencyCode())
                            {
                                Console.WriteLine("                        CurrencyCode");
                                Console.WriteLine("                            {0}", balance.CurrencyCode);
                            }
                            if (balance.IsSetValue())
                            {
                                Console.WriteLine("                        Value");
                                Console.WriteLine("                            {0}", balance.Value);
                            }
                        }
                        if (transaction.IsSetSenderTokenId())
                        {
                            Console.WriteLine("                    SenderTokenId");
                            Console.WriteLine("                        {0}", transaction.SenderTokenId);
                        }
                        if (transaction.IsSetRecipientTokenId())
                        {
                            Console.WriteLine("                    RecipientTokenId");
                            Console.WriteLine("                        {0}", transaction.RecipientTokenId);
                        }
                    }
                    if (getAccountActivityResult.IsSetStartTimeForNextTransaction())
                    {
                        Console.WriteLine("                StartTimeForNextTransaction");
                        Console.WriteLine("                    {0}", getAccountActivityResult.StartTimeForNextTransaction);
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
