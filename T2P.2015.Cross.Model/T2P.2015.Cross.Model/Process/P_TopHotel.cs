using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_TopHotel
    {
        public string FileLocal { get; set; }
        public long TotalRecord { get; set; }
        public List<P_TopHotel_Service> ListTab1 { get; set; }
        public List<P_TopHotel_BookingService> ListTab2 { get; set; }
    }

    public enum P_TopHotelProcedure
    {
        p_Report_Top_Hotel_Service,
        p_Report_Top_Hotel_Booking_Service
    }

    public class P_TopHotel_BookingService
    {
        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private long _hotelID;

        public long HotelID
        {
            get { return _hotelID; }
            set { _hotelID = value; }
        }

        private string _currencyCode;

        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        private decimal _otherAmount;

        public decimal OtherAmount
        {
            get { return _otherAmount; }
            set { _otherAmount = value; }
        }

        private decimal _nosAmount;

        public decimal NOSAmount
        {
            get { return _nosAmount; }
            set { _nosAmount = value; }
        }

        private decimal _breAmount;

        public decimal BREAmount
        {
            get { return _breAmount; }
            set { _breAmount = value; }
        }

        private decimal _logAmount;

        public decimal LOGAmount
        {
            get { return _logAmount; }
            set { _logAmount = value; }
        }

        private decimal _invoiceAmount;

        public decimal InvoiceAmount
        {
            get { return _invoiceAmount; }
            set { _invoiceAmount = value; }
        }

        private decimal _grossAmount;

        public decimal GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        private DateTime _checkOut;

        public DateTime CheckOut
        {
            get { return _checkOut; }
            set { _checkOut = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string _hotelNo;

        public string HotelNo
        {
            get { return _hotelNo; }
            set { _hotelNo = value; }
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

        private string _countryCode;

        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }

        private string _hotelPlatformName;

        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }
    }

    public class P_TopHotel_Service 
    {
        private long _hotelID;

        public long HotelID
        {
            get { return _hotelID; }
            set { _hotelID = value; }
        }

        private string _hotelAddress;

        public string HotelAddress
        {
            get { return _hotelAddress; }
            set { _hotelAddress = value; }
        }

        private string _hotelNo;

        public string HotelNo
        {
            get { return _hotelNo; }
            set { _hotelNo = value; }
        }

        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }

        private string _countryCode;

        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }

        private string _currencyCode;

        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        private int _numberOfBooking;

        public int NumberOfBooking
        {
            get { return _numberOfBooking; }
            set { _numberOfBooking = value; }
        }

        private decimal _otherAmount;

        public decimal OtherAmount
        {
            get { return _otherAmount; }
            set { _otherAmount = value; }
        }

        private decimal _nosAmount;

        public decimal NOSAmount
        {
            get { return _nosAmount; }
            set { _nosAmount = value; }
        }

        private decimal _breAmount;

        public decimal BREAmount
        {
            get { return _breAmount; }
            set { _breAmount = value; }
        }

        private decimal _logAmount;

        public decimal LOGAmount
        {
            get { return _logAmount; }
            set { _logAmount = value; }
        }

        private decimal _invoiceAmount;

        public decimal InvoiceAmount
        {
            get { return _invoiceAmount; }
            set { _invoiceAmount = value; }
        }
    }
}
