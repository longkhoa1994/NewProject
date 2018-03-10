using System;
using System.Collections.Generic;
using T2P._2015.Cross.Enum;
using T2P._2015.Cross.Model.Report;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model.Process
{
    [Serializable]
    public class P_TimGatewayDesk
    {
        public long ID { get; set; }

        public string CompanyName { get; set; }

        public string CountryFlag { get; set; }

        public string ListContact { get; set; }

        public string Address { get; set; }

        public int ExpectedInvoice { get; set; }

        public long TotalRecord { get; set; }

        private string _hotelPlatformName;

        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }

        private long b_AccessID;

        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private int overdue;

        public int Overdue
        {
            get { return overdue; }
            set { overdue = value; }
        }

        private DateTime checkOut;

        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        private DateTime checkIn;

        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

       
        private long relatedID;

        public long RelatedID
        {
            get { return relatedID; }
            set { relatedID = value; }
        }

        private long i_ImageID;

        public long I_ImageID
        {
            get { return i_ImageID; }
            set { i_ImageID = value; }
        }

        private string information;

        public string Information
        {
            get { return information; }
            set { information = value; }
        }

        private string additionInformation;

        public string AdditionInformation
        {
            get { return additionInformation; }
            set { additionInformation = value; }
        }

        private string _travelerName;

        public string TravelerName
        {
            get { return _travelerName; }
            set { _travelerName = value; }
        }

        private string _travelerID;

        public string TravelerID
        {
            get { return _travelerID; }
            set { _travelerID = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private DateTime? informationDate;

        public DateTime? InformationDate
        {
            get { return informationDate; }
            set { informationDate = value; }
        }

        private List<P_InvoiceError_Image> _listErrorCode;

        public List<P_InvoiceError_Image> ListErrorCode
        {
            get { return _listErrorCode; }
            set { _listErrorCode = value; }
        }

        private long numberOfBooking;

        public long NumberOfBooking
        {
            get { return numberOfBooking; }
            set { numberOfBooking = value; }
        }

        private string serviceCodes;

        public string ServiceCodes
        {
            get { return serviceCodes; }
            set { serviceCodes = value; }
        }


        private long noOfInvoice;

        public long NoOfInvoice
        {
            get { return noOfInvoice; }
            set { noOfInvoice = value; }
        }

        private long noOfFin;

        public long NoOfFin
        {
            get { return noOfFin; }
            set { noOfFin = value; }
        }

        private string iR1;

        public string IR1
        {
            get { return iR1; }
            set { iR1 = value; }
        }

        private string iR2;

        public string IR2
        {
            get { return iR2; }
            set { iR2 = value; }
        }

        private string bc1;

        public string BC1
        {
            get { return bc1; }
            set { bc1 = value; }
        }

        private string bc2;

        public string BC2
        {
            get { return bc2; }
            set { bc2 = value; }
        }

        private string fc1;

        public string FC1
        {
            get { return fc1; }
            set { fc1 = value; }
        }

        private string fc2;

        public string FC2
        {
            get { return fc2; }
            set { fc2 = value; }
        }

        private string tab;

        public string Tab
        {
            get { return tab; }
            set { tab = value; }
        }

        private string bookingStatus;

        public string BookingStatus
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }

        
    }

    public class P_TimGatewayDesk_Request : V_Pagination
    {
        private string _resNo;
        public string ResNo
        {
            get { return _resNo; }
            set { _resNo = value; }
        }

        private long _companyID;

        public long CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        private DateTime? _checkoutFrom;

        public DateTime? CheckoutFrom
        {
            get { return _checkoutFrom; }
            set { _checkoutFrom = value; }
        }

        private DateTime? _checkoutTo;

        public DateTime? CheckoutTo
        {
            get { return _checkoutTo; }
            set { _checkoutTo = value; }
        }

        private DateTime? _checkinFrom;

        public DateTime? CheckinFrom
        {
            get { return _checkinFrom; }
            set { _checkinFrom = value; }
        }

        private DateTime? _checkinTo;

        public DateTime? CheckinTo
        {
            get { return _checkinTo; }
            set { _checkinTo = value; }
        }

        private string _traveler;
        public string Traveler
        {
            get { return _traveler; }
            set { _traveler = value; }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


        private string _orderByDetail;

        public string OrderByDetail
        {
            get { return _orderByDetail; }
            set { _orderByDetail = value; }
        }

        private string _orderDirectionDetail;

        public string OrderDirectionDetail
        {
            get { return _orderDirectionDetail; }
            set { _orderDirectionDetail = value; }
        }

        private bool _isSearch;

        public bool IsSearch
        {
            get { return _isSearch; }
            set { _isSearch = value; }
        }

        private string _pageDetail;

        public string PageDetail
        {
            get { return _pageDetail; }
            set { _pageDetail = value; }
        }

        private string _pageSizeDetail;

        public string PageSizeDetail
        {
            get { return _pageSizeDetail; }
            set { _pageSizeDetail = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
    }

    public class P_TimGatewayDesk_DataInvoice
    {
        public P_TimGatewayDesk_HeaderInvoice HeaderInvoice { get; set; }
    }

     public class P_TimGatewayDesk_HeaderInvoice
     {
         public long BAccessID { get; set; }

         public string HotelName { get; set; }

         public string HoteAddress { get; set; }

         public string HotelZIPCode { get; set; }

         public string HotelCity { get; set; }

         public string HotelCountry { get; set; }

         public string CompanyName { get; set; }

         public string CompanyAddress { get; set; }

         public string CompanyZIPCode { get; set; }

         public string CompanyCity { get; set; }

         public string CompanyCountry { get; set; }

         public string BookingNo { get; set; }

         public DateTime? CheckInDate { get; set; }

         public DateTime? CheckOutDate { get; set; }
     }


    public enum P_TimGatewayDeskProcedure
    {
        p_P_TimGatewayDesk_Get_Open,
        p_P_TimGatewayDesk_Get_Open_Detail,
        p_P_TimGetwayDesk_Get_CommentHistory,
        p_P_TimGatewayDesk_Get_Incoming,
        p_P_TimGatewayDesk_Get_Incoming_Detail,
        p_P_TimGatewayDesk_Get_Finish,
        p_P_TimGatewayDesk_Get_Finish_Detail,
        p_P_TimGatewayDesk_Get_ServiceCode,
        p_P_TimGetwayDesk_GetHeaderIvoice,
        p_P_TimGetwayDesk_Get_TravelerHistory,
        p_P_TimGetwayDesk_Get_InvoiceData
    }
}