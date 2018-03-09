using System;
using System.Collections.Generic;
using T2P._2015.Cross.Model.View;
using T2P._2015.Cross.Model.Process;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Hotel : BaseModel
    {
        private int _caseSearch;

        public int CaseSearch
        {
            get { return _caseSearch; }
            set { _caseSearch = value; }
        }

        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_HotelChainID;
        public long? M_HotelChainID
        {
            get { return _m_HotelChainID; }
            set { _m_HotelChainID = value; }
        }
        private string _hotelNo;
        public string HotelNo
        {
            get { return _hotelNo; }
            set { _hotelNo = value; }
        }
        private string _hotelName;
        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }

        private string _convertedHotelName;

        public string ConvertedHotelName
        {
            get { return _convertedHotelName; }
            set { _convertedHotelName = value; }
        }

        private string _hoteAddress;
        public string HoteAddress
        {
            get { return _hoteAddress; }
            set { _hoteAddress = value; }
        }

        private string _convertedHotelAddress;

        public string ConvertedHotelAddress
        {
            get { return _convertedHotelAddress; }
            set { _convertedHotelAddress = value; }
        }

        private string _zipCode;
        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
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
        private string _countryCode;
        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }
        private string _phone;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private string _convertedPhoneNumber;

        public string ConvertedPhoneNumber
        {
            get { return _convertedPhoneNumber; }
            set { _convertedPhoneNumber = value; }
        }

        private string _fax;
        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        public bool FaxNotAvailable { get; set; }

        private string _convertedFaxNumber;

        public string ConvertedFaxNumber
        {
            get { return _convertedFaxNumber; }
            set { _convertedFaxNumber = value; }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
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
        private long? _m_LanguageID;
        public long? M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
        private long? _m_TimeZoneID;
        public long? M_TimeZoneID
        {
            get { return _m_TimeZoneID; }
            set { _m_TimeZoneID = value; }
        }
        private decimal? _timezone;
        public decimal? Timezone
        {
            get { return _timezone; }
            set { _timezone = value; }
        }
        private string _hotelVATNumber;
        public string HotelVATNumber
        {
            get { return _hotelVATNumber; }
            set { _hotelVATNumber = value; }
        }
        private bool? _isNewHotel;
        public bool? IsNewHotel
        {
            get { return _isNewHotel; }
            set { _isNewHotel = value; }
        }
        private int? _tIMRating;
        public int? TIMRating
        {
            get { return _tIMRating; }
            set { _tIMRating = value; }
        }
        private int? _starRating;
        public int? StarRating
        {
            get { return _starRating; }
            set { _starRating = value; }
        }
        private bool? _pMS;
        public bool? PMS
        {
            get { return _pMS; }
            set { _pMS = value; }
        }
        private int? _totalOfRoom;
        public int? TotalOfRoom
        {
            get { return _totalOfRoom; }
            set { _totalOfRoom = value; }
        }
        private string _currencyCode;
        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }
        private string _state;
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        private int? _hotelGateway;
        public int? HotelGateway
        {
            get { return _hotelGateway; }
            set { _hotelGateway = value; }
        }

        private long? _m_AccommodationTypeID;

        public long? M_AccommodationTypeID
        {
            get { return _m_AccommodationTypeID; }
            set { _m_AccommodationTypeID = value; }
        }
        private long? _m_HotelThemeID;

        public long? M_HotelThemeID
        {
            get { return _m_HotelThemeID; }
            set { _m_HotelThemeID = value; }
        }
        private string _tIM_ID_Number;

        public string TIM_ID_Number
        {
            get { return _tIM_ID_Number; }
            set { _tIM_ID_Number = value; }
        }

        private string _pMS_System;

        public string PMS_System
        {
            get { return _pMS_System; }
            set { _pMS_System = value; }
        }
        private long? _isLock;

        public long? IsLock
        {
            get { return _isLock; }
            set { _isLock = value; }
        }
        private long? _lockedBy;

        public long? LockedBy
        {
            get { return _lockedBy; }
            set { _lockedBy = value; }
        }


        private string _pCI_AccountName;

        public string PCI_AccountName
        {
            get { return _pCI_AccountName; }
            set { _pCI_AccountName = value; }
        }

        private string _pCI_AccountStatus;

        public string PCI_AccountStatus
        {
            get { return _pCI_AccountStatus; }
            set { _pCI_AccountStatus = value; }
        }

        private string _hotelSpecialty;

        public string HotelSpecialty
        {
            get { return _hotelSpecialty; }
            set { _hotelSpecialty = value; }
        }
        private DateTime? _pCI_CreatedDate;

        public DateTime? PCI_CreatedDate
        {
            get { return _pCI_CreatedDate; }
            set { _pCI_CreatedDate = value; }
        }

        private bool _pCI_Allowed;

        public bool PCI_Allowed
        {
            get { return _pCI_Allowed; }
            set { _pCI_Allowed = value; }
        }

        public string PCI_RegistrationEmail { get; set; }
        public DateTime? PCI_LastRegistrationDate { get; set; }
        public DateTime? PCI_ExpriredRegistrationDate { get; set; }

        public int? BackgroundProcess { get; set; }

        private string _contactPerson;

        public string ContactPerson
        {
            get { return _contactPerson; }
            set { _contactPerson = value; }
        }


        private string _languageCode;

        public string LanguageCode
        {
            get { return _languageCode; }
            set { _languageCode = value; }
        }

        public HotelPCIValues GetPCIValues()
        {
            return new HotelPCIValues
            {
                AccountName = _pCI_AccountName,
                IsAllowed = _pCI_Allowed,
                AccountStatus = _pCI_AccountStatus,
                ExpriredRegistrationDate = this.PCI_ExpriredRegistrationDate,
                CreatedDate = _pCI_CreatedDate,
                LastRegistrationDate = this.PCI_LastRegistrationDate,
                RegistrationEmail = this.PCI_RegistrationEmail
            };
        }

        public override string Table { get { return "M_Hotel"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Hotel_InsertOrUpdate"; } }
    }

    [Serializable]
    public class M_HotelIncludedORCText : M_Hotel
    {
        private string _ocrHotelName;
        public string OcrHotelName
        {
            get { return _ocrHotelName; }
            set { _ocrHotelName = value; }
        }
        private string _ocrHotelAddress;
        public string OcrHotelAddress
        {
            get { return _ocrHotelAddress; }
            set { _ocrHotelAddress = value; }
        }
        private string _ocrHotelCityName;
        public string OcrHotelCityName
        {
            get { return _ocrHotelCityName; }
            set { _ocrHotelCityName = value; }
        }
        private string _ocrHotelZipCode;
        public string OcrHotelZipCode
        {
            get { return _ocrHotelZipCode; }
            set { _ocrHotelZipCode = value; }
        }
        private string _ocrHotelVATNumber;
        public string OcrHotelVATNumber
        {
            get { return _ocrHotelVATNumber; }
            set { _ocrHotelVATNumber = value; }
        }
    }

    // Model for PCI
    [Serializable]
    public class HotelProperty
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string BusinessWebsite { get; set; }
        public string ContactPerson { get; set; }
        public string EmailAddress { get; set; }
        public string EmailNotifications { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string CountryCode { get; set; }
        public string PostalCode { get; set; }
        public string LanguageCode { get; set; }
        public int TTLHours { get; set; }
        //public string HotelSpecialty { get; set; }
        public HotelProperty()
        {

        }
    }

    public class PresentPCI
    {
        public string BookingNumberInterval { get; set; }
        public string BookingNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string TravelerName { get; set; }
        public string Message { get; set; }
        public string HotelPlatformName { get; set; }

    }
    public enum M_HotelColumns
    {
        ID,
        M_HotelChainID,
        HotelNo,
        HotelName,
        ConvertedHotelName,
        HotelAddress,
        ConvertedHotelAddress,
        ZipCode,
        CityName,
        M_CountryID,
        CountryCode,
        Phone,
        Fax,
        ConvertedFaxNumber,
        Email,
        Latitude,
        Longitude,
        M_LanguageID,
        M_TimeZoneID,
        Timezone,
        HotelVATNumber,
        IsNewHotel,
        TIMRating,
        StarRating,
        PMS,
        TotalOfRoom,
        CurrencyCode,
        State,
        HotelGateway,
        M_AccommodationTypeID,
        M_HotelThemeID,
        TIM_ID_Number,
        PMS_System,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
        HotelSpecialty,
    }

    public class M_Hotel_ConvertedColumns
    {
        public string ConvertedHotelName { get; set; }
        public string ConvertedHotelAddress { get; set; }
        public string ConvertedPhoneNumber { get; set; }
        public string ConvertedFaxNumber { get; set; }

    }

    public enum M_HotelProcedure
    {
        p_M_Hotel_CheckInfo,
        p_M_Hotel_GetListHotel,
        p_M_Hotel_GetListHotelForUpdateLatLong,
        p_M_Hotel_GetByI_ImageID,
        p_M_Hotel_Get_Search,
        p_M_Hotel_Get_Search_Count,
        p_M_Hotel_GetListByTime,
        p_M_Hotel_GetByB_AccessID,
        p_M_Hotel_GetByEmail,
        p_M_Hotel_GetByTableName,
        p_M_Hotel_GetInfor_ByID,
        p_M_Hotel_CheckDuplicated,
        p_M_Hotel_Get_Search_HotelPermission,
        p_M_Hotel_GetByBillingEmailId,
        p_M_Hotel_GetList_ForRegistration,
        p_M_Hotel_CheckDuplicated_Point,
        p_M_Hotel_GetList_CheckDuplicated,
        p_M_Hotel_GetList_CheckDuplicated_Total,
        p_M_Hotel_GetList_CheckDuplicated_Detail,
        p_M_Hotel_GetList_CheckDuplicated_ListNewHotel,
        p_M_Hotel_GetList_CheckDuplicated_ListNewHotel_Total,
        p_M_Hotel_GetList_CheckDuplicated_Detail_ListNewHotel,
        p_M_Hotel_GetList_LockedByUserID,
        p_M_Hotel_Update_LockHotel,
        p_M_Hotel_Update_UnLockHotel,
        p_M_Hotel_GetBy_SuggestDumb,
        p_M_Hotel_Update_UnLockHotelByUserID,
        p_P_Meetago_GetListHotelID,
        p_M_Hotel_GetNumber_DuplicatedHotel_By_UserID,
        p_M_Hotel_AccountStatusPCI_Pending,
        p_M_Hotel_AddNewAccount_PCI,
        p_M_Hotel_AccountPCI_Close,
        p_M_Hotel_GetByBookingNo,
        p_M_Hotel_GetInformation_PresentPCI,
        p_M_Hotel_ConvertFaxNumber,
        p_M_Hotel_Update_FaxNumber_FromDeeplink,
        p_M_Hotel_CheckTokenAndFaxNumberForDeeplink,
        p_M_Hotel_CheckDuplicated_Posibility,
        p_M_Hotel_CitySameName_GetAll,
        p_M_Hotel_GetDuplicated_Root,
        p_M_Hotel_ConvertColumns
    }

    public class P_Hotel_CommonData
    {
        public List<M_HotelPlatform> ListHotelPlatform { get; set; }
        public List<M_Country> ListCountry { get; set; }
        public List<string> ListCurrency { get; set; }
        public List<P_Company_OfflineReservation> ListCompany { get; set; }
        public List<M_ServiceCode> ListServiceCode { get; set; }
        public List<string> ListBlackListEmail { get; set; }

        public P_Hotel_CommonData()
        {
            ListCountry = new List<M_Country>();
            ListCurrency = new List<string>();
            ListCompany = new List<P_Company_OfflineReservation>();
            ListServiceCode = new List<M_ServiceCode>();
            ListBlackListEmail = new List<string>();
        }
    }

    public class P_Hotel_CommonReservation
    {
        public string Salutation { get; set; }
        public string TIMResNo { get; set; }
        public P_Hotel_CommonReservation()
        {
            TIMResNo = "T2P000001";
            Salutation = "Mr";
        }
    }

    public class P_Hotel_CommonCompany : M_Company
    {
        public string HotelCurrency { get; set; }
        public string CountryName { get; set; }
        public string LogoURL { get; set; }
        public string LogoPlatform { get; set; }
        public List<M_ServiceCode> ListAllowedServiceCode { get; set; }
        public List<string> ListDBI_Default { get; set; }
        public List<M_Company> ListChildCompany { get; set; }
        public M_CompanyDBI CustomerDBIName { get; set; }
        public List<string> ListDBI_PK { get; set; }
        public List<string> ListDBI_DS { get; set; }
        public List<string> ListDBI_KS { get; set; }
        public List<string> ListDBI_AE { get; set; }
        public List<string> ListDBI_PR { get; set; }
        public List<string> ListDBI_AU { get; set; }
        public List<string> ListDBI_RZ { get; set; }
        public List<string> ListDBI_IK { get; set; }

        public P_Hotel_CommonCompany()
        {
            LogoURL = string.Empty;
            LogoPlatform = string.Empty;
            HotelCurrency = string.Empty;
            CountryName = string.Empty;
            CustomerDBIName = new M_CompanyDBI();
            ListAllowedServiceCode = new List<M_ServiceCode>();
            ListDBI_Default = new List<string>();
            ListChildCompany = new List<M_Company>();
        }
    }

    public class P_Hotel_SearchInformation
    {
        private int _caseSearch;

        public int CaseSearch
        {
            get { return _caseSearch; }
            set { _caseSearch = value; }
        }

        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
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

        private string _cityName;

        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        private string _countryCode;

        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }

        private long _m_CountryID;

        public long M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }

        private string _countryName;

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private string _fax;

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }

    public class P_HotelDuplicated_Detail : M_Hotel
    {
        private string _hotelPlatform;

        public string HotelPlatform
        {
            get { return _hotelPlatform; }
            set { _hotelPlatform = value; }
        }

        private string _countryName;

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }

        private List<P_HotelNumber> _listHotelNumber;

        public List<P_HotelNumber> ListHotelNumber
        {
            get { return _listHotelNumber; }
            set { _listHotelNumber = value; }
        }

        private string _hotelNumber;

        public string HotelNumber
        {
            get { return _hotelNumber; }
            set { _hotelNumber = value; }
        }

        private string _pciAccountName;

        public string PCIAccountName
        {
            get { return _pciAccountName; }
            set { _pciAccountName = value; }
        }

        private string _pciStatus;
        public string PCIStatus
        {
            get { return _pciStatus; }
            set { _pciStatus = value; }
        }

        public P_HotelDuplicated_Detail()
        {
            ListHotelNumber = new List<P_HotelNumber>();
        }
    }

    public class P_HotelDuplicated : M_Hotel
    {
        private string _hotelPlatform;

        public string HotelPlatform
        {
            get { return _hotelPlatform; }
            set { _hotelPlatform = value; }
        }

        private bool _isShowDetail;

        public bool IsShowDetail
        {
            get { return _isShowDetail; }
            set { _isShowDetail = value; }
        }

        private long _total;

        public long Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public List<M_Hotel> ListDuplicatedHotel { get; set; }

        public List<P_HotelNumber> ListHotelNumber;

        private string _hotelNumber;

        public string HotelNumber
        {
            get { return _hotelNumber; }
            set { _hotelNumber = value; }
        }

        public P_HotelDuplicated()
        {
            ListDuplicatedHotel = new List<M_Hotel>();
            ListHotelNumber = new List<P_HotelNumber>();
        }
    }

    public class P_HotelDuplicated_SaveData
    {
        public List<N_PhoneCall> listOld_N_PhoneCall { get; set; }
        public List<B_Access> listOld_B_Access { get; set; }
        public List<B_Suggestion> listOld_B_Suggestion { get; set; }
        public List<I_Suggestion> listOld_I_Suggestion { get; set; }
        public List<M_HotelContact> listOld_M_HotelContact { get; set; }
        public List<M_HotelContact> listM_HotelContact { get; set; }
        public List<M_HotelContact> listM_HotelContact_Delete { get; set; }

        public List<M_Hotel> listM_Hotel_Update { get; set; }
        public List<M_HotelProcess> listM_HotelProcess { get; set; }
        public List<M_HotelProcess> listM_HotelProcess_Delete { get; set; }
        public List<M_DuplicatedHotel> listM_DuplicatedHotel { get; set; }
        public List<H_M_Hotel> listH_M_Hotel { get; set; }

        public P_HotelDuplicated_SaveData()
        {
            listOld_N_PhoneCall = new List<N_PhoneCall>();
            listOld_B_Access = new List<B_Access>();
            listOld_B_Suggestion = new List<B_Suggestion>();
            listOld_I_Suggestion = new List<I_Suggestion>();
            listOld_M_HotelContact = new List<M_HotelContact>();
            listM_HotelContact = new List<M_HotelContact>();
            listM_HotelContact_Delete = new List<M_HotelContact>();

            listM_Hotel_Update = new List<M_Hotel>();
            listM_HotelProcess = new List<M_HotelProcess>();
            listM_HotelProcess_Delete = new List<M_HotelProcess>();
            listM_DuplicatedHotel = new List<M_DuplicatedHotel>();

            listH_M_Hotel = new List<H_M_Hotel>();
        }
    }

    public class P_HotelDuplicated_ResultData
    {
        public List<M_Hotel> ListOriginal { get; set; }
        public List<M_Hotel> ListDuplicated { get; set; }

        public P_HotelDuplicated_ResultData()
        {
            ListOriginal = new List<M_Hotel>();
            ListDuplicated = new List<M_Hotel>();
        }
    }

    public class P_HotelDuplicated_ListCommon
    {
        public List<M_Country> ListCountry { get; set; }

        public P_HotelDuplicated_ListCommon()
        {
            ListCountry = new List<M_Country>();
        }
    }

    public class P_HotelNotDuplicate_Request
    {
        public bool IsHotelName { get; set; }
        public bool IsHotelNo { get; set; }
        public bool IsHotelAddress { get; set; }
        public bool IsZipCode { get; set; }
        public bool IsCity { get; set; }
        public bool IsCountry { get; set; }
        public bool IsPhone { get; set; }
        public bool IsFax { get; set; }
        public bool IsEmail { get; set; }
        public List<long> ListHotel { get; set; }
        public P_HotelNotDuplicate_Request()
        {
            ListHotel = new List<long>();
        }
    }

    public class P_HotelDuplicated_Request : V_Pagination
    {
        public bool IsHotelName { get; set; }
        public bool IsHotelNo { get; set; }
        public bool IsHotelAddress { get; set; }
        public bool IsZipCode { get; set; }
        public bool IsCity { get; set; }
        public bool IsCountry { get; set; }
        public bool IsPhone { get; set; }
        public bool IsFax { get; set; }
        public bool IsEmail { get; set; }
        public long ID { get; set; }
        public string HotelName { get; set; }
        public string HotelNo { get; set; }
        public string HoteAddress { get; set; }
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string CountryCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public int CurrentTab { get; set; }
        public P_HotelDuplicated_Request()
        {
            ID = 0;
            HotelName = string.Empty;
            HotelNo = string.Empty;
            HoteAddress = string.Empty;
            ZipCode = string.Empty;
            CityName = string.Empty;
            CountryCode = string.Empty;
            Phone = string.Empty;
            Fax = string.Empty;
            Email = string.Empty;
            CurrentTab = 1; //1: New Hotel, 2: Duplicated Hotel
        }
    }

    public class P_HotelGateway_Registration
    {
        public List<P_HotelRegistration> ListHotelRegistation { get; set; }

        public long TotalRecords { get; set; }

        public P_HotelGateway_Registration()
        {
            ListHotelRegistation = new List<P_HotelRegistration>();
            TotalRecords = 0;
        }
    }

    public class P_HotelRegistration : M_Hotel
    {
        private long _userID;

        public long UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _registedEmail;

        public string RegistedEmail
        {
            get { return _registedEmail; }
            set { _registedEmail = value; }
        }

        private DateTime _registrationDate;

        public DateTime RegistrationDate
        {
            get { return _registrationDate; }
            set { _registrationDate = value; }
        }

        private string _hotelAddress;

        public string HotelAddress
        {
            get { return _hotelAddress; }
            set { _hotelAddress = value; }
        }
    }

    public class HotelPCIValues
    {
        public string AccountName { get; set; }
        public bool IsAllowed { get; set; }
        public string AccountStatus { get; set; }
        public DateTime? ExpriredRegistrationDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string RegistrationEmail { get; set; }
        public DateTime? LastRegistrationDate { get; set; }
    }
}