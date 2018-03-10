using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_DataSendTraveler : BaseModel
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
        private long? _m_FileLocationID;
        public long? M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
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
        public override string Table { get { return "I_DataSendTraveler"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_DataSendTraveler_InsertOrUpdate"; } }
    }
    public enum I_DataSendTravelerColumns
    {
        ID,
        I_DataID,
        M_FileLocationID,
        M_NotificationTemplateID,
        From,
        To,
        CC,
        AttachmentFileName,
        FilePath,
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
    public enum I_DataSendTravelerProcedure
    {
        p_I_DataSendTravelerByI_ImageID,
        p_I_DataSendTraveler_GetListForDeleting,
        p_I_DataSendTraveler_GetListForArchiving_Deleting,
        p_I_DataSendTraveler_Get_ByMessageID,
    }
    public class I_DataSendTravelerList : List<I_DataSendTraveler>
    {

    }

    
}