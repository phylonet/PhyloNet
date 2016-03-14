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
    public class DebtBalance
    {
    
        private  Amount availableBalanceField;
        private  Amount pendingOutBalanceField;

        /// <summary>
        /// Gets and sets the AvailableBalance property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailableBalance")]
        public Amount AvailableBalance
        {
            get { return this.availableBalanceField ; }
            set { this.availableBalanceField = value; }
        }



        /// <summary>
        /// Sets the AvailableBalance property
        /// </summary>
        /// <param name="availableBalance">AvailableBalance property</param>
        /// <returns>this instance</returns>
        public DebtBalance WithAvailableBalance(Amount availableBalance)
        {
            this.availableBalanceField = availableBalance;
            return this;
        }



        /// <summary>
        /// Checks if AvailableBalance property is set
        /// </summary>
        /// <returns>true if AvailableBalance property is set</returns>
        public Boolean IsSetAvailableBalance()
        {
            return this.availableBalanceField != null;
        }




        /// <summary>
        /// Gets and sets the PendingOutBalance property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PendingOutBalance")]
        public Amount PendingOutBalance
        {
            get { return this.pendingOutBalanceField ; }
            set { this.pendingOutBalanceField = value; }
        }



        /// <summary>
        /// Sets the PendingOutBalance property
        /// </summary>
        /// <param name="pendingOutBalance">PendingOutBalance property</param>
        /// <returns>this instance</returns>
        public DebtBalance WithPendingOutBalance(Amount pendingOutBalance)
        {
            this.pendingOutBalanceField = pendingOutBalance;
            return this;
        }



        /// <summary>
        /// Checks if PendingOutBalance property is set
        /// </summary>
        /// <returns>true if PendingOutBalance property is set</returns>
        public Boolean IsSetPendingOutBalance()
        {
            return this.pendingOutBalanceField != null;
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
            if (IsSetAvailableBalance()) {
                Amount  availableBalance = this.AvailableBalance;
                xml.Append("<AvailableBalance>");
                xml.Append(availableBalance.ToXMLFragment());
                xml.Append("</AvailableBalance>");
            } 
            if (IsSetPendingOutBalance()) {
                Amount  pendingOutBalance = this.PendingOutBalance;
                xml.Append("<PendingOutBalance>");
                xml.Append(pendingOutBalance.ToXMLFragment());
                xml.Append("</PendingOutBalance>");
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