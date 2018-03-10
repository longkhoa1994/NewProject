using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Access : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _bookerID;

        public long BookerID
        {
            get { return _bookerID; }
            set { _bookerID = value; }
        }

        private long _m_CompanyID;

        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private long _m_HotelID;

        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }

        private long _m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }

        private long? _m_ProcessID;

        public long? M_ProcessID
        {
            get { return _m_ProcessID; }
            set { _m_ProcessID = value; }
        }

        private long? m_CompanyProcessID;

        public long? M_CompanyProcessID
        {
            get { return m_CompanyProcessID; }
            set { m_CompanyProcessID = value; }
        }

        private string _BookingStatus;

        public string BookingStatus
        {
            get { return _BookingStatus; }
            set { _BookingStatus = value; }
        }

        public override string Table { get { return "B_Access"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Access_InsertOrUpdate"; } }
    }

    public enum B_AccessColumns
    {
        ID,
        BookerID,
        M_CompanyID,
        M_HotelID,
        M_HotelPlatformID,
        M_ProcessID,
        M_CompanyProcessID,
        BookingStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_AccessProcedure
    {
        p_B_Access_Get_ByBookingNo,
        p_B_Access_GetListStopProcessHDE,
        p_B_Access_GetListStopProcessHRS,
        p_B_Access_GetCompanyIDByHotelID, 
        p_B_Access_GetListB_Access_ByListID,
        p_B_Access_ChangeCompanyProcess,
        p_B_Access_GetList_ByM_HotelID,
    }

    public class B_AccessList : List<B_Access>
    {
    }
}