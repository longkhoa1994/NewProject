using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_HotelContact : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_HotelID;

        public long B_HotelID
        {
            get { return _b_HotelID; }
            set { _b_HotelID = value; }
        }

        private string _hotelContactNo;

        
        public string HotelContactNo
        {
            get { return _hotelContactNo; }
            set { _hotelContactNo = value; }
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

        private string _position;

        
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        private string _comment;

        
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private string _phone;

        
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private string _email;

        
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _fax;

        
        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        public override string Table { get { return "B_HotelContact"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_HotelContact_InsertOrUpdate"; } }
    }

    public enum B_HotelContactColumns
    {
        ID,
        B_HotelID,
        HotelContactNo,
        Salutation,
        FirstName,
        LastName,
        Position,
        Comment,
        Phone,
        Email,
        Fax,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_HotelContactProcedure
    {
        p_B_HotelContact_Get_By_B_HotelID,
        p_B_HotelContact_GetListForDeleting,
    }

    public class B_HotelContactList : List<B_HotelContact>
    {
    }
}