using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ResourceTranslation : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_LanguageID;
        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
        private long _m_ResourceID;
        public long M_ResourceID
        {
            get { return _m_ResourceID; }
            set { _m_ResourceID = value; }
        }
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public override string Table { get { return "M_ResourceTranslation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_ResourceTranslation_InsertOrUpdate"; } }
    }
    public enum M_ResourceTranslationColumns
    {
        ID,
        M_LanguageID,
        M_ResourceID,
        Value,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_ResourceTranslationProcedure
    {
        p_M_Resource_Get_ForTranslate,
        p_M_Resource_Get_ForTranslation,
        p_M_ResourceTranslation_Get_ByResourceID,
        p_M_Resource_GetByKeyAndLanguageID
    }
    public class M_ResourceTranslationList : List<M_ResourceTranslation>
    {

    }
}