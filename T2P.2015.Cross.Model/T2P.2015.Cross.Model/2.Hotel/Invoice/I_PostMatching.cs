using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T2P._2015.Model;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_PostMatching : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        private long _i_ImageID;
        public long I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }
        private long _n_BillingEmailID;
        public long N_BillingEmailID
        {
            get { return _n_BillingEmailID; }
            set { _n_BillingEmailID = value; }
        }
        private long? _i_ReplacedID;
        public long? I_ReplacedID
        {
            get { return _i_ReplacedID; }
            set { _i_ReplacedID = value; }
        }
        private string _actionType;
        public string ActionType
        {
            get { return _actionType; }
            set { _actionType = value; }
        }
        private bool? _isCopy;
        public bool? IsCopy
        {
            get { return _isCopy; }
            set { _isCopy = value; }
        }
        private bool? _isUseOldData;
        public bool? IsUseOldData
        {
            get { return _isUseOldData; }
            set { _isUseOldData = value; }
        }
        private bool? _isGatewayInvoice;
        public bool? IsGatewayInvoice
        {
            get { return _isGatewayInvoice; }
            set { _isGatewayInvoice = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        private string _bookingNoSC;
        public string BookingNoSC
        {
            get { return _bookingNoSC; }
            set { _bookingNoSC = value; }
        }

        private string _invoiceNoSC;

        public string InvoiceNoSC
        {
            get { return _invoiceNoSC; }
            set { _invoiceNoSC = value; }
        }

        private long? _duplicatedID;
        public long? DuplicatedID
        {
            get { return _duplicatedID; }
            set { _duplicatedID = value; }
        }
        public bool IsInformationInvoice { get; set; }

        public List<N_Task> task { get; set; }

        public P_NextBookingStep BookingStep { get; set; }
        public override string Table { get { return "I_PostMatching"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_PostMatching_InsertOrUpdate"; } }
    }
    public enum I_PostMatchingColumns
    {
        ID,
        B_AccessID,
        I_ImageID,
        N_BillingEmailID,
        I_ReplacedID,
        ActionType,
        IsCopy,
        IsUseOldData,
        IsGatewayInvoice,
        Comment,
        BookingNoSC,
        DuplicatedID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_PostMatchingProcedure
    {
        I_PostMatching_GetList,
        I_PostMatching_GetList_FullTable
 
    }
    public class I_PostMatchingList : List<I_PostMatching>
    {

    }
}