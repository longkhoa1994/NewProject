using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_NotificationTemplate : BaseModel
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
        private long _r_M_PlatformID;
        public long R_M_PlatformID
        {
            get { return _r_M_PlatformID; }
            set { _r_M_PlatformID = value; }
        }
        private long? _m_CarRentalProviderID;
        public long? M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
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

        private bool? _useTranslation;
        public bool? UseTranslation
        {
            get { return _useTranslation; }
            set { _useTranslation = value; }
        }
        public override string Table { get { return "R_M_NotificationTemplate"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_NotificationTemplate_InsertOrUpdate"; } }
    }
    public enum R_M_NotificationTemplateColumns
    {
        ID,
        M_LanguageID,
        M_HotelPlatformID,
        M_CarRentalProviderID,
        Type,
        Category,
        Subject,
        BodyText,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_NotificationTemplateProcedure
    {
        p_R_M_NotificationTemplate_Get_By_Platform_Provider_Type_Category,
        p_R_M_NotificationTemplate_GetBy_Type
    }
    public class R_M_NotificationTemplateList : List<R_M_NotificationTemplate>
    {

    }
}