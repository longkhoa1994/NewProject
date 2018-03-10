using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class O_SuggestDumb : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _o_PageID;
        public long O_PageID
        {
            get { return _o_PageID; }
            set { _o_PageID = value; }
        }

        private string _companyIds;
        public string CompanyIds
        {
            get { return _companyIds; }
            set { _companyIds = value; }
        }

        private string _companyNames;
        public string CompanyNames
        {
            get { return _companyNames; }
            set { _companyNames = value; }
        }

        private string _companyKeywords;
        public string CompanyKeywords
        {
            get { return _companyKeywords; }
            set { _companyKeywords = value; }
        }

        private string _companyAddresses;
        public string CompanyAddresses
        {
            get { return _companyAddresses; }
            set { _companyAddresses = value; }
        }

        private string _companyCityNames;
        public string CompanyCityNames
        {
            get { return _companyCityNames; }
            set { _companyCityNames = value; }
        }

        private string _companyZipCodes;
        public string CompanyZipCodes
        {
            get { return _companyZipCodes; }
            set { _companyZipCodes = value; }
        }

        private string _hotelIds;
        public string HotelIds
        {
            get { return _hotelIds; }
            set { _hotelIds = value; }
        }

        private string _hotelNames;
        public string HotelNames
        {
            get { return _hotelNames; }
            set { _hotelNames = value; }
        }

        private string _hotelAddresses;
        public string HotelAddresses
        {
            get { return _hotelAddresses; }
            set { _hotelAddresses = value; }
        }

        private string _hotelCityNames;
        public string HotelCityNames
        {
            get { return _hotelCityNames; }
            set { _hotelCityNames = value; }
        }

        private string _hotelZipCodes;
        public string HotelZipCodes
        {
            get { return _hotelZipCodes; }
            set { _hotelZipCodes = value; }
        }

        private string _hotelVatNumbers;
        public string HotelVatNumbers
        {
            get { return _hotelVatNumbers; }
            set { _hotelVatNumbers = value; }
        }

        private string _travelerNames;
        public string TravelerNames
        {
            get { return _travelerNames; }
            set { _travelerNames = value; }
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

        public override string Table { get { return "O_SuggestDumb"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_SuggestDumb_InsertOrUpdate"; } }
    }
    public enum O_SuggestDumbColumns
    {
        ID,
        O_PageID,


        CompanyIds,
        CompanyNames,
        CompanyKeywords,
        CompanyAddresses,
        CompanyCityNames,
        CompanyZipCodes,

        HotelIds,
        HotelNames,
        HotelAddresses,
        HotelCityNames,
        HotelZipCodes,
        HotelVatNumbers,

        TravelerNames,

        CheckIn,
        CheckOut,

        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum O_SuggestDumbProcedure
    {

    }
    public class O_SuggestDumbList : List<O_SuggestDumb>
    {

    }
}