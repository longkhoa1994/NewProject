using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyProcessSchedule : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CompanyProcessDetailID;
        public long M_CompanyProcessDetailID
        {
            get { return _m_CompanyProcessDetailID; }
            set { _m_CompanyProcessDetailID = value; }
        }
        private string _frequency;
        public string Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }
        private string _period;
        public string Period
        {
            get { return _period; }
            set { _period = value; }
        }
        private string _executionDate;
        public string ExecutionDate
        {
            get { return _executionDate; }
            set { _executionDate = value; }
        }
        private string _executionTime;
        public string ExecutionTime
        {
            get { return _executionTime; }
            set { _executionTime = value; }
        }
        private int _usedTimeZone;
        public int UsedTimeZone
        {
            get { return _usedTimeZone; }
            set { _usedTimeZone = value; }
        }
        private string _serviceType;
        public string ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; }
        }
        private string _linkServer;
        public string LinkServer
        {
            get { return _linkServer; }
            set { _linkServer = value; }
        }
        private string _fileFormat;
        public string FileFormat
        {
            get { return _fileFormat; }
            set { _fileFormat = value; }
        }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _key;
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }
        private string _path;
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        private string _pathError;
        public string PathError
        {
            get { return _pathError; }
            set { _pathError = value; }
        }
        private int? _port;
        public int? Port
        {
            get { return _port; }
            set { _port = value; }
        }
        public bool? UseDownloadCenter { get; set; }
        public string UploadFrequency { get; set; }
        public string UploadPeriod { get; set; }
        public string ArchivingFrequency { get; set; }
        public string ArchivingPeriod { get; set; }
        public string ZipPassword { get; set; }
        public DateTime? LastArchivedDate { get; set; }
        public string NotificationEmail { get; set; }
        public string SettingType { get; set; }
        public bool IsAttachedExcel { get; set; }
        public override string Table { get { return "M_CompanyProcessSchedule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyProcessSchedule_InsertOrUpdate"; } }
    }
    public enum M_CompanyProcessScheduleColumns
    {
        ID,
        M_CompanyProcessDetailID,
        Frequency,
        Period,
        ExecutionDate,
        ExecutionTime,
        UsedTimeZone,
        ServiceType,
        LinkServer,
        FileFormat,
        UserName,
        Password,
        Key,
        Path,
        PathError,
        Port,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyProcessScheduleProcedure
    {
        p_M_CompanyProcessSchedule_Get_ByB_AccessID,
        p_M_CompanyProcessSchedule_GetByCompanyID,
        p_M_CompanyProcessSchedule_GetByCompanyIdAndStepCode,
        p_M_CompanyProcessSchedule_GetByM_CompanyProcessDetailID,
        p_M_CompanyProcessSchedule_Get_ByB_AccessID_SettingType
    }

    public class M_CompanyProcessScheduleList : List<M_CompanyProcessSchedule>
    {
    }
}