using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_Service_Keyword : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long m_LanguageID;

        public long M_LanguageID
        {
            get { return m_LanguageID; }
            set { m_LanguageID = value; }
        }

        private long? _r_M_SurchargeID;

        public long? R_M_SurchargeID
        {
            get { return _r_M_SurchargeID; }
            set { _r_M_SurchargeID = value; }
        }

        private string _surcharge;

        public string Surcharge
        {
            get { return _surcharge; }
            set { _surcharge = value; }
        }

        private string _serviceCode;

        public string ServiceCode
        {
            get { return _serviceCode; }
            set { _serviceCode = value; }
        }

        private string _serviceName;

        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }

        private string _unit;

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private long? _m_CarRentalProviderID;

        public long? M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
        }

        public long? CountryID { get; set; }

        public override string Table { get { return "R_M_Service_Keyword"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_Service_Keyword_InsertOrUpdate"; } }
    }

    public class Group_R_M_Service_Keyword
    {
        public long? M_CarRentalProviderID { get; set; }
        public long? R_M_SurchargeID { get; set; }
        public string ServiceCode { get; set; }

        public List<R_M_Service_Keyword> Sk { get; set; }
    }

    public class View_R_M_Service_Keyword
    {
        private long? _r_M_SurchargeID;

        public long? R_M_SurchargeID
        {
            get { return _r_M_SurchargeID; }
            set { _r_M_SurchargeID = value; }
        }

        private string _serviceCode;

        public string ServiceCode
        {
            get { return _serviceCode; }
            set { _serviceCode = value; }
        }

        private string _surcharge;

        public string Surcharge
        {
            get { return _surcharge; }
            set { _surcharge = value; }
        }

        private string _serviceNameEnglishOfSixt;

        public string ServiceNameEnglishOfSixt
        {
            get { return _serviceNameEnglishOfSixt; }
            set { _serviceNameEnglishOfSixt = value; }
        }

        private string _serviceNameGermanyOfSixt;

        public string ServiceNameGermanyOfSixt
        {
            get { return _serviceNameGermanyOfSixt; }
            set { _serviceNameGermanyOfSixt = value; }
        }

        private string _serviceNameEnglishUKOfNational;

        public string ServiceNameEnglishUKOfNational
        {
            get { return _serviceNameEnglishUKOfNational; }
            set { _serviceNameEnglishUKOfNational = value; }
        }

        private string _serviceNameEnglishUSOfNational;

        public string ServiceNameEnglishUSOfNational
        {
            get { return _serviceNameEnglishUSOfNational; }
            set { _serviceNameEnglishUSOfNational = value; }
        }

        private string _serviceNameEnglishCAOfNational;

        public string ServiceNameEnglishCAOfNational
        {
            get { return _serviceNameEnglishCAOfNational; }
            set { _serviceNameEnglishCAOfNational = value; }
        }

        private string _serviceNameGermanyOfNational;

        public string ServiceNameGermanyOfNational
        {
            get { return _serviceNameGermanyOfNational; }
            set { _serviceNameGermanyOfNational = value; }
        }

        private string _serviceNameSpanishOfNational;

        public string ServiceNameSpanishOfNational
        {
            get { return _serviceNameSpanishOfNational; }
            set { _serviceNameSpanishOfNational = value; }
        }

        private string _serviceNameFrenchOfNational;

        public string ServiceNameFrenchOfNational
        {
            get { return _serviceNameFrenchOfNational; }
            set { _serviceNameFrenchOfNational = value; }
        }

        private string _serviceNameFrenchCAOfNational;

        public string ServiceNameFrenchCAOfNational
        {
            get { return _serviceNameFrenchCAOfNational; }
            set { _serviceNameFrenchCAOfNational = value; }
        }

        private string _serviceNameEnglishOfAvis;

        public string ServiceNameEnglishOfAvis
        {
            get { return _serviceNameEnglishOfAvis; }
            set { _serviceNameEnglishOfAvis = value; }
        }

        private string _serviceNameGermanyOfAvis;

        public string ServiceNameGermanyOfAvis
        {
            get { return _serviceNameGermanyOfAvis; }
            set { _serviceNameGermanyOfAvis = value; }
        }

        private int _totalRecords;

        public int TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }

        public string CountryCode { get; set; }
        public long? CountryID { get; set; }
        public List<View_ServiceName> ListServiceNameEnglishOfSixt;
        public List<View_ServiceName> ListServiceNameGermanyOfSixt;

        public List<View_ServiceName> ListServiceNameEnglishUKOfNational;
        public List<View_ServiceName> ListServiceNameEnglishUSOfNational;
        public List<View_ServiceName> ListServiceNameEnglishCAOfNational;
        public List<View_ServiceName> ListServiceNameGermanyOfNational;
        public List<View_ServiceName> ListServiceNameSpanishOfNational;
        public List<View_ServiceName> ListServiceNameFrenchOfNational;
        public List<View_ServiceName> ListServiceNameFrenchCAOfNational;

        public List<View_ServiceName> ListServiceNameEnglishOfAvis;
        public List<View_ServiceName> ListServiceNameGermanyOfAvis;

        public View_R_M_Service_Keyword()
        {
            ListServiceNameEnglishOfSixt = new List<View_ServiceName>();
            ListServiceNameGermanyOfSixt = new List<View_ServiceName>();
            ListServiceNameEnglishUKOfNational = new List<View_ServiceName>();
            ListServiceNameEnglishUSOfNational = new List<View_ServiceName>();
            ListServiceNameEnglishCAOfNational = new List<View_ServiceName>();
            ListServiceNameGermanyOfNational = new List<View_ServiceName>();
            ListServiceNameSpanishOfNational = new List<View_ServiceName>();
            ListServiceNameFrenchOfNational = new List<View_ServiceName>();
            ListServiceNameEnglishOfAvis = new List<View_ServiceName>();
            ListServiceNameGermanyOfAvis = new List<View_ServiceName>();
            ListServiceNameFrenchCAOfNational = new List<View_ServiceName>();
        }
    }

    public class View_ServiceKeyWord_CommonData
    {
        public List<M_CarRentalProvider> ListProvider;
        public List<M_Language> ListLanguage;
        public List<R_M_Surcharge> ListSurcharge;
        public List<M_Country> ListCountry;
        public View_ServiceKeyWord_CommonData ()
        {
            ListProvider = new List<M_CarRentalProvider>();
            ListLanguage = new List<M_Language>();
            ListSurcharge = new List<R_M_Surcharge>();
            ListCountry = new List<M_Country>();
        }
    }

    public class View_ServiceName
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _serviceName;

        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }
    }

    public enum R_M_Service_KeywordColumns
    {
        ID,
        M_CarRentalProviderID,
        R_M_SurchargeID,
        Surcharge,
        ServiceCode,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_M_Service_KeywordProcedure
    {
        p_R_M_Service_Keyword_GetAll,
        p_R_M_Service_Keyword_GetBy_CarRentalProviderId,
        p_R_M_ServiceKeyword_GetByCondition,
        p_R_M_ServiceKeyword_GetByServiceName,
        p_R_M_ServiceKeyword_GetForUpdateCountry,
    }

    public class R_M_Service_KeywordList : List<R_M_Service_Keyword>
    {
    }
}