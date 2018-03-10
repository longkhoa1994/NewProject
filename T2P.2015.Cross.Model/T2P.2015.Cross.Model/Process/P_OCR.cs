using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Utility.OCR;

namespace T2P._2015.Cross.Model
{

    public class P_OCRPage
    {
        O_Page o_Page;

        public O_Page O_Page
        {
            get { return o_Page; }
            set { o_Page = value; }
        }
        O_PageDetail o_PageDetail;

        public O_PageDetail O_PageDetail
        {
            get { return o_PageDetail; }
            set { o_PageDetail = value; }
        }
        List<O_PageSuggestion> listO_PageSuggestion;

        public List<O_PageSuggestion> ListO_PageSuggestion
        {
            get { return listO_PageSuggestion; }
            set { listO_PageSuggestion = value; }
        }
        List<P_RowPage> listP_RowPage;

        public List<P_RowPage> ListP_RowPage
        {
            get { return listP_RowPage; }
            set { listP_RowPage = value; }
        }

        List<P_RowPageTemplate> p_PageTemplare;

        public List<P_RowPageTemplate> P_PageTemplare
        {
            get { return p_PageTemplare; }
            set { p_PageTemplare = value; }
        }

        private List<O_Suggestion> listSuggestion;

        public List<O_Suggestion> ListSuggestion
        {
            get { return listSuggestion; }
            set { listSuggestion = value; }
        }


        List<DateTime> listDateOCR;

        public List<DateTime> ListDateOCR
        {
            get { return listDateOCR; }
            set { listDateOCR = value; }
        }

        public P_OCRPage()
        {
            O_Page = new O_Page();
            O_PageDetail = new O_PageDetail();
            listO_PageSuggestion = new List<O_PageSuggestion>();
            ListP_RowPage = new List<P_RowPage>();
            ListSuggestion = new List<O_Suggestion>();
            P_PageTemplare = new List<P_RowPageTemplate>();
        }


    }
    public class P_RowPageTemplate
    {
        string templateName;

        public string TemplateName
        {
            get { return templateName; }
            set { templateName = value; }
        }
        List<P_RowPage> listP_RowPage;

        public List<P_RowPage> ListP_RowPage
        {
            get { return listP_RowPage; }
            set { listP_RowPage = value; }
        }

        public P_RowPageTemplate()
        {
            TemplateName = string.Empty;
            ListP_RowPage = new List<P_RowPage>();
        }
    }
    public class P_RowPage
    {
        O_RowPage o_RowPage;

        public O_RowPage O_RowPage
        {
            get { return o_RowPage; }
            set { o_RowPage = value; }
        }
        List<O_WordPage> listO_WordPage;

        public List<O_WordPage> ListO_WordPage
        {
            get { return listO_WordPage; }
            set { listO_WordPage = value; }
        }

        public P_RowPage()
        {
            O_RowPage = new O_RowPage();
            ListO_WordPage = new List<O_WordPage>();
        }

    }

    public class P_Booking_OCR : ICloneable
    {
        private long _ID;

        public long ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private long m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return m_HotelPlatformID; }
            set { m_HotelPlatformID = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private DateTime checkIn;

        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        private DateTime checkOut;

        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        private long hotelID;

        public long HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }

        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private string hoteAddress;

        public string HoteAddress
        {
            get { return hoteAddress; }
            set { hoteAddress = value; }
        }

        private string hotelZipCode;

        public string HotelZipCode
        {
            get { return hotelZipCode; }
            set { hotelZipCode = value; }
        }

        private string hotelCity;

        public string HotelCity
        {
            get { return hotelCity; }
            set { hotelCity = value; }
        }

        private string hotelCountry;

        public string HotelCountry
        {
            get { return hotelCountry; }
            set { hotelCountry = value; }
        }

        private long companyID;

        public long CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private string companyShortName;

        public string CompanyShortName
        {
            get { return companyShortName; }
            set { companyShortName = value; }
        }

        private string companyAddress;

        public string CompanyAddress
        {
            get { return companyAddress; }
            set { companyAddress = value; }
        }

        private string _companyVatCode;
        public string CompanyVATNumber
        {
            get { return _companyVatCode; }
            set { _companyVatCode = value; }
        }

        private string companyZipCode;

        public string CompanyZipCode
        {
            get { return companyZipCode; }
            set { companyZipCode = value; }
        }

        private string companyCity;

        public string CompanyCity
        {
            get { return companyCity; }
            set { companyCity = value; }
        }

        private string companyCountry;

        public string CompanyCountry
        {
            get { return companyCountry; }
            set { companyCountry = value; }
        }

        private int noOfInvoice;

        public int NoOfInvoice
        {
            get { return noOfInvoice; }
            set { noOfInvoice = value; }
        }
        private string travelerName;

        public string TravelerName
        {
            get { return travelerName; }
            set { travelerName = value; }
        }


        private long m_ProcessID;

        public long M_ProcessID
        {
            get { return m_ProcessID; }
            set { m_ProcessID = value; }
        }
        private int noOfFIN;

        public int NoOfFIN
        {
            get { return noOfFIN; }
            set { noOfFIN = value; }
        }
        private string bookingStatus;

        public string BookingStatus
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }

        private string hotelEmail;

        public string HotelEmail
        {
            get { return hotelEmail; }
            set { hotelEmail = value; }
        }

        private string hotelVATNumber;

        public string HotelVATNumber
        {
            get { return hotelVATNumber; }
            set { hotelVATNumber = value; }
        }

        //private List<M_Traveler> listTraveler;

        //public List<M_Traveler> ListTraveler
        //{
        //    get { return listTraveler; }
        //    set { listTraveler = value; }
        //}

        //private List<P_OCRDate> listCheckin;

        //public List<P_OCRDate> ListCheckin
        //{
        //    get { return listCheckin; }
        //    set { listCheckin = value; }
        //}

        //private List<P_OCRDate> listCheckout;

        //public List<P_OCRDate> ListCheckout
        //{
        //    get { return listCheckout; }
        //    set { listCheckout = value; }
        //}



        //public P_Booking_OCR()
        //{
        //    ListTraveler = new List<M_Traveler>();
        //    ListCheckin = new List<P_OCRDate>();
        //    ListCheckout = new List<P_OCRDate>();
        //}

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public enum P_Booking_OCR_Procedure
    {
        p_B_Booking_Get_ForOCR
    }

    public class P_OCRDate
    {
        private string date;

        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        private int position;

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        private DateTime oCRDate;

        public DateTime OCRDate
        {
            get { return oCRDate; }
            set { oCRDate = value; }
        }

        private List<string> listDate;

        public List<string> ListDate
        {
            get { return listDate; }
            set { listDate = value; }
        }

        public P_OCRDate()
        {
            ListDate = new List<string>();

        }
    }



}
