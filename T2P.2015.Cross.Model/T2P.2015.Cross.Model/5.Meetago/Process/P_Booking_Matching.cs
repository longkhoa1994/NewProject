using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_Meetago_Matching_SearchResult
    {
        public long? I_ImageID { get; set; }
        public List<P_Meetago_Matching_Booking> ListBookingNew { get; set; }
        public long TotalBookingNewRecord { get; set; }
        public List<P_Meetago_Matching_Booking> ListBookingMatched { get; set; }
        public long TotalBookingMatchedRecord { get; set; }
        public P_Meetago_Matching_SearchResult()
        {
            ListBookingNew = new List<P_Meetago_Matching_Booking>();
            TotalBookingNewRecord = 0;
            ListBookingMatched = new List<P_Meetago_Matching_Booking>();
            TotalBookingMatchedRecord = 0;
        }
    }

    public class P_Meetago_Matching_Booking
    {
        public long M_HotelPlatformID { get; set; }
        public long M_ProcessID { get; set; }
        public long B_AccessID { get; set; }
        public long B_EventID { get; set; }
        public string BookingNo { get; set; }
        public string ContractNo { get; set; }
        public string BookerName { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public List<P_Meetago_Matching_Image> ListImage { get; set; }
        public List<string> ListAllowedServiceCode { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTime? CancellationDate { get; set; }
        public bool IsCopy
        {
            get
            {
                return false;
            }
        }
        public bool IsPrepaid
        {
            get
            {
                return false;
            }
        }
        public bool IsMatch
        {
            get
            {
                if (CancellationDate != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public bool IsDeposit
        {
            get
            {
                return false;
            }
        }

        public P_Meetago_Matching_Booking()
        {
            M_HotelPlatformID = 0;
            M_ProcessID = 0;
            B_AccessID = 0;
            BookingNo = string.Empty;
            HotelName = string.Empty;
            HotelAddress = string.Empty;
            CompanyName = string.Empty;
            CompanyAddress = string.Empty;
            ListImage = new List<P_Meetago_Matching_Image>();
            ListAllowedServiceCode = new List<string>();
            Amount = 0;
            Currency = string.Empty;

        }
    }


    public class P_Meetago_Matching_Image
    {
        public long I_ImageID { get; set; }
        public string ImageStatus { get; set; }
        public bool IsReplace { get; set; }
        public bool IsUseOldData { get; set; }
        public List<P_Meetago_Matching_Page> ListPage { get; set; }
        public List<P_Meetago_Matching_ErrorCode> ListErrorCode { get; set; }
        public bool IsExportedVTI { get; set; }
        public bool IsGatewayInvoice { get; set; }
        public bool AutoUseOldData { get; set; }
        public bool IsSpecialCase { get; set; }

        public P_Meetago_Matching_Image()
        {
            I_ImageID = 0;
            ImageStatus = string.Empty;
            IsReplace = false;
            IsUseOldData = false;
            ListPage = new List<P_Meetago_Matching_Page>();
            ListErrorCode = new List<P_Meetago_Matching_ErrorCode>();
            IsExportedVTI = false;
            IsGatewayInvoice = false;
            AutoUseOldData = false;
            IsSpecialCase = false;
        }
    }

    public class P_Meetago_Matching_Page
    {
        public long N_AttachmentPageID { get; set; }
        public int Position { get; set; }
        public string LocalPath { get; set; }
        public string IISPath { get; set; }
        public int Rotate { get; set; }

        public P_Meetago_Matching_Page()
        {
            N_AttachmentPageID = 0;
            LocalPath = string.Empty;
            IISPath = string.Empty;
            Rotate = 0;

        }
    }

    public class P_Meetago_Matching_ErrorCode
    {
        public string ErrorCode { get; set; }
        public string ErrorText { get; set; }
        public int ErrorType { get; set; }
    }

    public class P_Meetago_Matching_Booker
    {
        public string FullName { get; set; }
    }
}
