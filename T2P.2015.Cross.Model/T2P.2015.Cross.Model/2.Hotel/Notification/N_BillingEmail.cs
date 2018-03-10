using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_BillingEmail : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_HotelPlatformSettingID;
        public long? M_HotelPlatformSettingID
        {
            get { return _m_HotelPlatformSettingID; }
            set { _m_HotelPlatformSettingID = value; }
        }
        private long? _n_BillingEmailFolderID;
        public long? N_BillingEmailFolderID
        {
            get { return _n_BillingEmailFolderID; }
            set { _n_BillingEmailFolderID = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
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
        private string _cC;
        public string CC
        {
            get { return _cC; }
            set { _cC = value; }
        }       
        private DateTime _receivingDate;
        public DateTime ReceivingDate
        {
            get { return _receivingDate; }
            set { _receivingDate = value; }
        }
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
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
        private bool _isRead;
        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }
        private bool _isImportant;
        public bool IsImportant
        {
            get { return _isImportant; }
            set { _isImportant = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        private long? _isLock;
        public long? IsLock
        {
            get { return _isLock; }
            set { _isLock = value; }
        }
        private string _CIGStatus;
        public string CIGStatus
        {
            get { return _CIGStatus; }
            set { _CIGStatus = value; }
        }

        public override string Table { get { return "N_BillingEmail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_BillingEmail_InsertOrUpdate"; } }
    }
    public enum N_BillingEmailColumns
    {
        ID,
        M_HotelPlatformSettingID,
        N_BillingEmailFolderID,
        Type,
        From,
        To,
        ReceivingDate,
        Subject,
        MessageID,
        InReplyTo,
        IsRead,
        IsImportant,
        Comment,
        IsLock,
        LockedBy,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public class N_BillingEmail_Extend : N_BillingEmail
    {
        public bool IsGatewayInvoice { get; set; }
        public string Body { get; set; }
        public string BodyFilter { get; set; }
        public string Subject_LinkToBooking { get; set; }
        public string FileNameBodyText { get; set; }  
        public N_BillingEmail_Extend()
        {
            IsGatewayInvoice = false;
            Subject_LinkToBooking = string.Empty;
            Body = string.Empty;
        }            
    }

    public class N_BillingEmail_ForBillingEmailDetail : N_BillingEmail
    {
        public string Body { get; set; }
        public string BookingNo { get; set; }
        public List<N_BillingEmailAttachment_Extend> ListN_BillingEmailAttachment { get; set; }

        public N_BillingEmail_ForBillingEmailDetail()
        {
            Body = string.Empty;
            BookingNo = string.Empty;
            ListN_BillingEmailAttachment = new List<N_BillingEmailAttachment_Extend>();
        }

    }

    public class N_BillingEmail_CIG : N_BillingEmail
    {
        public long M_CompanyID { get; set; }
        public string CompanyName { get; set; }
        public int NumOfTIM { get; set; }
        public int NumOfNonTIM { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public long I_DeliveryNotificationID { get; set; }
        public string AttachmentFileName { get; set; }
        public string LocalPath { get; set; }
        public string IISPath { get; set; }
        public int ProcessStatus { get; set; }  
        public N_BillingEmail_CIG()
        {
            M_CompanyID = 0;
            CompanyName = string.Empty;
            NumOfTIM = 0;
            NumOfNonTIM = 0;
            DeliveredDate = null;
            I_DeliveryNotificationID = 0;
            AttachmentFileName = string.Empty;
            LocalPath = string.Empty;
            IISPath = string.Empty;
            ProcessStatus = 0;
            
        }
    }

    public enum N_BillingEmailProcedure
    {
        p_N_BillingEmail_CheckMessage,
        p_N_BillingEmail_GetListInvoiceMatched,
        p_N_BillingEmail_GetByIDataID,
        p_N_BillingEmail_GetListForPreprocessing,
        p_N_BillingEmail_GetListForPreprocessing_GetTotal,
        p_N_BillingEmail_GetInbox,
        p_N_BillingEmail_GetNumberOfEmailOfAType,
        p_N_BillingEmail_GetByID,
        p_N_BillingEmail_GetByID_VanTest,
        p_N_BillingEmail_GetByB_AccessID,
        p_N_Email_GetGroupBy_ID,
        p_N_BillingEmail_GetSentMail,
        p_N_BillingEmail_GetTrash,        
        p_N_BillingEmail_SearchMails,
        p_N_BillingEmail_Search_GetSearchNumber,                  
        p_N_BillingEmail_GetByI_ImageID,
        p_N_Email_Search,
        p_N_Email_Search_VanTest,
        p_N_Email_GetNumber,
        p_N_Email_GetNumber_VanTest,
        p_N_BillingEmail_GetListByListI_ImageID_ForExceptionalHandling,
        p_N_Email_GetGroupBy_N_BillingEmailIDNotMatchedToBooking,
        p_N_BillingEmail_GetList_LockedByUserID,
        p_N_Email_GetConversation,
        p_N_Email_GetBookingEmail,
        p_N_BillingEmail_Update_LockEmail,
        p_N_BillingEmail_GetListForDeleting,
        p_N_BillingEmail_GetListForArchiving_Deleting,
        p_N_BillingEmail_GetByID_ForCIG,
        p_N_Email_CIG_Search,
        p_N_Email_CIG_GetNumber,
        p_N_Email_CIG_Conversation,
        p_N_BillingEmail_Error,
        p_N_BillingEmail_GetListReservation,
        p_N_BillingEmail_Get_By_ImageID_For_Delete_Dupdicated_Invoice,
        p_N_BillingEmail_GetListForPreprocessing_ForGetNext,
        p_N_BillingEmail_GetByID_UpdateSubjectLinkBooking,
        p_N_SentBox_GetByID_UpdateSubjectLinkBooking,
        p_N_BillingEmail_UnlockEmail_InPreprocessing
    }

    public class N_BillingEmailList : List<N_BillingEmail>
    {
    }
}