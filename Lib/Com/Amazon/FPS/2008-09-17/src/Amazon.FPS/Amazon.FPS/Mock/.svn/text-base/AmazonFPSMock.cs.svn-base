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
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Amazon.FPS.Model;

namespace Amazon.FPS.Mock
{

    /// <summary>
    /// AmazonFPSMock is the implementation of AmazonFPS based
    /// on the pre-populated set of XML files that serve local data. It simulates 
    /// responses from Amazon FPS service.
    /// </summary>
    /// <remarks>
    /// Use this to test your application without making a call to 
    /// Amazon FPS 
    /// 
    /// Note, current Mock Service implementation does not valiadate requests
    /// </remarks>
    public  class AmazonFPSMock : AmazonFPS {
    

        // Public API ------------------------------------------------------------//
    
        
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
        public CancelTokenResponse CancelToken(CancelTokenRequest request)
        {
            return Invoke<CancelTokenResponse>("CancelTokenResponse.xml");
        }
        
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
        public CancelResponse Cancel(CancelRequest request)
        {
            return Invoke<CancelResponse>("CancelResponse.xml");
        }
        
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
        public FundPrepaidResponse FundPrepaid(FundPrepaidRequest request)
        {
            return Invoke<FundPrepaidResponse>("FundPrepaidResponse.xml");
        }
        
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
        public GetAccountActivityResponse GetAccountActivity(GetAccountActivityRequest request)
        {
            return Invoke<GetAccountActivityResponse>("GetAccountActivityResponse.xml");
        }
        
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
        public GetAccountBalanceResponse GetAccountBalance(GetAccountBalanceRequest request)
        {
            return Invoke<GetAccountBalanceResponse>("GetAccountBalanceResponse.xml");
        }
        
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
        public GetDebtBalanceResponse GetDebtBalance(GetDebtBalanceRequest request)
        {
            return Invoke<GetDebtBalanceResponse>("GetDebtBalanceResponse.xml");
        }
        
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
        public GetOutstandingDebtBalanceResponse GetOutstandingDebtBalance(GetOutstandingDebtBalanceRequest request)
        {
            return Invoke<GetOutstandingDebtBalanceResponse>("GetOutstandingDebtBalanceResponse.xml");
        }
        
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
        public GetPrepaidBalanceResponse GetPrepaidBalance(GetPrepaidBalanceRequest request)
        {
            return Invoke<GetPrepaidBalanceResponse>("GetPrepaidBalanceResponse.xml");
        }
        
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
        public GetTokenByCallerResponse GetTokenByCaller(GetTokenByCallerRequest request)
        {
            return Invoke<GetTokenByCallerResponse>("GetTokenByCallerResponse.xml");
        }
        
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
        public CancelSubscriptionAndRefundResponse CancelSubscriptionAndRefund(CancelSubscriptionAndRefundRequest request)
        {
            return Invoke<CancelSubscriptionAndRefundResponse>("CancelSubscriptionAndRefundResponse.xml");
        }
        
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
        public GetTokenUsageResponse GetTokenUsage(GetTokenUsageRequest request)
        {
            return Invoke<GetTokenUsageResponse>("GetTokenUsageResponse.xml");
        }
        
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
        public GetTokensResponse GetTokens(GetTokensRequest request)
        {
            return Invoke<GetTokensResponse>("GetTokensResponse.xml");
        }
        
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
        public GetTotalPrepaidLiabilityResponse GetTotalPrepaidLiability(GetTotalPrepaidLiabilityRequest request)
        {
            return Invoke<GetTotalPrepaidLiabilityResponse>("GetTotalPrepaidLiabilityResponse.xml");
        }
        
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
        public GetTransactionResponse GetTransaction(GetTransactionRequest request)
        {
            return Invoke<GetTransactionResponse>("GetTransactionResponse.xml");
        }
        
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
        public GetTransactionStatusResponse GetTransactionStatus(GetTransactionStatusRequest request)
        {
            return Invoke<GetTransactionStatusResponse>("GetTransactionStatusResponse.xml");
        }
        
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
        public GetPaymentInstructionResponse GetPaymentInstruction(GetPaymentInstructionRequest request)
        {
            return Invoke<GetPaymentInstructionResponse>("GetPaymentInstructionResponse.xml");
        }
        
        /// <summary>
        /// Install Payment Instruction 
        /// </summary>
        /// <param name="request">Install Payment Instruction  request</param>
        /// <returns>Install Payment Instruction  Response from the service</returns>
        /// <remarks>
        /// Installs a payment instruction for caller.
        ///   
        /// </remarks>
        public InstallPaymentInstructionResponse InstallPaymentInstruction(InstallPaymentInstructionRequest request)
        {
            return Invoke<InstallPaymentInstructionResponse>("InstallPaymentInstructionResponse.xml");
        }
        
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
        public PayResponse Pay(PayRequest request)
        {
            return Invoke<PayResponse>("PayResponse.xml");
        }
        
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
        public RefundResponse Refund(RefundRequest request)
        {
            return Invoke<RefundResponse>("RefundResponse.xml");
        }
        
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
        public ReserveResponse Reserve(ReserveRequest request)
        {
            return Invoke<ReserveResponse>("ReserveResponse.xml");
        }
        
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
        public SettleResponse Settle(SettleRequest request)
        {
            return Invoke<SettleResponse>("SettleResponse.xml");
        }
        
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
        public SettleDebtResponse SettleDebt(SettleDebtRequest request)
        {
            return Invoke<SettleDebtResponse>("SettleDebtResponse.xml");
        }
        
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
        public WriteOffDebtResponse WriteOffDebt(WriteOffDebtRequest request)
        {
            return Invoke<WriteOffDebtResponse>("WriteOffDebtResponse.xml");
        }
        
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
        public VerifySignatureResponse VerifySignature(VerifySignatureRequest request)
        {
            return Invoke<VerifySignatureResponse>("VerifySignatureResponse.xml");
        }

        // Private API ------------------------------------------------------------//

        private T Invoke<T>(String xmlResource)
        {
            XmlSerializer serlizer = new XmlSerializer(typeof(T));
            Stream xmlStream = Assembly.GetAssembly(this.GetType()).GetManifestResourceStream(xmlResource);
            return (T)serlizer.Deserialize(xmlStream);
        }
    }
}