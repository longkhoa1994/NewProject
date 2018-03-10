using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model.Process
{
    public class P_CompanySearch : V_Pagination
    {
        public long CompanyID { get; set; }
        public string CompanyName { get; set; }
        public long CountryID { get; set; }
        public long ProcessID { get; set; }
        public bool IsParentCompany { get; set; }
        public long HotelPlatformID { get; set; }

    }
    public class P_Schedule
    {
        public long CompanyID { get; set; }
        public string StepCode { get; set; }
    }
    public class List_P_CompanyData
    {
        public List<P_Company> ListCompany { get; set; }
        public List<M_Process> ListProcess { get; set; }
        public List<M_Country> ListCountryForCompany { get; set; }
    }


    public class P_PlatformProcess
    {
        //public long M_ProcessID { get; set; }
        //public string Process { get; set; }
        public string ProcessName2 { get; set; }
        //public long M_HotelPlatformID { get; set; }

        public string HotelPlatformName { get; set; }
    }

    public class P_ProviderProcess
    {
        public string ProviderName { get; set; }
    }

    public class P_Company
    {
        public long ID { get; set; }
        public long ParentID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAlias { get; set; }
        public string CountryName { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string CountryFlag { get; set; }
        public int CompanyContact { get; set; }
        public long NumberOfCompanyChild { get; set; }
        public Boolean IsAvailableSetupFile { get; set; }
        public string ListContact { get; set; }

        //public long M_ProcessID { get; set; }
        //public string Process { get; set; }
        //public string ProcessName2 { get; set; }
        //public long M_HotelPlatformID { get; set; }
        //public string HotelPlatformName { get; set; }

        public string ListStringPlatformProcess { get; set; }

        public string ListStringProviderProcess { get; set; }

        public List<P_PlatformProcess> ListPlatformProcess { get; set; }

        public List<P_ProviderProcess> ListProviderProcess { get; set; }

        public long TotalRecord { get; set; }

        public P_Company()
        {
            ListPlatformProcess = new List<P_PlatformProcess>();
            ListProviderProcess = new List<P_ProviderProcess>();
        }

    }

    public class P_CompanyDetail
    {
        public string VATCode { get; set; }
        public long ID { get; set; }
        public long ParentID { get; set; }
        public long M_ProcessID { get; set; }
        public long M_CompanyContactID { get; set; }
        public long M_HotelPlatformID { get; set; }
        public long CountryID { get; set; }
        public long FileLocationID { get; set; }
        public string ProcessName { get; set; }
        public string ProcessName2 { get; set; }
        public string HotelPlatformName { get; set; }
        public string FilePath { get; set; }
        public string TempFile { get; set; }
        public string TempFileSignature { get; set; }
        public string CountryName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAlias { get; set; }
        public string CompanyShortName { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyTaxCode { get; set; }
        public string SubID { get; set; }
        public string NewCompanyLogo { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string CityName { get; set; }

        public string ProcessDescription { get; set; }
        public string CompanyParentName { get; set; }
        public long LanguageID { get; set; }

        public string LanguageText { get; set; }
        public decimal TimeZone { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Logo { get; set; }
        public string NewSignatureImage { get; set; }
        public string SignatureImage { get; set; }
        public string SignatureText { get; set; }
        public long NumberStepTypePresent { get; set; }
        public List<M_Country> ListCountry { get; set; }
        public List<M_Language> ListLanguage { get; set; }
        public List<M_CompanyContact> ListCompanyContact { get; set; }
        public List<M_Process> ListProcess { get; set; }
        public List<P_StepType> ListClassifyStepType { get; set; }
    }

    public class P_StepType
    {
        public long CompanyProcessID { get; set; }
        public long CompanyID { get; set; }
        public long M_CompanyProcessScheduleID { get; set; }
        public string ProcessDescription { get; set; }
        public string StepDescription { get; set; }
        public long StepTypeID { get; set; }
        public string StepCode { get; set; }
        public string StepCategory { get; set; }
        public string StepName { get; set; }
        public string Option { get; set; }
        public bool IsShow { get; set; }
        public M_CompanyProcessSchedule CompanySettingStep { get; set; }

        public List<M_CompanyGeneralSetting> ListCompanyGeneralSetting { get; set; }

        public P_StepType()
        {
            ListCompanyGeneralSetting = new List<M_CompanyGeneralSetting>();
        }
    }

    public class P_Process
    {
        public long ProcessID { get; set; }
        public string ProcessName { get; set; }
        public string Description { get; set; }
        public string Payment { get; set; }
        public long M_HotelPlatformID { get; set; }
    }
    public class P_CompanyContact
    {
        public long CompanyID { get; set; }
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Comment { get; set; }
        public int Status { get; set; }
    }

    public class P_CompanyFkey
    {
        public string CustomerNo { get; set; }

        public P_CompanyFkey()
        {
            CustomerNo = string.Empty; 
        }
    }


    public enum P_CompanyProcedure
    {
        p_M_CompanyGeneralSetting_CheckExistsEmail,
        p_M_CompanyAddition_GetListFkeyValidation,
        p_M_CompanyParentECS
    }

}
