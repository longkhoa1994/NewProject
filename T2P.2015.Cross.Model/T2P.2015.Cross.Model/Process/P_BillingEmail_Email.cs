

using System;
using System.Collections.Generic;
using T2P._2015.Cross.Enum;
namespace T2P._2015.Cross.Model.Process
{
    public class P_BillingEmail_Email
    {
        public long ID { get; set; }
        public string EmailAddress { get; set; } // either From email or To email

        public string Subject { get; set; }

        public DateTime Date { get; set; }

        public bool IsImportant { get; set; }

        public bool IsHavingAttachment { get; set; }

        public bool IsRead { get; set; }

        public bool IsSelected { get; set; }

        public bool IsExpanded { get; set; }

        public MailBoxType MailBoxType { get; set; }

        public bool IsHavingConversations { get; set; }

        public bool IsDeleted { get; set; }

        public List<P_Notification_Conversation> ConversationList { get; set; }
    }
}
