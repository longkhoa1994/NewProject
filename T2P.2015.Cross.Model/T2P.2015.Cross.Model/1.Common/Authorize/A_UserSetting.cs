using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_UserSetting : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _a_UserProfileID;
        public long A_UserProfileID
        {
            get { return _a_UserProfileID; }
            set { _a_UserProfileID = value; }
        }
        private long _m_LanguageID;
        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
        private string _dateFormat;
        public string DateFormat
        {
            get { return _dateFormat; }
            set { _dateFormat = value; }
        }
        private string _timeFormat;
        public string TimeFormat
        {
            get { return _timeFormat; }
            set { _timeFormat = value; }
        }
        private string _signature;
        public string Signature
        {
            get { return _signature; }
            set { _signature = value; }
        }
        private int _layout;
        public int Layout
        {
            get { return _layout; }
            set { _layout = value; }
        }

        private long? _m_HotelPlatformID;
        public long? M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }
        

        [NotInsert]
        [NotUpdate]
        public string SignatureDecode
        {
            get { return T2P._2015.Cross.Utility.Conversion.Conversion.ObjectToString(System.Net.WebUtility.HtmlDecode(this.Signature)); }
        }
        public override string Table { get { return "A_UserSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_UserSetting_InsertOrUpdate"; } }
    }
    public enum A_UserSettingColumns
    {
        ID,
        A_UserProfileID,
        M_LanguageID,
        DateFormat,
        TimeFormat,
        Signature,
        Layout,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum A_UserSettingProcedure
    {
        p_A_UserSetting_Get_ByUser,
        p_A_UserSetting_Get_ByLanguageID
    }

    public class A_UserSettingList : List<A_UserSetting>
    {
    }
}