using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyArchivedSetting : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CompanyID;
        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private string _uploadFrequency;
        public string UploadFrequency
        {
            get { return _uploadFrequency; }
            set { _uploadFrequency = value; }
        }
        private string _uploadPeriod;
        public string UploadPeriod
        {
            get { return _uploadPeriod; }
            set { _uploadPeriod = value; }
        }
        private string _archivingFrequency;
        public string ArchivingFrequency
        {
            get { return _archivingFrequency; }
            set { _archivingFrequency = value; }
        }
        private string _archivingPeriod;
        public string ArchivingPeriod
        {
            get { return _archivingPeriod; }
            set { _archivingPeriod = value; }
        }
        private string _zipPassword;
        public string ZipPassword
        {
            get { return _zipPassword; }
            set { _zipPassword = value; }
        }
        private DateTime? _lastArchivedDate;
        public DateTime? LastArchivedDate
        {
            get { return _lastArchivedDate; }
            set { _lastArchivedDate = value; }
        }

        private DateTime? _lastArchivedDateRC;
        public DateTime? LastArchivedDateRC
        {
            get { return _lastArchivedDateRC; }
            set { _lastArchivedDateRC = value; }
        }
        private string _companyNumber;
        public string CompanyNumber
        {
            get { return _companyNumber; }
            set { _companyNumber = value; }
        }
        private string _notificationEmail;
        public string NotificationEmail
        {
            get { return _notificationEmail; }
            set { _notificationEmail = value; }
        }
        private bool? _transactionFile;
        public bool? TransactionFile
        {
            get { return _transactionFile; }
            set { _transactionFile = value; }
        }
        private bool? _invoiceImage;
        public bool? InvoiceImage
        {
            get { return _invoiceImage; }
            set { _invoiceImage = value; }
        }
        private bool? _transactionPaper;
        public bool? TransactionPaper
        {
            get { return _transactionPaper; }
            set { _transactionPaper = value; }
        }
        private int? _fileSize;

        public int? FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; }
        }
        public bool UseDownloadCenter { get; set; }
        public override string Table { get { return "M_CompanyArchivedSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyArchivedSetting_InsertOrUpdate"; } }
    }
    public enum M_CompanyArchivedSettingColumns
    {
        ID,
        M_CompanyID,
        UploadFrequency,
        UploadPeriod,
        ArchivingFrequency,
        ArchivingPeriod,
        ZipPassword,
        LastArchivedDate,
        CompanyNumber,
        NotificationEmail,
        TransactionFile,
        InvoiceImage,
        TransactionPaper,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyArchivedSettingProcedure
    {
        p_M_CompanyArchivedSetting_GetListSetting,
        p_M_CompanyArchivedSetting_CheckDuplicateCompanyCode
    }
    public class M_CompanyArchivedSettingList : List<M_CompanyArchivedSetting>
    {

    }
}