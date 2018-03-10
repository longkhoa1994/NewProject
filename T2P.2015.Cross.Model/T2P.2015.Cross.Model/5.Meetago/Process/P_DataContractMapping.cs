using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_DataContractMapping
    {
        public int I_PositionID { get; set; }
        public int ReferID { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }

        public int ServiceType { get; set; }

        public int ContractQuantity { get; set; }

        public decimal Price { get; set; }

        public decimal Total { get; set; }

        public DateTime? ServiceDate { get; set; }

        //contract
        public string ServiceDescription { get; set; }
        //invoice
        public string ServiceDescription2 { get; set; }
        public string ServiceCodeContract { get; set; }
        public string ServiceCodeInvoice { get; set; }
        public int InvoiceQuantity { get; set; }
        public string RejectComment { get; set; }
        public string ContractCur { get; set; }
        public List<P_DataContractMapping> SubInvoice { get; set; }
        public bool IsGrouping { get; set; }

        public string InvoiceCur { get; set; }
        public decimal AmountAfterTax { get; set; }
        public float AmountBeforeTax { get; set; }
        public bool BRE { get; set; }

        public string ErrorCode { get; set; }

        public string ErrorText { get; set; }

        public int ErrorType { get; set; }

        public string ImageStatus { get; set; }
    }
}
