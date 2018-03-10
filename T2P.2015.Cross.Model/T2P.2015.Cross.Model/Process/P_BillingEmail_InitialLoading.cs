
using System.Collections.Generic;
namespace T2P._2015.Cross.Model.Process
{
    public class P_BillingEmail_InitialLoading
    {
        public P_BillingEmail_EmailList InboxInformationList { get; set; }

        public long NumberOfUnreadInformationEmails { get; set; }

        public long NumberOfUnreadOtherEmails { get; set; }

        public long NumberOfUnreadInvoiceEmails { get; set; }

        public long NumberOfImportantEmails { get; set; }
    }
}
