

namespace T2P._2015.Cross.Model.Process
{
    public class P_SuccessfulInvoice_Tax
    {
        public decimal? TaxRate { get; set; }

        public string TaxCode { get; set; }

        public double? NetAmount { get; set; }

        public double? TaxAmount { get; set; }

        public double? GrossAmount { get; set; }

        public string CurrencyCode { get; set; }
    }
}
