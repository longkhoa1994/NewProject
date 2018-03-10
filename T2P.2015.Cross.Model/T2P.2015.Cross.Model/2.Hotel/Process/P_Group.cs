using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Group
    {
        public A_Group A_Group { get; set; }
        public List<A_Group> ListGroup { get; set; }
        public List<A_Group> ListGroupAndItelya { get; set; }
        public List<M_InvoiceErrorCode> ListErrorCode { get; set; }
        public List<M_InvoiceErrorCode> ListGroupErrorCode { get; set; }
        public P_Group()
        {
            A_Group = new A_Group();
            ListGroup = new List<A_Group>();
            ListErrorCode = new List<M_InvoiceErrorCode>();
            ListGroupErrorCode = new List<M_InvoiceErrorCode>();
        }
    }
}
