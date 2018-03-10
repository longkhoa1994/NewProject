using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_Header : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_FileLocationID;
        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        private string _fileNameResult;
        public string FileNameResult
        {
            get { return _fileNameResult; }
            set { _fileNameResult = value; }
        }
        private string _fileType;
        public string FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
        }
        private string _transactionIdentifier;
        public string TransactionIdentifier
        {
            get { return _transactionIdentifier; }
            set { _transactionIdentifier = value; }
        }
        private DateTime _productionsDate;
        public DateTime ProductionsDate
        {
            get { return _productionsDate; }
            set { _productionsDate = value; }
        }
        private string _productionTime;
        public string ProductionTime
        {
            get { return _productionTime; }
            set { _productionTime = value; }
        }
        private string _version;
        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }
        private long _transactionCount;
        public long TransactionCount
        {
            get { return _transactionCount; }
            set { _transactionCount = value; }
        }
        private string _errorMessage;
        public string ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        private long? _replaceID;
        public long? ReplaceID
        {
            get { return _replaceID; }
            set { _replaceID = value; }
        }
        private string _companyIdentify;
        public string CompanyIdentify
        {
            get { return _companyIdentify; }
            set { _companyIdentify = value; }
        }
        private string _sequenceID;
        public string SequenceID
        {
            get { return _sequenceID; }
            set { _sequenceID = value; }
        }
        private int? _reprintCounter;
        public int? ReprintCounter
        {
            get { return _reprintCounter; }
            set { _reprintCounter = value; }
        }

        private bool _isDelivery;

        public bool IsDelivery
        {
            get { return _isDelivery; }
            set { _isDelivery = value; }
        }

        private long? _totalTransaction;

        public long? TotalTransaction
        {
            get { return _totalTransaction; }
            set { _totalTransaction = value; }
        }

        public override string Table { get { return "F_Header"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_Header_InsertOrUpdate"; } }
    }

    public class F_HeaderImport : F_Header
    { 
        public List<F_Transaction> ListFinTransaction { get; set; }

        public F_HeaderImport()
        {
            ListFinTransaction = new List<F_Transaction>();
        }
    }

    public enum F_HeaderColumns
    {
        ID,
        M_FileLocationID,
        FileName,
        FilePath,
        FileNameResult,
        FileType,
        TransactionIdentifier,
        ProductionsDate,
        ProductionTime,
        Version,
        TransactionCount,
        ErrorMessage,
        Comment,
        ReplaceID,
        CompanyIdentify,
        SequenceID,
        ReprintCounter,
        IsDelivery,
        TotalTransaction,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_HeaderProcedure
    {
        p_F_Header_GetList_CheckHeader,
        p_F_Header_GetListForDeleting,
        p_F_Header_GetListIDForDeleting,
        p_F_Header_Get_ForUpdatePriority5,
        p_F_Header_GetList_ByListID,
    }
    public class F_HeaderList : List<F_Header>
    {

    }

    public enum F_HeaderLenght
    {
        length = 53,
    }

    public enum F_HeaderColumnsLenght
    {
        ID,
        M_FileLocationID,
        FileName = 200,
        FilePath = 200,
        FileNameResult = 200,
        RecordIdentifier = 3,
        FileType = 11,
        UniqueFileID = 10,
        FileProducer = 3,
        ProductionsDate = 8,
        ProductionTime = 6,
        Version = 3,
        TestsystemIndicator = 1,
        PostingDate = 8,
        TransactionCount,
        ErrorMessage,
        Comment = 200,
        ReplaceID,
        CompanyIdentify = 100,
        SequenceID = 100,
        ReprintCounter,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
}