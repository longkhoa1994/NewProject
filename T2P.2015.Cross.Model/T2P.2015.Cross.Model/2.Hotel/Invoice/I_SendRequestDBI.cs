using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_SendRequestDBI : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _i_DataID;
        public long I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
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
        private string _token;
        public string Token
        {
            get { return _token; }
            set { _token = value; }
        }
        private string _code;
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        private DateTime? _expireTime;
        public DateTime? ExpireTime
        {
            get { return _expireTime; }
            set { _expireTime = value; }
        }
        public override string Table { get { return "I_SendRequestDBI"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_SendRequestDBI_InsertOrUpdate"; } }
    }
    public enum I_SendRequestDBIColumns
    {
        ID,
        I_DataID,
        M_NotificationTemplateID,
        From,
        To,
        CC,
        Subject,
        Body,
        MessageID,
        SendDate,
        IsSuccess,
        Token,
        Code,
        ExpireTime,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_SendRequestDBIProcedure
    {

    }
    public class I_SendRequestDBIList : List<I_SendRequestDBI>
    {

    }
}