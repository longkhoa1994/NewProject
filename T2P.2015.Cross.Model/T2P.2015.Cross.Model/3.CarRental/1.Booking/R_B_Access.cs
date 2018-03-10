using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_B_Access : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _r_M_PlatformID;

        public long? R_M_PlatformID
        {
            get { return _r_M_PlatformID; }
            set { _r_M_PlatformID = value; }
        }
        private long? _m_CompanyID;

        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private long? _m_CarRentalProviderID;

        public long? M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
        }

        private long? _m_TravelerID;

        public long? M_TravelerID
        {
            get { return _m_TravelerID; }
            set { _m_TravelerID = value; }
        }

        private long? _rG_RateGridID;

        public long? RG_RateGridID
        {
            get { return _rG_RateGridID; }
            set { _rG_RateGridID = value; }
        }

        private string _bookingStatus;

        public string BookingStatus
        {
            get { return _bookingStatus; }
            set { _bookingStatus = value; }
        }

        public override string Table { get { return "R_B_Access"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_B_Access_InsertOrUpdate"; } }
    }

    public enum R_B_AccessColumns
    {
        ID,
        M_HotelPlatformID,
        M_CompanyID,
        M_CarRentalProviderID,
        M_TravelerID,
        RG_RateGridID,
        BookingStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_B_AccessProcedure
    {
        p_R_B_Access_Get_By_BookingNo,
        p_R_B_Access_Get_Items_For_Stop_Booking_Process,
        p_R_B_Access_Get_Items_Have_No_Fin_No_Invoice,
        p_R_B_Access_Get_Item_CheckStatusBooking,
        p_R_Access_CheckCompany,
        p_R_Access_CheckFinish
    }

    public class R_B_AccessList : List<R_B_Access>
    {
    }
    
}