using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_Information : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        private long? _i_ImageID;
        public long? I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }

        private long? _f_TransactionID;

        public long? F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }

        private long _m_NotificationTemplateID;
        public long M_NotificationTemplateID
        {
            get { return _m_NotificationTemplateID; }
            set { _m_NotificationTemplateID = value; }
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
        private string _faxID;
        public string FaxID
        {
            get { return _faxID; }
            set { _faxID = value; }
        }
        private int? _isSuccess;
        public int? IsSuccess
        {
            get { return _isSuccess; }
            set { _isSuccess = value; }
        }
        public override string Table { get { return "N_Information"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_Information_InsertOrUpdate"; } }
    }
    public enum N_InformationColumns
    {
        ID,
        B_AccessID,
        I_ImageID,
        F_TransactionID,
        M_NotificationTemplateID,
        From,
        To,
        SendDate,
        Subject,
        Body,
        MessageID,
        FaxID,
        IsSuccess,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum N_InformationProcedure
    {
        p_N_Information_GetByB_AccessID,
        p_N_Information_GetListForDeleting,
        p_N_Information_GetListForArchiving_Deleting,
    }

    public class N_InformationList : List<N_Information>
    {
    }
}