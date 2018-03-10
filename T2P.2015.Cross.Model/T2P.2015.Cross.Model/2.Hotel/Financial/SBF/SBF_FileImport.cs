using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Financial.SBF
{
    public class SBF_FileImport
    {
        public F_ImportFile ImportFile { get; set; }
        public SBF_I_File File { get; set; }
        public SBF_I_Client Client { get; set; }
        public List<SBF_I_Company> ListCompanies { get; set; }
    }
}
