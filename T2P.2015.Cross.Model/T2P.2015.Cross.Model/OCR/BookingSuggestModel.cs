using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.OCR
{
    [Serializable]
    public class BookingSuggestModel
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _hotelName;
        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }

        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _travelerName;
        public string TravelerName
        {
            get { return _travelerName; }
            set { _travelerName = value; }
        }

        private DateTime? _checkInDate;
        public DateTime? CheckInDate
        {
            get { return _checkInDate; }
            set { _checkInDate = value; }
        }

        private DateTime? _checkOutDate;
        public DateTime? CheckOutDate
        {
            get { return _checkOutDate; }
            set { _checkOutDate = value; }
        }
    }

    [Serializable]
    public class SuggestBookingForm {

        private string _bookingNumber;
        public string BookingNumber
        {
            get { return _bookingNumber; }
            set { _bookingNumber = value; }
        }

        private List<string> _travelerNames;
        public List<string> TravelerNames
        {
            get { return _travelerNames; }
            set { _travelerNames = value; }
        }

        private Dictionary<long, string> _hotelNames;
        public Dictionary<long, string> HotelNames
        {
            get { return _hotelNames; }
            set { _hotelNames = value; }
        }

        private List<string> _companyNames;
        public List<string> CompanyNames
        {
            get { return _companyNames; }
            set { _companyNames = value; }
        }

        private DateTime? _checkIn;
        public DateTime? CheckIn
        {
            get { return _checkIn; }
            set { _checkIn = value; }
        }

        private DateTime? _checkOut;
        public DateTime? CheckOut
        {
            get { return _checkOut; }
            set { _checkOut = value; }
        }
    }
}
