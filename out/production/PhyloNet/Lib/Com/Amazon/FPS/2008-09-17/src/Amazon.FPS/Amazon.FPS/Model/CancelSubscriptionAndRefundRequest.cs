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
    public class CancelSubscriptionAndRefundRequest
    {
    
        private String subscriptionIdField;

        private  Amount refundAmountField;
        private String callerReferenceField;

        private String cancelReasonField;


        /// <summary>
        /// Gets and sets the SubscriptionId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubscriptionId")]
        public String SubscriptionId
        {
            get { return this.subscriptionIdField ; }
            set { this.subscriptionIdField= value; }
        }



        /// <summary>
        /// Sets the SubscriptionId property
        /// </summary>
        /// <param name="subscriptionId">SubscriptionId property</param>
        /// <returns>this instance</returns>
        public CancelSubscriptionAndRefundRequest WithSubscriptionId(String subscriptionId)
        {
            this.subscriptionIdField = subscriptionId;
            return this;
        }



        /// <summary>
        /// Checks if SubscriptionId property is set
        /// </summary>
        /// <returns>true if SubscriptionId property is set</returns>
        public Boolean IsSetSubscriptionId()
        {
            return  this.subscriptionIdField != null;

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
        public CancelSubscriptionAndRefundRequest WithRefundAmount(Amount refundAmount)
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
        public CancelSubscriptionAndRefundRequest WithCallerReference(String callerReference)
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
        /// Gets and sets the CancelReason property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CancelReason")]
        public String CancelReason
        {
            get { return this.cancelReasonField ; }
            set { this.cancelReasonField= value; }
        }



        /// <summary>
        /// Sets the CancelReason property
        /// </summary>
        /// <param name="cancelReason">CancelReason property</param>
        /// <returns>this instance</returns>
        public CancelSubscriptionAndRefundRequest WithCancelReason(String cancelReason)
        {
            this.cancelReasonField = cancelReason;
            return this;
        }



        /// <summary>
        /// Checks if CancelReason property is set
        /// </summary>
        /// <returns>true if CancelReason property is set</returns>
        public Boolean IsSetCancelReason()
        {
            return  this.cancelReasonField != null;

        }





    }

}