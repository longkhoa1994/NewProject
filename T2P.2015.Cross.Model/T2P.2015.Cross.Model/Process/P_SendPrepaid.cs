

namespace T2P._2015.Cross.Model.Process
{
    public class P_SendPrepaid
    {       
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string BodyText { get; set; }
        public string BodyTextDB { get; set; }
        public string BodyFax { get; set; }
        public long M_NotificationTemplateID { get; set; }
        public string LocalPathCompanyLogo { get; set; }
        public string LocalPathAirPlusLogo { get; set; }
        public string LocalPathHotelPlatformLogo { get; set; }

        
    }

    public enum P_SendPrepaidProcedure
    {
        p_P_SendPrepaid_ByB_AccessID
    }
}
