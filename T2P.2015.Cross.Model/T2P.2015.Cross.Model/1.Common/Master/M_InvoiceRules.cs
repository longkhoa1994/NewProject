using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.Model;

namespace T2P._2015.Cross.Model._1.Common.Master
{
    public class M_InvoiceRules
    {
        public string Key { get; set; }

        public int isShow { get; set; }

        public List<M_RelationInvoiceRuleError> lstInvoiceRules { get; set; }
        public M_InvoiceRules()
        {
            lstInvoiceRules = new List<M_RelationInvoiceRuleError>();
        }
    }
    public class M_RelationInvoiceRuleError : M_RelationInvoiceRule
    {
        public string ErrorText { get; set; }
        public string DescriptionRule { get; set; }
    }

    public enum StoreProceduteRelationInvoiceRuleError
    {
        p_M_RelationInvoiceRuleError_GetList
    }

}
