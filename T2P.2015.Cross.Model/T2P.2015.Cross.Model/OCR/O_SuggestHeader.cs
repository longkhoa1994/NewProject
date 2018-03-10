using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class O_SuggestHeader : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _o_SuggestionID;

        public long? O_SuggestionID
        {
            get { return _o_SuggestionID; }
            set { _o_SuggestionID = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }

        private string _hotelAddress;

        public string HotelAddress
        {
            get { return _hotelAddress; }
            set { _hotelAddress = value; }
        }

        private string _hotelZipCode;

        public string HotelZipCode
        {
            get { return _hotelZipCode; }
            set { _hotelZipCode = value; }
        }

        private string _hotelCity;

        public string HotelCity
        {
            get { return _hotelCity; }
            set { _hotelCity = value; }
        }

        private string _hotelVAT;

        public string HotelVAT
        {
            get { return _hotelVAT; }
            set { _hotelVAT = value; }
        }

        private string _companyname;

        public string Companyname
        {
            get { return _companyname; }
            set { _companyname = value; }
        }

        private string _companyAddress;

        public string CompanyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }

        private string _companyZipCode;

        public string CompanyZipCode
        {
            get { return _companyZipCode; }
            set { _companyZipCode = value; }
        }

        private string _companyCity;

        public string CompanyCity
        {
            get { return _companyCity; }
            set { _companyCity = value; }
        }

        private string _companyVAT;

        public string CompanyVAT
        {
            get { return _companyVAT; }
            set { _companyVAT = value; }
        }

        private string _traveler;

        public string Traveler
        {
            get { return _traveler; }
            set { _traveler = value; }
        }

        private DateTime? _invoiceDate;

        public DateTime? InvoiceDate
        {
            get { return _invoiceDate; }
            set { _invoiceDate = value; }
        }

        private string _invoiceNo;

        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }

        private DateTime? _checkin;

        public DateTime? CheckIn
        {
            get { return _checkin; }
            set { _checkin = value; }
        }

        private DateTime? _checkout;

        public DateTime? CheckOut
        {
            get { return _checkout; }
            set { _checkout = value; }
        }

        private string _currency;

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        private float? _grossAmount;

        public float? GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        private bool? _vAT;

        public bool? VAT
        {
            get { return _vAT; }
            set { _vAT = value; }
        }

        private bool? _tax;

        public bool? Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }

        public override string Table { get { return "O_SuggestHeader"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_SuggestHeader_InsertOrUpdate"; } }
    }

    public enum O_SuggestHeaderColumns
    {
        ID,
        O_SuggestionID,
        BookingNo,
        HotelName,
        HotelAddress,
        HotelZipCode,
        HotelCity,
        HotelVAT,
        Companyname,
        CompanyAddress,
        CompanyZipCode,
        CompanyCity,
        CompanyVAT,
        Traveler,
        InvoiceDate,
        InvoiceNo,
        Checkin,
        Checkout,
        Currency,
        GrossAmount,
        VAT,
        Tax,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum O_SuggestHeaderProcedure
    {
    }

    public class O_SuggestHeaderList : List<O_SuggestHeader>
    {
    }
}