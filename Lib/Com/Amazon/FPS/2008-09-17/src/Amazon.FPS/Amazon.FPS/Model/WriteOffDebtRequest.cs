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
    public class WriteOffDebtRequest
    {
    
        private String creditInstrumentIdField;

        private  Amount adjustmentAmountField;
        private String callerReferenceField;

        private String callerDescriptionField;


        /// <summary>
        /// Gets and sets the CreditInstrumentId property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CreditInstrumentId")]
        public String CreditInstrumentId
        {
            get { return this.creditInstrumentIdField ; }
            set { this.creditInstrumentIdField= value; }
        }



        /// <summary>
        /// Sets the CreditInstrumentId property
        /// </summary>
        /// <param name="creditInstrumentId">CreditInstrumentId property</param>
        /// <returns>this instance</returns>
        public WriteOffDebtRequest WithCreditInstrumentId(String creditInstrumentId)
        {
            this.creditInstrumentIdField = creditInstrumentId;
            return this;
        }



        /// <summary>
        /// Checks if CreditInstrumentId property is set
        /// </summary>
        /// <returns>true if CreditInstrumentId property is set</returns>
        public Boolean IsSetCreditInstrumentId()
        {
            return  this.creditInstrumentIdField != null;

        }


        /// <summary>
        /// Gets and sets the AdjustmentAmount property.
        /// </summary>
        [XmlElementAttribute(ElementName = "AdjustmentAmount")]
        public Amount AdjustmentAmount
        {
            get { return this.adjustmentAmountField ; }
            set { this.adjustmentAmountField = value; }
        }



        /// <summary>
        /// Sets the AdjustmentAmount property
        /// </summary>
        /// <param name="adjustmentAmount">AdjustmentAmount property</param>
        /// <returns>this instance</returns>
        public WriteOffDebtRequest WithAdjustmentAmount(Amount adjustmentAmount)
        {
            this.adjustmentAmountField = adjustmentAmount;
            return this;
        }



        /// <summary>
        /// Checks if AdjustmentAmount property is set
        /// </summary>
        /// <returns>true if AdjustmentAmount property is set</returns>
        public Boolean IsSetAdjustmentAmount()
        {
            return this.adjustmentAmountField != null;
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
        public WriteOffDebtRequest WithCallerReference(String callerReference)
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
        /// Gets and sets the CallerDescription property.
        /// </summary>
        [XmlElementAttribute(ElementName = "CallerDescription")]
        public String CallerDescription
        {
            get { return this.callerDescriptionField ; }
            set { this.callerDescriptionField= value; }
        }



        /// <summary>
        /// Sets the CallerDescription property
        /// </summary>
        /// <param name="callerDescription">CallerDescription property</param>
        /// <returns>this instance</returns>
        public WriteOffDebtRequest WithCallerDescription(String callerDescription)
        {
            this.callerDescriptionField = callerDescription;
            return this;
        }



        /// <summary>
        /// Checks if CallerDescription property is set
        /// </summary>
        /// <returns>true if CallerDescription property is set</returns>
        public Boolean IsSetCallerDescription()
        {
            return  this.callerDescriptionField != null;

        }





    }

}