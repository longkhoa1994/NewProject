using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_CompanyPlatform : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _r_M_CompanyID;
        public long? R_M_CompanyID
        {
            get { return _r_M_CompanyID; }
            set { _r_M_CompanyID = value; }
        }
        private long? _r_M_PlatformID;
        public long? R_M_PlatformID
        {
            get { return _r_M_PlatformID; }
            set { _r_M_PlatformID = value; }
        }
        public override string Table { get { return "R_M_CompanyPlatform"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_CompanyPlatform_InsertOrUpdate"; } }
    }
    public enum R_M_CompanyPlatformColumns
    {
        ID,
        R_M_CompanyID,
        R_M_PlatformID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_CompanyPlatformProcedure
    {
        p_R_M_CompanyPlatformGetByCompany
    }
    public class R_M_CompanyPlatformList : List<R_M_CompanyPlatform>
    {

    }
}