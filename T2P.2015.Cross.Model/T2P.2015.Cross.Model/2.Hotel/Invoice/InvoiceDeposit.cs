using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.History;
using T2P._2015.Model;

namespace T2P._2015.Cross.Model._2.Hotel.Invoice
{
    public class InvoiceDeposit
    {
        #region Delete Data
        public List<P_Validation> ListP_ValidationDelete { get; set; }
        public List<P_InvoiceError> InvoiceErrorDuplicateDelete { get; set; }
        #endregion

        #region Insert Or Update
        public B_Access UpdateB_Access { get; set; }
        //public N_BillingEmail UpdateBillingEmail { get; set; }
        public List<P_NextBookingStep> InsertListP_NextBookingStep { get; set; }
        public List<P_NextFinancialStep> InsertListP_NextFinacialStep { get; set; }
        #endregion
        public InvoiceDeposit()
        {
            #region Delete Data

            ListP_ValidationDelete = new List<P_Validation>();
            InvoiceErrorDuplicateDelete = new List<P_InvoiceError>();

            #endregion

            #region InsertOrUpdate

            UpdateB_Access = new B_Access();
            //UpdateBillingEmail = new N_BillingEmail();
            InsertListP_NextBookingStep = new List<P_NextBookingStep>();
            InsertListP_NextFinacialStep = new List<P_NextFinancialStep>();

            #endregion
        }
    }
}
