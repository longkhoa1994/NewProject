using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Enum;
using T2P._2015.Cross.Utility.Conversion;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Notification_BillingEmail
    {
        public MailBoxType MailBoxType { get; set; }
        public long ID { get; set; }
        public string Type { get; set; }
        public bool IsImportant { get; set; }
        public bool IsRead { get; set; }
        public int CountAttachment { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsGatewayInvoice { get; set; }
        public int CIGProcessStatus { get; set; }    
        public string ListBookingStr { get; set; }
        public bool HasConversation { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public List<P_Notification_Conversation> ListConversation { get; set; }
        public List<P_Notification_EmailBooking> ListBooking
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(ListBookingStr))
                {
                    return ListBookingStr.Split('|')
                        .Select(s => new P_Notification_EmailBooking { 
                            B_AccessID = Conversion.ObjectToLong(s.Split('*')[0]), 
                            BookingNo = Conversion.ObjectToString(s.Split('*')[1]) 
                        }).ToList();
                }
                else
                {
                    return new List<P_Notification_EmailBooking>();
                }
            }
        }
        public P_Notification_BillingEmail()
        {
            ID = 0;
            Type = string.Empty;
            IsImportant = false;
            IsRead = true;
            CountAttachment = 0;
            Subject = string.Empty;
            CountryCode = string.Empty;
            CountryName = string.Empty;
            IsGatewayInvoice = false;
            CIGProcessStatus = 0;
            HasConversation = false;
            ListConversation = new List<P_Notification_Conversation>();
        }
    }

    public class P_Notification_ForBillingEmail
    {
        public long ID { get; set; }
        public MailBoxType MailBoxType { get; set; }
        public string BookingNo { get; set; }
        public long B_AccessID { get; set; }
        public string Subject { get; set; }
        public string Subject_LinkToBooking { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string CC { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Comment { get; set; }       
        public string Body { get; set; }
        public bool IsImportant { get; set; }
        public string MessageID { get; set; }
        public bool IsGatewayInvoice { get; set; }
        public List<N_BillingEmailAttachment_Extend> ListAttachmentFile { get; set; }
        public List<P_Notification_Conversation> ListConversation { get; set; }
        public List<P_Notification_EmailBooking> ListEmailBooking { get; set; }
        public P_Notification_ForBillingEmail()
        {
            ID = 0;
            BookingNo = string.Empty;
            B_AccessID = 0;
            Subject = string.Empty;
            Sender = string.Empty;
            CC = string.Empty;
            Comment = string.Empty;
            IsImportant = false;
            Body = string.Empty;
            Receiver = string.Empty;
            MessageID = string.Empty;
            IsGatewayInvoice = false;
            ListAttachmentFile = new List<N_BillingEmailAttachment_Extend>();
            ListConversation = new List<P_Notification_Conversation>();
            ListEmailBooking = new List<P_Notification_EmailBooking>();
        }
    }

    public class P_Notification_EmailBooking
    {
        public long B_AccessID { get; set; }
        public string BookingNo { get; set; }
        public P_Notification_EmailBooking()
        {
            B_AccessID = 0;
            BookingNo = string.Empty;
        }
    }

    public class P_Notification_Conversation
    {
        public long ID { get; set; }
        public NotificationType NotificationType { get; set; }
        public string Subject { get; set; }
        public string Sender { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsLoadedData { get; set; }
        public bool IsShowData { get; set; }
        public P_Notification_Conversation()
        {
            ID = 0;
            Subject = string.Empty;
            Sender = string.Empty;
            To = string.Empty;
            CC = string.Empty;
            Body = string.Empty;
            IsLoadedData = false;
            IsShowData = false;

        }
    }

}
