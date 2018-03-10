using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.Process;

namespace T2P._2015.Cross.Model._4.Airbnb
{
    public class A_FillingDBI
    {
        List<A_DBI> _DBI;

        public List<A_DBI> DBI
        {
            get { return _DBI; }
            set { _DBI = value; }
        }

        N_BillingEmail emailDetail;

        public N_BillingEmail EmailDetail
        {
            get { return emailDetail; }
            set { emailDetail = value; }
        }

    }
}
