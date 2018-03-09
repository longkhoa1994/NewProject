using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Code : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string _code;
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "M_Code"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Code_InsertOrUpdate"; } }
    }
    public enum M_CodeColumns
    {
        ID,
        Code,
        Type,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CodeProcedure
    {
        p_M_Code_GetByType
    }
    public class M_CodeList : List<M_Code>
    {

    }
}