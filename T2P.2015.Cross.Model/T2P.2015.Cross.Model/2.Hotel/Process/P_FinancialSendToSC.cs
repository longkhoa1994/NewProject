using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_FinancialSendToSC
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _finID;

        public string FinID
        {
            get { return _finID; }
            set { _finID = value; }
        }

        private string _amount;

        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _reservationNumber;

        public string ReservationNumber
        {
            get { return _reservationNumber; }
            set { _reservationNumber = value; }
        }

        private string _travelerName;

        public string TravelerName
        {
            get { return _travelerName; }
            set { _travelerName = value; }
        }

        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
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
    }
}
