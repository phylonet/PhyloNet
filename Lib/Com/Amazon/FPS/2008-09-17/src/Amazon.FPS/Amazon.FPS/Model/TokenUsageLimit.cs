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
    public class TokenUsageLimit
    {
    
        private Decimal? countField;

        private  Amount amountField;
        private Decimal? lastResetCountField;

        private  Amount lastResetAmountField;
        private DateTime? lastResetTimestampField;


        /// <summary>
        /// Gets and sets the Count property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Count")]
        public Decimal Count
        {
            get { return this.countField.GetValueOrDefault() ; }
            set { this.countField= value; }
        }



        /// <summary>
        /// Sets the Count property
        /// </summary>
        /// <param name="count">Count property</param>
        /// <returns>this instance</returns>
        public TokenUsageLimit WithCount(Decimal count)
        {
            this.countField = count;
            return this;
        }



        /// <summary>
        /// Checks if Count property is set
        /// </summary>
        /// <returns>true if Count property is set</returns>
        public Boolean IsSetCount()
        {
            return  this.countField.HasValue;

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
        public TokenUsageLimit WithAmount(Amount amount)
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
        /// Gets and sets the LastResetCount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LastResetCount")]
        public Decimal LastResetCount
        {
            get { return this.lastResetCountField.GetValueOrDefault() ; }
            set { this.lastResetCountField= value; }
        }



        /// <summary>
        /// Sets the LastResetCount property
        /// </summary>
        /// <param name="lastResetCount">LastResetCount property</param>
        /// <returns>this instance</returns>
        public TokenUsageLimit WithLastResetCount(Decimal lastResetCount)
        {
            this.lastResetCountField = lastResetCount;
            return this;
        }



        /// <summary>
        /// Checks if LastResetCount property is set
        /// </summary>
        /// <returns>true if LastResetCount property is set</returns>
        public Boolean IsSetLastResetCount()
        {
            return  this.lastResetCountField.HasValue;

        }


        /// <summary>
        /// Gets and sets the LastResetAmount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LastResetAmount")]
        public Amount LastResetAmount
        {
            get { return this.lastResetAmountField ; }
            set { this.lastResetAmountField = value; }
        }



        /// <summary>
        /// Sets the LastResetAmount property
        /// </summary>
        /// <param name="lastResetAmount">LastResetAmount property</param>
        /// <returns>this instance</returns>
        public TokenUsageLimit WithLastResetAmount(Amount lastResetAmount)
        {
            this.lastResetAmountField = lastResetAmount;
            return this;
        }



        /// <summary>
        /// Checks if LastResetAmount property is set
        /// </summary>
        /// <returns>true if LastResetAmount property is set</returns>
        public Boolean IsSetLastResetAmount()
        {
            return this.lastResetAmountField != null;
        }




        /// <summary>
        /// Gets and sets the LastResetTimestamp property.
        /// </summary>
        [XmlElementAttribute(ElementName = "LastResetTimestamp")]
        public DateTime LastResetTimestamp
        {
            get { return this.lastResetTimestampField.GetValueOrDefault() ; }
            set { this.lastResetTimestampField= value; }
        }



        /// <summary>
        /// Sets the LastResetTimestamp property
        /// </summary>
        /// <param name="lastResetTimestamp">LastResetTimestamp property</param>
        /// <returns>this instance</returns>
        public TokenUsageLimit WithLastResetTimestamp(DateTime lastResetTimestamp)
        {
            this.lastResetTimestampField = lastResetTimestamp;
            return this;
        }



        /// <summary>
        /// Checks if LastResetTimestamp property is set
        /// </summary>
        /// <returns>true if LastResetTimestamp property is set</returns>
        public Boolean IsSetLastResetTimestamp()
        {
            return  this.lastResetTimestampField.HasValue;

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
            if (IsSetCount()) {
                xml.Append("<Count>");
                xml.Append(this.Count);
                xml.Append("</Count>");
            }
            if (IsSetAmount()) {
                Amount  amount = this.Amount;
                xml.Append("<Amount>");
                xml.Append(amount.ToXMLFragment());
                xml.Append("</Amount>");
            } 
            if (IsSetLastResetCount()) {
                xml.Append("<LastResetCount>");
                xml.Append(this.LastResetCount);
                xml.Append("</LastResetCount>");
            }
            if (IsSetLastResetAmount()) {
                Amount  lastResetAmount = this.LastResetAmount;
                xml.Append("<LastResetAmount>");
                xml.Append(lastResetAmount.ToXMLFragment());
                xml.Append("</LastResetAmount>");
            } 
            if (IsSetLastResetTimestamp()) {
                xml.Append("<LastResetTimestamp>");
                xml.Append(this.LastResetTimestamp);
                xml.Append("</LastResetTimestamp>");
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