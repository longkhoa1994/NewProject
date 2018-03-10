using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model.Process
{


    #region New
    public class P_Account_Setup
    {
        public long A_UserProfileID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public OrganizationType OrganizationType { get; set; }
        public long OrganizationID { get; set; }
        public long ChildID { get; set; }
        public long BookerID { get; set; }
        public long M_TravellerID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool? Gender { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public long A_RoleID { get; set; }
        public List<P_Account_PlatformCompany> ListPlatformCompany { get; set; }
        public long M_LanguageID { get; set; }
        public int Layout { get; set; }
        public long? M_HotelPlatformID { get; set; }
        public string DateFormat { get; set; }
        public string TimeFormat { get; set; }
        public string Signature { get; set; }
        public string SignatureDecode
        {
            get
            {
                return WebUtility.HtmlDecode(Signature);
            }
        }
        public P_Account_Setup()
        {
            A_UserProfileID = 0;
            UserName = string.Empty;
            Password = string.Empty;
            OrganizationID = 0;
            ChildID = 0;
            BookerID = 0;
            M_TravellerID = 0;
            Firstname = string.Empty;
            Lastname = string.Empty;
            Gender = null;
            Email = string.Empty;
            PhoneNumber = string.Empty;
            Description = string.Empty;
            A_RoleID = 0;
            ListPlatformCompany = new List<P_Account_PlatformCompany>();
            M_LanguageID = 3;
            Layout = 2;
            M_HotelPlatformID = null;
            DateFormat = "dd.MM.yyyy";
            TimeFormat = "HH:mm";
            Signature = string.Empty;
        }
    }

    public class P_Account_PlatformCompany
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public List<P_Account_Company> ListCompany { get; set; }
        public P_Account_PlatformCompany()
        {
            ListCompany = new List<P_Account_Company>();
        }
    }

    public class P_Account_Company
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public long M_ProcessID { get; set; }
        public string CountryCode { get; set; }
        public bool IsView { get; set; }
        public bool IsEdit { get; set; }
        public bool IsDisable { get; set; }
        public List<P_Account_Company> ListChild { get; set; }
        public P_Account_Company()
        {
            IsDisable = false;
            ListChild = new List<P_Account_Company>();
        }
    }

    public class P_Account_Search
    {
        public long ID { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string RoleName { get; set; }
        public string PartnerName { get; set; }
        public bool IsBlocked { get; set; }
    }

    public enum P_Account_SetupProcedure
    {
        p_P_Account_Setup_Get
    }


    public enum OrganizationType
    {
        Organization = 1,
        HotelPlatform = 2,
        Company = 3
    }

    #endregion

    #region Old

    public class P_AccountRequest : V_Pagination
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private long _companyID;

        public long CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        private long _roleID;

        public long RoleID
        {
            get { return _roleID; }
            set { _roleID = value; }
        }

        private long _hotelPlatformID;

        public long HotelPlatformID
        {
            get { return _hotelPlatformID; }
            set { _hotelPlatformID = value; }
        }

        //public string OrderBy { get; set; }
        //public string OrderDirection { get; set; }
        //public int Page { get; set; }
        //public int PageSize { get; set; }
    }
    public class ListCompanyID
    {
        public long ID { get; set; }
    }
    public class P_AccountList
    {
        public List<A_Role> ListRole { get; set; }
        public List<P_Account> ListAccount { get; set; }
    }
    public class P_Account
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _roleName;

        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        private string _partnerName;

        public string PartnerName
        {
            get { return _partnerName; }
            set { _partnerName = value; }
        }

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        private bool _isBlocked;
        public bool IsBlocked
        {
            get { return _isBlocked; }
            set { _isBlocked = value; }
        }

        private long _totalRecord;
        public long TotalRecord
        {
            get { return _totalRecord; }
            set { _totalRecord = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }

    public class P_AccountDetail
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _userRoleID;

        public long UserRoleID
        {
            get { return _userRoleID; }
            set { _userRoleID = value; }
        }

        private long _userSettingID;

        public long UserSettingID
        {
            get { return _userSettingID; }
            set { _userSettingID = value; }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _confirmPassword;

        public string ConfirmPassword
        {
            get { return _confirmPassword; }
            set { _confirmPassword = value; }
        }

        private long _roleID;

        public long RoleID
        {
            get { return _roleID; }
            set { _roleID = value; }
        }
        private string _roleName;

        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }
        private long? _companyID;

        public long? CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        private int _recursive;

        public int Recursive
        {
            get { return _recursive; }
            set { _recursive = value; }
        }

        private long? _bookerID;

        public long? BookerID
        {
            get { return _bookerID; }
            set { _bookerID = value; }
        }

        private long? _hotelID;

        public long? HotelID
        {
            get { return _hotelID; }
            set { _hotelID = value; }
        }

        private long? _travelerID;

        public long? TravelerID
        {
            get { return _travelerID; }
            set { _travelerID = value; }
        }

        private long _serviceCenterID;

        public long ServiceCenterID
        {
            get { return _serviceCenterID; }
            set { _serviceCenterID = value; }
        }

        private string _salutation;

        public string Salutation
        {
            get { return _salutation; }
            set { _salutation = value; }
        }

        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        private string _phone;

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private long _languageID;

        public long LanguageID
        {
            get { return _languageID; }
            set { _languageID = value; }
        }

        private string _dateFormat;

        public string DateFormat
        {
            get { return _dateFormat; }
            set { _dateFormat = value; }
        }

        private string _timeFormat;

        public string TimeFormat
        {
            get { return _timeFormat; }
            set { _timeFormat = value; }
        }

        private string _signature;

        public string Signature
        {
            get { return _signature; }
            set { _signature = value; }
        }
        private string _languageText;

        public string LanguageText
        {
            get { return _languageText; }
            set { _languageText = value; }
        }
        public long? HotelPlatformID { get; set; }
        public string HotelPlatformName { get; set; }
        public string CompanyName { get; set; }
        public string HotelName { get; set; }
        public string TravellerName { get; set; }
        public string BookerName { get; set; }

        public int AccessType { get; set; }
        public int IsChangeAccessType { get; set; }
        public int IsModify { get; set; }

        public int CountCheckChildCompany { get; set; }
        private List<M_Language> _listLanguage;
        public List<M_Language> ListLanguage
        {
            get { return _listLanguage; }
            set { _listLanguage = value; }
        }
        private List<A_Role> _listRole;
        public List<A_Role> ListRole
        {
            get { return _listRole; }
            set { _listRole = value; }
        }
        public List<p_ClassifyUserCompany> ListClassifyUserCompany { get; set; }
    }
    public class p_AccessCompany
    {
        public long M_HotelID { get; set; }
        public long M_CompanyID { get; set; }
    }
    public class p_ListClassifyUserCompany
    {
        public long CompanyID { get; set; }
        public long UserProfileID { get; set; }
    }
    public class p_ClassifyUserCompany
    {
        public long CompanyID { get; set; }
        public long UserProfileId { get; set; }
        public string CompanyName { get; set; }
        public long IsCheckCompany { get; set; }
    }
    public class LockOrUnLock
    {
        public long AccountID { get; set; }
        public int IsBlocked { get; set; }
    }
    public enum AccessType
    {
        Company = 1,
        Hotel = 2,
        Traveller = 3,
        Booker = 4,
        System = 5,
        ServiceCenter = 6,
    }

    public class P_Account_ChangePassword
    {
        private string oldPassword;

        public string OldPassword
        {
            get { return oldPassword; }
            set { oldPassword = value; }
        }

        private string newPassword;

        public string NewPassword
        {
            get { return newPassword; }
            set { newPassword = value; }
        }

        private long _userID;

        public long UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }
    }

    #endregion
}
