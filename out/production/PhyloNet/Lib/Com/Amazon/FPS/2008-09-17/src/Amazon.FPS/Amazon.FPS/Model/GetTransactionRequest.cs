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
    public class GetTransactionRequest
    {
    
        private String transactionIdField;


        /// <summary>
        /// Gets and sets the TransactionId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransactionId")]
        public String TransactionId
        {
            get { return this.transactionIdField ; }
            set { this.transactionIdField= value; }
        }



        /// <summary>
        /// Sets the TransactionId property
        /// </summary>
        /// <param name="transactionId">TransactionId property</param>
        /// <returns>this instance</returns>
        public GetTransactionRequest WithTransactionId(String transactionId)
        {
            this.transactionIdField = transactionId;
            return this;
        }



        /// <summary>
        /// Checks if TransactionId property is set
        /// </summary>
        /// <returns>true if TransactionId property is set</returns>
        public Boolean IsSetTransactionId()
        {
            return  this.transactionIdField != null;

        }





    }

}