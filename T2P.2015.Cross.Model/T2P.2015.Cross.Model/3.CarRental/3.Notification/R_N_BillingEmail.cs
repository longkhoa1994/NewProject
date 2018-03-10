using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_BillingEmail : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_CarRentalProviderSettingID;

        public long M_CarRentalProviderSettingID
        {
            get { return _m_CarRentalProviderSettingID; }
            set { _m_CarRentalProviderSettingID = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
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

        private DateTime _receivingDate;

        public DateTime ReceivingDate
        {
            get { return _receivingDate; }
            set { _receivingDate = value; }
        }

        private string _subject;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
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

        private bool _isRead;

        public bool IsRead
        {
            get { return _isRead; }
            set { _isRead = value; }
        }

        private bool _isImportant;

        public bool IsImportant
        {
            get { return _isImportant; }
            set { _isImportant = value; }
        }

        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public override string Table { get { return "R_N_BillingEmail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_BillingEmail_InsertOrUpdate"; } }
    }

    public enum R_N_BillingEmailColumns
    {
        ID,
        M_HotelPlatformSettingID,
        Type,
        From,
        To,
        CC,
        ReceivingDate,
        Subject,
        MessageID,
        InReplyTo,
        IsRead,
        IsImportant,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_N_BillingEmailProcedure
    {
        p_R_N_BillingEmail_CheckMessage,
        p_R_N_BillingEmail_GetSearch,
        p_R_N_BillingEmail_Get_List_By_ListID_ForBillingEmail,
        p_R_N_BillingEmail_Get_Email_Detail_ForBillingEmail,
        p_R_N_BillingEmail_GetNumber,
        p_R_N_BillingEmail_GetBy_ImageId,
        p_R_N_BillingEmail_CheckEmailMacthBooking,
        p_R_N_Email_GetConversation,
        p_R_N_Email_GetBy_ID,
        p_R_N_BillingEmail_GetEmail_Information_Match_Again_Image
    }

    public class R_N_BillingEmailList : List<R_N_BillingEmail>
    {
    }
}