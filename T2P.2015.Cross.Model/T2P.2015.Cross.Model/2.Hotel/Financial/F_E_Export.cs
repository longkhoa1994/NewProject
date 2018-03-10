using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_Export : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_NotificationTemplateID;
        public long M_NotificationTemplateID
        {
            get { return _m_NotificationTemplateID; }
            set { _m_NotificationTemplateID = value; }
        }
        private string _fromAddress;
        public string FromAddress
        {
            get { return _fromAddress; }
            set { _fromAddress = value; }
        }
        private string _toAddress;
        public string ToAddress
        {
            get { return _toAddress; }
            set { _toAddress = value; }
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
        public override string Table { get { return "F_E_Export"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_Export_InsertOrUpdate"; } }
    }
    public enum F_E_ExportColumns
    {
        ID,
        M_NotificationTemplateID,
        FromAddress,
        ToAddress,
        Subject,
        Body,
        MessageID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_ExportProcedure
    {

    }
    public class F_E_ExportList : List<F_E_Export>
    {

    }
}