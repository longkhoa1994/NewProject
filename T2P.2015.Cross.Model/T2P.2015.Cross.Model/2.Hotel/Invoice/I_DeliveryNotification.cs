using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_DeliveryNotification : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_NotificationTemplateID;
        public long? M_NotificationTemplateID
        {
            get { return _m_NotificationTemplateID; }
            set { _m_NotificationTemplateID = value; }
        }
        private long? _m_FileLocationID;
        public long? M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }
        private long? _n_BillingEmailID;
        public long? N_BillingEmailID
        {
            get { return _n_BillingEmailID; }
            set { _n_BillingEmailID = value; }
        }
        private string _from;
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        private string _to;
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        private string _attachmentFileName;
        public string AttachmentFileName
        {
            get { return _attachmentFileName; }
            set { _attachmentFileName = value; }
        }
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        private string _body;
        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }
        private string _messageID;
        public string MessageID
        {
            get { return _messageID; }
            set { _messageID = value; }
        }
        private string _inReplyTo;
        public string InReplyTo
        {
            get { return _inReplyTo; }
            set { _inReplyTo = value; }
        }
        private DateTime? _sendDate;
        public DateTime? SendDate
        {
            get { return _sendDate; }
            set { _sendDate = value; }
        }
        public override string Table { get { return "I_DeliveryNotification"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_DeliveryNotification_InsertOrUpdate"; } }
    }
    public enum I_DeliveryNotificationColumns
    {
        ID,
        M_NotificationTemplateID,
        M_FileLocationID,
        N_BillingEmailID,
        From,
        To,
        AttachmentFileName,
        FilePath,
        Subject,
        Body,
        MessageID,
        InReplyTo,
        SendDate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_DeliveryNotificationProcedure
    {
        p_I_DeliveryNotification_GetListForDeleting,
        p_I_DeliveryNotification_GetListIDForDeleting
    }
    public class I_DeliveryNotificationList : List<I_DeliveryNotification>
    {

    }
}