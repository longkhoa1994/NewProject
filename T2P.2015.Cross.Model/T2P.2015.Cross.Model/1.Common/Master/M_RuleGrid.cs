using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model.Model
{
    [Serializable]
    public class M_RuleGrid : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
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
        private string _exampleOnInvoice;
        public string ExampleOnInvoice
        {
            get { return _exampleOnInvoice; }
            set { _exampleOnInvoice = value; }
        }
        private string _exampleInSystem;
        public string ExampleInSystem
        {
            get { return _exampleInSystem; }
            set { _exampleInSystem = value; }
        }
        private string _handeling;
        public string Handeling
        {
            get { return _handeling; }
            set { _handeling = value; }
        }
        public override string Table { get { return "M_RuleGrid"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_RuleGrid_InsertOrUpdate"; } }
    }
    public enum M_RuleGridColumns
    {
        ID,
        ErrorType,
        Description,
        ExampleOnInvoice,
        ExampleInSystem,
        Handeling,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_RuleGridProcedure
    {
        p_M_RuleGrid_GetRelatedData,
        p_M_RuleGrid_GetRuleset,
        p_M_RuleGrid_GetSpecialRules,
        p_M_RuleGrid_Get_ErrorTypes,
        p_M_RuleGrid_GetRuleset_Invoice
    }
    public class M_RuleGridList : List<M_RuleGrid>
    {

    }
}