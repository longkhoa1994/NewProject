using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Hotel2 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_HotelChainID;
        public long? M_HotelChainID
        {
            get { return _m_HotelChainID; }
            set { _m_HotelChainID = value; }
        }
        private string _hotelNo;
        public string HotelNo
        {
            get { return _hotelNo; }
            set { _hotelNo = value; }
        }
        private string _hotelName;
        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }
        private string _hoteAddress;
        public string HoteAddress
        {
            get { return _hoteAddress; }
            set { _hoteAddress = value; }
        }
        private string _zipCode;
        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
        private string _cityName;
        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }
        private long? _m_CountryID;
        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }
        private string _countryCode;
        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        private string _fax;
        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private decimal? _latitude;
        public decimal? Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }
        private decimal? _longitude;
        public decimal? Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }
        private long? _m_LanguageID;
        public long? M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
        private long? _m_TimeZoneID;
        public long? M_TimeZoneID
        {
            get { return _m_TimeZoneID; }
            set { _m_TimeZoneID = value; }
        }
        private decimal? _timezone;
        public decimal? Timezone
        {
            get { return _timezone; }
            set { _timezone = value; }
        }
        private string _hotelVATNumber;
        public string HotelVATNumber
        {
            get { return _hotelVATNumber; }
            set { _hotelVATNumber = value; }
        }
        private bool? _isNewHotel;
        public bool? IsNewHotel
        {
            get { return _isNewHotel; }
            set { _isNewHotel = value; }
        }
        private string _legalEntity;

        public string LegalEntity
        {
            get { return _legalEntity; }
            set { _legalEntity = value; }
        }
        public override string Table { get { return "M_Hotel2"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Hotel2_InsertOrUpdate"; } }
    }
    public enum M_Hotel2Columns
    {
        ID,
        M_HotelChainID,
        HotelNo,
        HotelName,
        HoteAddress,
        ZipCode,
        CityName,
        M_CountryID,
        CountryCode,
        Phone,
        Fax,
        Email,
        Latitude,
        Longitude,
        M_LanguageID,
        M_TimeZoneID,
        Timezone,
        HotelVATNumber,
        IsNewHotel,
        LegalEntity,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_Hotel2Procedure
    {

    }
    public class M_Hotel2List : List<M_Hotel2>
    {

    }
}