using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model._1.Common.Master;
using T2P._2015.Cross.Model._5.Meetago.Master;
using T2P._2015.Cross.Model._1.Common.Master;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Process_CreditDebitInvoice
    {
        public bool IsOn { get; set; }
    }

    public class P_Process_HotelNoChargeVCC
    {
        public int StopTime { get; set; }
        public int SendTime { get; set; }
        public string Period { get; set; }
        public bool IsOn { get; set; }
    }

    public class P_Process_SelfPaymentMethodAccepted
    {
        public bool IsOn { get; set; }
        public bool IsDirectPayer { get; set; }
        public bool IsCompanyOnAccount { get; set; }
        public bool IsCompanyCreditCard { get; set; }
        public bool IsPersonalCreditCard { get; set; }
    }
    public class P_Company_Payment
    {
        public string name { get; set; }
        public string identity { get; set; }
        public bool IsGenerateVCC { get; set; }
        public string BillingAccount { get; set; }
        public string PaymentInterface { get; set; }
    }

    public class P_CompanyDeliveryEnrich : M_CompanyProcessEnrich
    {
        public string Name { get; set; }
        public bool DisplayMail { get; set; }
        public bool DisplaySFTP { get; set; }
        public string KeyPGP { get; set; }
        public string ErrorFormat { get; set; }
        public bool IsValidateEmail { get; set; }
        public string FilePath { get; set; }
    }
    public class P_CompanyDeliveryEnrichSetting
    {
        public bool IsOn { get; set; }
        public bool IsPartner { get; set; }
        public bool IsCustomer { get; set; }
       
        public long M_HotelPlatformID { get; set; }
        public long M_ProcessID { get; set; }
        public List<P_CompanyDeliveryEnrich> ListCompanyDeliveryEnrich;

        public P_CompanyDeliveryEnrichSetting()
        {
            ListCompanyDeliveryEnrich = new List<P_CompanyDeliveryEnrich>();
        }
    }
    public class P_Company_Delivery
    {
        public string DeliveryFequency { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public long ConvertFileTypeID { get; set; }
        public string FileTypeName { get; set; }
        public long FileType { get; set; }
        public string DeliveryType { get; set; }
        public string ExpireTime { get; set; }
        public string DeliveryChannel { get; set; }
        public string EmailAddress { get; set; }
        public string Server { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Path { get; set; }
        public string Encryption { get; set; }

        public bool isRemoveWhenSubmit { get; set; }

        public string ZipPassword { get; set; }
        public string KeyPGP { get; set; }

        public string OutputFormat { get; set; }
    }
    public class P_Company_NoStep_Setting
    {
        public dynamic Setting { get; set; }
        public int Index_View_NoStep_HDE { get; set; }
        public int Index_View_NoStep_HRS { get; set; }
        public int Index_View_NoStep_BCD { get; set; }
        public int Index_View_NoStep_Cytric { get; set; }
        public int Index_View_NoStep_OFF { get; set; }
        public int Index_View_NoStep_CFM { get; set; }
        public int Index_View_NoStep_Voya { get; set; }
        public int Index_Edit_NoStep_HDE { get; set; }
        public int Index_Edit_NoStep_HRS { get; set; }
        public int Index_Edit_NoStep_BCD { get; set; }
        public int Index_Edit_NoStep_Cytric { get; set; }
        public int Index_Edit_NoStep_OFF { get; set; }
        public int Index_Edit_NoStep_CFM { get; set; }
        public int Index_Edit_NoStep_Voya { get; set; }
        public string Name { get; set; }
    }

    public class P_Company_Detail : P_Company_Info
    {
        public bool IsImportByFKey { get; set; }
        public string NewLogoURL { get; set; }
        public string NewSetupFilePath { get; set; }
        public string MessageError { get; set; }
        public bool IsShowAll_ChildrenCompany { get; set; }
        public List<M_F_FileType> ListFileType { get; set; }
        public P_Company_Payment CompanyPayment { get; set; }
        public R_M_CompanyArchivedSetting RCCompanyArchived { get; set; }
        public M_CompanyArchivedSetting CompanyArchived { get; set; }
        public List<P_Company_Delivery> CompanyDelivery { get; set; }
        public List<P_Company_Contact> ListCompanyContact { get; set; }
        public List<P_Company_VATCode> ListCompanyVATCode { get; set; }
        public List<P_Company_Addition> ListCompanyAddition { get; set; }
        public List<P_Company_Info> ListChildrenCompany { get; set; }
        public List<P_UserPermission> ListUserSuggestion { get; set; }
        public List<M_CompanyDBISetting> ListCompanyDBISetting { get; set; }
        public List<M_CancellationPolicy> ListCancellationPolicy { get; set; }
        public List<M_ServiceKeyword> ListServiceKeyword { get; set; }
        public List<M_ServiceCode> ListServiceCode { get; set; }
        public List<P_Company_NoStep_Setting> ListSetting_WithoutStep { get; set; }
        public List<vm_M_CompanyCountrySetting> ListExceptionPolicyCountry { get; set; }
        public List<M_Currency> ListCurrency { get; set; }
        public M_CompanyTamaraSetting Tamara { get; set; }
        public List<M_CompanyCheckOutMail_NonContract_Addition> ListCompanyCheckOutMail { get; set; }
        public bool IsUseHotelPlatform { get; set; }

        public P_Company_Detail()
        {
            CompanyPayment = new P_Company_Payment();
            CompanyArchived = new M_CompanyArchivedSetting();
            CompanyDelivery = new List<P_Company_Delivery>();
            IsShowAll_ChildrenCompany = false;
            ListCompanyContact = new List<P_Company_Contact>();
            ListChildrenCompany = new List<P_Company_Info>();
            ListCompanyVATCode = new List<P_Company_VATCode>();
            ListUserSuggestion = new List<P_UserPermission>();
            ListCompanyAddition = new List<P_Company_Addition>();
            ListCompanyDBISetting = new List<M_CompanyDBISetting>();
            ListCancellationPolicy = new List<M_CancellationPolicy>();
            ListServiceKeyword = new List<M_ServiceKeyword>();
            ListServiceCode = new List<M_ServiceCode>();
            ListSetting_WithoutStep = new List<P_Company_NoStep_Setting>();
            ListExceptionPolicyCountry = new List<vm_M_CompanyCountrySetting>();
            ListCompanyCheckOutMail = new List<M_CompanyCheckOutMail_NonContract_Addition>();
            Tamara = new M_CompanyTamaraSetting();
        }
    }

    public class P_Company_Info : M_Company
    {
        public string LogoURL { get; set; }
        public string SetupFilePath { get; set; }
        public string ParentCompanyName { get; set; }
        public string CountryName { get; set; }
        public string LanguageText { get; set; }
        public string CountryCode { get; set; }
        public bool Highlight { get; set; }
        public bool HighlightCompanyName { get; set; }
        public string ValidateKeyErrorType { get; set; }
        public string CompanyNameDuplicateFKey { get; set; }
        public string VATCode { get; set; }
        public string VATCodeAllCountry { get; set; }
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
        public string CommonProcessName { get; set; }
        public string HotelPlatformName { get; set; }
        public long M_CompanyProcessID { get; set; }
        public long M_CompanyDBIID { get; set; }
        public string CompanyCode { get; set; }
        public string EmployeeNo_PK { get; set; }
        public string CostCenter_KS { get; set; }
        public string DepartmentNo_DS { get; set; }
        public string AccountingUnit_AE { get; set; }
        public string InternalAccount_IK { get; set; }
        public DateTime ProcessingDate_BD { get; set; }
        public string CustomerName_BD { get; set; }
        public string ProjectNo_PR { get; set; }
        public string OrderNo_AU { get; set; }
        public string ActionNo_AK { get; set; }
        public string FinalDestination_RZ { get; set; }
        public string DBI { get; set; }
        public bool IsPK { get; set; }
        public bool IsKS { get; set; }
        public bool IsDS { get; set; }
        public bool IsAE { get; set; }
        public bool IsAK { get; set; }
        public bool IsBD { get; set; }
        public bool IsPR { get; set; }
        public bool IsAU { get; set; }
        public bool IsRZ { get; set; }
        public bool IsIK { get; set; }
        public string ImageLayover { get; set; }
        public bool IsPK_Image { get; set; }
        public bool IsKS_Image { get; set; }
        public bool IsDS_Image { get; set; }
        public bool IsAE_Image { get; set; }
        public bool IsAK_Image { get; set; }
        public bool IsBD_Image { get; set; }
        public bool IsPR_Image { get; set; }
        public bool IsAU_Image { get; set; }
        public bool IsRZ_Image { get; set; }
        public bool IsIK_Image { get; set; }
        public List<P_Company_ProcessStep> ListStep { get; set; }
        public List<P_Company_NoStep_Setting> ListSetting_WithoutStep { get; set; }
        public P_Company_Process()
        {
            ListStep = new List<P_Company_ProcessStep>();
            ListSetting_WithoutStep = new List<P_Company_NoStep_Setting>();
            IsPK = false;
            IsKS = false;
            IsDS = false;
            IsAE = false;
            IsAK = false;
            IsBD = false;
            IsPR = false;
            IsAU = false;
            IsRZ = false;
            IsIK = false;
            EmployeeNo_PK = string.Empty;
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
        public bool Highlight { get; set; }
        public string ValidateKeyErrorType { get; set; }
    }

    public class P_Process_IDI
    {
        public string Frequency { get; set; }
        public string Period { get; set; }
        public string ExecutionDate { get; set; }
        public string ExecutionTime { get; set; }
        public string ServiceType { get; set; }
        public string LinkServer { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? Port { get; set; }
        public string Folder { get; set; }
        public string Path { get; set; }
        public bool IsOn { get; set; }
        public string Hour { get; set; }
        public string Minute { get; set; }
        public bool IsImage { get; set; }
        public string ArchivingFrequency { get; set; }
        public string ArchivingPeriod { get; set; }
        public string UploadFrequency { get; set; }
        public string UploadPeriod { get; set; }
        public string ZipPassword { get; set; }
        public bool? UseDownloadCenter { get; set; }
        public bool IsAttachedExcel { get; set; }
        public DateTime? LastArchivedDate { get; set; }
        public string NotificationEmail { get; set; }
        public bool IsApplyCarRental { get; set; }
        //public string FileNameDeliveryImage { get; set; }
    }

    public class M_CompanyProcessScheduleSetting : M_CompanyProcessSchedule
    {
        public bool IsOn { get; set; }
        public bool DisplayMail { get; set; }
        public bool DisplaySFTP { get; set; }
        public string Hour { get; set; }
        public string Minute { get; set; }
        public string Folder { get; set; }
        public bool IsValidateEmail { get; set; }
    }
    public class DateOfWeekMonth
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        
    }
    public class M_CompanyGroupSetting
    {
        public M_CompanyProcessScheduleSetting CompanyProcessScheduleSetting { get; set; }
        public List<DateOfWeekMonth> ListDateWeeks { get; set; }
        public List<DateOfWeekMonth> ListDateMonths { get; set; }
        public M_CompanyGroupSetting()
        {
            CompanyProcessScheduleSetting = new M_CompanyProcessScheduleSetting();
            ListDateWeeks = CreateDateWeekMonth("Weeks");
            ListDateMonths = CreateDateWeekMonth("Months");
        }
        private List<DateOfWeekMonth> CreateDateWeekMonth(string type)
        {
            List<DateOfWeekMonth> result = new List<DateOfWeekMonth>();

            if (type.Equals("Weeks"))
            {
                for (var i = 1; i < 8; i++)
                {
                    string dayOfWeek = "";
                    switch (i)
                    {
                        case 1:
                            dayOfWeek = "Sunday";
                            break;
                        case 2:
                            dayOfWeek = "Monday";
                            break;
                        case 3:
                            dayOfWeek = "Tuesday";
                            break;
                        case 4:
                            dayOfWeek = "Wednesday";
                            break;
                        case 5:
                            dayOfWeek = "Thursday";
                            break;
                        case 6:
                            dayOfWeek = "Friday";
                            break;
                        case 7:
                            dayOfWeek = "Saturday";
                            break;
                    };
                    result.Add(new DateOfWeekMonth()
                    {
                        ID = i,
                        Name = dayOfWeek,
                        IsActive = false
                    });
                }
            }
            else
            {
                for (var i = 0; i < 31; i++)
                {
                    result.Add(new DateOfWeekMonth()
                    {
                        ID = i,
                        IsActive = false
                    });
                }
            }
            return result;
        }
    }

    public class P_Process_IDICFM
    {
        public bool IsOn { get; set; }
        public List<M_CompanyGroupSetting> ListCompanyGroupSetting { get; set; }

        public P_Process_IDICFM()
        {
            ListCompanyGroupSetting = new List<M_CompanyGroupSetting>();
        }
    }
    public class P_Process_IGW
    {
        public bool IsOn { get; set; }
        public string Email { get; set; }
        public string MailServer { get; set; }
        public string MailPassword { get; set; }
        public string ZipPassword { get; set; }
    }

    public class P_Process_IAP
    {
        public bool IsOn { get; set; }
        public bool Is1st { get; set; }
        public bool Is2nd { get; set; }
        public bool IsSuccessInv { get; set; }

    }

    public class P_Process_IVA
    {
        public bool IsOn { get; set; }
    }

    public class P_Process_IFQC
    {
        public bool IsOn { get; set; }
        public bool IsPaySlip { get; set; }
        public bool IsCopy { get; set; }
        public bool IsVATNumber { get; set; }
        public List<string> ListFinalCheck { get; set; }
        public P_Process_IFQC()
        {
            ListFinalCheck = new List<string>();
        }
    }

    public class P_Process_ISTR
    {
        public bool IsOn { get; set; }
        public string HeaderText { get; set; }
        public string Email { get; set; }
        public string CC { get; set; }
        public bool IsAttach { get; set; }
        public bool IsDaimler { get; set; }
        public string HeaderTextCorrection { get; set; }
        public bool IsCheckOutCorrection { get; set; }
        public string ReceiverSetting { get; set; }
        public string HeaderContentSetting { get; set; }
        public bool IsCarRental { get; set; }
        public bool IsAlowCheaper { get; set; }
        public string CarRental_HeaderText { get; set; }
        public string CarRental_Email { get; set; }
        public string CarRental_CC { get; set; }
        public string CarRental_Company_Code { get; set; }
        public string CarRental_HeaderText_Correction { get; set; }
        public string CarRental_HeaderText_CreditNote { get; set; }


        public string RC_Received_Email_Setting { get; set; }
        public string RC_Custom_Received_Email { get; set; }
        public string RC_Custom_Received_Email_CC { get; set; }

        public bool RC_Has_Successful_Inv_Debit_T_Case { get; set; }
        public bool RC_Has_Error_Inv_Debit_T_Case { get; set; }
        public bool RC_Has_Attachment_Debit_Inv_T_Case { get; set; }

        //public bool RC_Has_Successful_Inv_New_Debit_T_Case { get; set; }
        //public bool RC_Has_Error_Inv_New_Debit_T_Case { get; set; }
        //public bool RC_Has_Attachment_New_Debit_Inv_T_Case { get; set; }

        public bool RC_Has_Successful_Inv_Cancel_T_Case { get; set; }
        public bool RC_Has_Attachment_Cancel_Inv_T_Case { get; set; }

        public bool RC_Has_Successful_Inv_Credit_Note_T_Case { get; set; }
        public bool RC_Has_Error_Inv_Credit_Note_T_Case { get; set; }
        public bool RC_Has_Attachment_Credit_Note_Inv_T_Case { get; set; }

        public bool RC_Has_Successful_Inv_Debit_C_Case { get; set; }
        public bool RC_Has_Error_Inv_Debit_C_Case { get; set; }
        public bool RC_Has_Attachment_Debit_Inv_C_Case { get; set; }

        //public bool RC_Has_Successful_Inv_New_Debit_C_Case { get; set; }
        //public bool RC_Has_Error_Inv_New_Debit_C_Case { get; set; }
        //public bool RC_Has_Attachment_New_Debit_Inv_C_Case { get; set; }

        public bool RC_Has_Successful_Inv_Cancel_C_Case { get; set; }
        public bool RC_Has_Attachment_Cancel_Inv_C_Case { get; set; }

        public bool RC_Has_Successful_Inv_Credit_Note_C_Case { get; set; }
        public bool RC_Has_Error_Inv_Credit_Note_C_Case { get; set; }
        public bool RC_Has_Attachment_Credit_Note_Inv_C_Case { get; set; }
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

    public class P_Process_Approval
    {
        public bool IsOn { get; set; }
        public bool Is1st { get; set; }
        public bool Is2nd { get; set; }

        public bool IsSuccessInv { get; set; }

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
    public class P_Process_BRE
    {
        public bool IsOn { get; set; }
    }
    public class P_Process_IDD
    {
        public bool IsOn { get; set; }
    }

    public class P_Process_ICSV
    {
        public bool IsOn { get; set; }
        public string Path { get; set; }
        public string Period { get; set; }
        public string Frequency { get; set; }
        public string Hour { get; set; }
        public string Minute { get; set; }
        public string ZipPassword { get; set; }
        public bool IsAttach { get; set; }
        public string ExecutionTime { get; set; }
        public string ExecutionDate { get; set; }
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
        public List<M_InvoiceErrorCode> ListStandard_FinalCheck { get; set; }

        public List<M_ServiceCode> ListServiceCode { get; set; }
        public P_Company_Common()
        {
            ListLanguage = new List<M_Language>();
            ListCountry = new List<M_Country>();
            ListParentCompany = new List<M_Company>();
            ListProcess = new List<M_Process>();
            ListHotelPlatform = new List<M_HotelPlatform>();
            ListFileLocation = new List<M_FileLocation>();
            ListTimeZone = new List<M_TimeZone>();
            ListStandard_FinalCheck = new List<M_InvoiceErrorCode>();
            ListServiceCode = new List<M_ServiceCode>();
        }
    }

    public class P_Company_Data
    {
        public string NewLogoURL { get; set; }
        public string NewSetupFilePath { get; set; }
        public M_Company Company { get; set; }
        public M_CompanyPayment CompanyPayment { get; set; }
        public M_CompanyArchivedSetting CompanyArchived { get; set; }
        public List<M_CompanyDelivery> CompanyDelivery { get; set; }
        public M_CompanyDBI CompanyDBI { get; set; }
        public List<P_Company_Data> ListChild { get; set; }
        public List<M_CompanyContact> ListCompanyContact { get; set; }
        public List<M_CompanyVATCode> ListCompanyVATCode { get; set; }
        public List<M_CompanyAddition> ListCompanyAddition { get; set; }
        public List<P_CompanyProcess_Data> ListCompanyProcess { get; set; }
        public List<A_UserCompanyPlatform> ListUserPermission { get; set; }
        public List<A_UserCompanyPlatform> ListOld_UserPermission { get; set; }
        public List<M_CompanyDBI> ListCompanyDBI { get; set; }
        public List<M_CompanyProcessSetting> ListCompanyProcessSetting { get; set; }

        public List<M_CancellationPolicy> ListCancellationPolicy { get; set; }

        public List<M_ServiceKeyword> ListServiceKeyword { get; set; }

        public List<vm_M_CompanyCountrySetting> ListExceptionPolicyCountry { get; set; }
        public M_CompanyTamaraSetting Tamara { get; set; }

        public P_Company_Data()
        {
            CompanyPayment = new M_CompanyPayment();
            CompanyArchived = new M_CompanyArchivedSetting();
            CompanyDelivery = new List<M_CompanyDelivery>();
            CompanyDBI = new M_CompanyDBI();
            ListChild = new List<P_Company_Data>();
            ListCompanyContact = new List<M_CompanyContact>();
            ListCompanyProcess = new List<P_CompanyProcess_Data>();
            ListUserPermission = new List<A_UserCompanyPlatform>();
            ListOld_UserPermission = new List<A_UserCompanyPlatform>();
            ListCompanyVATCode = new List<M_CompanyVATCode>();
            ListCompanyAddition = new List<M_CompanyAddition>();
            ListCompanyDBI = new List<M_CompanyDBI>();
            ListCompanyProcessSetting = new List<M_CompanyProcessSetting>();
            ListCancellationPolicy = new List<M_CancellationPolicy>();
            ListServiceKeyword = new List<M_ServiceKeyword>();
            ListExceptionPolicyCountry = new List<vm_M_CompanyCountrySetting>();
        }
    }

    public class P_CompanyProcess_Data
    {
        public M_CompanyProcess CompanyProcess { get; set; }
        public List<P_CompanyProcessDetail_Data> ListCompanyProcessDetail { get; set; }
        public List<M_CompanyProcessSetting> ListCompanyProcessSetting { get; set; }
        public List<M_CompanyProcessEnrich> ListCompanyProcessEnrich { get; set; }
        
        public M_CompanyProcess OldCompanyProcess { get; set; }
        public P_CompanyProcess_Data()
        {
            ListCompanyProcessDetail = new List<P_CompanyProcessDetail_Data>();
            ListCompanyProcessSetting = new List<M_CompanyProcessSetting>();
            ListCompanyProcessEnrich = new List<M_CompanyProcessEnrich>();
            
        }
    }

    public class P_CompanyProcessDetail_Data
    {
        public M_CompanyProcessDetail CompanyProcessDetail { get; set; }
        public List<M_CompanyGeneralSetting> ListCompanyGeneralSetting { get; set; }
        public M_CompanyProcessSchedule CompanyProcessSchedule { get; set; }
        public List<M_CompanyProcessSchedule> ListCompanyProcessSchedule { get; set; }
        public M_CompanyApprovalSetting CompanyApprovalSetting { get; set; }
        public P_CompanyProcessDetail_Data()
        {
            ListCompanyGeneralSetting = new List<M_CompanyGeneralSetting>();
            ListCompanyProcessSchedule = new List<M_CompanyProcessSchedule>();
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

    public class P_SubCompany_ValidateKey
    {
        public long CompanyID { get; set; }
        public string FKey { get; set; }
        public string KKey { get; set; }
    }

    public class P_Company_ValidateKey
    {
        public bool IsCompanyDetail { get; set; }
        public List<P_SubCompany_ValidateKey> ListCompanyAdditionID { get; set; }
        public List<P_SubCompany_ValidateKey> ListSubCompanyID { get; set; }
        public string ValidateErrorType { get; set; }
        public P_Company_ValidateKey()
        {
            IsCompanyDetail = false;
            ListCompanyAdditionID = new List<P_SubCompany_ValidateKey>();
            ListSubCompanyID = new List<P_SubCompany_ValidateKey>();
            ValidateErrorType = "";
        }
    }

    public class P_Company_Suggestion
    {
        public string MessageError { get; set; }
        public string MessageErrorType { get; set; }
        public long CompanyID { get; set; }
        public List<P_UserPermission> ListUserSuggestion { get; set; }
        public List<string> ListHotelPlatformNameDeselect { get; set; } // Comment: revert code
        public P_Company_ValidateKey CompanyInfoValidateKey { get; set; }
        public P_Company_ValidateNameAddress CompanyValidateNameAddress { get; set; }
        public P_Company_Suggestion()
        {
            ListUserSuggestion = new List<P_UserPermission>();
            //ListHotelPlatformNameDeselect = new List<string>();
            CompanyInfoValidateKey = new P_Company_ValidateKey();
            CompanyValidateNameAddress = new P_Company_ValidateNameAddress();
        }
    }

    public class P_SubCompany_ValidateNameAddress
    {
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string ZIPCode { get; set; }
        public string CityName { get; set; }
        public long? M_CountryID { get; set; }
    }
    public class P_Company_ValidateNameAddress
    {
        public string ValidateErrorType { get; set; }
        public List<P_SubCompany_ValidateNameAddress> ListSubCompany;
        public P_Company_ValidateNameAddress()
        {
            ValidateErrorType = string.Empty;
            ListSubCompany = new List<P_SubCompany_ValidateNameAddress>();
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

    public class vm_M_CompanyCountrySetting
    {
        private long _m_CompanyCountrySettingID;
        public long M_CompanyCountrySettingID
        {
            get { return _m_CompanyCountrySettingID; }
            set { _m_CompanyCountrySettingID = value; }
        }

        private long _m_CompanyID;
        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private long _m_CountryID;
        public long M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }

        private long _exceptionStatus;
        public long ExceptionStatus
        {
            get { return _exceptionStatus; }
            set { _exceptionStatus = value; }
        }

    }
    public class M_Company_Delete
    {
        public M_Company_Delete()
        {
            ListCompanyProcess = new List<M_CompanyProcess>();
            ListCompanyProcessDetail = new List<M_CompanyProcessDetail>();
            ListCompanyProcessSchedule = new List<M_CompanyProcessSchedule>();
            ListCompanyProcessSetting = new List<M_CompanyProcessSetting>();
            ListCompanyGeneralSetting = new List<M_CompanyGeneralSetting>();
        }
        public List<M_CompanyProcess> ListCompanyProcess { get; set; }
        public List<M_CompanyProcessDetail> ListCompanyProcessDetail { get; set; }
        public List<M_CompanyProcessSchedule> ListCompanyProcessSchedule { get; set; }
        public List<M_CompanyProcessSetting> ListCompanyProcessSetting { get; set; }
        public List<M_CompanyGeneralSetting> ListCompanyGeneralSetting { get; set; }

    }

    public class P_R_CompanyMasterData : P_Company_Info
    {
        public long R_M_CompanyID { get; set; }
        public bool IsAllowCheaper { get; set; }
        public string MessageError { get; set; }
        public decimal? Factor { get; set; }
        public string CompanyCode { get; set; }
    }

    public class P_R_CompanyDetail : P_R_CompanyMasterData
    {
        public string Logo { get; set; }
        public string LocalPath { get; set; }
        public List<R_M_CompanyProviderSetting> ListCompanyProviderSetting { get; set; }
        public List<R_M_CompanyPlatform> ListCompanyRPlatform { get; set; }
        public List<R_M_CompanySetting> ListCompanyCheckoutMailSetting { get; set; }
        public R_M_CompanyArchivedSetting RCCompanyArchived { get; set; }
        public M_CompanyArchivedSetting CompanyArchived { get; set; }
        public List<P_Company_Info> ListChildrenCompany { get; set; }
        public List<R_M_CompanySetting> ListReportSetting { get; set; }
        public List<P_Company_Contact> ListCompanyContact { get; set; }
        public List<R_M_CompanyAddition> ListCompanyAddition { get; set; }
        public R_M_CompanySchedule DeliveryImageSetting { get; set; }
        public bool IsFollowParent { get; set; }
    }
}
