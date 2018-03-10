using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_NotificationTemplate : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_LanguageID;
        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
        private long _m_HotelPlatformID;
        public long M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }
        private long? _m_ProcessID;
        public long? M_ProcessID
        {
            get { return _m_ProcessID; }
            set { _m_ProcessID = value; }
        }
        private string _paymentMethod;
        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        private string _bodyText;
        public string BodyText
        {
            get { return _bodyText; }
            set { _bodyText = value; }
        }
        private int? _isDefault;
        public int? IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }
        public string DisplayedContent { get; set; }
        public override string Table { get { return "M_NotificationTemplate"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_NotificationTemplate_InsertOrUpdate"; } }
    }
    public enum M_NotificationTemplateColumns
    {
        ID,
        M_LanguageID,
        M_HotelPlatformID,
        M_ProcessID,
        PaymentMethod,
        Type,
        Category,
        Subject,
        BodyText,
        IsDefault,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_NotificationTemplateProcedure
    {
        p_M_NotificationTemplate_Get_Default,
        p_M_NotificationTemplate_GetByTypeandCategory,
        p_M_NotificationTemplate_GetByLanguage_Type_Category,
        p_M_NotificationTemplate_Get_ForCheckTypeEmail,
        p_M_NotificationTemplate_GetListSearch,
        p_M_NotificationTemplate_GetListUpdate,
        p_M_NotificationTemplate_GetAllLanguage_Type_Category,

        p_M_NotificationTemplate_SendDeeplinkSmart
    }

    public class M_NotificationTemplateList : List<M_NotificationTemplate>
    {
    }
}