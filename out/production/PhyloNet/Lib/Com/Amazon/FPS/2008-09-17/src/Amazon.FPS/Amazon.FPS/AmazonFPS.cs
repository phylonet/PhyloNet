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
using Amazon.FPS.Model;

namespace Amazon.FPS
{


    /// <summary>
    /// 
    /// Amazon Flexible Payments Service
    /// 
    /// </summary>
    public interface  AmazonFPS {
    
                
        /// <summary>
        /// Cancel Token 
        /// </summary>
        /// <param name="request">Cancel Token  request</param>
        /// <returns>Cancel Token  Response from the service</returns>
        /// <remarks>
        /// 
        /// Cancels any token installed by the calling application on its own account.
        ///   
        /// </remarks>
        CancelTokenResponse CancelToken(CancelTokenRequest request);

                
        /// <summary>
        /// Cancel 
        /// </summary>
        /// <param name="request">Cancel  request</param>
        /// <returns>Cancel  Response from the service</returns>
        /// <remarks>
        /// 
        /// Cancels an ongoing transaction and puts it in cancelled state.
        ///   
        /// </remarks>
        CancelResponse Cancel(CancelRequest request);

                
        /// <summary>
        /// Fund Prepaid 
        /// </summary>
        /// <param name="request">Fund Prepaid  request</param>
        /// <returns>Fund Prepaid  Response from the service</returns>
        /// <remarks>
        /// 
        /// Funds the prepaid balance on the given prepaid instrument.
        ///   
        /// </remarks>
        FundPrepaidResponse FundPrepaid(FundPrepaidRequest request);

                
        /// <summary>
        /// Get Account Activity 
        /// </summary>
        /// <param name="request">Get Account Activity  request</param>
        /// <returns>Get Account Activity  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns transactions for a given date range.
        ///   
        /// </remarks>
        GetAccountActivityResponse GetAccountActivity(GetAccountActivityRequest request);

                
        /// <summary>
        /// Get Account Balance 
        /// </summary>
        /// <param name="request">Get Account Balance  request</param>
        /// <returns>Get Account Balance  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the account balance for an account in real time.
        ///   
        /// </remarks>
        GetAccountBalanceResponse GetAccountBalance(GetAccountBalanceRequest request);

                
        /// <summary>
        /// Get Debt Balance 
        /// </summary>
        /// <param name="request">Get Debt Balance  request</param>
        /// <returns>Get Debt Balance  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the balance corresponding to the given credit instrument.
        ///   
        /// </remarks>
        GetDebtBalanceResponse GetDebtBalance(GetDebtBalanceRequest request);

                
        /// <summary>
        /// Get Outstanding Debt Balance 
        /// </summary>
        /// <param name="request">Get Outstanding Debt Balance  request</param>
        /// <returns>Get Outstanding Debt Balance  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the total outstanding balance for all the credit instruments for the given creditor account.
        ///   
        /// </remarks>
        GetOutstandingDebtBalanceResponse GetOutstandingDebtBalance(GetOutstandingDebtBalanceRequest request);

                
        /// <summary>
        /// Get Prepaid Balance 
        /// </summary>
        /// <param name="request">Get Prepaid Balance  request</param>
        /// <returns>Get Prepaid Balance  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the balance available on the given prepaid instrument.
        ///   
        /// </remarks>
        GetPrepaidBalanceResponse GetPrepaidBalance(GetPrepaidBalanceRequest request);

                
        /// <summary>
        /// Get Token By Caller 
        /// </summary>
        /// <param name="request">Get Token By Caller  request</param>
        /// <returns>Get Token By Caller  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the details of a particular token installed by this calling application using the subway co-branded UI.
        ///   
        /// </remarks>
        GetTokenByCallerResponse GetTokenByCaller(GetTokenByCallerRequest request);

                
        /// <summary>
        /// Cancel Subscription And Refund 
        /// </summary>
        /// <param name="request">Cancel Subscription And Refund  request</param>
        /// <returns>Cancel Subscription And Refund  Response from the service</returns>
        /// <remarks>
        /// 
        /// Cancels a subscription.
        ///   
        /// </remarks>
        CancelSubscriptionAndRefundResponse CancelSubscriptionAndRefund(CancelSubscriptionAndRefundRequest request);

                
        /// <summary>
        /// Get Token Usage 
        /// </summary>
        /// <param name="request">Get Token Usage  request</param>
        /// <returns>Get Token Usage  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the usage of a token.
        ///   
        /// </remarks>
        GetTokenUsageResponse GetTokenUsage(GetTokenUsageRequest request);

                
        /// <summary>
        /// Get Tokens 
        /// </summary>
        /// <param name="request">Get Tokens  request</param>
        /// <returns>Get Tokens  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns a list of tokens installed on the given account.
        ///   
        /// </remarks>
        GetTokensResponse GetTokens(GetTokensRequest request);

                
        /// <summary>
        /// Get Total Prepaid Liability 
        /// </summary>
        /// <param name="request">Get Total Prepaid Liability  request</param>
        /// <returns>Get Total Prepaid Liability  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns the total liability held by the given account corresponding to all the prepaid instruments owned by the account.
        ///   
        /// </remarks>
        GetTotalPrepaidLiabilityResponse GetTotalPrepaidLiability(GetTotalPrepaidLiabilityRequest request);

                
        /// <summary>
        /// Get Transaction 
        /// </summary>
        /// <param name="request">Get Transaction  request</param>
        /// <returns>Get Transaction  Response from the service</returns>
        /// <remarks>
        /// 
        /// Returns all details of a transaction.
        ///   
        /// </remarks>
        GetTransactionResponse GetTransaction(GetTransactionRequest request);

                
        /// <summary>
        /// Get Transaction Status 
        /// </summary>
        /// <param name="request">Get Transaction Status  request</param>
        /// <returns>Get Transaction Status  Response from the service</returns>
        /// <remarks>
        /// 
        /// Gets the latest status of a transaction.
        ///   
        /// </remarks>
        GetTransactionStatusResponse GetTransactionStatus(GetTransactionStatusRequest request);

                
        /// <summary>
        /// Get Payment Instruction 
        /// </summary>
        /// <param name="request">Get Payment Instruction  request</param>
        /// <returns>Get Payment Instruction  Response from the service</returns>
        /// <remarks>
        /// 
        /// Gets the payment instruction of a token.
        ///   
        /// </remarks>
        GetPaymentInstructionResponse GetPaymentInstruction(GetPaymentInstructionRequest request);

                
        /// <summary>
        /// Install Payment Instruction 
        /// </summary>
        /// <param name="request">Install Payment Instruction  request</param>
        /// <returns>Install Payment Instruction  Response from the service</returns>
        /// <remarks>
        /// Installs a payment instruction for caller.
        ///   
        /// </remarks>
        InstallPaymentInstructionResponse InstallPaymentInstruction(InstallPaymentInstructionRequest request);

                
        /// <summary>
        /// Pay 
        /// </summary>
        /// <param name="request">Pay  request</param>
        /// <returns>Pay  Response from the service</returns>
        /// <remarks>
        /// 
        /// Allows calling applications to move money from a sender to a recipient.
        ///   
        /// </remarks>
        PayResponse Pay(PayRequest request);

                
        /// <summary>
        /// Refund 
        /// </summary>
        /// <param name="request">Refund  request</param>
        /// <returns>Refund  Response from the service</returns>
        /// <remarks>
        /// 
        /// Refunds a previously completed transaction.
        ///   
        /// </remarks>
        RefundResponse Refund(RefundRequest request);

                
        /// <summary>
        /// Reserve 
        /// </summary>
        /// <param name="request">Reserve  request</param>
        /// <returns>Reserve  Response from the service</returns>
        /// <remarks>
        /// 
        /// Reserve API is part of the Reserve and Settle API conjunction that serve the purpose of a pay where the authorization and settlement have a timing 				difference.
        ///   
        /// </remarks>
        ReserveResponse Reserve(ReserveRequest request);

                
        /// <summary>
        /// Settle 
        /// </summary>
        /// <param name="request">Settle  request</param>
        /// <returns>Settle  Response from the service</returns>
        /// <remarks>
        /// 
        /// The Settle API is used in conjunction with the Reserve API and is used to settle previously reserved transaction.
        ///   
        /// </remarks>
        SettleResponse Settle(SettleRequest request);

                
        /// <summary>
        /// Settle Debt 
        /// </summary>
        /// <param name="request">Settle Debt  request</param>
        /// <returns>Settle Debt  Response from the service</returns>
        /// <remarks>
        /// 
        /// Allows a caller to initiate a transaction that atomically transfers money from a sender’s payment instrument to the recipient, while decreasing corresponding 				debt balance.
        ///   
        /// </remarks>
        SettleDebtResponse SettleDebt(SettleDebtRequest request);

                
        /// <summary>
        /// Write Off Debt 
        /// </summary>
        /// <param name="request">Write Off Debt  request</param>
        /// <returns>Write Off Debt  Response from the service</returns>
        /// <remarks>
        /// 
        /// Allows a creditor to write off the debt balance accumulated partially or fully at any time.
        ///   
        /// </remarks>
        WriteOffDebtResponse WriteOffDebt(WriteOffDebtRequest request);

                
        /// <summary>
        /// Verify Signature 
        /// </summary>
        /// <param name="request">Verify Signature  request</param>
        /// <returns>Verify Signature  Response from the service</returns>
        /// <remarks>
        /// 
        /// Verify the signature that FPS sent in IPN or callback urls.
        ///   
        /// </remarks>
        VerifySignatureResponse VerifySignature(VerifySignatureRequest request);

    }
}