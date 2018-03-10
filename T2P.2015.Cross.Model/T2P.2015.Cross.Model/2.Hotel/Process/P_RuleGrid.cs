using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model._1.Common.Master;
using T2P._2015.Cross.Model.Model;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public interface P_RuleManagement
    {
        ICollection<P_RuleGrid> GetRules(P_RuleGridRelation relatedData);
        ICollection<M_InvoiceRules> GetRulesInvoice(P_RuleGridRelation relatedData);
    }

    public class P_RuleGrid : M_CompanySpecialRule
    {
        private P_RuleManagement _ruleManagement;
        public P_RuleGrid()
        {
        }
        public P_RuleGrid(P_RuleManagement ruleManagement)
        {
            _ruleManagement = ruleManagement;
        }

        public ICollection<P_RuleGrid> GetRules(P_RuleGridRelation relatedData)
        {
            return _ruleManagement.GetRules(relatedData);
        }

        public ICollection<M_InvoiceRules> GetRulesInvoice(P_RuleGridRelation relatedData)
        {
            return _ruleManagement.GetRulesInvoice(relatedData);
        }

    }

    public class P_RuleGridRelation
    {
        public long CompanyCountryID { get; set; }
        public long M_ProcessID { get; set; }
        public long CompanyID { get; set; }
        public long HotelCountryID { get; set; }
        public bool IsAppliedAmountLess150 { get; set; }
        public string CompanyName { get; set; }
        public long M_HotelPlatformID { get; set; }
    }

    public class v_p_RuleGrid
    {
        public v_p_RuleGrid()
        {
            Ruleset = new List<M_InvoiceRules>();
            SpecialRules = new List<P_RuleGrid>();
            ErrorTypes = new List<String>();
        }
        public ICollection<M_InvoiceRules> Ruleset { get; set; }

        public ICollection<P_RuleGrid> SpecialRules { get; set; }
        public ICollection<String> ErrorTypes { get; set; }
        public string CompanyName { get; set; }
        public long CompanyID { get; set; }
    }

    public class vm_SpecialRule
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
        private bool _isDeleted;
        public bool IsDeleted
        {
            get { return _isDeleted; }
            set { _isDeleted = value; }
        }

    }
}
