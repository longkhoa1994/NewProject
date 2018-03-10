using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_Rejection : BaseModel
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
        public override string Table { get { return "N_Rejection"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_Rejection_InsertOrUpdate"; } }
    }

    public class N_Rejection_Extend : N_Rejection
    {
        public string IISPath { get; set; }
        public List<I_Image_Extend> ListI_Image { get; set; }

        public N_Rejection_Extend()
        {
            IISPath = string.Empty;
            ListI_Image = new List<I_Image_Extend>();
        }
    }
    public enum N_RejectionColumns
    {
        ID,
        I_DataID,
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
    public enum N_RejectionProcedure
    {
        p_N_Rejection_GetByInvoiceIDAndCategoryTemplate,
        p_N_Rejection_GetByB_AccessID,
        p_N_Rejection_GetListByListInvoiceID,
        p_N_Rejection_GetByI_DataID,
        p_N_Rejection_GetListForDeleting,
        p_N_Rejection_GetListForArchiving_Deleting,
    }
    public class N_RejectionList : List<N_Rejection>
    {

    }
}