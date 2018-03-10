using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelFacility : BaseModel
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
        private long _m_FacilityID;
        public long M_FacilityID
        {
            get { return _m_FacilityID; }
            set { _m_FacilityID = value; }
        }
        public override string Table { get { return "M_HotelFacility"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelFacility_InsertOrUpdate"; } }
    }
    public enum M_HotelFacilityColumns
    {
        ID,
        M_HotelID,
        M_FacilityID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_HotelFacilityProcedure
    {
        p_M_HotelFacility_GetList_ByM_HotelID
    }
    public class M_HotelFacilityList : List<M_HotelFacility>
    {

    }
}