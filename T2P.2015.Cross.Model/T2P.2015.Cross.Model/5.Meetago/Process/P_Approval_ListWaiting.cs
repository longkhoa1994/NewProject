using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_Approval_Waiting
    {
        public long B_EventID { get; set; }
        public long N_ApprovalID { get; set; }
        public long B_AccessID { get; set; }
        public string MeetingNo { get; set; }
        public string ContractNo { get; set; }
        public string OfferNo { get; set; }
        public string MeetingName { get; set; }
        public string CompanyName { get; set; }
        public string SupplierName { get; set; }
        public string BookerName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class P_ListApprovalWaiting
    {
        public List<P_Approval_Waiting> listApproval { get; set; }
        public long totalRecords { get; set; }

        public P_ListApprovalWaiting()
        {
            listApproval = new List<P_Approval_Waiting>();
            totalRecords = 0;
        }
    }
}
