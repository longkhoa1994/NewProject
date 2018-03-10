using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_F_ErrorCodeTranslation : BaseModel
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
        private long _r_F_ErrorCodeID;
        public long R_F_ErrorCodeID
        {
            get { return _r_F_ErrorCodeID; }
            set { _r_F_ErrorCodeID = value; }
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
        public override string Table { get { return "R_F_ErrorCodeTranslation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_F_ErrorCodeTranslation_InsertOrUpdate"; } }
    }
    public enum R_F_ErrorCodeTranslationColumns
    {
        ID,
        M_LanguageID,
        R_F_ErrorCodeID,
        Name,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_F_ErrorCodeTranslationProcedure
    {

    }
    public class R_F_ErrorCodeTranslationList : List<R_F_ErrorCodeTranslation>
    {

    }
}