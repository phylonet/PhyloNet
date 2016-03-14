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
    public class VerifySignatureRequest
    {
    
        private String urlEndPointField;

        private String httpParametersField;


        /// <summary>
        /// Gets and sets the UrlEndPoint property.
        /// </summary>
        [XmlElementAttribute(ElementName = "UrlEndPoint")]
        public String UrlEndPoint
        {
            get { return this.urlEndPointField ; }
            set { this.urlEndPointField= value; }
        }



        /// <summary>
        /// Sets the UrlEndPoint property
        /// </summary>
        /// <param name="urlEndPoint">UrlEndPoint property</param>
        /// <returns>this instance</returns>
        public VerifySignatureRequest WithUrlEndPoint(String urlEndPoint)
        {
            this.urlEndPointField = urlEndPoint;
            return this;
        }



        /// <summary>
        /// Checks if UrlEndPoint property is set
        /// </summary>
        /// <returns>true if UrlEndPoint property is set</returns>
        public Boolean IsSetUrlEndPoint()
        {
            return  this.urlEndPointField != null;

        }


        /// <summary>
        /// Gets and sets the HttpParameters property.
        /// </summary>
        [XmlElementAttribute(ElementName = "HttpParameters")]
        public String HttpParameters
        {
            get { return this.httpParametersField ; }
            set { this.httpParametersField= value; }
        }



        /// <summary>
        /// Sets the HttpParameters property
        /// </summary>
        /// <param name="httpParameters">HttpParameters property</param>
        /// <returns>this instance</returns>
        public VerifySignatureRequest WithHttpParameters(String httpParameters)
        {
            this.httpParametersField = httpParameters;
            return this;
        }



        /// <summary>
        /// Checks if HttpParameters property is set
        /// </summary>
        /// <returns>true if HttpParameters property is set</returns>
        public Boolean IsSetHttpParameters()
        {
            return  this.httpParametersField != null;

        }





    }

}