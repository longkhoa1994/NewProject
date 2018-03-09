using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelProcess : BaseModel
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
        private long _m_HotelPlatformID;
        public long M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }

        private string _hotelNo;
        public string HotelNo
        {
            get { return _hotelNo; }
            set { _hotelNo = value; }
        }
        public override string Table { get { return "M_HotelProcess"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelProcess_InsertOrUpdate"; } }
    }
    public enum M_HotelProcessColumns
    {
        ID,
        M_HotelID,
        M_HotelPlatformID,
        OldID,
        HotelNo,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_HotelProcessProcedure
    {
        p_M_HotelProcess_GetList_ByM_HotelID
    }
    public class M_HotelProcessList : List<M_HotelProcess>
    {

    }
}