using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Archive : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _i_DeliveryNotificationID;
        public long? I_DeliveryNotificationID
        {
            get { return _i_DeliveryNotificationID; }
            set { _i_DeliveryNotificationID = value; }
        }

        private long? _m_HotelPlatformID;
        public long? M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }

        private long? _m_FileLocationID;
        public long? M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }

        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private long? _i_ArchiveRequestID;

        public long? I_ArchiveRequestID
        {
            get { return _i_ArchiveRequestID; }
            set { _i_ArchiveRequestID = value; }
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
        private decimal? _fileSize;
        public decimal? FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; }
        }
        private DateTime? _from;
        public DateTime? From
        {
            get { return _from; }
            set { _from = value; }
        }
        private DateTime? _to;
        public DateTime? To
        {
            get { return _to; }
            set { _to = value; }
        }
        private DateTime? _expire;
        public DateTime? Expire
        {
            get { return _expire; }
            set { _expire = value; }
        }
        private int? _numberOfInvoice;
        public int? NumberOfInvoice
        {
            get { return _numberOfInvoice; }
            set { _numberOfInvoice = value; }
        }
        private string _fileStatus;
        public string FileStatus
        {
            get { return _fileStatus; }
            set { _fileStatus = value; }
        }
        private int _platformType;

        public int PlatformType
        {
            get { return _platformType; }
            set { _platformType = value; }
        }
        private string _companyCode;

        public string CompanyCode
        {
            get { return _companyCode; }
            set { _companyCode = value; }
        }
        public bool IsDownloaded { get; set; }
        public override string Table { get { return "I_Archive"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_Archive_InsertOrUpdate"; } }
    }
    public enum I_ArchiveColumns
    {
        ID,
        I_DeliveryNotificationID,
        M_FileLocationID,
        M_CompanyID,
        I_ArchiveRequestID,
        FilePath,
        FileName,
        FileSize,
        From,
        To,
        Expire,
        NumberOfInvoice,
        FileStatus,
        PlatformType,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        IsDownloaded,
        Status,
    }
    public enum I_ArchiveProcedure
    {
        p_I_Archived_GetList,
        p_I_Archive_GetForDelete,
        p_I_Archive_GetListByUser,
        p_I_Archive_GetByArchiveID,
        p_I_Archive_GetHistoryByArchive,
        p_I_Archive_GetForNotiLetter,
        p_R_I_Archive_GetForNotiLetter,
        p_I_Archive_GetListWithType,
        p_I_Archive_GetSubFile,
        p_R_I_Archive_GetList,
        p_R_I_Archive_GetListByUser,
        p_R_I_Archive_GetHistoryByArchive,
        p_R_I_Archive_GetByArchiveID
    }
    public enum PlatformType
    {
        Hotel = 1,
        RentalCar = 2
    }

    public class I_ArchiveList : List<I_Archive>
    {

    }



    public class ArchiveInvoiceModel
    {
        // fileName and imageIds
        public Dictionary<string, List<long>> archiveInvoicesList = new Dictionary<string, List<long>>();

        public DateTime? LastArchivedDate;
        public DateTime? NextArchivedDate;

        public long CompanyId = 0;
        public long FileLocationId = 0;
        public long R_M_PlatformID;
        public string CompanyCode;
    }

    public class MustArchivedInvoiceModel
    {
        public long M_CompanyID { get; set; }
        public long I_ImageID { get; set; }
        public long B_BookingID { get; set; }
        public string BookingNo { get; set; }
        public long M_FileLocationID { get; set; }
        public string FileLocation { get; set; }
        public long M_HotelPlatformID { get; set; }
        public string PlatformName { get; set; }
        public long M_CompanyArchivedSettingID { get; set; }
        public string FullName { get; set; }
        public string M_HotelPlatformName { get; set; }
        public string UploadFrequency { get; set; }
        public string UploadPeriod { get; set; }
        public string ArchivingFrequency { get; set; }
        public string ArchivingPeriod { get; set; }
        public string ZipPassword { get; set; }
        public DateTime LastArchivedDate { get; set; }
        public DateTime ImageUpdatedDate { get; set; }
        public string CompanyCode { get; set; }
        public long R_M_PlatformID { get; set; }
    }

    public class I_ArchiveExtend : I_Archive
    {
        public string FullFileName { get; set; }
    }
}
