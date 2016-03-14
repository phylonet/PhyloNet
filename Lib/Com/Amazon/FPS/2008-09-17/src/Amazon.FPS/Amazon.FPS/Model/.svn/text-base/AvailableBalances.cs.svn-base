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
    public class AvailableBalances
    {
    
        private  Amount disburseBalanceField;
        private  Amount refundBalanceField;

        /// <summary>
        /// Gets and sets the DisburseBalance property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DisburseBalance")]
        public Amount DisburseBalance
        {
            get { return this.disburseBalanceField ; }
            set { this.disburseBalanceField = value; }
        }



        /// <summary>
        /// Sets the DisburseBalance property
        /// </summary>
        /// <param name="disburseBalance">DisburseBalance property</param>
        /// <returns>this instance</returns>
        public AvailableBalances WithDisburseBalance(Amount disburseBalance)
        {
            this.disburseBalanceField = disburseBalance;
            return this;
        }



        /// <summary>
        /// Checks if DisburseBalance property is set
        /// </summary>
        /// <returns>true if DisburseBalance property is set</returns>
        public Boolean IsSetDisburseBalance()
        {
            return this.disburseBalanceField != null;
        }




        /// <summary>
        /// Gets and sets the RefundBalance property.
        /// </summary>
        [XmlElementAttribute(ElementName = "RefundBalance")]
        public Amount RefundBalance
        {
            get { return this.refundBalanceField ; }
            set { this.refundBalanceField = value; }
        }



        /// <summary>
        /// Sets the RefundBalance property
        /// </summary>
        /// <param name="refundBalance">RefundBalance property</param>
        /// <returns>this instance</returns>
        public AvailableBalances WithRefundBalance(Amount refundBalance)
        {
            this.refundBalanceField = refundBalance;
            return this;
        }



        /// <summary>
        /// Checks if RefundBalance property is set
        /// </summary>
        /// <returns>true if RefundBalance property is set</returns>
        public Boolean IsSetRefundBalance()
        {
            return this.refundBalanceField != null;
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
            if (IsSetDisburseBalance()) {
                Amount  disburseBalance = this.DisburseBalance;
                xml.Append("<DisburseBalance>");
                xml.Append(disburseBalance.ToXMLFragment());
                xml.Append("</DisburseBalance>");
            } 
            if (IsSetRefundBalance()) {
                Amount  refundBalance = this.RefundBalance;
                xml.Append("<RefundBalance>");
                xml.Append(refundBalance.ToXMLFragment());
                xml.Append("</RefundBalance>");
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