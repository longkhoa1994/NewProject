using System;
using System.Collections.Generic;
using T2P._2015.Cross.Enum;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Booking : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private long _b_HeaderID;

        public long B_HeaderID
        {
            get { return _b_HeaderID; }
            set { _b_HeaderID = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private decimal _grossAmount;

        public decimal GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        private string _paymentMethod;

        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }

        private string _currencyCode;

        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        private DateTime? _bookingDate;

        
        public DateTime? BookingDate
        {
            get { return _bookingDate; }
            set { _bookingDate = value; }
        }

        private DateTime? _cancellationDate;

        
        public DateTime? CancellationDate
        {
            get { return _cancellationDate; }
            set { _cancellationDate = value; }
        }

        private DateTime _checkIn;

        public DateTime CheckIn
        {
            get { return _checkIn; }
            set { _checkIn = value; }
        }

        private DateTime _checkOut;

        public DateTime CheckOut
        {
            get { return _checkOut; }
            set { _checkOut = value; }
        }

        public override string Table { get { return "B_Booking"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Booking_InsertOrUpdate"; } }
    }

    public class B_Booking_Extend : B_Booking
    {
        public long M_HotelPlatformID { get; set; }
        public string BookingStatus { get; set; }
        public string HotelName { get; set; }
        public string CompanyName { get; set; }
        public string ListTraveller { get; set; }    
        public B_Booking_Extend()
        {
            M_HotelPlatformID = 0;
            HotelName = string.Empty;
            CompanyName = string.Empty;
            ListTraveller = string.Empty;           
        }
    }   

    public class B_Booking_ForMatching : B_Booking
    {
        public long M_HotelPlatformID { get; set; }
        public long M_ProcessID { get; set; }
        public int BookingType { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string ListTraveller { get; set; }
        public string ListImage { get; set; }
        public string ListFIN { get; set; }
        public string ListAllowedServiceCode { get; set; }
        public B_Booking_ForMatching()
        {
            M_HotelPlatformID = 0;
            M_ProcessID = 0;
            BookingType = 0;
            HotelName = string.Empty;
            HotelAddress = string.Empty;
            CompanyName = string.Empty;
            CompanyAddress = string.Empty;
            ListTraveller = string.Empty;
            ListImage = string.Empty;
            ListFIN = string.Empty;
            ListAllowedServiceCode = string.Empty;        
        }      
    }

    public class B_Booking_ForServiceCenterTemplate : B_Booking
    {
        public string Travellers { get; set; }
        public string HotelName { get; set; }        
        public string Booker { get; set; } 
        public string HotelNo { get; set; }
        public string HotelVATNumber { get; set; }
        public string HotelAddress { get; set; }
        public string HotelEmail { get; set; }
        public string HotelFax { get; set; }
        public long HotelM_LanguageID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNo { get; set; }
        public string CompanyVATNumber { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyFax { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceAmount { get; set; }
        public string Transactions { get; set; }
        public string UserSignature { get; set; }
        public string UserSignatureDecode
        {
            get { return T2P._2015.Cross.Utility.Conversion.Conversion.ObjectToString(System.Net.WebUtility.HtmlDecode(this.UserSignature)); }
        }
        public string BillingEmail { get; set; }
        public string BillingFax { get; set; }        
    }

    public enum B_BookingColumns
    {
        ID,
        B_AccessID,
        B_HeaderID,
        BookingNo,
        GrossAmount,
        PaymentMethod,
        CurrencyCode,
        BookingDate,
        CancellationDate,
        CheckIn,
        CheckOut,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_BookingProcedure
    {
        //p_B_Booking_Get_Search,
        p_B_Booking_GetSearch,
        p_B_Booking_GetSearch_GetTotal,
        p_B_Booking_Get_By_B_AccessID,
        p_B_Booking_CheckInfoHDE,
        p_B_Booking_GetByBookingNo,
        p_B_Booking_GetByHotelEmail,
        p_B_Booking_Get_Information,
        p_P_Matching_GetBooking,       
        p_P_Matching_GetBooking_Count,
        p_B_Booking_GetInfoForCollectionLetter,
        p_B_Booking_GetByBookingNoFor_MatchBillingEmail,        
        p_B_Booking_GetListForWeeklyLetterHRS,
        p_B_Booking_GetListForWeeklyReportToAirplus,
        p_B_Booking_Get_BookingNoForServiceCenterTemplate,
        p_B_Booking_GetList_ByBookingAccess_WithoutStatus,
        p_B_Booking_GetListForDeleting,
        p_B_Booking_GetListForPhysicalDeleting,
        p_B_Booking_GetListForArchiving_Deleting,
        p_B_Booking_CheckInfoBCD,
        p_B_Booking_GetListByCallID,
        p_B_Booking_GetListByListCallID,
    }

    public class B_BookingList : List<B_Booking>
    {
    }
}