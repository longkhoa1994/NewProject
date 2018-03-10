using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ServiceCodeTranslation : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_ServiceCodeID;
        public long M_ServiceCodeID
        {
            get { return _m_ServiceCodeID; }
            set { _m_ServiceCodeID = value; }
        }
        private long _m_LanguageID;
        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "M_ServiceCodeTranslation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_ServiceCodeTranslation_InsertOrUpdate"; } }
    }
    public enum M_ServiceCodeTranslationColumns
    {
        ID,
        M_ServiceCodeID,
        M_LanguageID,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_ServiceCodeTranslationProcedure
    {

    }
    public class M_ServiceCodeTranslationList : List<M_ServiceCodeTranslation>
    {

    }
}