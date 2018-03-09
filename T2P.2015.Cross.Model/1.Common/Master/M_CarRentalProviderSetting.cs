using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CarRentalProviderSetting : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CarRentalProviderID;
        public long M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
        }
        private long? _m_CountryID;
        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }
        private string _mailServer;
        public string MailServer
        {
            get { return _mailServer; }
            set { _mailServer = value; }
        }
        private string _mailUsername;
        public string MailUsername
        {
            get { return _mailUsername; }
            set { _mailUsername = value; }
        }
        private string _mailPassword;
        public string MailPassword
        {
            get { return _mailPassword; }
            set { _mailPassword = value; }
        }
        private string _faxNumber;
        public string FaxNumber
        {
            get { return _faxNumber; }
            set { _faxNumber = value; }
        }
        private string _faxUsername;
        public string FaxUsername
        {
            get { return _faxUsername; }
            set { _faxUsername = value; }
        }
        private string _faxPassword;
        public string FaxPassword
        {
            get { return _faxPassword; }
            set { _faxPassword = value; }
        }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private int? _isDefault;
        public int? IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }
        private string _attachementFolderPath;
        public string AttachementFolderPath
        {
            get { return _attachementFolderPath; }
            set { _attachementFolderPath = value; }
        }
        private string _imageFolderPath;
        public string ImageFolderPath
        {
            get { return _imageFolderPath; }
            set { _imageFolderPath = value; }
        }
        public override string Table { get { return "M_CarRentalProviderSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CarRentalProviderSetting_InsertOrUpdate"; } }
    }
    public enum M_CarRentalProviderSettingColumns
    {
        ID,
        M_CarRentalProviderID,
        M_CountryID,
        MailServer,
        MailUsername,
        MailPassword,
        FaxNumber,
        FaxUsername,
        FaxPassword,
        IsDefault,
        AttachementFolderPath,
        ImageFolderPath,
        Phone,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CarRentalProviderSettingProcedure
    {
        p_M_CarRentalProviderSetting_Get_By_M_CarRentalProviderID,
        p_M_CarRentalProviderSetting_Get_By_R_B_AccessID,

    }
    public class M_CarRentalProviderSettingList : List<M_CarRentalProviderSetting>
    {

    }
}