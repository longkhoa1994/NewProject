using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_BillingEmail_EmailList
    {
        public List<P_BillingEmail_Email> EmailList { get; set; }

        public long TotalRecord { get; set; }

        public long NumberOfTotalInbox { get; set; }
    }
}
