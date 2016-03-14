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
using System.Text;


namespace Amazon.FPS.Model
{
    [XmlTypeAttribute(Namespace = "http://fps.amazonaws.com/doc/2008-09-17/")]
    [XmlRootAttribute(Namespace = "http://fps.amazonaws.com/doc/2008-09-17/", IsNullable = false)]
    public class Transaction
    {
    
        private String transactionIdField;

        private DateTime? callerTransactionDateField;

        private DateTime? dateReceivedField;

        private DateTime? dateCompletedField;

        private  Amount transactionAmountField;
        private FPSOperation? FPSOperationField;

        private TransactionStatus? transactionStatusField;

        private String statusMessageField;

        private String statusCodeField;

        private String originalTransactionIdField;

        private  List<TransactionPart> transactionPartField;

        private PaymentMethod? paymentMethodField;

        private String senderNameField;

        private String callerNameField;

        private String recipientNameField;

        private  Amount FPSFeesField;
        private  Amount balanceField;
        private String senderTokenIdField;

        private String recipientTokenIdField;


        /// <summary>
        /// Gets and sets the TransactionId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransactionId")]
        public String TransactionId
        {
            get { return this.transactionIdField ; }
            set { this.transactionIdField= value; }
        }



        /// <summary>
        /// Sets the TransactionId property
        /// </summary>
        /// <param name="transactionId">TransactionId property</param>
        /// <returns>this instance</returns>
        public Transaction WithTransactionId(String transactionId)
        {
            this.transactionIdField = transactionId;
            return this;
        }



        /// <summary>
        /// Checks if TransactionId property is set
        /// </summary>
        /// <returns>true if TransactionId property is set</returns>
        public Boolean IsSetTransactionId()
        {
            return  this.transactionIdField != null;

        }


        /// <summary>
        /// Gets and sets the CallerTransactionDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CallerTransactionDate")]
        public DateTime CallerTransactionDate
        {
            get { return this.callerTransactionDateField.GetValueOrDefault() ; }
            set { this.callerTransactionDateField= value; }
        }



        /// <summary>
        /// Sets the CallerTransactionDate property
        /// </summary>
        /// <param name="callerTransactionDate">CallerTransactionDate property</param>
        /// <returns>this instance</returns>
        public Transaction WithCallerTransactionDate(DateTime callerTransactionDate)
        {
            this.callerTransactionDateField = callerTransactionDate;
            return this;
        }



