using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Company_Detail : P_Company_Info
    {
        public string NewLogoURL { get; set; }
        public string MessageError { get; set; }
        public bool IsShowAll_ChildrenCompany { get; set; }
        public List<P_Company_Contact> ListCompanyContact { get; set; }
        public List<P_Company_VATCode> ListCompanyVATCode { get; set; }

        public List<P_Company_Addition> ListCompanyAddition { get; set; }
        public List<P_Company_Info> ListChildrenCompany { get; set; }

        public List<P_UserPermission> ListUserSuggestion { get; set; }
        public P_Company_Detail()
        {
            IsShowAll_ChildrenCompany = false;
            ListCompanyContact = new List<P_Company_Contact>();
            ListChildrenCompany = new List<P_Company_Info>();
            ListCompanyVATCode = new List<P_Company_VATCode>();
            ListUserSuggestion = new List<P_UserPermission>();
            ListCompanyAddition = new List<P_Company_Addition>();
        }
    }

    public class P_Company_Info : M_Company
    {
        public string LogoURL { get; set; }
        public string ParentCompanyName { get; set; }
        public string CountryName { get; set; }
        public string LanguageText { get; set; }
        public string CountryCode { get; set; }
        public bool Highlight { get; set; }
        public bool HighlightCompanyName { get; set; }
        public List<P_Company_Process> ListCompanyProcess { get; set; }

        public P_Company_Info()
        {
            ListCompanyProcess = new List<P_Company_Process>();
        }
        public long TotalRecord { get; set; }

        public string Process { get; set; }
    }

    public class P_Company_Process : M_CompanyProcess
    {
        public string ProcessName { get; set; }
        public string HotelPlatformName { get; set; }

        public List<P_Company_ProcessStep> ListStep { get; set; }
        public P_Company_Process()
        {
            ListStep = new List<P_Company_ProcessStep>();
        }
    }

    public class P_Company_ProcessStep : M_CompanyProcessDetail
    {
        public string StepCode { get; set; }
        public dynamic Setting { get; set; }
        public bool IsActive { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }

        public decimal Order { get; set; }
    }

    public class P_Company_Contact : M_CompanyContact
    {
        public long UserID { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
    }

    public class P_Company_VATCode : M_CompanyVATCode
    {
        public string CountryName { get; set; }
        public bool HighlightCountry { get; set; }
        public bool HighlightVATNo { get; set; }
       
    }
    public class P_Company_Addition : M_CompanyAddition
    {
        public string HotelPlatformName { get; set; }
        public bool HighlightCompanyName { get; set; }
        public bool HighlightPlatform { get; set; }

    }

    public class P_Process_IDI
    {
        public string Frequency { get; set; }
        public string Period { get; set; }
        public string ExecutionDate{get;set;}
        public string ExecutionTime{get;set;}
        public string Path { get; set; }
        public bool IsOn { get; set; }
        public string Hour { get; set; }
        public string Minute { get; set; }
    }

    public class P_Process_IGW
    {
        public bool IsOn { get; set; }
        public string Email { get; set; }
        public string MailServer { get; set; }
        public string MailPassword { get; set; }
        public string ZipPassword { get; set; }
    }

    public class P_Process_IVA
    {
        public bool IsOn { get; set; }
    }

    public class P_Process_ISTR
    {
        public bool IsOn { get; set; }
        public string HeaderText { get; set; }
        public string Email { get; set; }
        public string CC { get; set; }
        public bool IsAttach { get; set; }
        public bool IsDaimler { get; set; }
    }

    public class P_Process_FST
    {
        public bool IsOn { get; set; }
    }

    public class P_Process_FMI
    {
        public bool IsOn { get; set; }
        public bool IsDCO { get; set; }
        public bool IsDSC { get; set; }
        public bool IsSNL { get; set; }
        public bool IsSND { get; set; }
        public bool IsDCI { get; set; }
        public bool IsSCI { get; set; }
    }

    public class P_Process_BST
    {
        public bool IsOn { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string Period { get; set; }
        public string Month { get; set; }
        public bool IsArchive { get; set; }
        public bool IsArchiveBooking { get; set; }
        public bool IsArchiveAttachment { get; set; }
        public bool IsArchiveInvoice { get; set; }
        public bool IsArchiveNotification { get; set; }
    }

    public class P_Company_Common
    {
        public List<M_Language> ListLanguage { get; set; }
        public List<M_Country> ListCountry { get; set; }
        public List<M_Company> ListParentCompany { get; set; }
        public List<M_Process> ListProcess { get; set; }
        public List<M_HotelPlatform> ListHotelPlatform { get; set; }
        public List<M_FileLocation> ListFileLocation { get; set; }
        public List<M_TimeZone> ListTimeZone { get; set; }
        public P_Company_Common() 
        {
            ListLanguage = new List<M_Language>();
            ListCountry = new List<M_Country>();
            ListParentCompany = new List<M_Company>();
            ListProcess = new List<M_Process>();
            ListHotelPlatform = new List<M_HotelPlatform>();
            ListFileLocation = new List<M_FileLocation>();
            ListTimeZone = new List<M_TimeZone>();
        }
    }

    public class P_Company_Data
    {
        public string NewLogoURL{ get; set; }
        public M_Company Company { get; set; }
        public List<P_Company_Data> ListChild { get; set; }
        public List<M_CompanyContact> ListCompanyContact { get; set; }
        public List<M_CompanyVATCode> ListCompanyVATCode { get; set; }
        public List<M_CompanyAddition> ListCompanyAddition { get; set; }
        public List<P_CompanyProcess_Data> ListCompanyProcess { get; set; }
        public List<A_UserCompanyPlatform> ListUserPermission { get; set; }
        public List<A_UserCompanyPlatform> ListOld_UserPermission { get; set; }
        public P_Company_Data() 
        {
            ListChild = new List<P_Company_Data>();
            ListCompanyContact = new List<M_CompanyContact>();
            ListCompanyProcess = new List<P_CompanyProcess_Data>();
            ListUserPermission = new List<A_UserCompanyPlatform>();
            ListOld_UserPermission = new List<A_UserCompanyPlatform>();
            ListCompanyVATCode = new List<M_CompanyVATCode>();
            ListCompanyAddition = new List<M_CompanyAddition>();
        }
    }

    public class P_CompanyProcess_Data
    {
        public M_CompanyProcess CompanyProcess { get; set; }
        public List<P_CompanyProcessDetail_Data> ListCompanyProcessDetail { get;set; }
        public M_CompanyProcess OldCompanyProcess { get; set; }
        public P_CompanyProcess_Data()
        {
            ListCompanyProcessDetail = new List<P_CompanyProcessDetail_Data>();
        }
    }

    public class P_CompanyProcessDetail_Data
    {
        public M_CompanyProcessDetail CompanyProcessDetail { get; set; }
        public List<M_CompanyGeneralSetting> ListCompanyGeneralSetting { get; set; }
        public M_CompanyProcessSchedule CompanyProcessSchedule { get; set; }
        public P_CompanyProcessDetail_Data()
        {
            ListCompanyGeneralSetting = new List<M_CompanyGeneralSetting>();
        }
    }

    public class P_Company_Caching 
    {
        public M_Company Company { get; set; }
        public List<long> ListUserPermission { get; set; }
        public P_Company_Caching() 
        {
            ListUserPermission = new List<long>();
        }
    }

    public class P_Company_Suggestion
    {
        public string MessageError { get; set; }
        public long CompanyID { get; set; }
        public List<P_UserPermission> ListUserSuggestion { get; set; }
        public P_Company_Suggestion() 
        {
            ListUserSuggestion = new List<P_UserPermission>();
        }
    }

    public class P_UserPermission : A_UserProfile
    {
        public int Permission { get; set; }
        public string RoleName { get; set; }
        public long M_HotelPlatformID { get; set; }
        public bool IsView { get; set; }
        public bool IsEdit { get; set; }
    }
}
