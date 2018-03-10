using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_WeeklyLetterToHRS
    {
        private long b_AccessID;

        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }

        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }
        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }
        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string checkIn;

        public string CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }
        private string checkOut;

        public string CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }
        private string traveler;

        public string Traveler
        {
            get { return traveler; }
            set { traveler = value; }
        }
        private string problem;

        public string Problem
        {
            get { return problem; }
            set { problem = value; }
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
