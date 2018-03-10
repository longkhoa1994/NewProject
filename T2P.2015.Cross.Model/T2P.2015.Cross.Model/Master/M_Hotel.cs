using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Hotel : BaseModel
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
        private int? _tIMRating;
        public int? TIMRating
        {
            get { return _tIMRating; }
            set { _tIMRating = value; }
        }
        private int? _starRating;
        public int? StarRating
        {
            get { return _starRating; }
            set { _starRating = value; }
        }
        private bool? _pMS;
        public bool? PMS
        {
            get { return _pMS; }
            set { _pMS = value; }
        }
        private int? _numberOfRoom;
        public int? NumberOfRoom
        {
            get { return _numberOfRoom; }
            set { _numberOfRoom = value; }
        }
        private string _currencyCode;
        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }
        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        private int? _hotelGateway;
        public int? HotelGateway
        {
            get { return _hotelGateway; }
            set { _hotelGateway = value; }
        }

        public override string Table { get { return "M_Hotel"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Hotel_InsertOrUpdate"; } }
    }

    [Serializable]
    public class M_HotelIncludedORCText : M_Hotel
    {
        private string _ocrHotelName;
        public string OcrHotelName
        {
            get { return _ocrHotelName; }
            set { _ocrHotelName = value; }
        }
        private string _ocrHotelAddress;
        public string OcrHotelAddress
        {
            get { return _ocrHotelAddress; }
            set { _ocrHotelAddress = value; }
        }
        private string _ocrHotelCityName;
        public string OcrHotelCityName
        {
            get { return _ocrHotelCityName; }
            set { _ocrHotelCityName = value; }
        }
        private string _ocrHotelZipCode;
        public string OcrHotelZipCode
        {
            get { return _ocrHotelZipCode; }
            set { _ocrHotelZipCode = value; }
        }
        private string _ocrHotelVATNumber;
        public string OcrHotelVATNumber
        {
            get { return _ocrHotelVATNumber; }
            set { _ocrHotelVATNumber = value; }
        }
    }

    public enum M_HotelColumns
    {
        ID,
        M_HotelChainID,
        HotelNo,
        HotelName,
        HotelAddress,
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
        TIMRating,
        StarRating,
        PMS,
        NumberOfRoom,
        CurrencyCode,
        State,
        HotelGateway,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_HotelProcedure
    {
        p_M_Hotel_CheckInfo,
        p_M_Hotel_GetListHotel,
        p_M_Hotel_GetListHotelForUpdateLatLong,
        p_M_Hotel_GetByI_ImageID,
        p_M_Hotel_Get_Search,
        p_M_Hotel_GetListByTime,
        p_M_Hotel_GetByB_AccessID,
        p_M_Hotel_GetInfor_ByID,
        p_M_Hotel_CheckDuplicated,
        p_M_Hotel_Get_Search_HotelPermission,
        p_M_Hotel_GetByBillingEmailId
    }

    public class M_HotelList : List<M_Hotel>
    {
    }
}