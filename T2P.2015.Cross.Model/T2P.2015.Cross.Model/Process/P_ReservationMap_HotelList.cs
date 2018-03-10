using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_ReservationMap_HotelList
    {
        
            private long id;

            public long ID
            {
                get { return id; }
                set { id = value; }
            }
            private string hotelName;

            public string HotelName
            {
                get { return hotelName; }
                set { hotelName = value; }
            }
            private string hotelNo;

            public string HotelNo
            {
                get { return hotelNo; }
                set { hotelNo = value; }
            }
            private string hoteAddress;

            public string HoteAddress
            {
                get { return hoteAddress; }
                set { hoteAddress = value; }
            }
            private string email;

            public string Email
            {
                get { return email; }
                set { email = value; }
            }
            private string fax;

            public string Fax
            {
                get { return fax; }
                set { fax = value; }
            }
            private string cityName;

            public string CityName
            {
                get { return cityName; }
                set { cityName = value; }
            }
            private string countryName;

            public string CountryName
            {
                get { return countryName; }
                set { countryName = value; }
            }

            private string zipCode;

            public string ZipCode
            {
                get { return zipCode; }
                set { zipCode = value; }
            }
            private decimal longitude;

            public decimal Longitude
            {
                get { return longitude; }
                set { longitude = value; }
            }
            private decimal latitude;

            public decimal Latitude
            {
                get { return latitude; }
                set { latitude = value; }
            }
            //private long totalRecord;

            //public long TotalRecord
            //{
            //    get { return totalRecord; }
            //    set { totalRecord = value; }
            //}

            private long totalBooking;

            public long TotalBooking
            {
                get { return totalBooking; }
                set { totalBooking = value; }
            }
    

            private int numberBooking;

            public int NumberBooking
            {
                get { return numberBooking; }
                set { numberBooking = value; }
            }


        
    }

    public class P_ReservationMap_TravelerList
    {
        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private string _traveler;

        public string Traveler
        {
            get { return _traveler; }
            set { _traveler = value; }
        }

        private long _hotelID;

        public long HotelID
        {
            get { return _hotelID; }
            set { _hotelID = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
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

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
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


        private string zipCode;

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

         private string cityName;

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }
	
	     private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
	

        private string flag;

        public string Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        private string hotelPlatformName;

        public string HotelPlatformName
        {
            get { return hotelPlatformName; }
            set { hotelPlatformName = value; }
        }
	

        private long totalRecord;

        public long TotalRecord
        {
            get { return totalRecord; }
            set { totalRecord = value; }
        }

    }
}
