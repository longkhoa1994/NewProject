using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_PushData
    {
        private string documentNo;

        public string DocumentNo
        {
            get { return documentNo; }
            set { documentNo = value; }
        }

        private string languageCode;

        public string LanguageCode
        {
            get { return languageCode; }
            set { languageCode = value; }
        }

        private string hotelPlatformName;

        public string HotelPlatformName
        {
            get { return hotelPlatformName; }
            set { hotelPlatformName = value; }
        }

        private string resNo;
        public string ResNo
        {
            get { return resNo; }
            set { resNo = value; }
        }

    }

    public class P_BookingList_Request
    {
        private List<string> listBookingNo;

        public List<string> ListBookingNo
        {
            get { return listBookingNo; }
            set { listBookingNo = value; }
        }

        public P_BookingList_Request()
        {
            ListBookingNo = new List<string>();
        }
    }


    public class P_Booking_Respone
    {
 
        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private string hotelCity;

        public string HotelCity
        {
            get { return hotelCity; }
            set { hotelCity = value; }
        }

        private string hotelCountryCode;

        public string HotelCountryCode
        {
            get { return hotelCountryCode; }
            set { hotelCountryCode = value; }
        }

        private string hotelCountryName;

        public string HotelCountryName
        {
            get { return hotelCountryName; }
            set { hotelCountryName = value; }
        }


        private string hotelZipCode;

        public string HotelZipCode
        {
            get { return hotelZipCode; }
            set { hotelZipCode = value; }
        }
        
        private string hotelAddress;

        public string HotelAddress
        {
            get { return hotelAddress; }
            set { hotelAddress = value; }
        }

        private string traveler;

        public string Traveler
        {
            get { return traveler; }
            set { traveler = value; }
        }

        private DateTime checkin;

        public DateTime Checkin
        {
            get { return checkin; }
            set { checkin = value; }
        }

        private DateTime checkout;

        public DateTime Checkout
        {
            get { return checkout; }
            set { checkout = value; }
        }

    }
}
