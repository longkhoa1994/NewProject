using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_F_ErrorCode : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
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
        public override string Table { get { return "R_F_ErrorCode"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_F_ErrorCode_InsertOrUpdate"; } }
    }
    public enum R_F_ErrorCodeColumns
    {
        ID,
        Code,
        Name,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_F_ErrorCodeProcedure
    {

    }
    public class R_F_ErrorCodeList : List<R_F_ErrorCode>
    {

    }
}