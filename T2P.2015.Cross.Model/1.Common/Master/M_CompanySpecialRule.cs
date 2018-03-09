using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model.Model
{
    [Serializable]
    public class M_CompanySpecialRule : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CompanyID;
        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private string _errorType;
        public string ErrorType
        {
            get { return _errorType; }
            set { _errorType = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
		private string _descriptionRawText;
		public string DescriptionRawText
		{
			get { return _descriptionRawText; }
			set { _descriptionRawText = value; }
		}
        private string _exampleOnInvoice;
        public string ExampleOnInvoice
        {
            get { return _exampleOnInvoice; }
            set { _exampleOnInvoice = value; }
        }
		private string _exampleOnInvoiceRawText;
		public string ExampleOnInvoiceRawText
		{
			get { return _exampleOnInvoiceRawText; }
			set { _exampleOnInvoiceRawText = value; }
		}
        private string _exampleInSystem;
        public string ExampleInSystem
        {
            get { return _exampleInSystem; }
            set { _exampleInSystem = value; }
        }
		private string _exampleInSystemRawText;
		public string ExampleInSystemRawText
		{
			get { return _exampleInSystemRawText; }
			set { _exampleInSystemRawText = value; }
		}
        private string _handeling;
        public string Handeling
        {
            get { return _handeling; }
            set { _handeling = value; }
        }
        public override string Table { get { return "M_CompanySpecialRule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanySpecialRule_InsertOrUpdate"; } }
    }
    public enum M_CompanySpecialRuleColumns
    {
        ID,
        M_CompanyID,
        ErrorType,
        Description,
		DescriptionRawText,
        ExampleOnInvoice,
		ExampleOnInvoiceRawText,
        ExampleInSystem,
		ExampleInSystemRawText,
        Handeling,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanySpecialRuleProcedure
    {
        p_M_CompanySpecialRuleList_Get_ListSearch,
        p_M_RuleGrid_GetRuleset
    }
    public class M_CompanySpecialRuleList : List<M_CompanySpecialRule>
    {
        
    }

    public class M_CompanySpecialRuleExtend : M_CompanySpecialRule
	{
        public string CompanyName { get; set; }
       
	}
    public class M_CompanySpecialRuleExtended
    {
        public List<M_CompanySpecialRuleExtend> CompanySpecialRules { get; set; }
        public long TotalRecord { get; set; }
        public M_CompanySpecialRuleExtended()
        {
            CompanySpecialRules = new List<M_CompanySpecialRuleExtend>();
            TotalRecord = 0;
        }
        
    }
}