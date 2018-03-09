using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_DownloadServer : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_PaymentProviderID;
        public long M_PaymentProviderID
        {
            get { return _m_PaymentProviderID; }
            set { _m_PaymentProviderID = value; }
        }
        private long _m_HotelPlatformID;
        public long M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }
        private long _m_F_FileTypeID;
        public long M_F_FileTypeID
        {
            get { return _m_F_FileTypeID; }
            set { _m_F_FileTypeID = value; }
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
        public override string Table { get { return "M_DownloadServer"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_DownloadServer_InsertOrUpdate"; } }
    }
    public enum M_DownloadServerColumns
    {
        ID,
        M_PaymentProviderID,
        M_HotelPlatformID,
        M_F_FileTypeID,
        Name,
        ServiceType,
        LinkServer,
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
    public enum M_DownloadServerProcedure
    {

    }
    public class M_DownloadServerList : List<M_DownloadServer>
    {

    }
}