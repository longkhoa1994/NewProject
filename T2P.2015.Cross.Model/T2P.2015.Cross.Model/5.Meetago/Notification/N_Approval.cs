using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_Approval : BaseModel
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

        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private long _m_NotificationTemplateID;
        public long M_NotificationTemplateID
        {
            get { return _m_NotificationTemplateID; }
            set { _m_NotificationTemplateID = value; }
        }
        private string _confirmToken;
        public string ConfirmToken
        {
            get { return _confirmToken; }
            set { _confirmToken = value; }
        }
        private int _level;
        public int Level
        {
            get { return _level; }
            set { _level = value; }
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
        private int? _retry;
        public int? Retry
        {
            get { return _retry; }
            set { _retry = value; }
        }
        private int? _isSuccess;
        public int? IsSuccess
        {
            get { return _isSuccess; }
            set { _isSuccess = value; }
        }
        private bool? _isConfirmed;
        public bool? IsConfirmed
        {
            get { return _isConfirmed; }
            set { _isConfirmed = value; }
        }
        private DateTime? _confirmedDate;
        public DateTime? ConfirmedDate
        {
            get { return _confirmedDate; }
            set { _confirmedDate = value; }
        }
        private string _secondApprovalName;
        public string SecondApprovalName
        {
            get { return _secondApprovalName; }
            set { _secondApprovalName = value; }
        }
        private string _secondApprovalEmail;
        public string SecondApprovalEmail
        {
            get { return _secondApprovalEmail; }
            set { _secondApprovalEmail = value; }
        }

        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private bool? _isLocked;
        public bool? IsLocked
        {
            get { return _isLocked; }
            set { _isLocked = value; }
        }

        public override string Table { get { return "N_Approval"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_Approval_InsertOrUpdate"; } }
    }
    public enum N_ApprovalColumns
    {
        ID,
        I_DataID,
        M_NotificationTemplateID,
        ConfirmToken,
        Level,
        From,
        To,
        SendDate,
        Subject,
        Body,
        Retry,
        IsSuccess,
        IsConfirmed,
        ConfirmedDate,
        SecondApprovalName,
        SecondApprovalEmail,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
        IsLocked
    }
    public enum N_ApprovalProcedure
    {
        p_N_Approval_GetListDataToSend,
        p_N_Approval_GetEventID_ByToken,
        p_N_Approval_GetDataForApprovalLetter,
        p_N_Approval_GetByI_DataID,
        p_N_Approval_GetByToken,
        p_N_Approval_GetByB_AccessID,
        p_N_Approval_GetInformation_ByToken,
        p_N_Approval_GetListRemind,
        p_MG_GetListApprovalWaiting,
        p_MG_GetListApprovalWaiting_Total
    }
    public class N_ApprovalList : List<N_Approval>
    {

    }
}