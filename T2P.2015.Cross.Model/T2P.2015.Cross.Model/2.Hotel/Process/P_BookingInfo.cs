using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_BookingInfo
    {
        private long? _reservationNumber;

        public long ? ReservationNumber
        {
            get { return _reservationNumber; }
            set { _reservationNumber = value; }
        }
        private DateTime? _bookingDate;

        public DateTime? BookingDate
        {
            get { return _bookingDate; }
            set { _bookingDate = value; }
        }
        private string _bookerFirstName;

        public string BookerFirstName
        {
            get { return _bookerFirstName; }
            set { _bookerFirstName = value; }
        }
        private string _bookerLastName;

        public string BookerLastName
        {
            get { return _bookerLastName; }
            set { _bookerLastName = value; }
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
        private string _paymentMethod;

        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }
        private string _deloymentID;

        public string DeloymentID
        {
            get { return _deloymentID; }
            set { _deloymentID = value; }
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
        private string _hotelPhone;

        public string HotelPhone
        {
            get { return _hotelPhone; }
            set { _hotelPhone = value; }
        }
        private string _hotelFax;

        public string HotelFax
        {
            get { return _hotelFax; }
            set { _hotelFax = value; }
        }
        private string _hotelEmail;

        public string HotelEmail
        {
            get { return _hotelEmail; }
            set { _hotelEmail = value; }
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
        private string _hotelCountryCode;

        public string HotelCountryCode
        {
            get { return _hotelCountryCode; }
            set { _hotelCountryCode = value; }
        }
        private string _hotelVATNumber;

        public string HotelVATNumber
        {
            get { return _hotelVATNumber; }
            set { _hotelVATNumber = value; }
        }
        private string _hotelTimeZone;

        public string HotelTimeZone
        {
            get { return _hotelTimeZone; }
            set { _hotelTimeZone = value; }
        }
        private string _companyID;

        public string CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }
        private string _customerID;

        public string CustomerID
        {
            get { return _customerID; }
            set { _customerID = value; }
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

        private string _companyCountryCode;

        public string CompanyCountryCode
        {
            get { return _companyCountryCode; }
            set { _companyCountryCode = value; }
        }
        private DateTime? _cancelationDeadline;

        public DateTime? CancelationDeadline
        {
            get { return _cancelationDeadline; }
            set { _cancelationDeadline = value; }
        }
        private DateTime? _cancelationDate;

        public DateTime? CancelationDate
        {
            get { return _cancelationDate; }
            set { _cancelationDate = value; }
        }
        private decimal ? _cancellationFee;

        public decimal ? CancellationFee
        {
            get { return _cancellationFee; }
            set { _cancellationFee = value; }
        }

        private long ? _itemNumber;

        public long ? ItemNumber
        {
            get { return _itemNumber; }
            set { _itemNumber = value; }
        }
        private string _travellerSalutation;

        public string TravellerSalutation
        {
            get { return _travellerSalutation; }
            set { _travellerSalutation = value; }
        }
        private string _travellerFirstName;

        public string TravellerFirstName
        {
            get { return _travellerFirstName; }
            set { _travellerFirstName = value; }
        }
        private string _travellerLastName;

        public string TravellerLastName
        {
            get { return _travellerLastName; }
            set { _travellerLastName = value; }
        }

        private string _travellerEmail;

        public string TravellerEmail
        {
            get { return _travellerEmail; }
            set { _travellerEmail = value; }
        }
        private decimal  _grossAmount;

        public decimal  GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }
        private string _currencyCode;

        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }
        private decimal? _BookingDepositAmout;

        public decimal? BookingDepositAmout
        {
            get { return _BookingDepositAmout; }
            set { _BookingDepositAmout = value; }
        }
        private string _depositRequire;

        public string DepositRequire
        {
            get { return _depositRequire; }
            set { _depositRequire = value; }
        }

        private string _invoiceRecipientEmail;

        public string InvoiceRecipientEmail
        {
            get { return _invoiceRecipientEmail; }
            set { _invoiceRecipientEmail = value; }
        }
        private string _deploymentStatus;

        public string DeploymentStatus
        {
            get { return _deploymentStatus; }
            set { _deploymentStatus = value; }
        }
        private string _allowances;

        public string Allowances
        {
            get { return _allowances; }
            set { _allowances = value; }
        }
        private string _spendType;

        public string SpendType
        {
            get { return _spendType; }
            set { _spendType = value; }
        }
        private bool _isWrongGrossAmount;

        public bool IsWrongGrossAmount
        {
            get { return _isWrongGrossAmount; }
            set { _isWrongGrossAmount = value; }
        }
        private bool _isWrongCancellationFee;

        public bool IsWrongCancellationFee
        {
            get { return _isWrongCancellationFee; }
            set { _isWrongCancellationFee = value; }
        }

        public P_BookingInfo ()
        {
            IsWrongGrossAmount = false;
            IsWrongCancellationFee = false;
        }

    }
    public enum BookingInfo
    {        
        ReservationNumber = 0,
        BookingDate = 1,
        BookerFirstName = 2,
        BookerLastName = 3,
        CheckIn = 4,
        CheckOut = 5,
        PaymentMethod = 6,
        DeploymentID = 7,
        HotelName = 8,
        HotelAddress = 9,
        HotelPhone = 10,
        HotelFax = 11,
        HotelEmail = 12,
        HotelZipCode = 13,
        HotelCity = 14,
        HotelCountryCode = 15,
        HotelVATNumber= 16,
        HotelTimeZone = 17,
        CompanyID = 18,
        CustomerID = 19,
        CompanyName = 20,
        CompanyAddress = 21,
        CompanyZipCode = 22,
        CompanyCity = 23,
        CompanyCountryCode = 24,
        CancellationDeadline = 25,
        CancellationDate = 26,
        CancellationFee =27,
        ItemNumber = 28,
        TravellerSalutation =29,
        TravellerFirstName = 30,
        TravellerLastName = 31,
        TravellerEmail = 32,
        GrossAmount = 33,
        CurrencyCode = 34,
        DepositRequire = 35,
        BookingDepositAmout = 36,
        InvoiceRecipientEmail = 37,
        DeploymentStatus = 38,
        Allowances = 39,
        SpendType = 40,

    }
}
