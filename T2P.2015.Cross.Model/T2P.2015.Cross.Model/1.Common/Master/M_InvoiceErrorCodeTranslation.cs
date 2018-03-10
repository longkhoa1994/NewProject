using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_InvoiceErrorCodeTranslation : BaseModel
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

        private long _m_InvoiceErrorCodeID;

        public long M_InvoiceErrorCodeID
        {
            get { return _m_InvoiceErrorCodeID; }
            set { _m_InvoiceErrorCodeID = value; }
        }

        private string _paymentMethod;

        
        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
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
        private string _rule;

        public string Rule
        {
            get { return _rule; }
            set { _rule = value; }
        }

        public override string Table { get { return "M_InvoiceErrorCodeTranslation"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_InvoiceErrorCodeTranslation_InsertOrUpdate"; } }
    }

    public enum M_InvoiceErrorCodeTranslationColumns
    {
        ID,
        M_LanguageID,
        M_InvoiceErrorCodeID,
        PaymentMethod,
        ErrorText,
        Description,
        Rule,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_InvoiceErrorCodeTranslationProcedure
    {
    }

    public class M_InvoiceErrorCodeTranslationList : List<M_InvoiceErrorCodeTranslation>
    {
    }
}