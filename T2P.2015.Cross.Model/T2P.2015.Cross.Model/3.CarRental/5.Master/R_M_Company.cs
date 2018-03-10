using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using T2P._2015.Cross.Model.Process;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_Company : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CompanyID;
        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private string _companyCode;
        public string CompanyCode
        {
            get { return _companyCode; }
            set { _companyCode = value; }
        }
        private decimal? _factor;
        public decimal? Factor
        {
            get { return _factor; }
            set { _factor = value; }
        }

        public bool IsAllowCheaper { get; set; }

        public override string Table { get { return "R_M_Company"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_Company_InsertOrUpdate"; } }
    }
    public class R_M_Company_ForAccountSetup : R_M_Company
    {
        public long R_M_PlatformID { get; set; }
        public string R_M_PlatformName { get; set; }
        public string CompanyName { get; set; }
        public long ParentID { get; set; }
        public string CountryCode { get; set; }
        public bool HasSixt { get; set; }
        public bool HasAvis { get; set; }
        public bool HasNational { get; set; }
        public bool HasEnterprise { get; set; }
        public bool HasEuropcar { get; set; }
        public bool EnableSixt { get; set; }
        public bool EnableAvis { get; set; }
        public bool EnableNational { get; set; }
        public bool EnableEnterprise { get; set; }
        public bool EnableEuropcar { get; set; }

    }

    public enum R_M_CompanyColumns
    {
        ID,
        M_CompanyID,
        CompanyCode,
        Factor,
        IsAllowCheaper,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_CompanyProcedure
    {
        p_R_M_Company_GetByCode,
        p_R_M_Company_GetByCompanyID,
        p_R_Company_GetMasterDataByID,
        p_R_M_Company_CheckInfo,
        p_R_M_CompanyGetByR_I_ImageID,
        p_M_CompanyGetBySkipACR,
        p_A_UserCompanyRentalCarPlatform_ForAccountSetup
    }
    public class R_M_CompanyList : List<R_M_Company>
    {

    }

    public class P_R_Process
    {
        public List<M_CarRentalProvider> ListProvider { get; set; }
        public List<R_M_ProviderProcess> ListProcess { get; set; }
        public List<R_M_Platform> ListPlatform { get; set; }
        public List<M_Company> ListParentRCCompany { get; set; }
        public List<string> ListReportType { get; set; }
        public List<string> ListReportFrequency { get; set; }
        public List<string> ListDayOfWeek { get; set; }
        public List<M_PaymentProvider> ListPaymentProvider { get; set; }

        public P_R_Process()
        {
            ListProvider = new List<M_CarRentalProvider>();
            ListProcess = new List<R_M_ProviderProcess>();
            ListPlatform = new List<R_M_Platform>();
            ListDayOfWeek = new List<string>();
            ListReportFrequency = new List<string>();
            ListReportType = new List<string>();
        }
    }
}