        /// <summary>
        /// Checks if CallerTransactionDate property is set
        /// </summary>
        /// <returns>true if CallerTransactionDate property is set</returns>
        public Boolean IsSetCallerTransactionDate()
        {
            return  this.callerTransactionDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the DateReceived property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DateReceived")]
        public DateTime DateReceived
        {
            get { return this.dateReceivedField.GetValueOrDefault() ; }
            set { this.dateReceivedField= value; }
        }



        /// <summary>
        /// Sets the DateReceived property
        /// </summary>
        /// <param name="dateReceived">DateReceived property</param>
        /// <returns>this instance</returns>
        public Transaction WithDateReceived(DateTime dateReceived)
        {
            this.dateReceivedField = dateReceived;
            return this;
        }



        /// <summary>
        /// Checks if DateReceived property is set
        /// </summary>
        /// <returns>true if DateReceived property is set</returns>
        public Boolean IsSetDateReceived()
        {
            return  this.dateReceivedField.HasValue;

        }


        /// <summary>
        /// Gets and sets the DateCompleted property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DateCompleted")]
        public DateTime DateCompleted
        {
            get { return this.dateCompletedField.GetValueOrDefault() ; }
            set { this.dateCompletedField= value; }
        }



        /// <summary>
        /// Sets the DateCompleted property
        /// </summary>
        /// <param name="dateCompleted">DateCompleted property</param>
        /// <returns>this instance</returns>
        public Transaction WithDateCompleted(DateTime dateCompleted)
        {
            this.dateCompletedField = dateCompleted;
            return this;
        }



        /// <summary>
        /// Checks if DateCompleted property is set
        /// </summary>
        /// <returns>true if DateCompleted property is set</returns>
        public Boolean IsSetDateCompleted()
        {
            return  this.dateCompletedField.HasValue;

        }


        /// <summary>
        /// Gets and sets the TransactionAmount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransactionAmount")]
        public Amount TransactionAmount
        {
            get { return this.transactionAmountField ; }
            set { this.transactionAmountField = value; }
        }



        /// <summary>
        /// Sets the TransactionAmount property
        /// </summary>
        /// <param name="transactionAmount">TransactionAmount property</param>
        /// <returns>this instance</returns>
        public Transaction WithTransactionAmount(Amount transactionAmount)
        {
            this.transactionAmountField = transactionAmount;
            return this;
        }



        /// <summary>
        /// Checks if TransactionAmount property is set
        /// </summary>
        /// <returns>true if TransactionAmount property is set</returns>
        public Boolean IsSetTransactionAmount()
        {
            return this.transactionAmountField != null;
        }




        /// <summary>
        /// Gets and sets the FPSOperation property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FPSOperation")]
        public FPSOperation FPSOperation
        {
            get { return this.FPSOperationField.GetValueOrDefault() ; }
            set { this.FPSOperationField= value; }
        }



        /// <summary>
        /// Sets the FPSOperation property
        /// </summary>
        /// <param name="FPSOperation">FPSOperation property</param>
        /// <returns>this instance</returns>
        public Transaction WithFPSOperation(FPSOperation FPSOperation)
        {
            this.FPSOperationField = FPSOperation;
            return this;
        }



        /// <summary>
        /// Checks if FPSOperation property is set
        /// </summary>
        /// <returns>true if FPSOperation property is set</returns>
        public Boolean IsSetFPSOperation()
        {
            return this.FPSOperationField.HasValue;

        }


        /// <summary>
        /// Gets and sets the TransactionStatus property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransactionStatus")]
        public TransactionStatus TransactionStatus
        {
            get { return this.transactionStatusField.GetValueOrDefault() ; }
            set { this.transactionStatusField= value; }
        }



        /// <summary>
        /// Sets the TransactionStatus property
        /// </summary>
        /// <param name="transactionStatus">TransactionStatus property</param>
        /// <returns>this instance</returns>
        public Transaction WithTransactionStatus(TransactionStatus transactionStatus)
        {
            this.transactionStatusField = transactionStatus;
            return this;
        }



        /// <summary>
        /// Checks if TransactionStatus property is set
        /// </summary>
        /// <returns>true if TransactionStatus property is set</returns>
        public Boolean IsSetTransactionStatus()
        {
            return this.transactionStatusField.HasValue;

        }


        /// <summary>
        /// Gets and sets the StatusMessage property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StatusMessage")]
        public String StatusMessage
        {
            get { return this.statusMessageField ; }
            set { this.statusMessageField= value; }
        }



        /// <summary>
        /// Sets the StatusMessage property
        /// </summary>
        /// <param name="statusMessage">StatusMessage property</param>
        /// <returns>this instance</returns>
        public Transaction WithStatusMessage(String statusMessage)
        {
            this.statusMessageField = statusMessage;
            return this;
        }



        /// <summary>
        /// Checks if StatusMessage property is set
        /// </summary>
        /// <returns>true if StatusMessage property is set</returns>
        public Boolean IsSetStatusMessage()
        {
            return  this.statusMessageField != null;

        }


        /// <summary>
        /// Gets and sets the StatusCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StatusCode")]
        public String StatusCode
        {
            get { return this.statusCodeField ; }
            set { this.statusCodeField= value; }
        }



        /// <summary>
        /// Sets the StatusCode property
        /// </summary>
        /// <param name="statusCode">StatusCode property</param>
        /// <returns>this instance</returns>
        public Transaction WithStatusCode(String statusCode)
        {
            this.statusCodeField = statusCode;
            return this;
        }



        /// <summary>
        /// Checks if StatusCode property is set
        /// </summary>
        /// <returns>true if StatusCode property is set</returns>
        public Boolean IsSetStatusCode()
        {
            return  this.statusCodeField != null;

        }


        /// <summary>
        /// Gets and sets the OriginalTransactionId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "OriginalTransactionId")]
        public String OriginalTransactionId
        {
            get { return this.originalTransactionIdField ; }
            set { this.originalTransactionIdField= value; }
        }



        /// <summary>
        /// Sets the OriginalTransactionId property
        /// </summary>
        /// <param name="originalTransactionId">OriginalTransactionId property</param>
        /// <returns>this instance</returns>
        public Transaction WithOriginalTransactionId(String originalTransactionId)
        {
            this.originalTransactionIdField = originalTransactionId;
            return this;
        }



        /// <summary>
        /// Checks if OriginalTransactionId property is set
        /// </summary>
        /// <returns>true if OriginalTransactionId property is set</returns>
        public Boolean IsSetOriginalTransactionId()
        {
            return  this.originalTransactionIdField != null;

        }


        /// <summary>
        /// Gets and sets the TransactionPart property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransactionPart")]
        public List<TransactionPart> TransactionPart
        {
            get
            {
                if (this.transactionPartField == null)
                {
                    this.transactionPartField = new List<TransactionPart>();
                }
                return this.transactionPartField;
            }
            set { this.transactionPartField =  value; }
        }



        /// <summary>
        /// Sets the TransactionPart property
        /// </summary>
        /// <param name="list">TransactionPart property</param>
        /// <returns>this instance</returns>
        public Transaction WithTransactionPart(params TransactionPart[] list)
        {
            foreach (TransactionPart item in list)
            {
                TransactionPart.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if TransactionPart property is set
        /// </summary>
        /// <returns>true if TransactionPart property is set</returns>
        public Boolean IsSetTransactionPart()
        {
            return (TransactionPart.Count > 0);
        }


        /// <summary>
        /// Gets and sets the PaymentMethod property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PaymentMethod")]
        public PaymentMethod PaymentMethod
        {
            get { return this.paymentMethodField.GetValueOrDefault() ; }
            set { this.paymentMethodField= value; }
        }



        /// <summary>
        /// Sets the PaymentMethod property
        /// </summary>
        /// <param name="paymentMethod">PaymentMethod property</param>
        /// <returns>this instance</returns>
        public Transaction WithPaymentMethod(PaymentMethod paymentMethod)
        {
            this.paymentMethodField = paymentMethod;
            return this;
        }



        /// <summary>
        /// Checks if PaymentMethod property is set
        /// </summary>
        /// <returns>true if PaymentMethod property is set</returns>
        public Boolean IsSetPaymentMethod()
        {
            return this.paymentMethodField.HasValue;

        }


        /// <summary>
        /// Gets and sets the SenderName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SenderName")]
        public String SenderName
        {
            get { return this.senderNameField ; }
            set { this.senderNameField= value; }
        }



        /// <summary>
        /// Sets the SenderName property
        /// </summary>
        /// <param name="senderName">SenderName property</param>
        /// <returns>this instance</returns>
        public Transaction WithSenderName(String senderName)
        {
            this.senderNameField = senderName;
            return this;
        }



        /// <summary>
        /// Checks if SenderName property is set
        /// </summary>
        /// <returns>true if SenderName property is set</returns>
        public Boolean IsSetSenderName()
        {
            return  this.senderNameField != null;

        }


        /// <summary>
        /// Gets and sets the CallerName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CallerName")]
        public String CallerName
        {
            get { return this.callerNameField ; }
            set { this.callerNameField= value; }
        }



        /// <summary>
        /// Sets the CallerName property
        /// </summary>
        /// <param name="callerName">CallerName property</param>
        /// <returns>this instance</returns>
        public Transaction WithCallerName(String callerName)
        {
            this.callerNameField = callerName;
            return this;
        }



        /// <summary>
        /// Checks if CallerName property is set
        /// </summary>
        /// <returns>true if CallerName property is set</returns>
        public Boolean IsSetCallerName()
        {
            return  this.callerNameField != null;

        }


        /// <summary>
        /// Gets and sets the RecipientName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "RecipientName")]
        public String RecipientName
        {
            get { return this.recipientNameField ; }
            set { this.recipientNameField= value; }
        }



        /// <summary>
        /// Sets the RecipientName property
        /// </summary>
        /// <param name="recipientName">RecipientName property</param>
        /// <returns>this instance</returns>
        public Transaction WithRecipientName(String recipientName)
        {
            this.recipientNameField = recipientName;
            return this;
        }



        /// <summary>
        /// Checks if RecipientName property is set
        /// </summary>
        /// <returns>true if RecipientName property is set</returns>
        public Boolean IsSetRecipientName()
        {
            return  this.recipientNameField != null;

        }


        /// <summary>
        /// Gets and sets the FPSFees property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FPSFees")]
        public Amount FPSFees
        {
            get { return this.FPSFeesField ; }
            set { this.FPSFeesField = value; }
        }



        /// <summary>
        /// Sets the FPSFees property
        /// </summary>
        /// <param name="FPSFees">FPSFees property</param>
        /// <returns>this instance</returns>
        public Transaction WithFPSFees(Amount FPSFees)
        {
            this.FPSFeesField = FPSFees;
            return this;
        }



        /// <summary>
        /// Checks if FPSFees property is set
        /// </summary>
        /// <returns>true if FPSFees property is set</returns>
        public Boolean IsSetFPSFees()
        {
            return this.FPSFeesField != null;
        }




        /// <summary>
        /// Gets and sets the Balance property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Balance")]
        public Amount Balance
        {
            get { return this.balanceField ; }
            set { this.balanceField = value; }
        }



        /// <summary>
        /// Sets the Balance property
        /// </summary>
        /// <param name="balance">Balance property</param>
        /// <returns>this instance</returns>
        public Transaction WithBalance(Amount balance)
        {
            this.balanceField = balance;
            return this;
        }



        /// <summary>
        /// Checks if Balance property is set
        /// </summary>
        /// <returns>true if Balance property is set</returns>
        public Boolean IsSetBalance()
        {
            return this.balanceField != null;
        }




        /// <summary>
        /// Gets and sets the SenderTokenId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SenderTokenId")]
        public String SenderTokenId
        {
            get { return this.senderTokenIdField ; }
            set { this.senderTokenIdField= value; }
        }



        /// <summary>
        /// Sets the SenderTokenId property
        /// </summary>
        /// <param name="senderTokenId">SenderTokenId property</param>
        /// <returns>this instance</returns>
        public Transaction WithSenderTokenId(String senderTokenId)
        {
            this.senderTokenIdField = senderTokenId;
            return this;
        }



        /// <summary>
        /// Checks if SenderTokenId property is set
        /// </summary>
        /// <returns>true if SenderTokenId property is set</returns>
        public Boolean IsSetSenderTokenId()
        {
            return  this.senderTokenIdField != null;

        }


        /// <summary>
        /// Gets and sets the RecipientTokenId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "RecipientTokenId")]
        public String RecipientTokenId
        {
            get { return this.recipientTokenIdField ; }
            set { this.recipientTokenIdField= value; }
        }



        /// <summary>
        /// Sets the RecipientTokenId property
        /// </summary>
        /// <param name="recipientTokenId">RecipientTokenId property</param>
        /// <returns>this instance</returns>
        public Transaction WithRecipientTokenId(String recipientTokenId)
        {
            this.recipientTokenIdField = recipientTokenId;
            return this;
        }



        /// <summary>
        /// Checks if RecipientTokenId property is set
        /// </summary>
        /// <returns>true if RecipientTokenId property is set</returns>
        public Boolean IsSetRecipientTokenId()
        {
            return  this.recipientTokenIdField != null;

        }




        /// <summary>
        /// XML fragment representation of this object
        /// </summary>
        /// <returns>XML fragment for this object.</returns>
        /// <remarks>
        /// Name for outer tag expected to be set by calling method. 
        /// This fragment returns inner properties representation only
        /// </remarks>


        protected internal String ToXMLFragment() {
            StringBuilder xml = new StringBuilder();
            if (IsSetTransactionId()) {
                xml.Append("<TransactionId>");
                xml.Append(EscapeXML(this.TransactionId));
                xml.Append("</TransactionId>");
            }
            if (IsSetCallerTransactionDate()) {
                xml.Append("<CallerTransactionDate>");
                xml.Append(this.CallerTransactionDate);
                xml.Append("</CallerTransactionDate>");
            }
            if (IsSetDateReceived()) {
                xml.Append("<DateReceived>");
                xml.Append(this.DateReceived);
                xml.Append("</DateReceived>");
            }
            if (IsSetDateCompleted()) {
                xml.Append("<DateCompleted>");
                xml.Append(this.DateCompleted);
                xml.Append("</DateCompleted>");
            }
            if (IsSetTransactionAmount()) {
                Amount  transactionAmount = this.TransactionAmount;
                xml.Append("<TransactionAmount>");
                xml.Append(transactionAmount.ToXMLFragment());
                xml.Append("</TransactionAmount>");
            } 
            if (IsSetFPSOperation()) {
                xml.Append("<FPSOperation>");
                xml.Append(this.FPSOperation);
                xml.Append("</FPSOperation>");
            }
            if (IsSetTransactionStatus()) {
                xml.Append("<TransactionStatus>");
                xml.Append(this.TransactionStatus);
                xml.Append("</TransactionStatus>");
            }
            if (IsSetStatusMessage()) {
                xml.Append("<StatusMessage>");
                xml.Append(EscapeXML(this.StatusMessage));
                xml.Append("</StatusMessage>");
            }
            if (IsSetStatusCode()) {
                xml.Append("<StatusCode>");
                xml.Append(EscapeXML(this.StatusCode));
                xml.Append("</StatusCode>");
            }
            if (IsSetOriginalTransactionId()) {
                xml.Append("<OriginalTransactionId>");
                xml.Append(EscapeXML(this.OriginalTransactionId));
                xml.Append("</OriginalTransactionId>");
            }
            List<TransactionPart> transactionPartList = this.TransactionPart;
            foreach (TransactionPart transactionPart in transactionPartList) {
                xml.Append("<TransactionPart>");
                xml.Append(transactionPart.ToXMLFragment());
                xml.Append("</TransactionPart>");
            }
            if (IsSetPaymentMethod()) {
                xml.Append("<PaymentMethod>");
                xml.Append(this.PaymentMethod);
                xml.Append("</PaymentMethod>");
            }
            if (IsSetSenderName()) {
                xml.Append("<SenderName>");
                xml.Append(EscapeXML(this.SenderName));
                xml.Append("</SenderName>");
            }
            if (IsSetCallerName()) {
                xml.Append("<CallerName>");
                xml.Append(EscapeXML(this.CallerName));
                xml.Append("</CallerName>");
            }
            if (IsSetRecipientName()) {
                xml.Append("<RecipientName>");
                xml.Append(EscapeXML(this.RecipientName));
                xml.Append("</RecipientName>");
            }
            if (IsSetFPSFees()) {
                Amount  FPSFees = this.FPSFees;
                xml.Append("<FPSFees>");
                xml.Append(FPSFees.ToXMLFragment());
                xml.Append("</FPSFees>");
            } 
            if (IsSetBalance()) {
                Amount  balance = this.Balance;
                xml.Append("<Balance>");
                xml.Append(balance.ToXMLFragment());
                xml.Append("</Balance>");
            } 
            if (IsSetSenderTokenId()) {
                xml.Append("<SenderTokenId>");
                xml.Append(EscapeXML(this.SenderTokenId));
                xml.Append("</SenderTokenId>");
            }
            if (IsSetRecipientTokenId()) {
                xml.Append("<RecipientTokenId>");
                xml.Append(EscapeXML(this.RecipientTokenId));
                xml.Append("</RecipientTokenId>");
            }
            return xml.ToString();
        }

        /**
         * 
         * Escape XML special characters
         */
        private String EscapeXML(String str) {
            StringBuilder sb = new StringBuilder();
            foreach (Char c in str)
            {
                switch (c) {
                case '&':
                    sb.Append("&amp;");
                    break;
                case '<':
                    sb.Append("&lt;");
                    break;
                case '>':
                    sb.Append("&gt;");
                    break;
                case '\'':
                    sb.Append("&#039;");
                    break;
                case '"':
                    sb.Append("&quot;");
                    break;
                default:
                    sb.Append(c);
                    break;
                }
            }
            return sb.ToString();
        }



    }

}