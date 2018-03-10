using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ErrorCode : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_ErrorCodeCategoryID;
        public long M_ErrorCodeCategoryID
        {
            get { return _m_ErrorCodeCategoryID; }
            set { _m_ErrorCodeCategoryID = value; }
        }
        private string _code;
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "M_ErrorCode"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_ErrorCode_InsertOrUpdate"; } }
    }
    public enum M_ErrorCodeColumns
    {
        ID,
        M_ErrorCodeCategoryID,
        Code,
        Name,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status
    }
    public enum M_ErrorCodeProcedure
    {

    }
    public class M_ErrorCodeList : List<M_ErrorCode>
    {

    }
}