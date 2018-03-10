
using System;

namespace T2P._2015.Cross.Model.Process
{
    public class P_SuccessfulInvoice_Position
    {
        public DateTime? ServiceDate { get; set; }

        public string ServiceDescription { get; set; }

        public string ServiceCode { get; set; }

        public decimal? AmountBeforeTax { get; set; }

        public decimal? TaxRate { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? AmountAfterTax { get; set; }

        public string CurrencyCode { get; set; }
    }
}
