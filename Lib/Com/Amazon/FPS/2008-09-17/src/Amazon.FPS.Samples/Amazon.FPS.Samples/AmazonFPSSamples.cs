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
using Amazon.FPS.Mock;
using Amazon.FPS.Model;

namespace Amazon.FPS.Samples
{

    /// <summary>
    /// Amazon FPS  Samples
    /// </summary>
    public class AmazonFPSSamples 
    {
    
       /**
        * Samples for Amazon FPS functionality
        */
        public static void Main(string [] args) 
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("Welcome to Amazon FPS Samples!");
            Console.WriteLine("===========================================");

            Console.WriteLine("To get started:");
            Console.WriteLine("===========================================");
            Console.WriteLine("  - Fill in your AWS credentials");
            Console.WriteLine("  - Uncomment sample you're interested in trying");
            Console.WriteLine("  - Set request with desired parameters");
            Console.WriteLine("  - Hit F5 to run!");
            Console.WriteLine();

            Console.WriteLine("===========================================");
            Console.WriteLine("Samples Output");
            Console.WriteLine("===========================================");
            Console.WriteLine();

           /************************************************************************
            * Access Key ID and Secret Acess Key ID, obtained from:
            * http://aws.amazon.com
            ***********************************************************************/
            String accessKeyId = "<Your Access Key ID>";
            String secretAccessKey = "<Your Secret Access Key>";
        
            /************************************************************************
            * Instantiate  Implementation of Amazon FPS 
            ***********************************************************************/
            AmazonFPS service = new AmazonFPSClient(accessKeyId, secretAccessKey);
        
            /************************************************************************
            * Uncomment to try advanced configuration options. Available options are:
            *
            *  - Signature Version
            *  - Proxy Host and Proxy Port
            *  - Service URL
            *  - User Agent String to be sent to Amazon FPS  service
            *
            ***********************************************************************/
            // AmazonFPSConfig config = new AmazonFPSConfig();
            // config.SignatureVersion = "0";
            // AmazonFPS service = new AmazonFPSClient(accessKeyId, secretAccessKey, config);
        
        
            /************************************************************************
            * Uncomment to try out Mock Service that simulates Amazon FPS 
            * responses without calling Amazon FPS  service.
            *
            * Responses are loaded from local XML files. You can tweak XML files to
            * experiment with various outputs during development
            *
            * XML files available under Amazon\FPS\Mock tree
            *
            ***********************************************************************/
            // AmazonFPS service = new AmazonFPSMock();


