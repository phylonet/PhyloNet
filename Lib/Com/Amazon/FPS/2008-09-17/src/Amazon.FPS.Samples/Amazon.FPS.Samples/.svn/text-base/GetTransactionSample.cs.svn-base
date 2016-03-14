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
    /// Get Transaction  Samples
    /// </summary>
    public class GetTransactionSample
    {
    
                                                                             
        /// <summary>
        /// 
        /// Returns all details of a transaction.
        /// 
        /// </summary>
        /// <param name="service">Instance of AmazonFPS service</param>
        /// <param name="request">GetTransactionRequest request</param>
        public static void InvokeGetTransaction(AmazonFPS service, GetTransactionRequest request)
        {
            try 
            {
                GetTransactionResponse response = service.GetTransaction(request);
                
                
                Console.WriteLine ("Service Response");
                Console.WriteLine ("=============================================================================");
                Console.WriteLine ();

                Console.WriteLine("        GetTransactionResponse");
                if (response.IsSetGetTransactionResult())
                {
                    Console.WriteLine("            GetTransactionResult");
                    GetTransactionResult  getTransactionResult = response.GetTransactionResult;
                    if (getTransactionResult.IsSetTransaction())
                    {
                        Console.WriteLine("                Transaction");
                        TransactionDetail  transaction = getTransactionResult.Transaction;
                        if (transaction.IsSetTransactionId())
                        {
                            Console.WriteLine("                    TransactionId");
                            Console.WriteLine("                        {0}", transaction.TransactionId);
                        }
                        if (transaction.IsSetCallerReference())
                        {
                            Console.WriteLine("                    CallerReference");
                            Console.WriteLine("                        {0}", transaction.CallerReference);
                        }
                        if (transaction.IsSetCallerDescription())
                        {
                            Console.WriteLine("                    CallerDescription");
                            Console.WriteLine("                        {0}", transaction.CallerDescription);
                        }
                        if (transaction.IsSetSenderDescription())
                        {
                            Console.WriteLine("                    SenderDescription");
                            Console.WriteLine("                        {0}", transaction.SenderDescription);
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
                        if (transaction.IsSetMarketplaceFees())
                        {
                            Console.WriteLine("                    MarketplaceFees");
                            Amount  marketplaceFees = transaction.MarketplaceFees;
                            if (marketplaceFees.IsSetCurrencyCode())
                            {
                                Console.WriteLine("                        CurrencyCode");
                                Console.WriteLine("                            {0}", marketplaceFees.CurrencyCode);
                            }
                            if (marketplaceFees.IsSetValue())
                            {
                                Console.WriteLine("                        Value");
                                Console.WriteLine("                            {0}", marketplaceFees.Value);
                            }
                        }
                        if (transaction.IsSetFPSFeesPaidBy())
                        {
                            Console.WriteLine("                    FPSFeesPaidBy");
                            Console.WriteLine("                        {0}", transaction.FPSFeesPaidBy);
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
                        if (transaction.IsSetPrepaidInstrumentId())
                        {
                            Console.WriteLine("                    PrepaidInstrumentId");
                            Console.WriteLine("                        {0}", transaction.PrepaidInstrumentId);
                        }
                        if (transaction.IsSetCreditInstrumentId())
                        {
                            Console.WriteLine("                    CreditInstrumentId");
                            Console.WriteLine("                        {0}", transaction.CreditInstrumentId);
                        }
                        if (transaction.IsSetFPSOperation())
                        {
                            Console.WriteLine("                    FPSOperation");
                            Console.WriteLine("                        {0}", transaction.FPSOperation);
                        }
                        if (transaction.IsSetPaymentMethod())
                        {
                            Console.WriteLine("                    PaymentMethod");
                            Console.WriteLine("                        {0}", transaction.PaymentMethod);
                        }
                        if (transaction.IsSetTransactionStatus())
                        {
                            Console.WriteLine("                    TransactionStatus");
                            Console.WriteLine("                        {0}", transaction.TransactionStatus);
                        }
                        if (transaction.IsSetStatusCode())
                        {
                            Console.WriteLine("                    StatusCode");
                            Console.WriteLine("                        {0}", transaction.StatusCode);
                        }
                        if (transaction.IsSetStatusMessage())
                        {
                            Console.WriteLine("                    StatusMessage");
                            Console.WriteLine("                        {0}", transaction.StatusMessage);
                        }
                        if (transaction.IsSetSenderName())
                        {
                            Console.WriteLine("                    SenderName");
                            Console.WriteLine("                        {0}", transaction.SenderName);
                        }
                        if (transaction.IsSetSenderEmail())
                        {
                            Console.WriteLine("                    SenderEmail");
                            Console.WriteLine("                        {0}", transaction.SenderEmail);
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
                        if (transaction.IsSetRecipientEmail())
                        {
                            Console.WriteLine("                    RecipientEmail");
                            Console.WriteLine("                        {0}", transaction.RecipientEmail);
                        }
                        List<RelatedTransaction> relatedTransactionList = transaction.RelatedTransaction;
                        foreach (RelatedTransaction relatedTransaction in relatedTransactionList)
                        {
                            Console.WriteLine("                    RelatedTransaction");
                            if (relatedTransaction.IsSetTransactionId())
                            {
                                Console.WriteLine("                        TransactionId");
                                Console.WriteLine("                            {0}", relatedTransaction.TransactionId);
                            }
                            if (relatedTransaction.IsSetRelationType())
                            {
                                Console.WriteLine("                        RelationType");
                                Console.WriteLine("                            {0}", relatedTransaction.RelationType);
                            }
                        }
                        List<StatusHistory> statusHistoryList = transaction.StatusHistory;
                        foreach (StatusHistory statusHistory in statusHistoryList)
                        {
                            Console.WriteLine("                    StatusHistory");
                            if (statusHistory.IsSetDate())
                            {
                                Console.WriteLine("                        Date");
                                Console.WriteLine("                            {0}", statusHistory.Date);
                            }
                            if (statusHistory.IsSetTransactionStatus())
                            {
                                Console.WriteLine("                        TransactionStatus");
                                Console.WriteLine("                            {0}", statusHistory.TransactionStatus);
                            }
                            if (statusHistory.IsSetStatusCode())
                            {
                                Console.WriteLine("                        StatusCode");
                                Console.WriteLine("                            {0}", statusHistory.StatusCode);
                            }
                            if (statusHistory.IsSetAmount())
                            {
                                Console.WriteLine("                        Amount");
                                Amount  amount = statusHistory.Amount;
                                if (amount.IsSetCurrencyCode())
                                {
                                    Console.WriteLine("                            CurrencyCode");
                                    Console.WriteLine("                                {0}", amount.CurrencyCode);
                                }
                                if (amount.IsSetValue())
                                {
                                    Console.WriteLine("                            Value");
                                    Console.WriteLine("                                {0}", amount.Value);
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
