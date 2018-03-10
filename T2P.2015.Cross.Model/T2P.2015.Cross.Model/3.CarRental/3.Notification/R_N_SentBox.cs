using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_SentBox : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _m_CarRentalProviderSettingID;

        public long? M_CarRentalProviderSettingID
        {
            get { return _m_CarRentalProviderSettingID; }
            set { _m_CarRentalProviderSettingID = value; }
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

        private int? _isSuccess;

        public int? IsSuccess
        {
            get { return _isSuccess; }
            set { _isSuccess = value; }
        }

        public override string Table { get { return "R_N_SentBox"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_SentBox_InsertOrUpdate"; } }
    }

    public enum R_N_SentBoxColumns
    {
        ID,
        M_CarRentalProviderSettingID,
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
        IsSuccess,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_N_SentBoxProcedure
    {
        p_R_N_SentBox_Get_List_By_ListID_ForBillingEmail,
    }

    public class R_N_SentBoxList : List<R_N_SentBox>
    {
    }
}