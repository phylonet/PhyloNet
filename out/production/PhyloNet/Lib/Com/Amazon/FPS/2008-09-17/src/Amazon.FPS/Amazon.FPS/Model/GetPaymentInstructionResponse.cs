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
    public class GetPaymentInstructionResponse
    {
    
        private  GetPaymentInstructionResult getPaymentInstructionResultField;
        private  ResponseMetadata responseMetadataField;

        /// <summary>
        /// Gets and sets the GetPaymentInstructionResult property.
        /// </summary>
        [XmlElementAttribute(ElementName = "GetPaymentInstructionResult")]
        public GetPaymentInstructionResult GetPaymentInstructionResult
        {
            get { return this.getPaymentInstructionResultField ; }
            set { this.getPaymentInstructionResultField = value; }
        }



        /// <summary>
        /// Sets the GetPaymentInstructionResult property
        /// </summary>
        /// <param name="getPaymentInstructionResult">GetPaymentInstructionResult property</param>
        /// <returns>this instance</returns>
        public GetPaymentInstructionResponse WithGetPaymentInstructionResult(GetPaymentInstructionResult getPaymentInstructionResult)
        {
            this.getPaymentInstructionResultField = getPaymentInstructionResult;
            return this;
        }



        /// <summary>
        /// Checks if GetPaymentInstructionResult property is set
        /// </summary>
        /// <returns>true if GetPaymentInstructionResult property is set</returns>
        public Boolean IsSetGetPaymentInstructionResult()
        {
            return this.getPaymentInstructionResultField != null;
        }




        /// <summary>
        /// Gets and sets the ResponseMetadata property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ResponseMetadata")]
        public ResponseMetadata ResponseMetadata
        {
            get { return this.responseMetadataField ; }
            set { this.responseMetadataField = value; }
        }



        /// <summary>
        /// Sets the ResponseMetadata property
        /// </summary>
        /// <param name="responseMetadata">ResponseMetadata property</param>
        /// <returns>this instance</returns>
        public GetPaymentInstructionResponse WithResponseMetadata(ResponseMetadata responseMetadata)
        {
            this.responseMetadataField = responseMetadata;
            return this;
        }



        /// <summary>
        /// Checks if ResponseMetadata property is set
        /// </summary>
        /// <returns>true if ResponseMetadata property is set</returns>
        public Boolean IsSetResponseMetadata()
        {
            return this.responseMetadataField != null;
        }






        /// <summary>
        /// XML Representation for this object
        /// </summary>
        /// <returns>XML String</returns>

        public String ToXML() {
            StringBuilder xml = new StringBuilder();
            xml.Append("<GetPaymentInstructionResponse xmlns=\"http://fps.amazonaws.com/doc/2008-09-17/\">");
            if (IsSetGetPaymentInstructionResult()) {
                GetPaymentInstructionResult  getPaymentInstructionResult = this.GetPaymentInstructionResult;
                xml.Append("<GetPaymentInstructionResult>");
                xml.Append(getPaymentInstructionResult.ToXMLFragment());
                xml.Append("</GetPaymentInstructionResult>");
            } 
            if (IsSetResponseMetadata()) {
                ResponseMetadata  responseMetadata = this.ResponseMetadata;
                xml.Append("<ResponseMetadata>");
                xml.Append(responseMetadata.ToXMLFragment());
                xml.Append("</ResponseMetadata>");
            } 
            xml.Append("</GetPaymentInstructionResponse>");
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