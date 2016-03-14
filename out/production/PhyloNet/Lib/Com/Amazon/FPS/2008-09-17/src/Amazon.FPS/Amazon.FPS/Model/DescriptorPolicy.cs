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
    public class DescriptorPolicy
    {
    
        private SoftDescriptorType? softDescriptorTypeField;

        private CSOwner? CSOwnerField;


        /// <summary>
        /// Gets and sets the SoftDescriptorType property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SoftDescriptorType")]
        public SoftDescriptorType SoftDescriptorType
        {
            get { return this.softDescriptorTypeField.GetValueOrDefault() ; }
            set { this.softDescriptorTypeField= value; }
        }



        /// <summary>
        /// Sets the SoftDescriptorType property
        /// </summary>
        /// <param name="softDescriptorType">SoftDescriptorType property</param>
        /// <returns>this instance</returns>
        public DescriptorPolicy WithSoftDescriptorType(SoftDescriptorType softDescriptorType)
        {
            this.softDescriptorTypeField = softDescriptorType;
            return this;
        }



        /// <summary>
        /// Checks if SoftDescriptorType property is set
        /// </summary>
        /// <returns>true if SoftDescriptorType property is set</returns>
        public Boolean IsSetSoftDescriptorType()
        {
            return this.softDescriptorTypeField.HasValue;

        }


        /// <summary>
        /// Gets and sets the CSOwner property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CSOwner")]
        public CSOwner CSOwner
        {
            get { return this.CSOwnerField.GetValueOrDefault() ; }
            set { this.CSOwnerField= value; }
        }



        /// <summary>
        /// Sets the CSOwner property
        /// </summary>
        /// <param name="CSOwner">CSOwner property</param>
        /// <returns>this instance</returns>
        public DescriptorPolicy WithCSOwner(CSOwner CSOwner)
        {
            this.CSOwnerField = CSOwner;
            return this;
        }



        /// <summary>
        /// Checks if CSOwner property is set
        /// </summary>
        /// <returns>true if CSOwner property is set</returns>
        public Boolean IsSetCSOwner()
        {
            return this.CSOwnerField.HasValue;

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
            if (IsSetSoftDescriptorType()) {
                xml.Append("<SoftDescriptorType>");
                xml.Append(this.SoftDescriptorType);
                xml.Append("</SoftDescriptorType>");
            }
            if (IsSetCSOwner()) {
                xml.Append("<CSOwner>");
                xml.Append(this.CSOwner);
                xml.Append("</CSOwner>");
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