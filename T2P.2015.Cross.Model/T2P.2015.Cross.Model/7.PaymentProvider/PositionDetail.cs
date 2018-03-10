using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._7.PaymentProvider
{
    [Serializable]
    public class PositionDetail
    {
        public DateTime? ServiceDate { get; set; }
        public string ServiceName { get; set; }
        public string ServiceCode { get; set; }
        public string Extend { get; set; }
        public string AmountSign { get; set; }
        public decimal NetAmount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal GrossAmount { get; set; }
    }
}
