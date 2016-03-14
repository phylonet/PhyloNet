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
    public class TransactionPart
    {
    
        private String instrumentIdField;

        private TransactionalRole? roleField;

        private String nameField;

        private String referenceField;

        private String descriptionField;

        private  Amount feesPaidField;

        /// <summary>
        /// Gets and sets the InstrumentId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstrumentId")]
        public String InstrumentId
        {
            get { return this.instrumentIdField ; }
            set { this.instrumentIdField= value; }
        }



        /// <summary>
        /// Sets the InstrumentId property
        /// </summary>
        /// <param name="instrumentId">InstrumentId property</param>
        /// <returns>this instance</returns>
        public TransactionPart WithInstrumentId(String instrumentId)
        {
            this.instrumentIdField = instrumentId;
            return this;
        }



        /// <summary>
        /// Checks if InstrumentId property is set
        /// </summary>
        /// <returns>true if InstrumentId property is set</returns>
        public Boolean IsSetInstrumentId()
        {
            return  this.instrumentIdField != null;

        }


        /// <summary>
        /// Gets and sets the Role property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Role")]
        public TransactionalRole Role
        {
            get { return this.roleField.GetValueOrDefault() ; }
            set { this.roleField= value; }
        }



        /// <summary>
        /// Sets the Role property
        /// </summary>
        /// <param name="role">Role property</param>
        /// <returns>this instance</returns>
        public TransactionPart WithRole(TransactionalRole role)
        {
            this.roleField = role;
            return this;
        }



        /// <summary>
        /// Checks if Role property is set
        /// </summary>
        /// <returns>true if Role property is set</returns>
        public Boolean IsSetRole()
        {
            return this.roleField.HasValue;

        }


        /// <summary>
        /// Gets and sets the Name property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Name")]
        public String Name
        {
            get { return this.nameField ; }
            set { this.nameField= value; }
        }



        /// <summary>
        /// Sets the Name property
        /// </summary>
        /// <param name="name">Name property</param>
        /// <returns>this instance</returns>
        public TransactionPart WithName(String name)
        {
            this.nameField = name;
            return this;
        }



        /// <summary>
        /// Checks if Name property is set
        /// </summary>
        /// <returns>true if Name property is set</returns>
        public Boolean IsSetName()
        {
            return  this.nameField != null;

        }


        /// <summary>
        /// Gets and sets the Reference property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Reference")]
        public String Reference
        {
            get { return this.referenceField ; }
            set { this.referenceField= value; }
        }



        /// <summary>
        /// Sets the Reference property
        /// </summary>
        /// <param name="reference">Reference property</param>
        /// <returns>this instance</returns>
        public TransactionPart WithReference(String reference)
        {
            this.referenceField = reference;
            return this;
        }



        /// <summary>
        /// Checks if Reference property is set
        /// </summary>
        /// <returns>true if Reference property is set</returns>
        public Boolean IsSetReference()
        {
            return  this.referenceField != null;

        }


        /// <summary>
        /// Gets and sets the Description property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Description")]
        public String Description
        {
            get { return this.descriptionField ; }
            set { this.descriptionField= value; }
        }



        /// <summary>
        /// Sets the Description property
        /// </summary>
        /// <param name="description">Description property</param>
        /// <returns>this instance</returns>
        public TransactionPart WithDescription(String description)
        {
            this.descriptionField = description;
            return this;
        }



        /// <summary>
        /// Checks if Description property is set
        /// </summary>
        /// <returns>true if Description property is set</returns>
        public Boolean IsSetDescription()
        {
            return  this.descriptionField != null;

        }


        /// <summary>
        /// Gets and sets the FeesPaid property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FeesPaid")]
        public Amount FeesPaid
        {
            get { return this.feesPaidField ; }
            set { this.feesPaidField = value; }
        }



        /// <summary>
        /// Sets the FeesPaid property
        /// </summary>
        /// <param name="feesPaid">FeesPaid property</param>
        /// <returns>this instance</returns>
        public TransactionPart WithFeesPaid(Amount feesPaid)
        {
            this.feesPaidField = feesPaid;
            return this;
        }



        /// <summary>
        /// Checks if FeesPaid property is set
        /// </summary>
        /// <returns>true if FeesPaid property is set</returns>
        public Boolean IsSetFeesPaid()
        {
            return this.feesPaidField != null;
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
            if (IsSetInstrumentId()) {
                xml.Append("<InstrumentId>");
                xml.Append(EscapeXML(this.InstrumentId));
                xml.Append("</InstrumentId>");
            }
            if (IsSetRole()) {
                xml.Append("<Role>");
                xml.Append(this.Role);
                xml.Append("</Role>");
            }
            if (IsSetName()) {
                xml.Append("<Name>");
                xml.Append(EscapeXML(this.Name));
                xml.Append("</Name>");
            }
            if (IsSetReference()) {
                xml.Append("<Reference>");
                xml.Append(EscapeXML(this.Reference));
                xml.Append("</Reference>");
            }
            if (IsSetDescription()) {
                xml.Append("<Description>");
                xml.Append(EscapeXML(this.Description));
                xml.Append("</Description>");
            }
            if (IsSetFeesPaid()) {
                Amount  feesPaid = this.FeesPaid;
                xml.Append("<FeesPaid>");
                xml.Append(feesPaid.ToXMLFragment());
                xml.Append("</FeesPaid>");
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