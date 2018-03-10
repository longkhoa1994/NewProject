using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_I_DataCheckOutMail : BaseModel
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
        public bool? HasAttachment { get; set; }

        public string ImageStatusSent { get; set; }

        public override string Table { get { return "R_I_DataCheckOutMail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_I_DataCheckOutMail_InsertOrUpdate"; } }
    }
    public enum R_I_DataCheckOutMailColumns
    {
        ID,
        R_I_DataID,
        R_M_NotificationTemplateID,
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
    public enum R_I_DataCheckOutMailProcedure
    {
        p_R_I_DataCheckOutMail_GetByImageID,
        p_R_I_DataCheckoutMail_CreateTaskForCheckoutMail
    }
    public class R_I_DataCheckOutMailList : List<R_I_DataCheckOutMail>
    {

    }
}