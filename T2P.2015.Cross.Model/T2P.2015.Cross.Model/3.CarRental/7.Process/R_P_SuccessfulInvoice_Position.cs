using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.CarRental
{
    public class R_P_SuccessfulInvoice_Position
    {
        public string ServiceCode { get; set; }             
        public string ServiceName { get;set; }
        public string Currency { get; set; }
        public float Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float NetAmount { get; set; }
        public float TaxAmount { get; set; }
        public float TaxRate { get; set; }
        public float GrossAmount { get; set; }       
    }
}
