using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_F_ImportFile : F_ImportFile
    {
        public string FullFilePath { get; set; }
        public long M_FileLocationID { get; set; }
        public string FileType { get; set; }
    }
}
