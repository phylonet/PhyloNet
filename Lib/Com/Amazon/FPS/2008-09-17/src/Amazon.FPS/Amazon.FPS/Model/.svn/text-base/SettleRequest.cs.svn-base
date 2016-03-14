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
    public class SettleRequest
    {
    
        private String reserveTransactionIdField;

        private  Amount transactionAmountField;

        /// <summary>
        /// Gets and sets the ReserveTransactionId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReserveTransactionId")]
        public String ReserveTransactionId
        {
            get { return this.reserveTransactionIdField ; }
            set { this.reserveTransactionIdField= value; }
        }



        /// <summary>
        /// Sets the ReserveTransactionId property
        /// </summary>
        /// <param name="reserveTransactionId">ReserveTransactionId property</param>
        /// <returns>this instance</returns>
        public SettleRequest WithReserveTransactionId(String reserveTransactionId)
        {
            this.reserveTransactionIdField = reserveTransactionId;
            return this;
        }



        /// <summary>
        /// Checks if ReserveTransactionId property is set
        /// </summary>
        /// <returns>true if ReserveTransactionId property is set</returns>
        public Boolean IsSetReserveTransactionId()
        {
            return  this.reserveTransactionIdField != null;

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
        public SettleRequest WithTransactionAmount(Amount transactionAmount)
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







    }

}