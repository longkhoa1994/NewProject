using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_CharRule : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _c_KeyWordID;
        public long C_KeyWordID
        {
            get { return _c_KeyWordID; }
            set { _c_KeyWordID = value; }
        }
        private string _original;
        public string Original
        {
            get { return _original; }
            set { _original = value; }
        }
        private string _oCRChars;
        public string OCRChars
        {
            get { return _oCRChars; }
            set { _oCRChars = value; }
        }
        public override string Table { get { return "C_CharRule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_CharRule_InsertOrUpdate"; } }
    }
    public enum C_CharRuleColumns
    {
        ID,
        C_KeyWordID,
        Original,
        OCRChars,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum C_CharRuleProcedure
    {

    }
    public class C_CharRuleList : List<C_CharRule>
    {

    }
}