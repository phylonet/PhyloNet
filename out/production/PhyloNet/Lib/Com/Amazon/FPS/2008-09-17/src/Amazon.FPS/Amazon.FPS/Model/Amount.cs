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
    public class Amount
    {
    
        private CurrencyCode? currencyCodeField;

        private String valueField;


        /// <summary>
        /// Gets and sets the CurrencyCode property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CurrencyCode")]
        public CurrencyCode CurrencyCode
        {
            get { return this.currencyCodeField.GetValueOrDefault() ; }
            set { this.currencyCodeField= value; }
        }



        /// <summary>
        /// Sets the CurrencyCode property
        /// </summary>
        /// <param name="currencyCode">CurrencyCode property</param>
        /// <returns>this instance</returns>
        public Amount WithCurrencyCode(CurrencyCode currencyCode)
        {
            this.currencyCodeField = currencyCode;
            return this;
        }



        /// <summary>
        /// Checks if CurrencyCode property is set
        /// </summary>
        /// <returns>true if CurrencyCode property is set</returns>
        public Boolean IsSetCurrencyCode()
        {
            return this.currencyCodeField.HasValue;

        }


        /// <summary>
        /// Gets and sets the Value property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Value")]
        public String Value
        {
            get { return this.valueField ; }
            set { this.valueField= value; }
        }



        /// <summary>
        /// Sets the Value property
        /// </summary>
        /// <param name="value">Value property</param>
        /// <returns>this instance</returns>
        public Amount WithValue(String value)
        {
            this.valueField = value;
            return this;
        }



        /// <summary>
        /// Checks if Value property is set
        /// </summary>
        /// <returns>true if Value property is set</returns>
        public Boolean IsSetValue()
        {
            return  this.valueField != null;

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
            if (IsSetCurrencyCode()) {
                xml.Append("<CurrencyCode>");
                xml.Append(this.CurrencyCode);
                xml.Append("</CurrencyCode>");
            }
            if (IsSetValue()) {
                xml.Append("<Value>");
                xml.Append(EscapeXML(this.Value));
                xml.Append("</Value>");
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