using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelPlatformSetting : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
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
        private int _isDefault;
        public int IsDefault
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

        public override string Table { get { return "M_HotelPlatformSetting"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_HotelPlatformSetting_InsertOrUpdate"; } }
    }

    public enum M_HotelPlatformEmailColumns
    {
        ID,
        M_HotelPlatformID,
        MailServer,
        MailUser,
        MailPassword,
        FaxUser,
        FaxPassword,
        IsDefault,
        AttachementFolderPath,
        ImageFolderPath,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_HotelPlatformSettingProcedure
    {
        p_M_HotelPlatformSetting_GetByHotelPlatformID,
        p_M_HotelPlatformSetting_GetByBAccessID,
        p_M_HotelPlatformSetting_GetAllMailUsername,
        p_M_HotelPlatformSetting_GetByBooking,
        p_M_HotelPlatformSetting_GetByN_BillingEmailID,
        p_M_HotelPlatformSetting_GetDefaultByHotelPlatformID,
        p_M_HotelPlatformSetting_GetForBillingEmail
    }

    public class M_HotelPlatformSettingList : List<M_HotelPlatformSetting>
    {
    }
}