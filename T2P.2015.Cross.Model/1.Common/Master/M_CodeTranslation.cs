using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T2P._2015.Cross.Model;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CodeTranslation : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_LanguageID;
        public long? M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
        private long? _m_CodeID;
        public long? M_CodeID
        {
            get { return _m_CodeID; }
            set { _m_CodeID = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "M_CodeTranslation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CodeTranslation_InsertOrUpdate"; } }
    }
    public enum M_CodeTranslationColumns
    {
        ID,
        M_LanguageID,
        M_CodeID,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CodeTranslationProcedure
    {
        p_M_CodeTranslation_GetListByTypeAndLanguage
    }
    public class M_CodeTranslationList : List<M_CodeTranslation>
    {

    }
}