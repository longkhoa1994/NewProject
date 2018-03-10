using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_ImportFile : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_F_FileTypeID;
        public long M_F_FileTypeID
        {
            get { return _m_F_FileTypeID; }
            set { _m_F_FileTypeID = value; }
        }
        private long _m_DownloadServerID;
        public long M_DownloadServerID
        {
            get { return _m_DownloadServerID; }
            set { _m_DownloadServerID = value; }
        }
        private long _m_PaymentProviderID;
        public long M_PaymentProviderID
        {
            get { return _m_PaymentProviderID; }
            set { _m_PaymentProviderID = value; }
        }
        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        private int _importStatus;
        public int ImportStatus
        {
            get { return _importStatus; }
            set { _importStatus = value; }
        }
        private int _fileStatus;
        public int FileStatus
        {
            get { return _fileStatus; }
            set { _fileStatus = value; }
        }
        private int _deliveryStatus;
        public int DeliveryStatus
        {
            get { return _deliveryStatus; }
            set { _deliveryStatus = value; }
        }
        private long? _oldID;
        public long? OldID
        {
            get { return _oldID; }
            set { _oldID = value; }
        }
        private DateTime? _uploadDateTime;
        public DateTime? UploadDateTime
        {
            get { return _uploadDateTime; }
            set { _uploadDateTime = value; }
        }
        private int _totalTransaction;
        public int TotalTransaction
        {
            get { return _totalTransaction; }
            set { _totalTransaction = value; }
        }
        private int _processingTransaction;

        public int ProcessingTransaction
        {
            get { return _processingTransaction; }
            set { _processingTransaction = value; }
        }
        private int _specialTransaction;

        public int SpecialTransaction
        {
            get { return _specialTransaction; }
            set { _specialTransaction = value; }
        }
        private int _enrichedTransaction;

        public int EnrichedTransaction
        {
            get { return _enrichedTransaction; }
            set { _enrichedTransaction = value; }
        }
        public override string Table { get { return "F_ImportFile"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_ImportFile_InsertOrUpdate"; } }
    }
    public enum F_ImportFileColumns
    {
        ID,
        M_FileTypeID,
        M_DownloadServerID,
        ProviderName,
        FilePath,
        FileName,
        ImportStatus,
        OldID,
        UploadDateTime,
        TotalTransaction,
	    ProcessingTransaction,
	    SpecialTransaction,
	    EnrichedTransaction,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_ImportFileProcedure
    {
        p_F_ImportFile_Get_By_CompanyID,
        p_F_DisplayImportFile_Search,
        p_F_DisplayImportFile_Search_TotalRecord,
        p_F_ImportFile_GetListFileToImport,
        p_F_DisplayHistory_File,
        p_F_ImportFile_GetBy_F_TransactionID,
        p_F_ImportFile_IsFileDuplicated
    }
    public class F_ImportFileList : List<F_ImportFile>
    {

    }
}