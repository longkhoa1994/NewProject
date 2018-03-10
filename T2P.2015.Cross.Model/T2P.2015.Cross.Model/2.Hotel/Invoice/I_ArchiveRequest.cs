using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_ArchiveRequest : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private int? _requestStatus;
        public int? RequestStatus
        {
            get { return _requestStatus; }
            set { _requestStatus = value; }
        }
        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private string _companyCode;
        public string CompanyCode
        {
            get { return _companyCode; }
            set { _companyCode = value; }
        }
        private int? _type;
        public int? Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private DateTime? _fromDate;
        public DateTime? FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }
        private DateTime? _toDate;
        public DateTime? ToDate
        {
            get { return _toDate; }
            set { _toDate = value; }
        }
        public override string Table { get { return "I_ArchiveRequest"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_ArchiveRequest_InsertOrUpdate"; } }
    }
    public enum I_ArchiveRequestColumns
    {
        ID,
        RequestStatus,
        M_CompanyID,
        CompanyCode,
        Type,
        FromDate,
        ToDate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_ArchiveRequestProcedure
    {
        p_I_ArchiveRequest_CheckExist,
        p_I_ArchiveRequest_GetForResend
    }
    public enum RequestStatus
    {
        New = 1,
        WaitingForFile = 2,
        Archiving = 3,
        Complete = 4
    }
    public enum ArchiveType
    {
        InvoiceImage = 1, 
        TransactionFile = 2, 
        CollectiveStatement = 3
    }
    public class I_ArchiveRequestList : List<I_ArchiveRequest>
    {

    }
}