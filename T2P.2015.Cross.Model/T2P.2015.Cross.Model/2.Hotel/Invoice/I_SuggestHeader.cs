using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_SuggestHeader : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _i_ImageID;
        public long? I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }

        private string _bookingNo;
        [Extract]
        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }
        private decimal? _bookingNoThreshold;
        public decimal? BookingNoThreshold
        {
            get { return _bookingNoThreshold; }
            set { _bookingNoThreshold = value; }
        }
        private string _bookingNoCoordinates;
        public string BookingNoCoordinates
        {
            get { return _bookingNoCoordinates; }
            set { _bookingNoCoordinates = value; }
        }

        private string _hotelName;
        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }
        private decimal? _hotelNameThreshold;
        public decimal? HotelNameThreshold
        {
            get { return _hotelNameThreshold; }
            set { _hotelNameThreshold = value; }
        }
        private string _hotelNameCoordinates;
        public string HotelNameCoordinates
        {
            get { return _hotelNameCoordinates; }
            set { _hotelNameCoordinates = value; }
        }

        private string _hotelAddress;
        public string HotelAddress
        {
            get { return _hotelAddress; }
            set { _hotelAddress = value; }
        }
        private decimal? _hotelAddressThreshold;
        public decimal? HotelAddressThreshold
        {
            get { return _hotelAddressThreshold; }
            set { _hotelAddressThreshold = value; }
        }
        private string _hotelAddressCoordinates;
        public string HotelAddressCoordinates
        {
            get { return _hotelAddressCoordinates; }
            set { _hotelAddressCoordinates = value; }
        }

        private string _hotelZipCode;
        public string HotelZipCode
        {
            get { return _hotelZipCode; }
            set { _hotelZipCode = value; }
        }
        private decimal? _hotelZipCodeThreshold;
        public decimal? HotelZipCodeThreshold
        {
            get { return _hotelZipCodeThreshold; }
            set { _hotelZipCodeThreshold = value; }
        }
        private string _hotelZipCodeCoordinates;
        public string HotelZipCodeCoordinates
        {
            get { return _hotelZipCodeCoordinates; }
            set { _hotelZipCodeCoordinates = value; }
        }

        private string _hotelCity;
        public string HotelCity
        {
            get { return _hotelCity; }
            set { _hotelCity = value; }
        }
        private decimal? _hotelCityThreshold;
        public decimal? HotelCityThreshold
        {
            get { return _hotelCityThreshold; }
            set { _hotelCityThreshold = value; }
        }
        private string _hotelCityCoordinates;
        public string HotelCityCoordinates
        {
            get { return _hotelCityCoordinates; }
            set { _hotelCityCoordinates = value; }
        }

        private string _hotelVAT;
        [Extract]
        public string HotelVAT
        {
            get { return _hotelVAT; }
            set { _hotelVAT = value; }
        }
        private decimal? _hotelVATThreshold;
        public decimal? HotelVATThreshold
        {
            get { return _hotelVATThreshold; }
            set { _hotelVATThreshold = value; }
        }
        private string _hotelVATCoordinates;
        public string HotelVATCoordinates
        {
            get { return _hotelVATCoordinates; }
            set { _hotelVATCoordinates = value; }
        }

        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private decimal? _companyNameThreshold;
        public decimal? CompanyNameThreshold
        {
            get { return _companyNameThreshold; }
            set { _companyNameThreshold = value; }
        }
        private string _companyNameCoordinates;
        public string CompanyNameCoordinates
        {
            get { return _companyNameCoordinates; }
            set { _companyNameCoordinates = value; }
        }

        private string _companyAddress;
        public string CompanyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }
        private decimal? _companyAddressThreshold;
        public decimal? CompanyAddressThreshold
        {
            get { return _companyAddressThreshold; }
            set { _companyAddressThreshold = value; }
        }
        private string _companyAddressCoordinates;
        public string CompanyAddressCoordinates
        {
            get { return _companyAddressCoordinates; }
            set { _companyAddressCoordinates = value; }
        }

        private string _companyZipCode;
        public string CompanyZipCode
        {
            get { return _companyZipCode; }
            set { _companyZipCode = value; }
        }
        private decimal? _companyZipCodeThreshold;
        public decimal? CompanyZipCodeThreshold
        {
            get { return _companyZipCodeThreshold; }
            set { _companyZipCodeThreshold = value; }
        }
        private string _companyZipCodeCoordinates;
        public string CompanyZipCodeCoordinates
        {
            get { return _companyZipCodeCoordinates; }
            set { _companyZipCodeCoordinates = value; }
        }

        private string _companyCity;
        public string CompanyCity
        {
            get { return _companyCity; }
            set { _companyCity = value; }
        }
        private decimal? _companyCityThreshold;
        public decimal? CompanyCityThreshold
        {
            get { return _companyCityThreshold; }
            set { _companyCityThreshold = value; }
        }
        private string _companyCityCoordinates;
        public string CompanyCityCoordinates
        {
            get { return _companyCityCoordinates; }
            set { _companyCityCoordinates = value; }
        }

        private string _companyVAT;
        public string CompanyVAT
        {
            get { return _companyVAT; }
            set { _companyVAT = value; }
        }
        private decimal? _companyVATThreshold;
        public decimal? CompanyVATThreshold
        {
            get { return _companyVATThreshold; }
            set { _companyVATThreshold = value; }
        }
        private string _companyVATCoordinates;
        public string CompanyVATCoordinates
        {
            get { return _companyVATCoordinates; }
            set { _companyVATCoordinates = value; }
        }

        private string _traveler;
        [Extract]
        public string Traveler
        {
            get { return _traveler; }
            set { _traveler = value; }
        }

        private decimal? _travelerThreshold;
        public decimal? TravelerThreshold
        {
            get { return _travelerThreshold; }
            set { _travelerThreshold = value; }
        }

        private string _travelerCoordinates;
        public string TravelerCoordinates
        {
            get { return _travelerCoordinates; }
            set { _travelerCoordinates = value; }
        }

        private DateTime? _invoiceDate;
        [Extract]
        public DateTime? InvoiceDate
        {
            get { return _invoiceDate; }
            set { _invoiceDate = value; }
        }

        private decimal? _invoiceDateThreshold;
        public decimal? InvoiceDateThreshold
        {
            get { return _invoiceDateThreshold; }
            set { _invoiceDateThreshold = value; }
        }

        private string _invoiceDateCoordinates;
        public string InvoiceDateCoordinates
        {
            get { return _invoiceDateCoordinates; }
            set { _invoiceDateCoordinates = value; }
        }

        private string _invoiceNo;
        [Extract]
        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }

        private decimal? _invoiceNoThreshold;
        public decimal? InvoiceNoThreshold
        {
            get { return _invoiceNoThreshold; }
            set { _invoiceNoThreshold = value; }
        }

        private string _invoiceNoCoordinates;
        public string InvoiceNoCoordinates
        {
            get { return _invoiceNoCoordinates; }
            set { _invoiceNoCoordinates = value; }
        }

        private DateTime? _checkin;
        [Extract]
        public DateTime? CheckIn
        {
            get { return _checkin; }
            set { _checkin = value; }
        }

        private decimal? _checkinThreshold;
        public decimal? CheckinThreshold
        {
            get { return _checkinThreshold; }
            set { _checkinThreshold = value; }
        }

        private string _checkinCoordinates;
        public string CheckinCoordinates
        {
            get { return _checkinCoordinates; }
            set { _checkinCoordinates = value; }
        }

        private DateTime? _checkout;
        [Extract]
        public DateTime? CheckOut
        {
            get { return _checkout; }
            set { _checkout = value; }
        }

        private decimal? _checkoutThreshold;
        public decimal? CheckoutThreshold
        {
            get { return _checkoutThreshold; }
            set { _checkoutThreshold = value; }
        }

        private string _checkoutCoordinates;
        public string CheckoutCoordinates
        {
            get { return _checkoutCoordinates; }
            set { _checkoutCoordinates = value; }
        }

        private string _currency;
        [Extract]
        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }
        private decimal? _currencyThreshold;
        public decimal? CurrencyThreshold
        {
            get { return _currencyThreshold; }
            set { _currencyThreshold = value; }
        }
        private string _currencyCoordinates;
        public string CurrencyCoordinates
        {
            get { return _currencyCoordinates; }
            set { _currencyCoordinates = value; }
        }

        private decimal? _grossAmount;
        [Extract]
        public decimal? GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        private decimal? _grossAmountThreshold;
        public decimal? GrossAmountThreshold
        {
            get { return _grossAmountThreshold; }
            set { _grossAmountThreshold = value; }
        }

        private string _grossAmountCoordinates;
        public string GrossAmountCoordinates
        {
            get { return _grossAmountCoordinates; }
            set { _grossAmountCoordinates = value; }
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

        private bool? _isCopy;
        public bool? IsCopy
        {
            get { return _isCopy; }
            set { _isCopy = value; }
        }

        private decimal? _imageWidth;
        public decimal? ImageWidth
        {
            get { return _imageWidth; }
            set { _imageWidth = value; }
        }

        private decimal? _imageHeight;
        public decimal? ImageHeight
        {
            get { return _imageHeight; }
            set { _imageHeight = value; }
        }

        private decimal? _ImageSkewAngle;

        public decimal? ImageSkewAngle
        {
            get { return _ImageSkewAngle; }
            set { _ImageSkewAngle = value; }
        }

        public override string Table { get { return "I_SuggestHeader"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_SuggestHeader_InsertOrUpdate"; } }
    }
    public enum I_SuggestHeaderColumns
    {
        ID,
        I_ImageID,

        BookingNo,
        BookingNoThreshold,
        BookingNoCoordinates,

        HotelName,
        HotelNameThreshold,
        HotelNameCoordinates,

        HotelAddress,
        HotelAddressThreshold,
        HotelAddressCoordinates,

        HotelZipCode,
        HotelZipCodeThreshold,
        HotelZipCodeCoordinates,

        HotelCity,
        HotelCityThreshold,
        HotelCityCoordinates,

        HotelVAT,
        HotelVATThreshold,
        HotelVATCoordinates,

        CompanyName,
        CompanyNameThreshold,
        CompanyNameCoordinates,

        CompanyAddress,
        CompanyAddressThreshold,
        CompanyAddressCoordinates,

        CompanyZipCode,
        CompanyZipCodeThreshold,
        CompanyZipCodeCoordinates,

        CompanyCity,
        CompanyCityThreshold,
        CompanyCityCoordinates,

        CompanyVAT,
        CompanyVATThreshold,
        CompanyVATCoordinates,

        Traveler,
        TravelerThreshold,
        TravelerCoordinates,

        InvoiceDate,
        InvoiceDateThreshold,
        InvoiceDateCoordinates,

        InvoiceNo,
        InvoiceNoThreshold,
        InvoiceNoCoordinates,

        Checkin,
        CheckinThreshold,
        CheckinCoordinates,

        Checkout,
        CheckoutThreshold,
        CheckoutCoordinates,

        Currency,
        CurrencyThreshold,
        CurrencyCoordinates,

        GrossAmount,
        GrossAmountThreshold,
        GrossAmountCoordinates,

        ImageWidth,
        ImageHeight,
        ImageSkewAngle,

        VAT,
        Tax,
        IsCopy,
        
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_SuggestHeaderProcedure
    {
        p_I_SuggestHeader_GetBySuggestID,
    }
    public class I_SuggestHeaderList : List<I_SuggestHeader>
    {

    }
}