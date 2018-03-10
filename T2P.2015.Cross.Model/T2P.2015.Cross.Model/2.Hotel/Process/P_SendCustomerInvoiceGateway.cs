

namespace T2P._2015.Cross.Model.Process
{
    public class P_SendCustomerInvoiceGateway
    {       
        public string MailUsername { get; set; }
        public string MailPassword { get; set; }
        public string MailServer { get; set; }
        public string ZipPassword { get; set; }        
        public string From { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Subject { get; set; }
        public string BodyText { get; set; }
        public string BodyTextDB { get; set; }
        public long M_NotificationTemplateID { get; set; }
        public long M_FileLocationID { get; set; }
        public long N_BillingEmailID { get; set; }
        public string InReplyTo { get; set; }        
        public string LocalPathCompanyLogo { get; set; }
        public string LocalPathAirPlusLogo { get; set; }
        public string LocalPathHotelPlatformLogo { get; set; }


    }

    public enum P_SendCustomerInvoiceGatewayProcedure
    {
        p_P_CustomerInvoiceGateway_Delivery
    }
}
