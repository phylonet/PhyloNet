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
    public class Token
    {
    
        private String tokenIdField;

        private String friendlyNameField;

        private TokenStatus? tokenStatusField;

        private DateTime? dateInstalledField;

        private String callerReferenceField;

        private TokenType? tokenTypeField;

        private String oldTokenIdField;

        private String paymentReasonField;


        /// <summary>
        /// Gets and sets the TokenId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TokenId")]
        public String TokenId
        {
            get { return this.tokenIdField ; }
            set { this.tokenIdField= value; }
        }



        /// <summary>
        /// Sets the TokenId property
        /// </summary>
        /// <param name="tokenId">TokenId property</param>
        /// <returns>this instance</returns>
        public Token WithTokenId(String tokenId)
        {
            this.tokenIdField = tokenId;
            return this;
        }



        /// <summary>
        /// Checks if TokenId property is set
        /// </summary>
        /// <returns>true if TokenId property is set</returns>
        public Boolean IsSetTokenId()
        {
            return  this.tokenIdField != null;

        }


        /// <summary>
        /// Gets and sets the FriendlyName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FriendlyName")]
        public String FriendlyName
        {
            get { return this.friendlyNameField ; }
            set { this.friendlyNameField= value; }
        }



        /// <summary>
        /// Sets the FriendlyName property
        /// </summary>
        /// <param name="friendlyName">FriendlyName property</param>
        /// <returns>this instance</returns>
        public Token WithFriendlyName(String friendlyName)
        {
            this.friendlyNameField = friendlyName;
            return this;
        }



        /// <summary>
        /// Checks if FriendlyName property is set
        /// </summary>
        /// <returns>true if FriendlyName property is set</returns>
        public Boolean IsSetFriendlyName()
        {
            return  this.friendlyNameField != null;

        }


        /// <summary>
        /// Gets and sets the TokenStatus property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TokenStatus")]
        public TokenStatus TokenStatus
        {
            get { return this.tokenStatusField.GetValueOrDefault() ; }
            set { this.tokenStatusField= value; }
        }



        /// <summary>
        /// Sets the TokenStatus property
        /// </summary>
        /// <param name="tokenStatus">TokenStatus property</param>
        /// <returns>this instance</returns>
        public Token WithTokenStatus(TokenStatus tokenStatus)
        {
            this.tokenStatusField = tokenStatus;
            return this;
        }



        /// <summary>
        /// Checks if TokenStatus property is set
        /// </summary>
        /// <returns>true if TokenStatus property is set</returns>
        public Boolean IsSetTokenStatus()
        {
            return this.tokenStatusField.HasValue;

        }


        /// <summary>
        /// Gets and sets the DateInstalled property.
        /// </summary>
        [XmlElementAttribute(ElementName = "DateInstalled")]
        public DateTime DateInstalled
        {
            get { return this.dateInstalledField.GetValueOrDefault() ; }
            set { this.dateInstalledField= value; }
        }



        /// <summary>
        /// Sets the DateInstalled property
        /// </summary>
        /// <param name="dateInstalled">DateInstalled property</param>
        /// <returns>this instance</returns>
        public Token WithDateInstalled(DateTime dateInstalled)
        {
            this.dateInstalledField = dateInstalled;
            return this;
        }



        /// <summary>
        /// Checks if DateInstalled property is set
        /// </summary>
        /// <returns>true if DateInstalled property is set</returns>
        public Boolean IsSetDateInstalled()
        {
            return  this.dateInstalledField.HasValue;

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
        public Token WithCallerReference(String callerReference)
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
        /// Gets and sets the TokenType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TokenType")]
        public TokenType TokenType
        {
            get { return this.tokenTypeField.GetValueOrDefault() ; }
            set { this.tokenTypeField= value; }
        }



        /// <summary>
        /// Sets the TokenType property
        /// </summary>
        /// <param name="tokenType">TokenType property</param>
        /// <returns>this instance</returns>
        public Token WithTokenType(TokenType tokenType)
        {
            this.tokenTypeField = tokenType;
            return this;
        }



        /// <summary>
        /// Checks if TokenType property is set
        /// </summary>
        /// <returns>true if TokenType property is set</returns>
        public Boolean IsSetTokenType()
        {
            return this.tokenTypeField.HasValue;

        }


        /// <summary>
        /// Gets and sets the OldTokenId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "OldTokenId")]
        public String OldTokenId
        {
            get { return this.oldTokenIdField ; }
            set { this.oldTokenIdField= value; }
        }



        /// <summary>
        /// Sets the OldTokenId property
        /// </summary>
        /// <param name="oldTokenId">OldTokenId property</param>
        /// <returns>this instance</returns>
        public Token WithOldTokenId(String oldTokenId)
        {
            this.oldTokenIdField = oldTokenId;
            return this;
        }



        /// <summary>
        /// Checks if OldTokenId property is set
        /// </summary>
        /// <returns>true if OldTokenId property is set</returns>
        public Boolean IsSetOldTokenId()
        {
            return  this.oldTokenIdField != null;

        }


        /// <summary>
        /// Gets and sets the PaymentReason property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PaymentReason")]
        public String PaymentReason
        {
            get { return this.paymentReasonField ; }
            set { this.paymentReasonField= value; }
        }



        /// <summary>
        /// Sets the PaymentReason property
        /// </summary>
        /// <param name="paymentReason">PaymentReason property</param>
        /// <returns>this instance</returns>
        public Token WithPaymentReason(String paymentReason)
        {
            this.paymentReasonField = paymentReason;
            return this;
        }



        /// <summary>
        /// Checks if PaymentReason property is set
        /// </summary>
        /// <returns>true if PaymentReason property is set</returns>
        public Boolean IsSetPaymentReason()
        {
            return  this.paymentReasonField != null;

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
            if (IsSetTokenId()) {
                xml.Append("<TokenId>");
                xml.Append(EscapeXML(this.TokenId));
                xml.Append("</TokenId>");
            }
            if (IsSetFriendlyName()) {
                xml.Append("<FriendlyName>");
                xml.Append(EscapeXML(this.FriendlyName));
                xml.Append("</FriendlyName>");
            }
            if (IsSetTokenStatus()) {
                xml.Append("<TokenStatus>");
                xml.Append(this.TokenStatus);
                xml.Append("</TokenStatus>");
            }
            if (IsSetDateInstalled()) {
                xml.Append("<DateInstalled>");
                xml.Append(this.DateInstalled);
                xml.Append("</DateInstalled>");
            }
            if (IsSetCallerReference()) {
                xml.Append("<CallerReference>");
                xml.Append(EscapeXML(this.CallerReference));
                xml.Append("</CallerReference>");
            }
            if (IsSetTokenType()) {
                xml.Append("<TokenType>");
                xml.Append(this.TokenType);
                xml.Append("</TokenType>");
            }
            if (IsSetOldTokenId()) {
                xml.Append("<OldTokenId>");
                xml.Append(EscapeXML(this.OldTokenId));
                xml.Append("</OldTokenId>");
            }
            if (IsSetPaymentReason()) {
                xml.Append("<PaymentReason>");
                xml.Append(EscapeXML(this.PaymentReason));
                xml.Append("</PaymentReason>");
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