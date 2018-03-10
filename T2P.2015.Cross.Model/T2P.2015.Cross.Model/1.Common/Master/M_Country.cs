using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Country : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _countryCode;

        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }

        private string _countryName;

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }

        private string _countryLanguageCode;

        public string CountryLanguageCode
        {
            get { return _countryLanguageCode; }
            set { _countryLanguageCode = value; }
        }

        private string _flag;


        public string Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }

        private long? m_LanguageID;

        public long? M_LanguageID
        {
            get { return m_LanguageID; }
            set { m_LanguageID = value; }
        }
        private long? m_LanguageID2;

        public long? M_LanguageID2
        {
            get { return m_LanguageID2; }
            set { m_LanguageID2 = value; }
        }

        public override string Table { get { return "M_Country"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_Country_InsertOrUpdate"; } }
    }

    public enum M_CountryColumns
    {
        ID,
        CountryCode,
        CountryName,
        CountryLanguageCode,
        Flag,
        M_LanguageID,
        M_LanguageID2,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_CountryProcedure
    {
        p_M_CountryGet_ByCountryCode,
        p_M_Country_Get_ByCountryCode,
        p_M_Country_GetList_ByCompanyID_ForEnrichment,
        p_M_Country_GetListForCompany,
        p_M_Country_GetListForHotel,
        p_R_M_Country_GetBy_Location,
        p_M_Country_GetListInTemplate,
        p_M_CountryAddition_GetBy_CountryCode,
        p_M_Country_GetListForServiceKeyword,

        p_M_Country_GeListCustom,
        p_M_Country_GetListForCompanyCustom
    }

    public class M_CountryList : List<M_Country>
    {
    }

    public class vm_M_CountryCompany : M_Country
    {
        private string _m_CompanyCountrySettingID;

        public string M_CompanyCountrySettingID
        {
            get { return _m_CompanyCountrySettingID; }
            set { _m_CompanyCountrySettingID = value; }
        }
    }
}