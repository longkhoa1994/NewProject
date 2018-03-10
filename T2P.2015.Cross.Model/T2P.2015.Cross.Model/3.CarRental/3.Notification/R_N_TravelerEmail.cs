using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_TravelerEmail : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _r_I_DataID;

        public long R_I_DataID
        {
            get { return _r_I_DataID; }
            set { _r_I_DataID = value; }
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

        private string _cC;

        public string CC
        {
            get { return _cC; }
            set { _cC = value; }
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

        private DateTime _sendDate;

        public DateTime SendDate
        {
            get { return _sendDate; }
            set { _sendDate = value; }
        }

        private int _isSuccess;

        public int IsSuccess
        {
            get { return _isSuccess; }
            set { _isSuccess = value; }
        }

        public override string Table { get { return "R_N_TravelerEmail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_TravelerEmail_InsertOrUpdate"; } }
    }

    public enum R_N_TravelerEmailColumns
    {
        ID,
        R_I_DataID,
        M_NotificationTemplateID,
        From,
        To,
        CC,
        Subject,
        Body,
        MessageID,
        SendDate,
        IsSuccess,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_N_TravelerEmailProcedure
    {
    }

    public class R_N_TravelerEmailList : List<R_N_TravelerEmail>
    {
    }
}