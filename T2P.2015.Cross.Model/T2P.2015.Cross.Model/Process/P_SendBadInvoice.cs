

namespace T2P._2015.Cross.Model.Process
{
    public class P_SendBadInvoice
    {
        public string MailUsername { get; set; }
        public string MailPassword { get; set; }
        public string MailServer { get; set; }
        public bool IsSendFax { get; set; }        
        public string FaxUsername { get; set; }
        public string FaxPassword { get; set; }
        public string FaxNumber { get; set; }        
        public string From { get; set; }
        public string To { get; set; }
        public string MessageID { get; set; }
        public string Subject { get; set; }
        public string BodyText { get; set; }
        public string BodyTextDB { get; set; }
        public string BodyFax { get; set; }
        public long M_NotificationTemplateID { get; set; }
        public string LocalPathHotelPlatformLogo { get; set; }        
    }

    public enum P_SendBadInvoiceProcedure
    {
        p_P_SendBadInvoice_ByI_ImageID
    }
}
