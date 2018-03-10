using System;
using System.Collections.Generic;
using T2P._2015.Cross.Model.Process;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_Information : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _r_M_NotificationTemplateID;
        public long R_M_NotificationTemplateID
        {
            get { return _r_M_NotificationTemplateID; }
            set { _r_M_NotificationTemplateID = value; }
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

        private string _token;
        public string Token
        {
            get { return _token; }
            set { _token = value; }
        }

        private DateTime? _expiredTime;
        public DateTime? ExpiredTime
        {
            get { return _expiredTime; }
            set { _expiredTime = value; }
        }

        private int _tokenStatus;
        public int TokenStatus
        {
            get { return _tokenStatus; }
            set { _tokenStatus = value; }
        }

        private long? _i_ArchiveID;

        public long? I_ArchiveID
        {
            get { return _i_ArchiveID; }
            set { _i_ArchiveID = value; }
        }
        public override string Table { get { return "R_N_Information"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_Information_InsertOrUpdate"; } }
    }
    public enum R_N_InformationColumns
    {
        ID,
        R_M_NotificationTemplateID,
        From,
        To,
        SendDate,
        Subject,
        Body,
        MessageID,
        FaxID,
        IsSuccess,
        I_ArchiveID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,

    }

    public enum R_N_InformationProcedure
    {
        

    }

    public class R_N_InformationList : List<R_N_Information>
    {
    }

}