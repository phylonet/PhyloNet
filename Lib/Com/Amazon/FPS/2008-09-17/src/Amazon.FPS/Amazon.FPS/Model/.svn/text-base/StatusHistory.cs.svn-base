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
    public class StatusHistory
    {
    
        private DateTime? dateField;

        private TransactionStatus? transactionStatusField;

        private String statusCodeField;

        private  Amount amountField;

        /// <summary>
        /// Gets and sets the Date property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Date")]
        public DateTime Date
        {
            get { return this.dateField.GetValueOrDefault() ; }
            set { this.dateField= value; }
        }



        /// <summary>
        /// Sets the Date property
        /// </summary>
        /// <param name="date">Date property</param>
        /// <returns>this instance</returns>
        public StatusHistory WithDate(DateTime date)
        {
            this.dateField = date;
            return this;
        }



        /// <summary>
        /// Checks if Date property is set
        /// </summary>
        /// <returns>true if Date property is set</returns>
        public Boolean IsSetDate()
        {
            return  this.dateField.HasValue;

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
        public StatusHistory WithTransactionStatus(TransactionStatus transactionStatus)
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
        public StatusHistory WithStatusCode(String statusCode)
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
        /// Gets and sets the Amount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Amount")]
        public Amount Amount
        {
            get { return this.amountField ; }
            set { this.amountField = value; }
        }



        /// <summary>
        /// Sets the Amount property
        /// </summary>
        /// <param name="amount">Amount property</param>
        /// <returns>this instance</returns>
        public StatusHistory WithAmount(Amount amount)
        {
            this.amountField = amount;
            return this;
        }



        /// <summary>
        /// Checks if Amount property is set
        /// </summary>
        /// <returns>true if Amount property is set</returns>
        public Boolean IsSetAmount()
        {
            return this.amountField != null;
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
            if (IsSetDate()) {
                xml.Append("<Date>");
                xml.Append(this.Date);
                xml.Append("</Date>");
            }
            if (IsSetTransactionStatus()) {
                xml.Append("<TransactionStatus>");
                xml.Append(this.TransactionStatus);
                xml.Append("</TransactionStatus>");
            }
            if (IsSetStatusCode()) {
                xml.Append("<StatusCode>");
                xml.Append(EscapeXML(this.StatusCode));
                xml.Append("</StatusCode>");
            }
            if (IsSetAmount()) {
                Amount  amount = this.Amount;
                xml.Append("<Amount>");
                xml.Append(amount.ToXMLFragment());
                xml.Append("</Amount>");
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