using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Traveler : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CompanyID;
        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
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
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        private string _cellPhone;
        public string CellPhone
        {
            get { return _cellPhone; }
            set { _cellPhone = value; }
        }
        private string _extensionNumber;
        public string ExtensionNumber
        {
            get { return _extensionNumber; }
            set { _extensionNumber = value; }
        }
        private string _position;
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        private string _skype;
        public string Skype
        {
            get { return _skype; }
            set { _skype = value; }
        }
        private string _fax;
        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
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
        public override string Table { get { return "M_Traveler"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Traveler_InsertOrUpdate"; } }
    }
    
    [Serializable]
    public class M_TravelerIncludedORCText : M_Traveler
    {
        private string _ocrFullName;
        public string OcrFullName
        {
            get { return _ocrFullName; }
            set { _ocrFullName = value; }
        }
    }

    public class M_Traveler_ForMatching
    {
        public string FullName { get; set; }
    }

    public enum M_TravelerColumns
    {
        ID,
        M_CompanyID,
        Salutation,
        FirstName,
        LastName,
        FullName,
        PhoneNumber,
        CellPhone,
        ExtensionNumber,
        Position,
        Skype,
        Fax,
        Comment,
        Email,
        Address,
        ZipCode,
        CityName,
        M_CountryID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_TravelerProcedure
    {
        p_M_Traveler_CheckInfo,
        p_M_Traveler_GetByCompanyID,
        p_M_Traveler_GetListFullName,
        p_M_Traveller_FilterByCompanyID, 
        p_M_Traveler_Get_ByAccess,
        p_M_Traveler_GetForMatching,
        p_M_Traveller_GetBookerByM_CompanyID,
        p_M_Traveller_GetByM_CompanyID
    }

    public class M_TravelerList : List<M_Traveler>
    {
    }


    public class C_Traveler : M_Traveler
    {
        private long m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return m_HotelPlatformID; }
            set { m_HotelPlatformID = value; }
        }
    }
}