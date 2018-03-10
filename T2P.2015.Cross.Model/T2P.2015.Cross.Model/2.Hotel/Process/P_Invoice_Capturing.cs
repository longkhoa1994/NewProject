using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model._2.Hotel.Invoice;

namespace T2P._2015.Cross.Model
{
    public class P_InvoiceCaptureList
    {
        private bool _checkForward;

        public bool CheckForward
        {
            get { return _checkForward; }
            set { _checkForward = value; }
        }

        private long _imageID;

        public long ImageID
        {
            get { return _imageID; }
            set { _imageID = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }

        private DateTime _processedDate;

        public DateTime ProcessedDate
        {
            get { return _processedDate; }
            set { _processedDate = value; }
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

        private int page;

        public int Page
        {
            get { return page; }
            set { page = value; }
        }

        private int pageSize;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        private string orderBy;

        public string OrderBy
        {
            get { return orderBy; }
            set { orderBy = value; }
        }

        private string orderDirection;

        public string OrderDirection
        {
            get { return orderDirection; }
            set { orderDirection = value; }
        }

        private bool _isLocked;

        public bool IsLocked
        {
            get { return _isLocked; }
            set { _isLocked = value; }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private DateTime _updatedDate;

        public DateTime UpdatedDate
        {
            get { return _updatedDate; }
            set { _updatedDate = value; }
        }
        private long _updatedBy;

        public long UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }

        private string _hotelPlatformName;

        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }

        private int _totalRecords;

        public int TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }

        private string _processName;

        public string ProcessName
        {
            get { return _processName; }
            set { _processName = value; }
        }

        public string ContractNumber { get; set; }

        public string EventNo { get; set; }

        public long EventID { get; set; }

    }
    public class P_InvoiceValidateInfo
    {
        public bool GrossHigher150 { get; set; }
        public bool IsEuropeanUnion { get; set; }
        public bool IsPremiumReverse { get; set; }
        public bool IsDomesticInvoice { get; set; }
        public bool IsGermanInvoice { get; set; }

        public string HotelCountryCode { get; set; }

        public List<M_ServiceCodeTax> ListServiceCodeTax { get; set; }
    }

    public class P_Booking_LastCapture
    {
        public string B_AccessID { get; set; }
        public string BookingNo { get; set; }
    }

    public class P_Invoice_Capture
    {
        public I_Suggestion I_Suggestion { get; set; }
        public I_InvoiceCapture I_Image { get; set; }
        public I_SuggestHeader I_SuggestHeader { get; set; }
        public List<I_SuggestPosition> ListI_SuggestPosition { get; set; }
        public List<I_SuggestTax> ListI_SuggestTax { get; set; }
        public List<I_SuggestError> ListI_SuggestError { get; set; }
        public List<M_Currency> ListCurrency { get; set; }
        public List<M_ServiceCodeTax> ListService { get; set; }
        public List<P_I_ImageCorrection> ListImage { get; set; }
        public List<M_ServiceCodeTax> ListServiceCode { get; set; }
        public bool IsAutoAddTax { get; set; }
        public List<I_InvoiceCapture> ListOldI_Image { get; set; }

        public List<P_Booking_LastCapture> ListLastCapture { get; set; }


        public P_Invoice_Capture()
        {
            I_Image = new I_InvoiceCapture();
            I_Suggestion = new I_Suggestion();
            I_SuggestHeader = new I_SuggestHeader();
            ListI_SuggestPosition = new List<I_SuggestPosition>();
            ListI_SuggestTax = new List<I_SuggestTax>();
            ListI_SuggestError = new List<I_SuggestError>();
            ListLastCapture = new List<P_Booking_LastCapture>();
        }
    }

    public class P_Invoice_CaptureExtend : P_Invoice_Capture
    {
        public string InvoiceNoSC { get; set; }
        public string BillingEmail { get; set; }
    }

    //public partial class I_Suggestion
    //{
    //private string companyName;

    //public string CompanyName
    //{
    //    get { return companyName; }
    //    set { companyName = value; }
    //}

    //private string companyAddress;

    //public string CompanyAddress
    //{
    //    get { return companyAddress; }
    //    set { companyAddress = value; }
    //}

    //private string companyZipCode;

    //public string CompanyZipCode
    //{
    //    get { return companyZipCode; }
    //    set { companyZipCode = value; }
    //}

    //private string companyCity;

    //public string CompanyCity
    //{
    //    get { return companyCity; }
    //    set { companyCity = value; }
    //}

    //private string companyCountry;

    //public string CompanyCountry
    //{
    //    get { return companyCountry; }
    //    set { companyCountry = value; }
    //}

    //private string companyCountryCode;

    //public string CompanyCountryCode
    //{
    //    get { return companyCountryCode; }
    //    set { companyCountryCode = value; }
    //}

    //private string companyVAT;

    //public string CompanyVAT
    //{
    //    get { return companyVAT; }
    //    set { companyVAT = value; }
    //}


    //private string hotelName;

    //public string HotelName
    //{
    //    get { return hotelName; }
    //    set { hotelName = value; }
    //}

    //private string hotelAddress;

    //public string HotelAddress
    //{
    //    get { return hotelAddress; }
    //    set { hotelAddress = value; }
    //}

    //private string hotelZipCode;

    //public string HotelZipCode
    //{
    //    get { return hotelZipCode; }
    //    set { hotelZipCode = value; }
    //}

    //private string hotelCity;

    //public string HotelCity
    //{
    //    get { return hotelCity; }
    //    set { hotelCity = value; }
    //}

    //private string hotelCountry;

    //public string HotelCountry
    //{
    //    get { return hotelCountry; }
    //    set { hotelCountry = value; }
    //}

    //private string hotelCountryCode;

    //public string HotelCountryCode
    //{
    //    get { return hotelCountryCode; }
    //    set { hotelCountryCode = value; }
    //}

    //private string hotelVAT;

    //public string HotelVAT
    //{
    //    get { return hotelVAT; }
    //    set { hotelVAT = value; }
    //}

    //private string bookingNo;

    //public string BookingNo
    //{
    //    get { return bookingNo; }
    //    set { bookingNo = value; }
    //}

    //private DateTime checkin;

    //public DateTime BCheckin
    //{
    //    get { return checkin; }
    //    set { checkin = value; }
    //}

    //private DateTime checkout;

    //public DateTime BCheckout
    //{
    //    get { return checkout; }
    //    set { checkout = value; }
    //}

    //private long _hotelCountryID;

    //public long HotelCountryID
    //{
    //    get { return _hotelCountryID; }
    //    set { _hotelCountryID = value; }
    //}

    //}

    public enum P_InvoiceCaptureProcedure
    {
        p_InvoiceCapture_Get_ListSearch,
        //for meetago
        p_M_InvoiceCapture_Get_ListSearch
    }

}
