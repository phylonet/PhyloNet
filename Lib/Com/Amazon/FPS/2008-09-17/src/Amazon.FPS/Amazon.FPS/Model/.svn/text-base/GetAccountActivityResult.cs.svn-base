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
    public class GetAccountActivityResult
    {
    
        private Decimal? batchSizeField;

        private  List<Transaction> transactionField;

        private DateTime? startTimeForNextTransactionField;


        /// <summary>
        /// Gets and sets the BatchSize property.
        /// </summary>
        [XmlElementAttribute(ElementName = "BatchSize")]
        public Decimal BatchSize
        {
            get { return this.batchSizeField.GetValueOrDefault() ; }
            set { this.batchSizeField= value; }
        }



        /// <summary>
        /// Sets the BatchSize property
        /// </summary>
        /// <param name="batchSize">BatchSize property</param>
        /// <returns>this instance</returns>
        public GetAccountActivityResult WithBatchSize(Decimal batchSize)
        {
            this.batchSizeField = batchSize;
            return this;
        }



        /// <summary>
        /// Checks if BatchSize property is set
        /// </summary>
        /// <returns>true if BatchSize property is set</returns>
        public Boolean IsSetBatchSize()
        {
            return  this.batchSizeField.HasValue;

        }


        /// <summary>
        /// Gets and sets the Transaction property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Transaction")]
        public List<Transaction> Transaction
        {
            get
            {
                if (this.transactionField == null)
                {
                    this.transactionField = new List<Transaction>();
                }
                return this.transactionField;
            }
            set { this.transactionField =  value; }
        }



        /// <summary>
        /// Sets the Transaction property
        /// </summary>
        /// <param name="list">Transaction property</param>
        /// <returns>this instance</returns>
        public GetAccountActivityResult WithTransaction(params Transaction[] list)
        {
            foreach (Transaction item in list)
            {
                Transaction.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if Transaction property is set
        /// </summary>
        /// <returns>true if Transaction property is set</returns>
        public Boolean IsSetTransaction()
        {
            return (Transaction.Count > 0);
        }


        /// <summary>
        /// Gets and sets the StartTimeForNextTransaction property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartTimeForNextTransaction")]
        public DateTime StartTimeForNextTransaction
        {
            get { return this.startTimeForNextTransactionField.GetValueOrDefault() ; }
            set { this.startTimeForNextTransactionField= value; }
        }



        /// <summary>
        /// Sets the StartTimeForNextTransaction property
        /// </summary>
        /// <param name="startTimeForNextTransaction">StartTimeForNextTransaction property</param>
        /// <returns>this instance</returns>
        public GetAccountActivityResult WithStartTimeForNextTransaction(DateTime startTimeForNextTransaction)
        {
            this.startTimeForNextTransactionField = startTimeForNextTransaction;
            return this;
        }



        /// <summary>
        /// Checks if StartTimeForNextTransaction property is set
        /// </summary>
        /// <returns>true if StartTimeForNextTransaction property is set</returns>
        public Boolean IsSetStartTimeForNextTransaction()
        {
            return  this.startTimeForNextTransactionField.HasValue;

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
            if (IsSetBatchSize()) {
                xml.Append("<BatchSize>");
                xml.Append(this.BatchSize);
                xml.Append("</BatchSize>");
            }
            List<Transaction> transactionList = this.Transaction;
            foreach (Transaction transaction in transactionList) {
                xml.Append("<Transaction>");
                xml.Append(transaction.ToXMLFragment());
                xml.Append("</Transaction>");
            }
            if (IsSetStartTimeForNextTransaction()) {
                xml.Append("<StartTimeForNextTransaction>");
                xml.Append(this.StartTimeForNextTransaction);
                xml.Append("</StartTimeForNextTransaction>");
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