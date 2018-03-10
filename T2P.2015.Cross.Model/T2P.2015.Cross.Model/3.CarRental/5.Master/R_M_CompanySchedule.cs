using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_CompanySchedule : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _r_M_CompanyID;
        public long R_M_CompanyID
        {
            get { return _r_M_CompanyID; }
            set { _r_M_CompanyID = value; }
        }
        public string Type { get; set; }
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
        private int? _usedTimeZone;
        public int? UsedTimeZone
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
        public override string Table { get { return "R_M_CompanySchedule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_CompanySchedule_InsertOrUpdate"; } }
    }
    public enum R_M_CompanyScheduleColumns
    {
        ID,
        R_M_CompanyID,
        Type,
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
    public enum R_M_CompanyScheduleProcedure
    {
        p_R_M_CompanySchedule_GetForDeliveryImage
    }
    public class R_M_CompanyScheduleList : List<R_M_CompanySchedule>
    {

    }

    public enum R_M_CompanyScheduleType
    {
        DeliveryImage
    }
}