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
    public class GetTokensRequest
    {
    
        private TokenStatus? tokenStatusField;

        private TokenType? tokenTypeField;

        private String callerReferenceField;

        private String tokenFriendlyNameField;


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
        public GetTokensRequest WithTokenStatus(TokenStatus tokenStatus)
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
        public GetTokensRequest WithTokenType(TokenType tokenType)
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
        public GetTokensRequest WithCallerReference(String callerReference)
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
        public GetTokensRequest WithTokenFriendlyName(String tokenFriendlyName)
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





    }

}