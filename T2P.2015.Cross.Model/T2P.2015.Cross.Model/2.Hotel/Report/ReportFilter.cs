using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Report
{
    public class ReportFilter
    {
        #region Report Information
        public DateTime? CreatedDateFrom { get; set; }
        public DateTime? CreatedDateTo { get; set; }
        #endregion
        #region Booking Information
        public DateTime? CheckInFrom { get; set; }
        public DateTime? CheckInTo { get; set; }
        public DateTime? CheckOutFrom { get; set; }
        public DateTime? CheckOutTo { get; set; }
        private string _reservationNo;
        public string ReservationNo
        {
            get
            {
                if (_reservationNo == null) return string.Empty;
                return _reservationNo;
            }
            set
            {
                if (value != null)
                    _reservationNo = value;
            }
        }
        #endregion
        #region Hotel Information
        private string _hotelName;
        public string HotelName
        {
            get
            {
                if (_hotelName == null)
                    return string.Empty;
                return _hotelName;
            }
            set
            {
                if (value != null)
                    _hotelName = value;
            }
        }
        private string _hotelCity;
        public string HotelCity
        {
            get
            {
                if (_hotelCity == null)
                    return string.Empty;
                return _hotelCity;
            }
            set
            {
                if (value != null)
                    _hotelCity = value;
            }
        }
        private string _hotelNo;

        public string HotelNo
        {
            get
            {
                if (_hotelNo == null)
                    return string.Empty;
                return _hotelNo;
            }
            set
            {
                if (value != null)
                    _hotelNo = value;
            }
        }

        private string _countryCode;

        public string CountryCode
        {
            get
            {
                if (_countryCode == null)
                    return string.Empty;
                return _countryCode;
            }
            set { _countryCode = value; }
        }

        private string _currencyCode;

        public string CurrencyCode
        {
            get
            {
                if (_currencyCode == null)
                    return string.Empty;
                return _currencyCode;
            }
            set { _currencyCode = value; }
        }


        public long HotelCountryId { get; set; }
        #endregion
        private string _caller;

        public string Caller
        {
            get
            {
                if (_caller == null)
                    return string.Empty;
                return _caller;
            }
            set { _caller = value; }
        }

        private string _travelerName;

        public string TravelerName
        {
            get
            {
                if (_travelerName == null)
                    return string.Empty;
                return _travelerName;
            }
            set { _travelerName = value; }
        }

    }
}
