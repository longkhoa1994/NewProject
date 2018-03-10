using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_ArchiveRequestFileDetail : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _i_ArchiveRequestDetailID;
        public long I_ArchiveRequestDetailID
        {
            get { return _i_ArchiveRequestDetailID; }
            set { _i_ArchiveRequestDetailID = value; }
        }
        private long? _financialID;
        public long? FinancialID
        {
            get { return _financialID; }
            set { _financialID = value; }
        }
        private string _bookingNo;
        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }
        private string _invoiceNo;
        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }
        public override string Table { get { return "I_ArchiveRequestFileDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_ArchiveRequestFileDetail_InsertOrUpdate"; } }
    }
    public enum I_ArchiveRequestFileDetailColumns
    {
        ID,
        I_ArchiveRequestDetailID,
        FinancialID,
        BookingNo,
        InvoiceNo,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_ArchiveRequestFileDetailProcedure
    {
        p_I_ArchiveRequestFileDetail_FindBookingNoAndInvoiceNo_ByInputID,
        I_ArchiveRequestFileDetail_FindBookingNoAndInvoiceNo_ByF_ImportFileID
    }
    public class I_ArchiveRequestFileDetailList : List<I_ArchiveRequestFileDetail>
    {

    }
}