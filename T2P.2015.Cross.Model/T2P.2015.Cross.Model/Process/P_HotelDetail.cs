using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_HotelDetail
    {
        public string Error { get; set; }
        public M_HotelExtend M_Hotel { get; set; }
        public List<M_HotelContactExtend> ListM_HotelContact { get; set; }
        public M_Country M_Country { get; set; }
        public List<M_Country> ListM_Country { get; set; }
       
        public M_Language M_Language { get; set; }
        public List<M_Language> ListM_Language { get; set; }

        public List<decimal> ListM_TimeZone { get; set; }

        public string Address { get; set; }

        public P_HotelDetail()
        {
            Error = string.Empty;
            M_Hotel = new M_HotelExtend();
            ListM_HotelContact = new List<M_HotelContactExtend>();
            M_Country = new M_Country();
            ListM_Country = new List<M_Country>();
            M_Language = new M_Language();
            ListM_Language = new List<M_Language>();
            ListM_TimeZone = new List<decimal>();
            Address = string.Empty;
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
    }
}
