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
    public class RefundRequest
    {
    
        private String transactionIdField;

        private  Amount refundAmountField;
        private String callerReferenceField;

        private String callerDescriptionField;

        private MarketplaceRefundPolicy? marketplaceRefundPolicyField;


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
        public RefundRequest WithTransactionId(String transactionId)
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
        /// Gets and sets the RefundAmount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "RefundAmount")]
        public Amount RefundAmount
        {
            get { return this.refundAmountField ; }
            set { this.refundAmountField = value; }
        }



        /// <summary>
        /// Sets the RefundAmount property
        /// </summary>
        /// <param name="refundAmount">RefundAmount property</param>
        /// <returns>this instance</returns>
        public RefundRequest WithRefundAmount(Amount refundAmount)
        {
            this.refundAmountField = refundAmount;
            return this;
        }



        /// <summary>
        /// Checks if RefundAmount property is set
        /// </summary>
        /// <returns>true if RefundAmount property is set</returns>
        public Boolean IsSetRefundAmount()
        {
            return this.refundAmountField != null;
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
        public RefundRequest WithCallerReference(String callerReference)
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
        public RefundRequest WithCallerDescription(String callerDescription)
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
        /// Gets and sets the MarketplaceRefundPolicy property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MarketplaceRefundPolicy")]
        public MarketplaceRefundPolicy MarketplaceRefundPolicy
        {
            get { return this.marketplaceRefundPolicyField.GetValueOrDefault() ; }
            set { this.marketplaceRefundPolicyField= value; }
        }



        /// <summary>
        /// Sets the MarketplaceRefundPolicy property
        /// </summary>
        /// <param name="marketplaceRefundPolicy">MarketplaceRefundPolicy property</param>
        /// <returns>this instance</returns>
        public RefundRequest WithMarketplaceRefundPolicy(MarketplaceRefundPolicy marketplaceRefundPolicy)
        {
            this.marketplaceRefundPolicyField = marketplaceRefundPolicy;
            return this;
        }



        /// <summary>
        /// Checks if MarketplaceRefundPolicy property is set
        /// </summary>
        /// <returns>true if MarketplaceRefundPolicy property is set</returns>
        public Boolean IsSetMarketplaceRefundPolicy()
        {
            return this.marketplaceRefundPolicyField.HasValue;

        }





    }

}