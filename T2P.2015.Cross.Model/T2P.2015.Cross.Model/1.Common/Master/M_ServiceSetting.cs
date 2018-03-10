using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ServiceSetting : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
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
        public override string Table { get { return "M_ServiceSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_ServiceSetting_InsertOrUpdate"; } }
    }
    public enum M_ServiceSettingColumns
    {
        ID,
        Name,
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
        CreatedDateTime,
        UpdatedBy,
        UpdatedDateTime,
        Status,
    }
    public enum M_ServiceSettingProcedure
    {
        p_M_ServiceSetting_GetByName,
        p_M_ServiceSetting_GetByServiceName
    }
    public class M_ServiceSettingList : List<M_ServiceSetting>
    {

    }
    public enum NameServiceSetting
    {
        CFM_Import_Booking,
        CFM_Import_FIN,
        CFM_Export_FIN,
        CFM_Export_Invoice_Data,
        CFM_Export_Invoice_Image,
    }
}