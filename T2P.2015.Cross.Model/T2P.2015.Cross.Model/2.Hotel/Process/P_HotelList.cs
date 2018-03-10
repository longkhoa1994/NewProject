using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Hotel
    {
        private bool _isHotelPermission;

        public bool IsHotelPermission
        {
            get { return _isHotelPermission; }
            set { _isHotelPermission = value; }
        }

        private long totalRecord;

        public long TotalRecord
        {
            get { return totalRecord; }
            set { totalRecord = value; }
        } 

        public List<P_HotelList> ListHotel { get; set; }

        public P_Hotel()
        {
            IsHotelPermission = false;
            TotalRecord = 0;
            ListHotel = new List<P_HotelList>();
        }
    }

    public class P_HotelList 
    {
        private int _hotelGateway;

        public int HotelGateway
        {
            get { return _hotelGateway; }
            set { _hotelGateway = value; }
        }

        //public List<M_HotelContact> ListHotelContact { get; set; }

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

        public List<P_HotelNumber> ListHotelNumber { get; set; }

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

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
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
        private int hotelContact;

        public int HotelContact
        {
            get { return hotelContact; }
            set { hotelContact = value; }
        }
        private int traveller;

        public int Traveller
        {
            get { return traveller; }
            set { traveller = value; }
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

        private long b_AccessID;

        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }

        private string fullName;

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public string ListContact { get; set; }

        public string ListTraveler { get; set; }
        private string hotelChainName;

        public string HotelChainName
        {
            get { return hotelChainName; }
            set { hotelChainName = value; }
        }

        private long totalRecord;

        public long TotalRecord
        {
            get { return totalRecord; }
            set { totalRecord = value; }
        }
       

        public DateTime? UpdatedDate { get; set; }

        public P_HotelList()
        {
            ListHotelNumber = new List<P_HotelNumber>();
        }
    }

    public class P_Traveler
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }
        private string _salutation;


        public string Salutation
        {
            get { return _salutation; }
            set { _salutation = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;


        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _email;


        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _phone;


        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
    }

    public class P_HotelChainList
    {
        public List<M_HotelChain_Keyword> ListKeyword { get; set; }

        public List<M_Country> ListCountry { get; set; }

        private long m_HotelChainID;

        public long M_HotelChainID
        {
            get { return m_HotelChainID; }
            set { m_HotelChainID = value; }
        }
        private long m_HotelID;

        public long M_HotelID
        {
            get { return m_HotelID; }
            set { m_HotelID = value; }
        }
        private string hotelChainName;

        public string HotelChainName
        {
            get { return hotelChainName; }
            set { hotelChainName = value; }
        }
        private int numberOfHotel;

        public int NumberOfHotel
        {
            get { return numberOfHotel; }
            set { numberOfHotel = value; }
        }
       
        private long totalRecord;

        public long TotalRecord
        {
            get { return totalRecord; }
            set { totalRecord = value; }
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
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string flag;

        public string Flag
        {
            get { return flag; }
            set { flag = value; }
        }

        private string legalEntity;

        public string LegalEntity
        {
            get { return legalEntity; }
            set { legalEntity = value; }
        }

        private string headQuater;

        public string HeadQuater
        {
            get { return headQuater; }
            set { headQuater = value; }
        }

        private long m_CountryID;

        public long M_CountryID
        {
            get { return m_CountryID; }
            set { m_CountryID = value; }
        }

        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        private string countryCode;

         public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }  
    }
}
