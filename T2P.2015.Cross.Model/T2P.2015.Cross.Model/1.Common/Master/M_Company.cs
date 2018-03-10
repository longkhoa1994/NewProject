using System;
using System.Collections.Generic;
using T2P._2015.Cross.Model.Process;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Company : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_ProcessID;
        public long? M_ProcessID
        {
            get { return _m_ProcessID; }
            set { _m_ProcessID = value; }
        }
        private long? _m_HotelPlatformID;
        public long? M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }
        private long? _m_FileLocationID;
        public long? M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }
        private long? _m_CaptureCenterID;
        public long? M_CaptureCenterID
        {
            get { return _m_CaptureCenterID; }
            set { _m_CaptureCenterID = value; }
        }
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        private long? _parentID;
        public long? ParentID
        {
            get { return _parentID; }
            set { _parentID = value; }
        }
        private long? _m_LanguageID;
        public long? M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _alias;

        public string Alias
        {
            get { return _alias; }
            set { _alias = value; }
        }

        private string _keyword;
        public string Keyword
        {
            get { return _keyword; }
            set { _keyword = value; }
        }
        
        private string _companyShortName;
        public string CompanyShortName
        {
            get { return _companyShortName; }
            set { _companyShortName = value; }
        }
        private string _customerNo;
        public string CustomerNo
        {
            get { return _customerNo; }
            set { _customerNo = value; }
        }
        private string _companyVATNumber;
        public string CompanyVATNumber
        {
            get { return _companyVATNumber; }
            set { _companyVATNumber = value; }
        }
        private string _subID;
        public string SubID
        {
            get { return _subID; }
            set { _subID = value; }
        }
        private string _companyTaxCode;
        public string CompanyTaxCode
        {
            get { return _companyTaxCode; }
            set { _companyTaxCode = value; }
        }
        private string _companyAddress;
        public string CompanyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }
        private string _companyEmail;
        public string CompanyEmail
        {
            get { return _companyEmail; }
            set { _companyEmail = value; }
        }
        private string _bankID;
        public string BankID
        {
            get { return _bankID; }
            set { _bankID = value; }
        }
        private string _zIPCode;
        public string ZIPCode
        {
            get { return _zIPCode; }
            set { _zIPCode = value; }
        }
        private string _cityName;
        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }
        private long? _m_CountryID;
        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }
        private string _telephone;
        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        private string _fax;
        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        private string _logo;
        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }

        private string _setupFilePath;
        public string SetupFilePath
        {
            get { return _setupFilePath; }
            set { _setupFilePath = value; }
        }

        private string _setupFileName;
        public string SetupFileName
        {
            get { return _setupFileName; }
            set { _setupFileName = value; }
        }

        private string _signatureImage;
        public string SignatureImage
        {
            get { return _signatureImage; }
            set { _signatureImage = value; }
        }
        private string _signatureText;
        public string SignatureText
        {
            get { return _signatureText; }
            set { _signatureText = value; }
        }
        private decimal? _latitude;
        public decimal? Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }
        private decimal? _longitude;
        public decimal? Longitude
        {
            get { return _longitude; }
            set { _longitude = value; }
        }
        private decimal? _timeZone;
        public decimal? TimeZone
        {
            get { return _timeZone; }
            set { _timeZone = value; }
        }

        private int? _fileSizeAttachment;
        public int? FileSizeAttachment
        {
            get { return _fileSizeAttachment; }
            set { _fileSizeAttachment = value; }
        }

        private int? _validateFkeyKkey;
        public int? ValidateFkeyKkey
        {
            get { return _validateFkeyKkey; }
            set { _validateFkeyKkey = value; }
        }

        private bool _isATXPremiumProcess;

        public bool IsATXPremiumProcess
        {
            get { return _isATXPremiumProcess; }
            set { _isATXPremiumProcess = value; }
        }

        public bool IsSkipInfoValidation { get; set; }

        public override string Table { get { return "M_Company"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Company_InsertOrUpdate"; } }

        private int _validateFKey;
        public int ValidateFKey
        {
            get { return _validateFKey; }
            set { _validateFKey = value; }
        }
    }

    [Serializable]
    public class M_CompanyIncludedORCText : M_Company
    {
        private string _ocrCompanyName;
        public string OcrCompanyName
        {
            get { return _ocrCompanyName; }
            set { _ocrCompanyName = value; }
        }

        private string _ocrCompanyShortName;
        public string OcrCompanyShortName
        {
            get { return _ocrCompanyShortName; }
            set { _ocrCompanyShortName = value; }
        }

        private string _ocrCompanyAddress;
        public string OcrCompanyAddress
        {
            get { return _ocrCompanyAddress; }
            set { _ocrCompanyAddress = value; }
        }

        private string _ocrCompanyCityName;
        public string OcrCompanyCityName
        {
            get { return _ocrCompanyCityName; }
            set { _ocrCompanyCityName = value; }
        }

        private string _ocrCompanyZipCode;
        public string OcrCompanyZipCode
        {
            get { return _ocrCompanyZipCode; }
            set { _ocrCompanyZipCode = value; }
        }

        private string _ocrCompanyVATNumber;
        public string OcrCompanyVATNumber
        {
            get { return _ocrCompanyVATNumber; }
            set { _ocrCompanyVATNumber = value; }
        }
    }

    public class M_Company_ForAccountSetup : M_Company
    {
        public OrganizationType Category { get; set; }
        public string HotelPlatformName { get; set; }
        public string CountryCode { get; set; }
        public int Permission { get; set; }

        public string Process { get; set; }
     
    }
    public enum M_CompanyColumns
    {
        ID,
        M_ProcessID,
        M_HotelPlatformID,
        M_FileLocationID,
        M_CaptureCenterID,
        FilePath,
        ParentID,
        M_LanguageID,
        CompanyName,
        Keyword,
        CompanyShortName,
        CustomerNo,
        CompanyVATNumber,
        SubID,
        CompanyTaxCode,
        CompanyAddress,
        CompanyEmail,
        BankID,
        ZIPCode,
        CityName,
        M_CountryID,
        Telephone,
        Fax,
        Logo,
        SetupFileURL,
        SignatureImage,
        SignatureText,
        Latitude,
        Longitude,
        TimeZone,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_CompanyProcedure
    {
        p_M_Company_CheckInfoHDE,
        p_M_Company_CheckInfoHRS,
        p_M_Company_GetListSearch,
        p_R_M_Company_GetListSearch,
        p_M_Company_GetListChild,
        p_R_M_Company_GetListChild,
        p_M_Company_GetByID,
        p_M_Company_GetByCompanyName,
        p_M_Company_GetListIDByHotelPlaformID,
        p_M_Company_GetListByHotelPlaformID,
        p_M_Company_GetByInvoiceID,
        p_M_Company_GetList_ParentCompany_By_ListID,
        p_M_Company_GetByEmail,
        p_M_Company_CheckCompanySetup,
      
        p_M_company_GetListHaveSetupDelete,
        p_M_Company_GetCIG,
        p_A_UserCompanyPlatform_ForAccountSetup,
        p_M_Company_Organization_ForAccountSetup,
        p_M_Company_GetChild,
        p_P_Company_GetDetailByID,
        p_P_Company_GetDetailByID_Page,
        p_P_Company_GetListChildrenCompany,

        p_M_Company_GetForDeletingLetter,
        p_M_Company_GetList_ByUserHotel,

        p_M_Company_CheckInfoEiffage,
        p_M_Company_GetListForReservationReview,

        p_M_Company_GetBy_SuggestDumb,
        p_M_Company_GetLogoURL_ByID,
        p_P_Company_GetList_ByUserID_ForOfflineGateway,
        p_Company_CheckInfoCFM,
        p_M_Company_CountrySetting,
        p_M_Company_GetByCustomerNo,
        
        //Company ECS
        p_M_Company_CheckInfoECS,
        p_M_Company_CheckIsECS,
        p_M_Company_CheckIsECSByCompanyID,

        p_M_Company_Get_By_A_UserProfileID,
        p_M_Company_GetListFkey,
        p_M_Company_GetListKkey,
        p_M_Company_GetListFkeyKKeyForCompanyRelation,
        p_M_Company_CheckExistNameAddress,

        p_M_Company_Get_ListCompany_By_HotelPlatformID,
        p_M_Company_GetListCompanyByListProcess,
        p_M_Company_GetListCompanyByPlatform_M_CompanyProcessID
    }

    public class M_CompanyList : List<M_Company>
    {
    }

    //public class M_CompanyDeleteInfo : M_Company
    //{
    //    private long _bookingCount;

    //    public long BookingCount
    //    {
    //        get { return _bookingCount; }
    //        set { _bookingCount = value; }
    //    }

    //    private DateTime? _firstCheckOutDate;

    //    public DateTime? FirstCheckOutDate
    //    {
    //        get { return _firstCheckOutDate; }
    //        set { _firstCheckOutDate = value; }
    //    }
    //}

    public class M_CompanyReservationReview
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private string _address;

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _zipCode;

        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
        private string _city;

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        private string _countryName;

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }
        private string _kKeys;

        public string KKeys
        {
            get { return _kKeys; }
            set { _kKeys = value; }
        }
        private string _fKey;

        public string FKey
        {
            get { return _fKey; }
            set { _fKey = value; }
        }
        private string _processName;

        public string ProcessName
        {
            get { return _processName; }
            set { _processName = value; }
        }
        private long _m_hotelPlatformID;

        public long M_hotelPlatformID
        {
            get { return _m_hotelPlatformID; }
            set { _m_hotelPlatformID = value; }
        }



    }

    public class P_Company_OfflineReservation : M_Company
    {
        public string LogoURL { get; set; }
        public string CountryName { get; set; }
        public P_Company_OfflineReservation()
        {
            LogoURL = string.Empty;
            CountryName = string.Empty;
        }
    }

    public class AP_M_Company
    {
        public long ID { get; set; }
        public string CompanyName { get; set; }
    }
}