using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_Collection : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _r_B_AccessID;
        public long? R_B_AccessID
        {
            get { return _r_B_AccessID; }
            set { _r_B_AccessID = value; }
        }
        private long? _r_F_TransactionID;
        public long? R_F_TransactionID
        {
            get { return _r_F_TransactionID; }
            set { _r_F_TransactionID = value; }
        }
        private long? _r_I_ImageID;
        public long? R_I_ImageID
        {
            get { return _r_I_ImageID; }
            set { _r_I_ImageID = value; }
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
        public override string Table { get { return "R_N_Collection"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_Collection_InsertOrUpdate"; } }
    }
    public enum R_N_CollectionColumns
    {
        ID,
        R_B_AccessID,
        R_F_TransactionID,
        R_I_ImageID,
        R_M_NotificationTemplateID,
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
    public enum R_N_CollectionProcedure
    {
        R_N_Collection_Get_By_R_AccessID,
        p_R_N_Collection_For_InvoiceData,
        p_R_N_Collection_For_InvoiceImage
    }
    public class R_N_CollectionList : List<R_N_Collection>
    {

    }

    public class CollectionInvoiceDataByCarProvider
    {
        public long M_CarRentalProviderID { get; set; }

        public List<CollectionFollowCompanyInvoice> ListCollectionCompanyInvoice { get; set; }

    }

    public class CollectionFollowCompanyInvoice
    {
        public long ParentID { get; set; }

        public List<CollectionFollowReturnDateInvoice> ListCollectionReturnDateInvoice { get; set; }

    }

    public class CollectionFollowReturnDateInvoice
    {
        public DateTime ReturnDate { get; set; }

        public List<CollectionInvoice> ListCollectionInvoice { get; set; }
    }

    public class CollectionInvoice
    {
        public long M_CarRentalProviderID { get; set; }

        public long ParentID { get; set; }

        public DateTime ReturnDate { get; set; }

        public long R_B_AccessID { get; set; }

        public long R_M_PlatformID { get; set; }

        public string BookingNo { get; set; }

        public string CompanyName { get; set; }

        public string TravellerName { get; set; }

        public DateTime PickupDate { get; set; }
    }
}