using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Hotel : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_BookingID;

        public long B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
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

        private string _street;

        public string Street
        {
            get { return _street; }
            set { _street = value; }
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

        private string _countryName;

        
        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
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

        private bool? _isSendingEmail;

        
        public bool? IsSendingEmail
        {
            get { return _isSendingEmail; }
            set { _isSendingEmail = value; }
        }

        private bool? _isSendingFax;


        public bool? IsSendingFax
        {
            get { return _isSendingFax; }
            set { _isSendingFax = value; }
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

        private string _communicationLanguages;

        
        public string CommunicationLanguages
        {
            get { return _communicationLanguages; }
            set { _communicationLanguages = value; }
        }

        private string _timezone;

        
        public string Timezone
        {
            get { return _timezone; }
            set { _timezone = value; }
        }

        public override string Table { get { return "B_Hotel"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Hotel_InsertOrUpdate"; } }
        public B_Hotel()
        {
            Phone = string.Empty;
        }
    }

    public enum B_HotelColumns
    {
        ID,
        B_BookingID,
        HotelNo,
        HotelName,
        Street,
        ZipCode,
        CityName,
        CountryName,
        CountryCode,
        Phone,
        Fax,
        Email,
        IsSendingEmail,
        IsSendingFax,
        Latitude,
        Longitude,
        CommunicationLanguages,
        Timezone,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_HotelProcedure
    {
        p_B_Hotel_Get_by_B_BookingID,
        p_B_Hotel_GetListForDeleting,
    }

    public class B_HotelList : List<B_Hotel>
    {
    }
}