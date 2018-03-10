using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._7.PaymentProvider
{
    public class F_TransactionDetail
    {
        public FINStructure ImportFile { get; set; }
        public FINStructure ExportFile { get; set; }
        public FINStructure VTIFile { get; set; }
        public FINStructure ImportFile_Relation { get; set; }
        public FINStructure ExportFile_Relation { get; set; }
    }
}
