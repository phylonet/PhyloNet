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
    public class GetPaymentInstructionResult
    {
    
        private  Token tokenField;
        private String paymentInstructionField;

        private String callerReferenceField;

        private String tokenFriendlyNameField;


        /// <summary>
        /// Gets and sets the Token property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Token")]
        public Token Token
        {
            get { return this.tokenField ; }
            set { this.tokenField = value; }
        }



        /// <summary>
        /// Sets the Token property
        /// </summary>
        /// <param name="token">Token property</param>
        /// <returns>this instance</returns>
        public GetPaymentInstructionResult WithToken(Token token)
        {
            this.tokenField = token;
            return this;
        }



        /// <summary>
        /// Checks if Token property is set
        /// </summary>
        /// <returns>true if Token property is set</returns>
        public Boolean IsSetToken()
        {
            return this.tokenField != null;
        }




        /// <summary>
        /// Gets and sets the PaymentInstruction property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PaymentInstruction")]
        public String PaymentInstruction
        {
            get { return this.paymentInstructionField ; }
            set { this.paymentInstructionField= value; }
        }



        /// <summary>
        /// Sets the PaymentInstruction property
        /// </summary>
        /// <param name="paymentInstruction">PaymentInstruction property</param>
        /// <returns>this instance</returns>
        public GetPaymentInstructionResult WithPaymentInstruction(String paymentInstruction)
        {
            this.paymentInstructionField = paymentInstruction;
            return this;
        }



        /// <summary>
        /// Checks if PaymentInstruction property is set
        /// </summary>
        /// <returns>true if PaymentInstruction property is set</returns>
        public Boolean IsSetPaymentInstruction()
        {
            return  this.paymentInstructionField != null;

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
        public GetPaymentInstructionResult WithCallerReference(String callerReference)
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
        /// Gets and sets the TokenFriendlyName property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TokenFriendlyName")]
        public String TokenFriendlyName
        {
            get { return this.tokenFriendlyNameField ; }
            set { this.tokenFriendlyNameField= value; }
        }



        /// <summary>
        /// Sets the TokenFriendlyName property
        /// </summary>
        /// <param name="tokenFriendlyName">TokenFriendlyName property</param>
        /// <returns>this instance</returns>
        public GetPaymentInstructionResult WithTokenFriendlyName(String tokenFriendlyName)
        {
            this.tokenFriendlyNameField = tokenFriendlyName;
            return this;
        }



        /// <summary>
        /// Checks if TokenFriendlyName property is set
        /// </summary>
        /// <returns>true if TokenFriendlyName property is set</returns>
        public Boolean IsSetTokenFriendlyName()
        {
            return  this.tokenFriendlyNameField != null;

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
            if (IsSetToken()) {
                Token  token = this.Token;
                xml.Append("<Token>");
                xml.Append(token.ToXMLFragment());
                xml.Append("</Token>");
            } 
            if (IsSetPaymentInstruction()) {
                xml.Append("<PaymentInstruction>");
                xml.Append(EscapeXML(this.PaymentInstruction));
                xml.Append("</PaymentInstruction>");
            }
            if (IsSetCallerReference()) {
                xml.Append("<CallerReference>");
                xml.Append(EscapeXML(this.CallerReference));
                xml.Append("</CallerReference>");
            }
            if (IsSetTokenFriendlyName()) {
                xml.Append("<TokenFriendlyName>");
                xml.Append(EscapeXML(this.TokenFriendlyName));
                xml.Append("</TokenFriendlyName>");
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