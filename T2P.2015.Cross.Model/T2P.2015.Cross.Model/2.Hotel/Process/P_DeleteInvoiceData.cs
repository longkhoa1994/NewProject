using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.History;
using T2P._2015.Model;

namespace T2P._2015.Cross.Model.Process
{
    public class P_DeleteInvoiceData
    {
        public List<I_Image> ListImage { get; set; }
        public List<I_Data> ListData { get; set; }
        public List<I_Position> ListPosition { get; set; }
        public List<I_Tax> ListTax { get; set; }
        public List<P_Validation> ListValidation { get; set; }
        public List<P_InvoiceError> ListInvoiceError { get; set; }
        public List<I_Error> ListError { get; set; }

        public List<H_I_Data> ListHistoryData { get; set; }
        public List<H_I_Position> ListHistoryPosition { get; set; }
        public List<H_I_Tax> ListHistoryTax { get; set; }
        public List<H_P_Validation> ListHistoryValidation { get; set; }
        public List<H_P_InvoiceError> ListHistoryInvoiceError { get; set; }

        public List<I_ForwardLine> ListForwardLine { get; set; }
        public List<N_Rejection> ListRejection { get; set; }
        public List<P_InvoiceStep> ListInvoiceStep { get; set; }
        public List<P_NextInvoiceStep> ListInvoiceNextStep { get; set; }
        public List<I_PageToImage> ListPageToImage { get; set; }
        public List<N_BillingEmail> ListBillingEmail { get; set; }

        public P_DeleteInvoiceData()
        {
            ListImage = new List<I_Image>();
            ListData = new List<I_Data>();
            ListPosition = new List<I_Position>();
            ListTax = new List<I_Tax>();
            ListValidation = new List<P_Validation>();
            ListInvoiceError = new List<P_InvoiceError>();
            ListError = new List<I_Error>();
            ListHistoryData = new List<H_I_Data>();
            ListHistoryPosition = new List<H_I_Position>();
            ListHistoryTax = new List<H_I_Tax>();
            ListHistoryValidation = new List<H_P_Validation>();
            ListHistoryInvoiceError = new List<H_P_InvoiceError>();
            ListForwardLine = new List<I_ForwardLine>();
            ListRejection = new List<N_Rejection>();
            ListInvoiceStep = new List<P_InvoiceStep>();
            ListInvoiceNextStep = new List<P_NextInvoiceStep>();
            ListPageToImage = new List<I_PageToImage>();
            ListBillingEmail = new List<N_BillingEmail>();

        }
    }

    public class P_DeleteInvoice
    {
        public I_Image I_Image { get; set; }
        public I_Data I_Data { get; set; }
        public List<I_Position> ListPosition { get; set; }
        public List<I_Tax> ListTax { get; set; }
        public List<P_Validation> ListValidation { get; set; }
        public List<P_InvoiceError> ListInvoiceError { get; set; }
        public List<I_Error> ListError { get; set; }

        public List<H_I_Data> ListHistoryData { get; set; }
        public List<H_I_Position> ListHistoryPosition { get; set; }
        public List<H_I_Tax> ListHistoryTax { get; set; }
        public List<H_P_Validation> ListHistoryValidation { get; set; }
        public List<H_P_InvoiceError> ListHistoryInvoiceError { get; set; }

        public List<I_ForwardLine> ListForwardLine { get; set; }
        public List<N_Rejection> ListRejection { get; set; }
        public List<P_InvoiceStep> ListInvoiceStep { get; set; }
        public List<P_NextInvoiceStep> ListInvoiceNextStep { get; set; }
        public List<I_PageToImage> ListPageToImage { get; set; }
        public List<N_BillingEmail> ListBillingEmail { get; set; }

        public N_BookingBillingEmail N_BookingBillingEmail { get; set; }

        public List<B_Comment> ListComment { get; set; }

        public List<I_Replace> ListReplace { get; set; }

        public P_DeleteInvoice()
        {
            I_Image = new I_Image();
            I_Data = new I_Data();
            ListPosition = new List<I_Position>();
            ListTax = new List<I_Tax>();
            ListValidation = new List<P_Validation>();
            ListInvoiceError = new List<P_InvoiceError>();
            ListError = new List<I_Error>();
            ListHistoryData = new List<H_I_Data>();
            ListHistoryPosition = new List<H_I_Position>();
            ListHistoryTax = new List<H_I_Tax>();
            ListHistoryValidation = new List<H_P_Validation>();
            ListHistoryInvoiceError = new List<H_P_InvoiceError>();
            ListForwardLine = new List<I_ForwardLine>();
            ListRejection = new List<N_Rejection>();
            ListInvoiceStep = new List<P_InvoiceStep>();
            ListInvoiceNextStep = new List<P_NextInvoiceStep>();
            ListPageToImage = new List<I_PageToImage>();
            ListBillingEmail = new List<N_BillingEmail>();
            N_BookingBillingEmail = new N_BookingBillingEmail();
            ListComment = new List<B_Comment>();
            ListReplace = new List<I_Replace>();
        }
    }
}
