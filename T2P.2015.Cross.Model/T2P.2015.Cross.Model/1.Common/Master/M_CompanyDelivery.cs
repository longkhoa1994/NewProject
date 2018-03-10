using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyDelivery : BaseModel
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
        private long _m_CompanyID;
        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private long? _m_NotificationTemplateID;
        public long? M_NotificationTemplateID
        {
            get { return _m_NotificationTemplateID; }
            set { _m_NotificationTemplateID = value; }
        }
        private long _m_FileTypeID;
        public long M_FileTypeID
        {
            get { return _m_FileTypeID; }
            set { _m_FileTypeID = value; }
        }

        private long? _convertFileTypeID;
        public long? ConvertFileTypeID
        {
            get { return _convertFileTypeID; }
            set { _convertFileTypeID = value; }
        }
        private string _deliveryFequency;
        public string DeliveryFequency
        {
            get { return _deliveryFequency; }
            set { _deliveryFequency = value; }
        }
        private string _deliveryDate;
        public string DeliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }
        private string _deliveryTime;
        public string DeliveryTime
        {
            get { return _deliveryTime; }
            set { _deliveryTime = value; }
        }
        private string _deliveryType;
        public string DeliveryType
        {
            get { return _deliveryType; }
            set { _deliveryType = value; }
        }
        private float? _expireDate;
        public float? ExpireDate
        {
            get { return _expireDate; }
            set { _expireDate = value; }
        }
        private string _filenameFormat;
        public string FilenameFormat
        {
            get { return _filenameFormat; }
            set { _filenameFormat = value; }
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
        private string _encryption;

        public string Encryption
        {
            get { return _encryption; }
            set { _encryption = value; }
        }
        public override string Table { get { return "M_CompanyDelivery"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyDelivery_InsertOrUpdate"; } }
    }
    public enum M_CompanyDeliveryColumns
    {
        ID,
        M_PaymentProviderID,
        M_CompanyID,
        M_NotificationTemplateID,
        M_FileTypeID,
        ConvertFileTypeID,
        DeliveryFequency,
        DeliveryDate,
        DeliveryTime,
        DeliveryType,
        ExpireDate,
        FilenameFormat,
        ServiceType,
        LinkServer,
        UserName,
        Password,
        Key,
        Path,
        PathError,
        Port,
        Encryption,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyDeliveryProcedure
    {
        p_M_CompanyDelivery_GetForExport,
        p_M_CompanyDelivery_Get_By_M_CompanyID,
    }
    public class M_CompanyDeliveryList : List<M_CompanyDelivery>
    {

    }
}