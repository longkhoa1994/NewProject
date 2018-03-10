using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._3.CarRental._7.Process
{
    public class R_P_InvoiceHistory
    {
        public R_I_Image Image { get; set; }
        public R_I_Data Data { get; set; }
        public List<R_I_Tax> ListTax { get; set; }
        public List<R_I_Service> ListService { get; set; }
        public List<R_I_Error> ListError { get; set; }
        public List<R_P_Validation> ListValidation { get; set; }

        public List<R_I_Tax> ListTaxOld { get; set; }
        public List<R_I_Service> ListServiceOld { get; set; }
        public List<R_I_Error> ListErrorOld { get; set; }
        public List<R_P_Validation> ListValidationOld { get; set; }

        public R_H_I_Data R_H_I_Data { get; set; }
        public List<R_H_I_Tax> ListR_H_I_Tax { get; set; }
        public List<R_H_I_Service> ListR_H_I_Service { get; set; }
        public List<R_H_I_Error> ListR_H_I_Error { get; set; }
        public List<R_H_P_Validation> ListR_H_P_Validation { get; set; }

        public List<R_P_InvoiceStep> ListInvoiceStep { get; set; }

        public List<R_P_NextInvoiceStep> ListInvoiceNextStep { get; set; }

        public List<R_P_NextInvoiceStep> ListInvoiceNextStepDelete { get; set; }

        public R_P_InvoiceHistory()
        {
            Data = null;
            ListTax = new List<R_I_Tax>();
            ListService = new List<R_I_Service>();
            ListValidation = new List<R_P_Validation>();
            ListError = new List<R_I_Error>();

            ListTaxOld = new List<R_I_Tax>();
            ListServiceOld = new List<R_I_Service>();
            ListValidationOld = new List<R_P_Validation>();
            ListErrorOld = new List<R_I_Error>();

            R_H_I_Data = null;
            ListR_H_I_Tax = new List<R_H_I_Tax>();
            ListR_H_I_Service = new List<R_H_I_Service>();
            ListR_H_I_Error = new List<R_H_I_Error>();
            ListR_H_P_Validation = new List<R_H_P_Validation>();

            ListInvoiceStep = new List<R_P_InvoiceStep>();
            ListInvoiceNextStep = new List<R_P_NextInvoiceStep>();
            ListInvoiceNextStepDelete = new List<R_P_NextInvoiceStep>();
            
        }
    }
}
