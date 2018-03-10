using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.CarRental
{
    public class R_P_SuccessfulInvoice_Tax
    {
        public float TaxRate { get; set; }

        public float NetAmount { get; set; }
        public float TaxAmount { get; set; }
        public float GrossAmount { get; set; }
    }
}
