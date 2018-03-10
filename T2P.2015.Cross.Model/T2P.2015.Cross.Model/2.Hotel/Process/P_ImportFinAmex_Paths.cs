using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_ImportFinAmex_Paths
    {
        public string LinkServer { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ServerDirectoryPath { get; set; }
        public string ServerDirectoryPathError { get; set; }
        public string LocalDirectoryName { get; set; }
        public string LocalDirectoryPath { get; set; }
        public M_FileLocation M_FileLocation { get; set; }
    }
}
