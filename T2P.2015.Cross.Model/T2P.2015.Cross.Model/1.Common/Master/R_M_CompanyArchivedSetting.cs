using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_CompanyArchivedSetting : BaseModel
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

        private DateTime? _lastArchivedDateRC;
        public DateTime? LastArchivedDateRC
        {
            get { return _lastArchivedDateRC; }
            set { _lastArchivedDateRC = value; }
        }
        private string _notificationEmail;
        public string NotificationEmail
        {
            get { return _notificationEmail; }
            set { _notificationEmail = value; }
        }
        private bool? _invoiceImage;
        public bool? InvoiceImage
        {
            get { return _invoiceImage; }
            set { _invoiceImage = value; }
        }
        private int? _fileSize;

        public int? FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; }
        }
        public bool UseDownloadCenter { get; set; }
        public override string Table { get { return "R_M_CompanyArchivedSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_CompanyArchivedSetting_InsertOrUpdate"; } }
    }
    public enum R_M_CompanyArchivedSettingColumns
    {
        ID,
        M_CompanyID,
        UploadFrequency,
        UploadPeriod,
        ArchivingFrequency,
        ArchivingPeriod,
        ZipPassword,
        LastArchivedDateRC,
        CompanyNumber,
        NotificationEmail,
        InvoiceImage,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_CompanyArchivedSettingProcedure
    {

    }
    public class R_M_CompanyArchivedSettingList : List<R_M_CompanyArchivedSetting>
    {

    }
}