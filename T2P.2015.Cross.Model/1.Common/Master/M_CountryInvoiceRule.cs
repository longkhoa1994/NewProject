using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CountryInvoiceRule : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_CountryID;
        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }
        private long? _m_InvoiceErrorCodeID;
        public long? M_InvoiceErrorCodeID
        {
            get { return _m_InvoiceErrorCodeID; }
            set { _m_InvoiceErrorCodeID = value; }
        }
        private bool _isDomestic;
        public bool IsDomestic
        {
            get { return _isDomestic; }
            set { _isDomestic = value; }
        }
        private bool _isInternational;
        public bool IsInternational
        {
            get { return _isInternational; }
            set { _isInternational = value; }
        }
        public override string Table { get { return "M_CountryInvoiceRule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CountryInvoiceRule_InsertOrUpdate"; } }
    }
    public enum M_CountryInvoiceRuleColumns
    {
        ID,
        M_CountryID,
        M_InvoiceErrorCodeID,
        IsDomestic,
        IsInternational,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CountryInvoiceRuleProcedure
    {
        
    }
    public class M_CountryInvoiceRuleList : List<M_CountryInvoiceRule>
    {

    }


    //Get rule list for page Rule
    public class P_CountryInvoiceRule : M_CountryInvoiceRule
    {
        //private long _m_Language_ID;

        //public long M_Language_ID
        //{
        //    get { return _m_Language_ID; }
        //    set { _m_Language_ID = value; }
        //}
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
    }
    public enum P_CountryInvoiceRuleProcedure
    {
        p_M_CountryInvoiceRule_Get_ByCountryID_LanguageID,
        p_M_InvoiceErrorCode_M_InvoiceErrorCodeTranslation_Update
    }
    public class CountryList
    {
        private int _iD;

        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _countryCode;

        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }
        private string _countryName;

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }
    }
    public enum CountryListProcedure
    {
        p_M_Country_GetList
    }
}