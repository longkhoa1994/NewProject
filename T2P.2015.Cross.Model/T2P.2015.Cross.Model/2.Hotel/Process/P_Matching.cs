
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Enum;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Matching
    {
        public bool IsLock { get; set; }
        public long I_MatchingID { get; set; }

        public long? N_BillingEmailID { get; set; }

        public string FromAddress { get; set; }

        public string ToAddress { get; set; }

        public long? M_HotelPlatformID { get; set; }

        public string M_HotelPlatformName { get; set; }

        public DateTime? ReceivedDate { get; set; }

        public P_Matching_Img Image { get; set; }

        public P_Matching_Suggestion Suggestion { get; set; }

        public long? M_CompanyID { get; set; }

        public string CompanyName { get; set; }

        public List<M_HotelPlatform> ListHotelPlatform { get; set; }

        public P_Matching()
        {
            Image = new P_Matching_Img();
            Suggestion = new P_Matching_Suggestion();
            ListHotelPlatform = new List<M_HotelPlatform>();
        }
    }
    public class P_MatchingExtend : P_Matching
    {
        public string EmailBody { get; set; }
        public long? DuplicatedImageID { get; set; }
        public string EmailBodyFilter { get; set; }

    }

    public class P_Matching_Search
    {
        private bool isGatewayInvoice;

        public bool IsGatewayInvoice
        {
            get { return isGatewayInvoice; }
            set { isGatewayInvoice = value; }
        }

        //add attribute
        private long m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return m_HotelPlatformID; }
            set { m_HotelPlatformID = value; }
        }

        private string fromAddress;

        public string FromAddress
        {
            get { return fromAddress; }
            set { fromAddress = value; }
        }

        private DateTime? receivedDate;

        public DateTime? ReceivedDate
        {
            get { return receivedDate; }
            set { receivedDate = value; }
        }

        private long i_ImageID;

        public long I_ImageID
        {
            get { return i_ImageID; }
            set { i_ImageID = value; }
        }

        //private long i_MatchingID;
        //public long I_MatchingID
        //{
        //    get { return i_MatchingID; }
        //    set { i_MatchingID = value; }
        //}

        private long n_BillingEmailID;
        public long N_BillingEmailID
        {
            get { return n_BillingEmailID; }
            set { n_BillingEmailID = value; }
        }

        private string bookingNo;
        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private string contractNo;
        public string ContractNo
        {
            get { return contractNo; }
            set { contractNo = value; }
        }

        private string hotelName;
        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private string companyName;
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        //private long m_CompanyID;

        //public long CompanyID
        //{
        //    get { return m_CompanyID; }
        //    set { m_CompanyID = value; }
        //}
        //private string invoiceNo;

        //public string InvoiceNo
        //{
        //    get { return invoiceNo; }
        //    set { invoiceNo = value; }
        //}

        private string travellerName;
        public string TravellerName
        {
            get { return travellerName; }
            set { travellerName = value; }
        }

        private V_DateRange checkout;
        public V_DateRange Checkout
        {
            get { return checkout; }
            set { checkout = value; }
        }

        private V_Pagination_ForMatching pagination;

        public V_Pagination_ForMatching Pagination
        {
            get { return pagination; }
            set { pagination = value; }
        }

        private string dateRange;
        public string DateRange
        {
            get { return dateRange; }
            set { dateRange = value; }
        }

        private string bookingType; //new, matched, both
        public string BookingType
        {
            get { return bookingType; }
            set { bookingType = value; }
        }

        public P_Matching_Search()
        {
            Checkout = new V_DateRange();
            Pagination = new V_Pagination_ForMatching();
        }
    }


    public class P_Matching_SearchExtened : P_Matching_Search
    {
        public string InvoiceNo { get; set; }
    }

    #region Image
    public class P_Matching_Img
    {
        public long? I_ImageID { get; set; }
        public bool? IsGateway { get; set; }
        public bool IHighPriority { get; set; }
        public List<P_Matching_Img_Page> ListPage { get; set; }
        

        public P_Matching_Img()
        {
            ListPage = new List<P_Matching_Img_Page>();
        }
    }

    public class P_Matching_Img_Page
    {
        public long ID { get; set; }
        public string IISPath { get; set; }
        public int Rotate { get; set; }

    }

    public class P_Matching_Img_Compare : P_Matching_Img_Page
    {
        public string ImageStatus { get; set; }
        public bool IsReplace { get; set; }
        public bool IsUseOldData { get; set; }
        public bool IsExportedVTI { get; set; }
        public bool IsGatewayInvoice { get; set; }
        public bool AutoUseOldData { get; set; }
        public bool IsSpecialCase { get; set; }
        public List<P_Matching_ErrorCode> ListErrorCode { get; set; }
    }
    #endregion

    #region Booking

    public class P_Matching_ListReservation
    {
        public long TotalRecord { get; set; }
        public List<P_Matching_Reservation_New> ListBooking { get; set; }
    }

    public class P_Matching_Reservation
    {
        public long M_HotelPlatformID { get; set; }
        public long M_ProcessID { get; set; }
        public long B_AccessID { get; set; }
        public string BookingNo { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public List<P_Matching_Traveller> ListTraveller { get; set; }

        public List<P_Matching_FIN> ListFIN { get; set; }

        public decimal Amount { get; set; }
        public string Currency { get; set; }

        public bool IsCopy
        {
            get
            {
                return IsMatch && !(M_ProcessID == (int)ProcessType.Basic || M_ProcessID == (int)ProcessType.ContractedMerchant);
            }
        }

        public bool IsMatch
        {
            get
            {
                return !(
                            (
                                (M_ProcessID == (int)ProcessType.NonContractedMerchant || M_ProcessID == (int)ProcessType.ContractedMerchant)
                                && ListTraveller.Where(s => s.TravellerStatus == 1).Count() == ListTraveller.Count
                            )
                            || (ListTraveller.Where(s => s.TravellerStatus == -1).Count() == ListTraveller.Count)
                        )
                    ;
            }
        }

        public P_Matching_Reservation()
        {
            M_HotelPlatformID = 0;
            M_ProcessID = 0;
            B_AccessID = 0;
            BookingNo = string.Empty;
            HotelName = string.Empty;
            HotelAddress = string.Empty;
            CompanyName = string.Empty;
            CompanyAddress = string.Empty;
            ListTraveller = new List<P_Matching_Traveller>();
            ListFIN = new List<P_Matching_FIN>();
            Amount = 0;
            Currency = string.Empty;

        }
    }

    public class P_Matching_Reservation_New : P_Matching_Reservation
    {
        public bool IsPrepaid
        {
            get
            {
                return (M_ProcessID == (int)ProcessType.NonContractedMerchant || M_ProcessID == (int)ProcessType.ContractedMerchant)
                    && ListTraveller.Where(s => s.TravellerStatus == 1).Count() > 0;
            }
        }

        public bool IsDeposit
        {
            get
            {
                return IsMatch && M_ProcessID != (int)ProcessType.Basic;
            }
        }
    }

    public class P_Matching_Reservation_Matched : P_Matching_Reservation
    {
        public List<P_Matching_Img_Compare> ListImage { get; set; }

        public List<string> ListAllowedServiceCode { get; set; }
    }

    #endregion


    public enum P_MatchingProcedure
    {
        p_P_Matching_LoadingCompany,
        p_P_Matching_LoadingHotel,
        p_P_Matching_LoadingTraveller,
        p_P_Matching_Gateway_UpdateCIGStatus,
        p_P_Matching_CheckLockingStatus,
        p_P_Matching_GetImageNextStep,
        p_P_Matching_GetSuggestion,
        p_P_Matching_GetNewBooking,
        p_P_Matching_GetNewBooking_Count,
        p_P_Matching_GetMatchedBooking,
        p_P_Matching_GetMatchedBooking_Count,
        p_P_Matching_GetImagePages,
        p_P_Matching_GetTotalImageNumber,
        p_P_Matching_GetListImageMatched_By_B_AccessID,
        p_P_Matching_GetImageNextStep2,
        p_P_Meetago_Matching_GetMatchedBooking,
        p_P_Meetago_Matching_GetMatchedBooking_Count,
        p_P_Meetago_Matching_GetNewBooking,
        p_P_Meetago_Matching_GetNewBooking_Count,
        p_P_Matching_GetListBookerName,
        p_P_ReviewDuplicated_CheckLockingStatus,
        p_P_ReviewDuplicated_GetImage,
        p_P_ReviewDuplicated_GetTotalImageNumber,
        p_P_ReviewDuplicated_GetMatchedBooking_Count,
        p_P_ReviewDuplicate_GetMatchedBooking
    }

    public class vm_MatchingParam
    {
        public string ActionType { get; set; }
        public long N_BillingEmailID { get; set; }
        public long I_ImageID { get; set; }
        public long B_AccessID { get; set; }
        public bool IsCopy { get; set; }
        public long I_ReplacedID { get; set; }
        public bool IsUseOldData { get; set; }
        public bool IsGatewayInvoice { get; set; }
        public List<P_Matching_Img_Page> ListPage { get; set; }
        public string Comment { get; set; }
        public string BookingNoSC { get; set; }
        public string InvoiceNoSC { get; set; }
        public long DuplicatedID { get; set; }

        public bool IsInformationInvoice { get; set; }
        public vm_MatchingParam()
        {
            ActionType = string.Empty;
            N_BillingEmailID = 0;
            I_ImageID = 0;
            B_AccessID = 0;
            IsCopy = false;
            I_ReplacedID = 0;
            IsUseOldData = false;
            ListPage = new List<P_Matching_Img_Page>();
            Comment = string.Empty;
            BookingNoSC = string.Empty;
            InvoiceNoSC = string.Empty;
            DuplicatedID = 0;
            IsInformationInvoice = false;
        }
    }
}
