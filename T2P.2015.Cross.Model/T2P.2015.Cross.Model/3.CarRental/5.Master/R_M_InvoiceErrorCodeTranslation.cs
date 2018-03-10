using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_InvoiceErrorCodeTranslation : BaseModel
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
        private long _r_M_InvoiceErrorCodeID;

        public long R_M_InvoiceErrorCodeID
        {
            get { return _r_M_InvoiceErrorCodeID; }
            set { _r_M_InvoiceErrorCodeID = value; }
        }
      
        private string _errorText;
        public string ErrorText
        {
            get { return _errorText; }
            set { _errorText = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "R_M_InvoiceErrorCodeTranslation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_InvoiceErrorCodeTranslation_InsertOrUpdate"; } }
    }
    public enum R_M_InvoiceErrorCodeTranslationColumns
    {
        ID,
        M_LanguageID,
        R_M_InvoiceErrorCodeID,
        ErrorText,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_InvoiceErrorCodeTranslationProcedure
    {

    }
    public class R_M_InvoiceErrorCodeTranslationList : List<R_M_InvoiceErrorCodeTranslation>
    {

    }
}