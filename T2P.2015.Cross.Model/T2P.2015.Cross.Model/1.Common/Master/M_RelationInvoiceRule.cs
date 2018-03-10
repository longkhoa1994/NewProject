using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model.Model
{
    [Serializable]
    public class M_RelationInvoiceRule : BaseModel
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
        private long? _m_ProcessID;
        public long? M_ProcessID
        {
            get { return _m_ProcessID; }
            set { _m_ProcessID = value; }
        }
        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private bool? _appliedAmount;
        public bool? AppliedAmount
        {
            get { return _appliedAmount; }
            set { _appliedAmount = value; }
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
        public override string Table { get { return "M_RelationInvoiceRule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_RelationInvoiceRule_InsertOrUpdate"; } }
    }
    public enum M_RelationInvoiceRuleColumns
    {
        ID,
        M_CountryID,
        M_InvoiceErrorCodeID,
        M_ProcessID,
        M_CompanyID,
        AppliedAmount,
        IsDomestic,
        IsInternational,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_RelationInvoiceRuleProcedure
    {

    }
    public class M_RelationInvoiceRuleList : List<M_RelationInvoiceRule>
    {

    }
}