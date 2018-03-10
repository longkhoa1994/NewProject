using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_OfflineHotel : BaseModel
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

        private long _m_HotelID;

        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }

        public override string Table { get { return "M_OfflineHotel"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_OfflineHotel_InsertOrUpdate"; } }
    }

    public enum M_OfflineHotelColumns
    {
        ID,
        M_CompanyID,
        M_HotelID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_OfflineHotelProcedure
    {
        p_M_OfflineHotel_Get_ByB_AccessID
    }

    public class M_OfflineHotelList : List<M_OfflineHotel>
    {
    }
}