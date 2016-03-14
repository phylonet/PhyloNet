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
    public class SettleDebtRequest
    {
    
        private String senderTokenIdField;

        private String creditInstrumentIdField;

        private  Amount settlementAmountField;
        private String callerReferenceField;

        private String senderDescriptionField;

        private String callerDescriptionField;

        private  DescriptorPolicy descriptorPolicyField;
        private Decimal? transactionTimeoutInMinsField;


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
        public SettleDebtRequest WithSenderTokenId(String senderTokenId)
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
        /// Gets and sets the CreditInstrumentId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreditInstrumentId")]
        public String CreditInstrumentId
        {
            get { return this.creditInstrumentIdField ; }
            set { this.creditInstrumentIdField= value; }
        }



        /// <summary>
        /// Sets the CreditInstrumentId property
        /// </summary>
        /// <param name="creditInstrumentId">CreditInstrumentId property</param>
        /// <returns>this instance</returns>
        public SettleDebtRequest WithCreditInstrumentId(String creditInstrumentId)
        {
            this.creditInstrumentIdField = creditInstrumentId;
            return this;
        }



        /// <summary>
        /// Checks if CreditInstrumentId property is set
        /// </summary>
        /// <returns>true if CreditInstrumentId property is set</returns>
        public Boolean IsSetCreditInstrumentId()
        {
            return  this.creditInstrumentIdField != null;

        }


        /// <summary>
        /// Gets and sets the SettlementAmount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SettlementAmount")]
        public Amount SettlementAmount
        {
            get { return this.settlementAmountField ; }
            set { this.settlementAmountField = value; }
        }



        /// <summary>
        /// Sets the SettlementAmount property
        /// </summary>
        /// <param name="settlementAmount">SettlementAmount property</param>
        /// <returns>this instance</returns>
        public SettleDebtRequest WithSettlementAmount(Amount settlementAmount)
        {
            this.settlementAmountField = settlementAmount;
            return this;
        }



        /// <summary>
        /// Checks if SettlementAmount property is set
        /// </summary>
        /// <returns>true if SettlementAmount property is set</returns>
        public Boolean IsSetSettlementAmount()
        {
            return this.settlementAmountField != null;
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
        public SettleDebtRequest WithCallerReference(String callerReference)
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
        public SettleDebtRequest WithSenderDescription(String senderDescription)
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
        public SettleDebtRequest WithCallerDescription(String callerDescription)
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
        public SettleDebtRequest WithDescriptorPolicy(DescriptorPolicy descriptorPolicy)
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
        public SettleDebtRequest WithTransactionTimeoutInMins(Decimal transactionTimeoutInMins)
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





    }

}