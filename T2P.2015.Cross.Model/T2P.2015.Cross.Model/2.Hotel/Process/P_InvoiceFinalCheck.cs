using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_InvoiceFinalCheck
    {
        public bool IsCheckPaySlip { get; set; }
        public bool IsCheckCopyInvoice { get; set; }
        public bool IsCheckVATNumber { get; set; }
        public bool IsErrorPaySlip { get; set; }
        public bool IsErrorCopy { get; set; }
        public bool IsErrorCustomerVATCode { get; set; }
        public int TotalError { get; set; }
        public dynamic Message { get; set; }
        public long B_AccessID { get; set; }
        public long I_ImageID { get; set; }
        public string BookingNo { get; set; }
        public long I_DataID { get; set; }
		public string VATCode { get; set; }
        public string CompanyVATNumber { get; set; }
		public string VATCodeAllCountry { get; set; }
        public List<P_InvoiceFinalCheck_ImagePage> ListPage { get; set; }
        public bool IsReplace { get; set; }
        public bool IsUseOldData { get; set; }
        public long OldImageID { get; set; }
        public bool IsLockOtherInvoice { get; set; }
        public bool IsValidCancel { get; set; }
        public P_InvoiceFinalCheck()
        {
            ListPage = new List<P_InvoiceFinalCheck_ImagePage>();
        }
    }

    public class P_InvoiceFinalCheck_ImagePage
    {
        public long I_ImageID { get; set; }
        public string ImageStatus { get; set; }
        public string IISPath { get; set; }
        public string FilePath { get; set; }
        public string ImageFileName { get; set; }
        public int Rotate { get; set; }
    }

    public enum P_InvoiceFinalCheckProcedure
    {
        p_P_InvoiceFinalCheck_GetImage,
        p_P_InvoiceFinalCheck_GetImage1
    }

    public class P_InvoiceFinalCheck_Request
    {
        public long I_ImageID { get; set; }
        public long I_DataID { get; set; }
        public bool IsCustomerVATCode { get; set; }
        public bool IsCopyInvoice { get; set; }
        public bool IsPaySlip { get; set; }
        public string Comment { get; set; }
        public bool IsSendRejection { get; set; }
        public bool IsVerifyData { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public bool IsChangeTax { get; set; }
        public bool IsValidCancel { get; set; }
    }
}
