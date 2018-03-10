using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyProcess : BaseModel
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
        private long _m_ProcessID;
        public long M_ProcessID
        {
            get { return _m_ProcessID; }
            set { _m_ProcessID = value; }
        }
        private long _m_HotelPlatformID;
        public long M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }
        private bool _isDefault;
        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }
        public override string Table { get { return "M_CompanyProcess"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyProcess_InsertOrUpdate"; } }
    }
    public enum M_CompanyProcessColumns
    {
        ID,
        M_CompanyID,
        M_ProcessID,
        M_HotelPlatformID,
        IsDefault,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyProcessProcedure
    {
        p_M_CompanyProcess_Get_By_M_CompanyID,
        p_P_CompanyProcess_Get_By_M_CompanyID,
        p_M_CompanyProcess_Get_By_M_CompanyID_Default,
        p_M_CompanyProcessSchedule_Delete_ByStep
    }
    public class M_CompanyProcessList : List<M_CompanyProcess>
    {

    }
}