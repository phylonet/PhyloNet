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
    public class PayResult
    {
    
        private String transactionIdField;

        private TransactionStatus? transactionStatusField;


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
        public PayResult WithTransactionId(String transactionId)
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
        public PayResult WithTransactionStatus(TransactionStatus transactionStatus)
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
            if (IsSetTransactionStatus()) {
                xml.Append("<TransactionStatus>");
                xml.Append(this.TransactionStatus);
                xml.Append("</TransactionStatus>");
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