            /************************************************************************
            * Uncomment to invoke Cancel Token Action
            ***********************************************************************/
            // CancelTokenRequest request = new CancelTokenRequest();
            // @TODO: set request parameters here
            // CancelTokenSample.InvokeCancelToken(service, request);
            /************************************************************************
            * Uncomment to invoke Cancel Action
            ***********************************************************************/
            // CancelRequest request = new CancelRequest();
            // @TODO: set request parameters here
            // CancelSample.InvokeCancel(service, request);
            /************************************************************************
            * Uncomment to invoke Fund Prepaid Action
            ***********************************************************************/
            // FundPrepaidRequest request = new FundPrepaidRequest();
            // @TODO: set request parameters here
            // FundPrepaidSample.InvokeFundPrepaid(service, request);
            /************************************************************************
            * Uncomment to invoke Get Account Activity Action
            ***********************************************************************/
            // GetAccountActivityRequest request = new GetAccountActivityRequest();
            // @TODO: set request parameters here
            // GetAccountActivitySample.InvokeGetAccountActivity(service, request);
            /************************************************************************
            * Uncomment to invoke Get Account Balance Action
            ***********************************************************************/
            // GetAccountBalanceRequest request = new GetAccountBalanceRequest();
            // @TODO: set request parameters here
            // GetAccountBalanceSample.InvokeGetAccountBalance(service, request);
            /************************************************************************
            * Uncomment to invoke Get Debt Balance Action
            ***********************************************************************/
            // GetDebtBalanceRequest request = new GetDebtBalanceRequest();
            // @TODO: set request parameters here
            // GetDebtBalanceSample.InvokeGetDebtBalance(service, request);
            /************************************************************************
            * Uncomment to invoke Get Outstanding Debt Balance Action
            ***********************************************************************/
            // GetOutstandingDebtBalanceRequest request = new GetOutstandingDebtBalanceRequest();
            // @TODO: set request parameters here
            // GetOutstandingDebtBalanceSample.InvokeGetOutstandingDebtBalance(service, request);
            /************************************************************************
            * Uncomment to invoke Get Prepaid Balance Action
            ***********************************************************************/
            // GetPrepaidBalanceRequest request = new GetPrepaidBalanceRequest();
            // @TODO: set request parameters here
            // GetPrepaidBalanceSample.InvokeGetPrepaidBalance(service, request);
            /************************************************************************
            * Uncomment to invoke Get Token By Caller Action
            ***********************************************************************/
            // GetTokenByCallerRequest request = new GetTokenByCallerRequest();
            // @TODO: set request parameters here
            // GetTokenByCallerSample.InvokeGetTokenByCaller(service, request);
            /************************************************************************
            * Uncomment to invoke Cancel Subscription And Refund Action
            ***********************************************************************/
            // CancelSubscriptionAndRefundRequest request = new CancelSubscriptionAndRefundRequest();
            // @TODO: set request parameters here
            // CancelSubscriptionAndRefundSample.InvokeCancelSubscriptionAndRefund(service, request);
            /************************************************************************
            * Uncomment to invoke Get Token Usage Action
            ***********************************************************************/
            // GetTokenUsageRequest request = new GetTokenUsageRequest();
            // @TODO: set request parameters here
            // GetTokenUsageSample.InvokeGetTokenUsage(service, request);
            /************************************************************************
            * Uncomment to invoke Get Tokens Action
            ***********************************************************************/
            // GetTokensRequest request = new GetTokensRequest();
            // @TODO: set request parameters here
            // GetTokensSample.InvokeGetTokens(service, request);
            /************************************************************************
            * Uncomment to invoke Get Total Prepaid Liability Action
            ***********************************************************************/
            // GetTotalPrepaidLiabilityRequest request = new GetTotalPrepaidLiabilityRequest();
            // @TODO: set request parameters here
            // GetTotalPrepaidLiabilitySample.InvokeGetTotalPrepaidLiability(service, request);
            /************************************************************************
            * Uncomment to invoke Get Transaction Action
            ***********************************************************************/
            // GetTransactionRequest request = new GetTransactionRequest();
            // @TODO: set request parameters here
            // GetTransactionSample.InvokeGetTransaction(service, request);
            /************************************************************************
            * Uncomment to invoke Get Transaction Status Action
            ***********************************************************************/
            // GetTransactionStatusRequest request = new GetTransactionStatusRequest();
            // @TODO: set request parameters here
            // GetTransactionStatusSample.InvokeGetTransactionStatus(service, request);
            /************************************************************************
            * Uncomment to invoke Get Payment Instruction Action
            ***********************************************************************/
            // GetPaymentInstructionRequest request = new GetPaymentInstructionRequest();
            // @TODO: set request parameters here
            // GetPaymentInstructionSample.InvokeGetPaymentInstruction(service, request);
            /************************************************************************
            * Uncomment to invoke Install Payment Instruction Action
            ***********************************************************************/
            // InstallPaymentInstructionRequest request = new InstallPaymentInstructionRequest();
            // @TODO: set request parameters here
            // InstallPaymentInstructionSample.InvokeInstallPaymentInstruction(service, request);
            /************************************************************************
            * Uncomment to invoke Pay Action
            ***********************************************************************/
            // PayRequest request = new PayRequest();
            // @TODO: set request parameters here
            // PaySample.InvokePay(service, request);
            /************************************************************************
            * Uncomment to invoke Refund Action
            ***********************************************************************/
            // RefundRequest request = new RefundRequest();
            // @TODO: set request parameters here
            // RefundSample.InvokeRefund(service, request);
            /************************************************************************
            * Uncomment to invoke Reserve Action
            ***********************************************************************/
            // ReserveRequest request = new ReserveRequest();
            // @TODO: set request parameters here
            // ReserveSample.InvokeReserve(service, request);
            /************************************************************************
            * Uncomment to invoke Settle Action
            ***********************************************************************/
            // SettleRequest request = new SettleRequest();
            // @TODO: set request parameters here
            // SettleSample.InvokeSettle(service, request);
            /************************************************************************
            * Uncomment to invoke Settle Debt Action
            ***********************************************************************/
            // SettleDebtRequest request = new SettleDebtRequest();
            // @TODO: set request parameters here
            // SettleDebtSample.InvokeSettleDebt(service, request);
            /************************************************************************
            * Uncomment to invoke Write Off Debt Action
            ***********************************************************************/
            // WriteOffDebtRequest request = new WriteOffDebtRequest();
            // @TODO: set request parameters here
            // WriteOffDebtSample.InvokeWriteOffDebt(service, request);
            /************************************************************************
            * Uncomment to invoke Verify Signature Action
            ***********************************************************************/
            // VerifySignatureRequest request = new VerifySignatureRequest();
            // @TODO: set request parameters here
            // VerifySignatureSample.InvokeVerifySignature(service, request);
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine("End of output. You can close this window");
            Console.WriteLine("===========================================");

            System.Threading.Thread.Sleep(50000);
        }

    }
}
