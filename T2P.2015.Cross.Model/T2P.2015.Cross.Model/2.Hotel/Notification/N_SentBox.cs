using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_SentBox : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_HotelPlatformSettingID;
        public long M_HotelPlatformSettingID
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

        private string _bCC;

        
        public string BCC
        {
            get { return _bCC; }
            set { _bCC = value; }
        }

        private DateTime _sendDate;

        public DateTime SendDate
        {
            get { return _sendDate; }
            set { _sendDate = value; }
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

        private string _bodyFilter;

        public string BodyFilter
        {
            get { return _bodyFilter; }
            set { _bodyFilter = value; }
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

        private bool _isImportant;

        public bool IsImportant
        {
            get { return _isImportant; }
            set { _isImportant = value; }
        }
        private int? _emailResult;
        public int? EmailResult
        {
            get { return _emailResult; }
            set { _emailResult = value; }
        }
        private int _isSuccess;

        public int IsSuccess
        {
            get { return _isSuccess; }
            set { _isSuccess = value; }
        }
        private long? _a_UserTemplateTranslationID;

        public long? A_UserTemplateTranslationID
        {
            get { return _a_UserTemplateTranslationID; }
            set { _a_UserTemplateTranslationID = value; }
        }


        public override string Table { get { return "N_SentBox"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_N_SentBox_InsertOrUpdate"; } }
    }

    public class N_SentBox_Extend : N_SentBox
    {
        public string Subject_LinkToBooking { get; set; }  
        public List<N_SentBoxAttachment_Extend> ListN_SentBoxAttachment { get; set; }

        public N_SentBox_Extend()
        {
            Subject_LinkToBooking = string.Empty;
            ListN_SentBoxAttachment = new List<N_SentBoxAttachment_Extend>();
        }
    }

    public enum N_SentBoxColumns
    {
        ID,
        M_HotelPlatformSettingID,
        N_BillingEmailFolderID,
        A_UserTemplateTranslationID,
        From,
        To,
        CC,
        BCC,
        SendDate,
        Subject,
        Body,
        BodyFilter,
        MessageID,
        InReplyTo,
        IsImportant,
        EmailResult,
        IsSuccess,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum N_SentBoxProcedure
    {
        p_N_SentBox_GetByB_AccessID,
        p_N_SentBox_GetByID,
        p_N_SentBox_GetSentBoxList,
        p_N_SentBox_GetListForDeleting,
        p_N_SentBox_GetListForArchiving_Deleting        
    }

    public class N_SentBoxList : List<N_SentBox>
    {
    }
}