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
    public class GetAccountActivityRequest
    {
    
        private Decimal? maxBatchSizeField;

        private DateTime? startDateField;

        private DateTime? endDateField;

        private SortOrder? sortOrderByDateField;

        private FPSOperation? FPSOperationField;

        private PaymentMethod? paymentMethodField;

        private List<TransactionalRole> roleField;

        private TransactionStatus? transactionStatusField;


        /// <summary>
        /// Gets and sets the MaxBatchSize property.
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxBatchSize")]
        public Decimal MaxBatchSize
        {
            get { return this.maxBatchSizeField.GetValueOrDefault() ; }
            set { this.maxBatchSizeField= value; }
        }



        /// <summary>
        /// Sets the MaxBatchSize property
        /// </summary>
        /// <param name="maxBatchSize">MaxBatchSize property</param>
        /// <returns>this instance</returns>
        public GetAccountActivityRequest WithMaxBatchSize(Decimal maxBatchSize)
        {
            this.maxBatchSizeField = maxBatchSize;
            return this;
        }



        /// <summary>
        /// Checks if MaxBatchSize property is set
        /// </summary>
        /// <returns>true if MaxBatchSize property is set</returns>
        public Boolean IsSetMaxBatchSize()
        {
            return  this.maxBatchSizeField.HasValue;

        }


        /// <summary>
        /// Gets and sets the StartDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "StartDate")]
        public DateTime StartDate
        {
            get { return this.startDateField.GetValueOrDefault() ; }
            set { this.startDateField= value; }
        }



        /// <summary>
        /// Sets the StartDate property
        /// </summary>
        /// <param name="startDate">StartDate property</param>
        /// <returns>this instance</returns>
        public GetAccountActivityRequest WithStartDate(DateTime startDate)
        {
            this.startDateField = startDate;
            return this;
        }



        /// <summary>
        /// Checks if StartDate property is set
        /// </summary>
        /// <returns>true if StartDate property is set</returns>
        public Boolean IsSetStartDate()
        {
            return  this.startDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the EndDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "EndDate")]
        public DateTime EndDate
        {
            get { return this.endDateField.GetValueOrDefault() ; }
            set { this.endDateField= value; }
        }



        /// <summary>
        /// Sets the EndDate property
        /// </summary>
        /// <param name="endDate">EndDate property</param>
        /// <returns>this instance</returns>
        public GetAccountActivityRequest WithEndDate(DateTime endDate)
        {
            this.endDateField = endDate;
            return this;
        }



        /// <summary>
        /// Checks if EndDate property is set
        /// </summary>
        /// <returns>true if EndDate property is set</returns>
        public Boolean IsSetEndDate()
        {
            return  this.endDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the SortOrderByDate property.
        /// </summary>
        [XmlElementAttribute(ElementName = "SortOrderByDate")]
        public SortOrder SortOrderByDate
        {
            get { return this.sortOrderByDateField.GetValueOrDefault() ; }
            set { this.sortOrderByDateField= value; }
        }



        /// <summary>
        /// Sets the SortOrderByDate property
        /// </summary>
        /// <param name="sortOrderByDate">SortOrderByDate property</param>
        /// <returns>this instance</returns>
        public GetAccountActivityRequest WithSortOrderByDate(SortOrder sortOrderByDate)
        {
            this.sortOrderByDateField = sortOrderByDate;
            return this;
        }



        /// <summary>
        /// Checks if SortOrderByDate property is set
        /// </summary>
        /// <returns>true if SortOrderByDate property is set</returns>
        public Boolean IsSetSortOrderByDate()
        {
            return this.sortOrderByDateField.HasValue;

        }


        /// <summary>
        /// Gets and sets the FPSOperation property.
        /// </summary>
        [XmlElementAttribute(ElementName = "FPSOperation")]
        public FPSOperation FPSOperation
        {
            get { return this.FPSOperationField.GetValueOrDefault() ; }
            set { this.FPSOperationField= value; }
        }



        /// <summary>
        /// Sets the FPSOperation property
        /// </summary>
        /// <param name="FPSOperation">FPSOperation property</param>
        /// <returns>this instance</returns>
        public GetAccountActivityRequest WithFPSOperation(FPSOperation FPSOperation)
        {
            this.FPSOperationField = FPSOperation;
            return this;
        }



        /// <summary>
        /// Checks if FPSOperation property is set
        /// </summary>
        /// <returns>true if FPSOperation property is set</returns>
        public Boolean IsSetFPSOperation()
        {
            return this.FPSOperationField.HasValue;

        }


        /// <summary>
        /// Gets and sets the PaymentMethod property.
        /// </summary>
        [XmlElementAttribute(ElementName = "PaymentMethod")]
        public PaymentMethod PaymentMethod
        {
            get { return this.paymentMethodField.GetValueOrDefault() ; }
            set { this.paymentMethodField= value; }
        }



        /// <summary>
        /// Sets the PaymentMethod property
        /// </summary>
        /// <param name="paymentMethod">PaymentMethod property</param>
        /// <returns>this instance</returns>
        public GetAccountActivityRequest WithPaymentMethod(PaymentMethod paymentMethod)
        {
            this.paymentMethodField = paymentMethod;
            return this;
        }



        /// <summary>
        /// Checks if PaymentMethod property is set
        /// </summary>
        /// <returns>true if PaymentMethod property is set</returns>
        public Boolean IsSetPaymentMethod()
        {
            return this.paymentMethodField.HasValue;

        }


        /// <summary>
        /// Gets and sets the Role property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Role")]
        public List<TransactionalRole> Role
        {
            get
            {
                if (this.roleField == null)
                {
                    this.roleField = new List<TransactionalRole>();
                }
                return this.roleField;
            }
            set { this.roleField =  value; }
        }



        /// <summary>
        /// Sets the Role property
        /// </summary>
        /// <param name="list">Role property</param>
        /// <returns>this instance</returns>
        public GetAccountActivityRequest WithRole(params TransactionalRole[] list)
        {
            foreach (TransactionalRole item in list)
            {
                Role.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks of Role property is set
        /// </summary>
        /// <returns>true if Role property is set</returns>
        public Boolean IsSetRole()
        {
            return (Role.Count > 0);
        }




        /// <summary>
        /// Gets and sets the TransactionStatus property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TransactionStatus")]
        public TransactionStatus TransactionStatus
        {
            get { return this.transactionStatusField.GetValueOrDefault() ; }
            set { this.transactionStatusField= value; }
        }



        /// <summary>
        /// Sets the TransactionStatus property
        /// </summary>
        /// <param name="transactionStatus">TransactionStatus property</param>
        /// <returns>this instance</returns>
        public GetAccountActivityRequest WithTransactionStatus(TransactionStatus transactionStatus)
        {
            this.transactionStatusField = transactionStatus;
            return this;
        }



        /// <summary>
        /// Checks if TransactionStatus property is set
        /// </summary>
        /// <returns>true if TransactionStatus property is set</returns>
        public Boolean IsSetTransactionStatus()
        {
            return this.transactionStatusField.HasValue;

        }





    }

}