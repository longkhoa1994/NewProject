using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_HotelDetail
    {
		public string HotelSpecialty { get; set; }
        public string Error { get; set; }
        public string Address { get; set; }
        public M_Country M_Country { get; set; }
        public M_HotelExtend M_Hotel { get; set; }
        public List<P_RoomType> ListHotelRoom { get; set; }
        public List<M_Language> ListCommunicationLanguage { get; set; }
        public List<M_Payment> ListPaymentAccepted { get; set; }
        public List<M_BookingChannel> ListBookingChannel { get; set; }
        public List<M_Facility> ListHotelFacility { get; set; }
        public List<M_HotelContactExtend> ListM_HotelContact { get; set; }
        public M_HotelPayment M_HotelPayment { get; set; }
        public string ListRestrictedFaxNumber { get; set; }
        public List<M_Country> ListM_Country { get; set; }
        public M_Language M_Language { get; set; }
        public List<M_Language> ListM_Language { get; set; }
        public List<decimal> ListM_TimeZone { get; set; }
        public List<string> ListPCIBlackEmails { get; set; }

        public P_HotelDetail()
        {
            Error = string.Empty;
            Address = string.Empty;
            M_Country = new M_Country();
            M_Hotel = new M_HotelExtend();
            ListHotelRoom = new List<P_RoomType>();
            ListCommunicationLanguage = new List<M_Language>();
            ListPaymentAccepted = new List<M_Payment>();
            ListBookingChannel = new List<M_BookingChannel>();
            ListHotelFacility = new List<M_Facility>();
            ListM_HotelContact = new List<M_HotelContactExtend>();
            M_HotelPayment = new M_HotelPayment();

            ListM_Country = new List<M_Country>();
            M_Language = new M_Language();
            ListM_Language = new List<M_Language>();
            ListM_TimeZone = new List<decimal>();

            ListPCIBlackEmails = new List<string>();
        }
    }
    public class M_HotelExtend : M_Hotel
    {
        private string countryCodeNumber;

        public string CountryCodeNumber
        {
            get { return countryCodeNumber; }
            set { countryCodeNumber = value; }
        }

        private string hotelChainName;

        public string HotelChainName
        {
            get { return hotelChainName; }
            set { hotelChainName = value; }
        }

        private string _legalEntity;

        public string LegalEntity
        {
            get { return _legalEntity; }
            set { _legalEntity = value; }
        }

        private string _accommodationType;

        public string AccommodationType
        {
            get { return _accommodationType; }
            set { _accommodationType = value; }
        }

        private string _theme;

        public string Theme
        {
            get { return _theme; }
            set { _theme = value; }
        }

        private string _hotelNumber;
        public string HotelNumber
        {
            get { return _hotelNumber; }
            set { _hotelNumber = value; }
        }

        private bool IsResendPCI { get; set; }

        public List<P_HotelNumber> ListHotelNumber { get; set; }

        public M_HotelExtend()
        {
            ListHotelNumber = new List<P_HotelNumber>();
        }
    }

    public class P_Hotel_ListCommon
    {
        public List<M_Country> ListM_Country { get; set; }
        public List<M_Language> ListM_Language { get; set; }
        public List<M_HotelChain> ListM_HotelChain { get; set; }
        public List<M_Payment> ListM_Payment { get; set; }
        public List<M_BookingChannel> ListM_BookingChannel { get; set; }
        public List<M_Facility> ListM_Facility { get; set; }
        public List<M_RoomType> ListM_RoomType { get; set; }
        public List<M_AccommodationType> ListM_AccommodationType { get; set; }
        public List<M_HotelTheme> ListM_HotelTheme { get; set; }
        public List<M_Currency> ListM_Currency { get; set; }
        //public List<M_HotelPayment> ListM_HotelPayment { get; set; }
        public P_Hotel_ListCommon()
        {
            ListM_Country = new List<M_Country>();
            ListM_Language = new List<M_Language>();
            ListM_HotelChain = new List<M_HotelChain>();
            ListM_Payment = new List<M_Payment>();
            ListM_BookingChannel = new List<M_BookingChannel>();
            ListM_Facility = new List<M_Facility>();
            ListM_RoomType = new List<M_RoomType>();
            ListM_AccommodationType = new List<M_AccommodationType>();
            ListM_Currency = new List<M_Currency>();
            //ListM_HotelPayment = new List<M_HotelPayment>();
        }
    }

    public class P_HotelProcess
    {
        public M_Hotel Hotel { get; set; }
        public List<M_HotelCommunicationLanguage> ListLanguage_Insert { get; set; }
        public List<M_HotelCommunicationLanguage> ListLanguage_Delete { get; set; }
        
        public List<M_HotelFacility> ListFacility_Insert { get; set; }
        public List<M_HotelFacility> ListFacility_Delete { get; set; }

        public List<M_HotelPayment> ListPayment_Insert { get; set; }
        public List<M_HotelPayment> ListPayment_Delete { get; set; }

        public List<M_HotelBookingChannel> ListBookingChannel_Insert { get; set; }
        public List<M_HotelBookingChannel> ListBookingChannel_Delete { get; set; }

        public List<M_HotelRoomType> ListRoomType_Insert { get; set; }
        public List<M_HotelRoomType> ListRoomType_Delete { get; set; }

        public P_HotelProcess() 
        {
            Hotel = new M_Hotel();
            
            ListLanguage_Insert = new List<M_HotelCommunicationLanguage>();
            ListLanguage_Delete = new List<M_HotelCommunicationLanguage>();

            ListFacility_Insert = new List<M_HotelFacility>();
            ListFacility_Delete = new List<M_HotelFacility>();

            ListPayment_Insert = new List<M_HotelPayment>();
            ListPayment_Delete = new List<M_HotelPayment>();

            ListBookingChannel_Insert = new List<M_HotelBookingChannel>();
            ListBookingChannel_Delete = new List<M_HotelBookingChannel>();

            ListRoomType_Insert = new List<M_HotelRoomType>();
            ListRoomType_Delete = new List<M_HotelRoomType>();
        }
    }

}
