using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelContact : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_HotelID;

        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
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

        private string _convertedFaxNumber;

        public string ConvertedFaxNumber
        {
            get { return _convertedFaxNumber; }
            set { _convertedFaxNumber = value; }
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

        private bool _isDefault;

        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }

        public override string Table { get { return "M_HotelContact"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_HotelContact_InsertOrUpdate"; } }
    }

    public enum M_HotelContactColumns
    {
        ID,
        M_HotelID,
        Salutation,
        FirstName,
        LastName,
        PhoneNumber,
        CellPhone,
        ExtensionNumber,
        Position,
        Skype,
        Fax,
        ConvertedFaxNumber,
        Comment,
        Email,
        IsDefault,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_HotelContactProcedure
    {
        p_B_HotelContact_Get_By_Email,
        p_M_HotelContact_GetByM_HotelID,
        p_M_HotelContactExtend_GetByM_HotelID,
        p_M_HotelContact_GetBy_ListHotel,
        p_M_HotelContact_GetByBooking,
        p_M_HotelContact_GetList_ByListHotelID,
        p_M_HotelContact_CheckDuplicated
    }
    public class M_HotelContactExtend : M_HotelContact 
    {
        public bool IsEdit { get; set; }
        public string CreatedByUser { get; set; }
    }
    public class M_HotelContactList : List<M_HotelContact>
    {
    }

    public class M_HotelContactReturnModel
    {
        public List<M_HotelContactExtend> listHotelContactExtend { get; set; }
        public bool isUpdateSuccess { get; set; }
        public List<string> errors { get; set; }

        public M_HotelContactReturnModel()
        {
            listHotelContactExtend = new List<M_HotelContactExtend>();
            isUpdateSuccess = true;
            errors = new List<string>();
        }

    }
}