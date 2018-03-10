using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Invoice_ExceptionalHandling
    {
		public string BookingNo { get; set; }
        public long I_DataID { get; set; }
        public long B_BookingID { get; set; }
        public long I_ImageID { get; set; }
        public long B_AccessID { get; set; }
        public string ImageStatus { get; set; }
        public string InvoiceNo { get; set; }
        public string ImageFileName { get; set; }
        public string InvoiceGrossAmount { get; set; }

        public string CheckIn { get; set; }
        public string CheckOut { get; set; }

        public string HotelName { get; set; }
        public string CompanyName { get; set; }
        public string Traveler { get; set; }

        public long M_CompanyID { get; set; }

        public int ErrorCount { get; set; }

        public int IsSpecialCase { get; set; }

        private List<P_InvoiceError_Image> _listErrorCode;


        public List<P_InvoiceError_Image> ListErrorCode
        {
            get { return _listErrorCode; }
            set { _listErrorCode = value; }
        }
    }

    public enum P_Invoice_ExceptionalHandlingProcedure
    {
        p_I_Image_Get_ByBookingNumber_ForExceptionalHandling,
        p_I_Image_Get_ByBookingNumber_ForMoveorDeleteInvoice,
        p_I_Image_Get_ByBookingNumber_ForReplaceInvoice,
        p_I_Image_Get_ByBookingNumber_ForSkipMatchingFin,
        p_B_Booking_GetNewBooking_ForTransferInvoice,
        p_I_Data_GetInvoiceReplace,

    }
    public class ErrorList
    {
        public string ErrorText { get; set; }
    }

    public class P_Invoice_ExceptionalHandlingResult
    {
        public long I_ImageID { get; set; }
        public long I_ImageIDNew { get; set;}
        public string InvoiceNo { get; set; }
        public int ProcessStatus { get; set; }
        public string UserLockInReview { get; set; }
    }
}
