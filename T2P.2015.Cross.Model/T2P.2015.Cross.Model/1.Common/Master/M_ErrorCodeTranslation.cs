using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ErrorCodeTranslation : BaseModel
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
        private long _m_ErrorCodeID;
        public long M_ErrorCodeID
        {
            get { return _m_ErrorCodeID; }
            set { _m_ErrorCodeID = value; }
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
        public override string Table { get { return "M_ErrorCodeTranslation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_ErrorCodeTranslation_InsertOrUpdate"; } }
    }
    public enum M_ErrorCodeTranslationColumns
    {
        ID,
        M_LanguageID,
        M_ErrorCodeID,
        Name,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status
    }
    public enum M_ErrorCodeTranslationProcedure
    {

    }
    public class M_ErrorCodeTranslationList : List<M_ErrorCodeTranslation>
    {

    }
}