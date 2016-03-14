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
    public class AccountBalance
    {
    
        private  Amount totalBalanceField;
        private  Amount pendingInBalanceField;
        private  Amount pendingOutBalanceField;
        private  AvailableBalances availableBalancesField;

        /// <summary>
        /// Gets and sets the TotalBalance property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TotalBalance")]
        public Amount TotalBalance
        {
            get { return this.totalBalanceField ; }
            set { this.totalBalanceField = value; }
        }



        /// <summary>
        /// Sets the TotalBalance property
        /// </summary>
        /// <param name="totalBalance">TotalBalance property</param>
        /// <returns>this instance</returns>
        public AccountBalance WithTotalBalance(Amount totalBalance)
        {
            this.totalBalanceField = totalBalance;
            return this;
        }



        /// <summary>
        /// Checks if TotalBalance property is set
        /// </summary>
        /// <returns>true if TotalBalance property is set</returns>
        public Boolean IsSetTotalBalance()
        {
            return this.totalBalanceField != null;
        }




        /// <summary>
        /// Gets and sets the PendingInBalance property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PendingInBalance")]
        public Amount PendingInBalance
        {
            get { return this.pendingInBalanceField ; }
            set { this.pendingInBalanceField = value; }
        }



        /// <summary>
        /// Sets the PendingInBalance property
        /// </summary>
        /// <param name="pendingInBalance">PendingInBalance property</param>
        /// <returns>this instance</returns>
        public AccountBalance WithPendingInBalance(Amount pendingInBalance)
        {
            this.pendingInBalanceField = pendingInBalance;
            return this;
        }



        /// <summary>
        /// Checks if PendingInBalance property is set
        /// </summary>
        /// <returns>true if PendingInBalance property is set</returns>
        public Boolean IsSetPendingInBalance()
        {
            return this.pendingInBalanceField != null;
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
        public AccountBalance WithPendingOutBalance(Amount pendingOutBalance)
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
        /// Gets and sets the AvailableBalances property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailableBalances")]
        public AvailableBalances AvailableBalances
        {
            get { return this.availableBalancesField ; }
            set { this.availableBalancesField = value; }
        }



        /// <summary>
        /// Sets the AvailableBalances property
        /// </summary>
        /// <param name="availableBalances">AvailableBalances property</param>
        /// <returns>this instance</returns>
        public AccountBalance WithAvailableBalances(AvailableBalances availableBalances)
        {
            this.availableBalancesField = availableBalances;
            return this;
        }



        /// <summary>
        /// Checks if AvailableBalances property is set
        /// </summary>
        /// <returns>true if AvailableBalances property is set</returns>
        public Boolean IsSetAvailableBalances()
        {
            return this.availableBalancesField != null;
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
            if (IsSetTotalBalance()) {
                Amount  totalBalance = this.TotalBalance;
                xml.Append("<TotalBalance>");
                xml.Append(totalBalance.ToXMLFragment());
                xml.Append("</TotalBalance>");
            } 
            if (IsSetPendingInBalance()) {
                Amount  pendingInBalance = this.PendingInBalance;
                xml.Append("<PendingInBalance>");
                xml.Append(pendingInBalance.ToXMLFragment());
                xml.Append("</PendingInBalance>");
            } 
            if (IsSetPendingOutBalance()) {
                Amount  pendingOutBalance = this.PendingOutBalance;
                xml.Append("<PendingOutBalance>");
                xml.Append(pendingOutBalance.ToXMLFragment());
                xml.Append("</PendingOutBalance>");
            } 
            if (IsSetAvailableBalances()) {
                AvailableBalances  availableBalances = this.AvailableBalances;
                xml.Append("<AvailableBalances>");
                xml.Append(availableBalances.ToXMLFragment());
                xml.Append("</AvailableBalances>");
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