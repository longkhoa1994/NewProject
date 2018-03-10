using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ServiceKeyword : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private long? _m_ServiceCodeID;
        public long? M_ServiceCodeID
        {
            get { return _m_ServiceCodeID; }
            set { _m_ServiceCodeID = value; }
        }
        private long? _m_LanguageID;
        public long? M_LanguageID
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
        public override string Table { get { return "M_ServiceKeyword"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_ServiceKeyword_InsertOrUpdate"; } }
    }
    public enum M_ServiceKeywordColumns
    {
        ID,
        M_CompanyID,
        M_ServiceCodeID,
        M_LanguageID,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_ServiceKeywordProcedure
    {
        P_M_ServiceKeyword_GetByCompany,
        p_M_ServiceKeyword_GetDescriptionByCompany
    }
    public class M_ServiceKeywordList : List<M_ServiceKeyword>
    {

    }
}