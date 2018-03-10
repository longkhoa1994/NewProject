using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model
{
    public class P_SearchNotificationTemplate : V_Pagination
    {
        public string Subject { get; set; }
        public long LanguageID { get; set; }
        public long HotelPlatformID { get; set; }
        public string TemplateType { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string Payment { get; set; }
        public string All { get; set; }
    }

    public class P_InitialNotificationTemplate
    {
        public long TotalRecords { get; set; }
        public List<P_NotificationTemplate> ListNotificationTemplate { get; set; }
        public List<M_Language> ListLanguage { get; set; }
        public List<M_HotelPlatform> ListHotelPlatform { get; set; }
        public List<P_InitialSearchTemplate> TemplatesType { get; set; }
        public List<string> ProcessesType { get; set; }

    }

    public class P_NotificationTemplateView
    {
        public List<P_NotificationTemplate> ListNotificationTemplate { get; set; }
        public long TotalRecords { get; set; }
    }
    public class P_NotificationTemplate
    {
        public long ID { get; set; }
        public string Subject { get; set; }
        public string HotelPlatformName { get; set; }
        public string CountryFlag { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public string LetterType { get; set; }
        public string PaymentMethod { get; set; }
    }

    public class P_InitialSearchTemplate
    {
        public string TemplateType {get;set;}

        public List<string> LetterType { get; set; }
    }

    public class P_NotificationTemplateDetail : M_NotificationTemplate
    {
        public string NewAttachmentFilePath { get; set; }
        public string AttachmentFilePath { get; set; }
        public string AttachmentFileName { get; set; }
        public string HotelLogoImage { get; set; }
        public string LeftLogoMarked { get; set; }
        public string LeftLogoImage { get; set; }
        public string All { get; set; }
    }
    public class P_InitialNotificationTemplateDetail
    {
        public P_NotificationTemplateDetail TemplateDetail { get; set; }
        public List<P_NotificationTemplate> ListNotificationTemplate { get; set; }
        public List<M_Language> ListLanguage { get; set; }
        public List<M_HotelPlatform> ListHotelPlatform { get; set; }
        public List<P_InitialSearchTemplate> TemplatesType { get; set; }
        public List<M_FileLocation> ListFileLocation { get; set; }
        public List<string> ProcessesType { get; set; }
       

    }

}
