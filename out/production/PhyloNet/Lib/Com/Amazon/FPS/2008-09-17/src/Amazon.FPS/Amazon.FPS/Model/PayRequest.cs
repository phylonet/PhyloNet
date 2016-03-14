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
    public class PayRequest
    {
    
        private String senderTokenIdField;

        private String recipientTokenIdField;

        private  Amount transactionAmountField;
        private ChargeFeeTo? chargeFeeToField;

        private String callerReferenceField;

        private String callerDescriptionField;

        private String senderDescriptionField;

        private  DescriptorPolicy descriptorPolicyField;
        private Decimal? transactionTimeoutInMinsField;

        private  Amount marketplaceFixedFeeField;
        private Decimal? marketplaceVariableFeeField;


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
        public PayRequest WithSenderTokenId(String senderTokenId)
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
        public PayRequest WithRecipientTokenId(String recipientTokenId)
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
        public PayRequest WithTransactionAmount(Amount transactionAmount)
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
        /// Gets and sets the ChargeFeeTo property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ChargeFeeTo")]
        public ChargeFeeTo ChargeFeeTo
        {
            get { return this.chargeFeeToField.GetValueOrDefault() ; }
            set { this.chargeFeeToField= value; }
        }



        /// <summary>
        /// Sets the ChargeFeeTo property
        /// </summary>
        /// <param name="chargeFeeTo">ChargeFeeTo property</param>
        /// <returns>this instance</returns>
        public PayRequest WithChargeFeeTo(ChargeFeeTo chargeFeeTo)
        {
            this.chargeFeeToField = chargeFeeTo;
            return this;
        }



        /// <summary>
        /// Checks if ChargeFeeTo property is set
        /// </summary>
        /// <returns>true if ChargeFeeTo property is set</returns>
        public Boolean IsSetChargeFeeTo()
        {
            return this.chargeFeeToField.HasValue;

        }


        /// <summary>
        /// Gets and sets the CallerReference property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CallerReference")]
        public String CallerReference
        {
            get { return this.callerReferenceField ; }
            set { this.callerReferenceField= value; }
        }



        /// <summary>
        /// Sets the CallerReference property
        /// </summary>
        /// <param name="callerReference">CallerReference property</param>
        /// <returns>this instance</returns>
        public PayRequest WithCallerReference(String callerReference)
        {
            this.callerReferenceField = callerReference;
            return this;
        }



        /// <summary>
        /// Checks if CallerReference property is set
        /// </summary>
        /// <returns>true if CallerReference property is set</returns>
        public Boolean IsSetCallerReference()
        {
            return  this.callerReferenceField != null;

        }


        /// <summary>
        /// Gets and sets the CallerDescription property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CallerDescription")]
        public String CallerDescription
        {
            get { return this.callerDescriptionField ; }
            set { this.callerDescriptionField= value; }
        }



        /// <summary>
        /// Sets the CallerDescription property
        /// </summary>
        /// <param name="callerDescription">CallerDescription property</param>
        /// <returns>this instance</returns>
        public PayRequest WithCallerDescription(String callerDescription)
        {
            this.callerDescriptionField = callerDescription;
            return this;
        }



        /// <summary>
        /// Checks if CallerDescription property is set
        /// </summary>
        /// <returns>true if CallerDescription property is set</returns>
        public Boolean IsSetCallerDescription()
        {
            return  this.callerDescriptionField != null;

        }


        /// <summary>
        /// Gets and sets the SenderDescription property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SenderDescription")]
        public String SenderDescription
        {
            get { return this.senderDescriptionField ; }
            set { this.senderDescriptionField= value; }
        }



        /// <summary>
        /// Sets the SenderDescription property
        /// </summary>
        /// <param name="senderDescription">SenderDescription property</param>
        /// <returns>this instance</returns>
        public PayRequest WithSenderDescription(String senderDescription)
        {
            this.senderDescriptionField = senderDescription;
            return this;
        }



        /// <summary>
        /// Checks if SenderDescription property is set
        /// </summary>
        /// <returns>true if SenderDescription property is set</returns>
        public Boolean IsSetSenderDescription()
        {
            return  this.senderDescriptionField != null;

        }


        /// <summary>
        /// Gets and sets the DescriptorPolicy property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DescriptorPolicy")]
        public DescriptorPolicy DescriptorPolicy
        {
            get { return this.descriptorPolicyField ; }
            set { this.descriptorPolicyField = value; }
        }



        /// <summary>
        /// Sets the DescriptorPolicy property
        /// </summary>
        /// <param name="descriptorPolicy">DescriptorPolicy property</param>
        /// <returns>this instance</returns>
        public PayRequest WithDescriptorPolicy(DescriptorPolicy descriptorPolicy)
        {
            this.descriptorPolicyField = descriptorPolicy;
            return this;
        }



        /// <summary>
        /// Checks if DescriptorPolicy property is set
        /// </summary>
        /// <returns>true if DescriptorPolicy property is set</returns>
        public Boolean IsSetDescriptorPolicy()
        {
            return this.descriptorPolicyField != null;
        }




        /// <summary>
        /// Gets and sets the TransactionTimeoutInMins property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransactionTimeoutInMins")]
        public Decimal TransactionTimeoutInMins
        {
            get { return this.transactionTimeoutInMinsField.GetValueOrDefault() ; }
            set { this.transactionTimeoutInMinsField= value; }
        }



        /// <summary>
        /// Sets the TransactionTimeoutInMins property
        /// </summary>
        /// <param name="transactionTimeoutInMins">TransactionTimeoutInMins property</param>
        /// <returns>this instance</returns>
        public PayRequest WithTransactionTimeoutInMins(Decimal transactionTimeoutInMins)
        {
            this.transactionTimeoutInMinsField = transactionTimeoutInMins;
            return this;
        }



        /// <summary>
        /// Checks if TransactionTimeoutInMins property is set
        /// </summary>
        /// <returns>true if TransactionTimeoutInMins property is set</returns>
        public Boolean IsSetTransactionTimeoutInMins()
        {
            return  this.transactionTimeoutInMinsField.HasValue;

        }


        /// <summary>
        /// Gets and sets the MarketplaceFixedFee property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MarketplaceFixedFee")]
        public Amount MarketplaceFixedFee
        {
            get { return this.marketplaceFixedFeeField ; }
            set { this.marketplaceFixedFeeField = value; }
        }



        /// <summary>
        /// Sets the MarketplaceFixedFee property
        /// </summary>
        /// <param name="marketplaceFixedFee">MarketplaceFixedFee property</param>
        /// <returns>this instance</returns>
        public PayRequest WithMarketplaceFixedFee(Amount marketplaceFixedFee)
        {
            this.marketplaceFixedFeeField = marketplaceFixedFee;
            return this;
        }



        /// <summary>
        /// Checks if MarketplaceFixedFee property is set
        /// </summary>
        /// <returns>true if MarketplaceFixedFee property is set</returns>
        public Boolean IsSetMarketplaceFixedFee()
        {
            return this.marketplaceFixedFeeField != null;
        }




        /// <summary>
        /// Gets and sets the MarketplaceVariableFee property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MarketplaceVariableFee")]
        public Decimal MarketplaceVariableFee
        {
            get { return this.marketplaceVariableFeeField.GetValueOrDefault() ; }
            set { this.marketplaceVariableFeeField= value; }
        }



        /// <summary>
        /// Sets the MarketplaceVariableFee property
        /// </summary>
        /// <param name="marketplaceVariableFee">MarketplaceVariableFee property</param>
        /// <returns>this instance</returns>
        public PayRequest WithMarketplaceVariableFee(Decimal marketplaceVariableFee)
        {
            this.marketplaceVariableFeeField = marketplaceVariableFee;
            return this;
        }



        /// <summary>
        /// Checks if MarketplaceVariableFee property is set
        /// </summary>
        /// <returns>true if MarketplaceVariableFee property is set</returns>
        public Boolean IsSetMarketplaceVariableFee()
        {
            return  this.marketplaceVariableFeeField.HasValue;

        }





    }

}