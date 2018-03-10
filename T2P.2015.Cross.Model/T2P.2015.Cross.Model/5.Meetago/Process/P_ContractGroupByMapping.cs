using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{


    public class Mountain
    {
        public string ContractCurrency { get; set; }
        public string InvoiceCurrency { get; set; }
        public dynamic MeetingPackage { get; set; }
        public dynamic Room { get; set; }
        public dynamic Additional { get; set; }
        public dynamic SNC { get; set; }
    }
    public class P_ContractGroupByMapping
    {
        public P_ContractMapping Contract { get; set; }
        public List<P_DataContractMapping> Invoice { get; set; }
        public List<P_ContractGroupByMapping> SubContractGroupByMapping { get; set; }
        public bool? IsParent { get; set; }
        public long? ParentId { get; set; }
        public decimal? TotalParentContract { get; set; }
        public decimal? TotalParentInvoice { get; set; }
    }

    public class P_ContractMapping
    {
        public int ReferID { get; set; }
        public int I_PositionID { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public int ServiceType { get; set; }
        public int ContractQuantity { get; set; }
        public decimal Price { get; set; }
        public string ContractCur { get; set; }
        public string ServiceDescription { get; set; }
        public string InvoiceCur { get; set; }
        public bool BRE { get; set; }

        public decimal Total { get; set; }

        public string ServiceCode { get; set; }

    }
}
