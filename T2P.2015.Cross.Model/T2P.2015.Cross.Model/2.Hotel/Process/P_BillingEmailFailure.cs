using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class P_BillingEmailFailure : N_BillingEmail
    {
        private string _body;

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        private string _bodyFilter;

        public string BodyFilter
        {
            get { return _bodyFilter; }
            set { _bodyFilter = value; }
        }

        public string FileNameBodyText { get; set; }
    }
}
