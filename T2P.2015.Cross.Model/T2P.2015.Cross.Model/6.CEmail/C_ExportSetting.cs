using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_ExportSetting : BaseModel
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
        private long? _m_CompanyProcessID;
        public long? M_CompanyProcessID
        {
            get { return _m_CompanyProcessID; }
            set { _m_CompanyProcessID = value; }
        }
        private string _settingType;
        public string SettingType
        {
            get { return _settingType; }
            set { _settingType = value; }
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

        private string _attachmentFolderPath;
        public string AttachmentFolderPath
        {
            get { return _attachmentFolderPath; }
            set { _attachmentFolderPath = value; }
        }        

        private int _port;
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }
        
        private string _weekDaySchedule;
        public string WeekDaySchedule
        {
            get { return _weekDaySchedule; }
            set { _weekDaySchedule = value; }
        }  
        public override string Table { get { return "C_ExportSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_ExportSetting_InsertOrUpdate"; } }
    }
    public enum C_ExportSettingColumns
    {
        ID,
        Name,
        M_CompanyProcessID,
        SettingType,
        ServiceType,
        LinkServer,
        UserName,
        Password,
        Path,
        PathError,
        AttachmentFolderPath,
        Port,
        CreatedBy,
        CreatedDateTime,
        UpdatedBy,
        UpdatedDateTime,
        Status,
    }
    public enum C_ExportSettingProcedure
    {
        p_C_ExportSetting_Get_ByName
    }
    public class C_ExportSettingList : List<C_ExportSetting>
    {

    }
}