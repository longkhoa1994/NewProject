using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Traveler : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_BookingDetailID;

        public long B_BookingDetailID
        {
            get { return _b_BookingDetailID; }
            set { _b_BookingDetailID = value; }
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

        private long _m_CompanyID;

        public long  M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        public long TravelerIndex { get; set; }
        public override string Table { get { return "B_Traveler"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Traveler_InsertOrUpdate"; } }
    }

    public enum B_TravelerColumns
    {
        ID,
        B_BookingDetailID,
        Salutation,
        FirstName,
        LastName,
        Email,
        Phone,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_TravelerProcedure
    {
        p_B_Traveler_Get_By_B_BookingDetailID,
        p_B_Traveler_Get_ByBooking,
        p_B_Traveler_GetByM_HotelID,
        p_B_Traveler_GetByDateAndHotelID,
        p_B_Traveler_GetListForDeleting,
        p_B_Traveler_GetList_ByB_BookingID,
    }

    public class B_TravelerList : List<B_Traveler>
    {
    }
}