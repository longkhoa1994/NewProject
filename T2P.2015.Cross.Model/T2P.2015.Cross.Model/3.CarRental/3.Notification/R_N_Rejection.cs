using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_Rejection : BaseModel
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

        public long? R_I_ReportID { get; set; }

        public override string Table { get { return "R_N_Rejection"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_Rejection_InsertOrUpdate"; } }
    }

    public enum R_N_RejectionColumns
    {
        ID,
        R_I_DataID,
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

    public enum R_N_RejectionProcedure
    {
        p_R_N_Rejection_Get_By_ImageID,
        p_R_N_Rejection_Get_By_ListR_I_DataID,
        p_R_N_Rejection_Get_By_R_B_AccessID
    }

    public class R_N_RejectionList : List<R_N_Rejection>
    {
    }
}