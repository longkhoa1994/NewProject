using System;
using System.Collections.Generic;
using T2P._2015.Cross.Model;

namespace T2P._2015.Cross.Model
{
    public class P_BookingInfo_Email
    {
        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }


        private long _bookingID;

        public long BookingID
        {
            get { return _bookingID; }
            set { _bookingID = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string _paymentMethod;

        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
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

        private long _m_ProcessID;

        public long M_ProcessID
        {
            get { return _m_ProcessID; }
            set { _m_ProcessID = value; }
        }

        private DateTime _bookingDate;

        public DateTime BookingDate
        {
            get { return _bookingDate; }
            set { _bookingDate = value; }
        }

        //company information
        private long _companyID;

        public long CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        private string _iP;

        public string IP
        {
            get { return _iP; }
            set { _iP = value; }
        }

        private string _iISPath;

        public string IISPath
        {
            get { return _iISPath; }
            set { _iISPath = value; }
        }

        private string _logo;

        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _companyAddress;

        public string CompanyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }

        private string _zipCode;

        public string ZIPCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }

        private string _cityName;

        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        private string _signatureImage;

        public string SignatureImage
        {
            get { return _signatureImage; }
            set { _signatureImage = value; }
        }
        private string _filePathLogo;

        public string FilePathLogo
        {
            get { return _filePathLogo; }
            set { _filePathLogo = value; }
        }

        private string _signatureText;

        public string SignatureText
        {
            get { return _signatureText; }
            set { _signatureText = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _fax;

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        private long _m_LanguageID;

        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }

        private string _hotelPlatform;

        public string HotelPlatform
        {
            get { return _hotelPlatform; }
            set { _hotelPlatform = value; }
        }

        private long _hotelPlatformID;

        public long HotelPlatformID
        {
            get { return _hotelPlatformID; }
            set { _hotelPlatformID = value; }
        }

        //booker information
        private string _salutation;

        public string Salutation
        {
            get { return _salutation; }
            set { _salutation = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private List<B_Traveler> _listTraveler;

        public List<B_Traveler> ListTraveler
        {
            get { return _listTraveler; }
            set { _listTraveler = value; }
        }

        //ForFIN
        private long _transactionID;

        public long TransactionID
        {
            get { return _transactionID; }
            set { _transactionID = value; }
        }

        private string _documentNo;

        public string DocumentNo
        {
            get { return _documentNo; }
            set { _documentNo = value; }
        }

        private DateTime _salesDate;

        public DateTime SalesDate
        {
            get { return _salesDate; }
            set { _salesDate = value; }
        }

        private decimal _grossAmount;

        public decimal GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        private string currencyCode;

        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }
        //ForInvoice
        private List<F_Transaction> _listFin;

        public List<F_Transaction> ListFin
        {
            get { return _listFin; }
            set { _listFin = value; }
        }


        private long _invoiceID;

        public long InvoiceID
        {
            get { return _invoiceID; }
            set { _invoiceID = value; }
        }


        private string invoiceNo;

        public string InvoiceNo
        {
            get { return invoiceNo; }
            set { invoiceNo = value; }
        }

        private DateTime? invoiceDate;

        public DateTime? InvoiceDate
        {
            get { return invoiceDate; }
            set { invoiceDate = value; }
        }

        private DateTime? invoiceReceivedDate;

        public DateTime? InvoiceReceivedDate
        {
            get { return invoiceReceivedDate; }
            set { invoiceReceivedDate = value; }
        }

        private List<M_InvoiceErrorCode> _listInvoiceError;

        public List<M_InvoiceErrorCode> ListInvoiceError
        {
            get { return _listInvoiceError; }
            set { _listInvoiceError = value; }
        }

        public string GetIISLogo()
        {
            return this.IISPath + "/" + this.FilePathLogo.Replace("\\", "/") + "/" + this.Logo;
        }

        public string GetLocalLogo()
        {
            return this.IP + "\\" + this.FilePathLogo + "\\" + this.Logo;
        }

        public string GetIISSignature()
        {
            return this.IISPath + "/" + this.FilePathLogo.Replace("\\", "/") + "/" + this.SignatureImage;
        }

        public string GetLocalSignature()
        {
            return this.IP + "\\" + this.FilePathLogo + "\\" + this.SignatureImage;
        }

        public P_BookingInfo_Email()
        {
            ListTraveler = new List<B_Traveler>();
            ListFin = new List<F_Transaction>();
            ListInvoiceError = new List<M_InvoiceErrorCode>();
        }
    }
}