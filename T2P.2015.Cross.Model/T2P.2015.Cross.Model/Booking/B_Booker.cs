using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Booker : BaseModel
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

        private string _countryCode;

        
        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }

        public override string Table { get { return "B_Customer"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Booker_InsertOrUpdate"; } }
    }

    public enum B_BookerColumns
    {
        ID,
        B_BookingID,
        Salutation,
        FirstName,
        LastName,
        Email,
        Phone,
        Street,
        ZipCode,
        CityName,
        CountryCode,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_BookerProcedure
    {
        p_B_Booker_Get_by_B_BookingID,
        p_B_Booker_GetListFullName,
        p_B_Booker_GetListByCompanyID,
        p_B_Booker_GetListForDeleting
    }

    public class B_BookerList : List<B_Booker>
    {
    }
    public class B_BookerExtend : B_Booker
    {
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
    }
}