using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelPlatformProcess : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_HotelPlatformID;
        public long M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }
        private long _m_Process;
        public long M_Process
        {
            get { return _m_Process; }
            set { _m_Process = value; }
        }
        public override string Table { get { return "M_HotelPlatformProcess"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelPlatformProcess_InsertOrUpdate"; } }
    }
    public enum M_HotelPlatformProcessColumns
    {
        ID,
        M_HotelPlatformID,
        M_Process,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_HotelPlatformProcessProcedure
    {

    }
    public class M_HotelPlatformProcessList : List<M_HotelPlatformProcess>
    {

    }
}