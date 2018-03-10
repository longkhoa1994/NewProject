using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.SBF
{
    public class SBF_FileExport
    {
        public F_ImportFile ImportFile { get; set; }
        public SBF_E_File File { get; set; }
        public SBF_E_Client Client { get; set; }
        public List<SBF_E_Company> ListCompanies { get; set; }

    }
}
