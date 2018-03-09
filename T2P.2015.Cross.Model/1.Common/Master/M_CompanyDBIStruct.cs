using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyDBIStruct : BaseModel
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
        private string _dBIName;
        public string DBIName
        {
            get { return _dBIName; }
            set { _dBIName = value; }
        }
        private int _required;
        public int Required
        {
            get { return _required; }
            set { _required = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "M_CompanyDBIStruct"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyDBIStruct_InsertOrUpdate"; } }
    }
    public enum M_CompanyDBIStructColumns
    {
        ID,
        M_CompanyID,
        DBIName,
        Required,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyDBIStructProcedure
    {
        p_M_CompanyDBIStruct_Get_By_M_CompanyID,
    }
    public class M_CompanyDBIStructList : List<M_CompanyDBIStruct>
    {

    }
}