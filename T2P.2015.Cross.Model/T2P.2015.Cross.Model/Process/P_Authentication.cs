using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{

    public class P_Authenticate
    {
        private string _customer;

        public string Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

        private bool _isBlocked;

        public bool IsBlocked
        {
            get { return _isBlocked; }
            set { _isBlocked = value; }
        }


        private int _remainDays;

        public int RemainDays
        {
            get { return _remainDays; }
            set { _remainDays = value; }
        }

        private string _loginStatus;

        public string LoginStatus
        {
            get { return _loginStatus; }
            set { _loginStatus = value; }
        }

        private DateTime _passwordChangedDate;

        public DateTime PasswordChangedDate
        {
            get { return _passwordChangedDate; }
            set { _passwordChangedDate = value; }
        }


        private string _roleName;

        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        private long userID;

        public long UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string username;

        private string sessionID;

        public string SessionID
        {
            get { return sessionID; }
            set { sessionID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

  


        private long companyID;

        public long CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        private long bookerID;

        public long BookerID
        {
            get { return bookerID; }
            set { bookerID = value; }
        }

        private long travellerID;

        public long TravellerID
        {
            get { return travellerID; }
            set { travellerID = value; }
        }

        private long hotelID;

        public long HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }

        private long serviceCenterID;

        public long ServiceCenterID
        {
            get { return serviceCenterID; }
            set { serviceCenterID = value; }
        }

        private int isRecursive;

        public int IsRecursive
        {
            get { return isRecursive; }
            set { isRecursive = value; }
        }

        private string dateFormat;

        public string DateFormat
        {
            get { return dateFormat; }
            set { dateFormat = value; }
        }

        private string timeFormat;

        public string TimeFormat
        {
            get { return timeFormat; }
            set { timeFormat = value; }
        }

        private long languageID;

        public long LanguageID
        {
            get { return languageID; }
            set { languageID = value; }
        }

        private string _languageCode;

        public string LanguageCode
        {
            get { return _languageCode; }
            set { _languageCode = value; }
        }

        private string _languageCode1;

        public string LanguageCode1
        {
            get { return _languageCode1; }
            set { _languageCode1 = value; }
        }

        private DateTime _loginTime;

        public DateTime LoginTime
        {
          get { return _loginTime; }
          set { _loginTime = value; }
        }


        private string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private string _ip;

        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private bool _userHistory;

        public bool UserHistory
        {
            get { return _userHistory; }
            set { _userHistory = value; }
        }

        private List<P_ObjectFuntion> listObjectFunction;

        public List<P_ObjectFuntion> ListObjectFunction
        {
            get { return listObjectFunction; }
            set { listObjectFunction = value; }
        }

        private List<P_ObjectRelation> listObjectRelation;

        public List<P_ObjectRelation> ListObjectRelation
        {
            get { return listObjectRelation; }
            set { listObjectRelation = value; }
        }

        private List<P_Menu> listMenu;

        public List<P_Menu> ListMenu
        {
            get { return listMenu; }
            set { listMenu = value; }
        }

        private List<M_Language> listLanguage;

        public List<M_Language> ListLanguage
        {
            get { return listLanguage; }
            set { listLanguage = value; }
        }

        private List<A_UserCompanyPlatform> listUserCompany;

        public List<A_UserCompanyPlatform> ListUserCompany
        {
            get { return listUserCompany; }
            set { listUserCompany = value; }
        }

        private List<M_HotelPlatform> listHotelPlatform;

        public List<M_HotelPlatform> ListHotelPlatform
        {
            get { return listHotelPlatform; }
            set { listHotelPlatform = value; }
        }

        private long hotelPlatformID;

        public long HotelPlatformID
        {
            get { return hotelPlatformID; }
            set { hotelPlatformID = value; }
        }

        private string _hotelPlatform;

        public string HotelPlatform
        {
            get { return _hotelPlatform; }
            set { _hotelPlatform = value; }
        }

        private int _layout;

        public int Layout
        {
            get { return _layout; }
            set { _layout = value; }
        }

        public List<A_UserHotel> ListUserHotel { get; set; }

        public P_Authenticate()
        {
            ListObjectFunction = new List<P_ObjectFuntion>();
            ListObjectRelation = new List<P_ObjectRelation>();
            ListMenu = new List<P_Menu>();
            ListLanguage = new List<M_Language>();
            ListHotelPlatform = new List<M_HotelPlatform>();
            ListUserHotel = new List<A_UserHotel>();
            LoginTime = DateTime.Now;
        }
    }

    public class P_ObjectFuntion
    {
        private long _objectID;

        public long ObjectID
        {
            get { return _objectID; }
            set { _objectID = value; }
        }

        private string _objectName;

        public string ObjectName
        {
            get { return _objectName; }
            set { _objectName = value; }
        }

        private string _controllerName;

        public string ControllerName
        {
            get { return _controllerName; }
            set { _controllerName = value; }
        }

        private int _hotelPlatformFilter;

        public int HotelPlatformFilter
        {
            get { return _hotelPlatformFilter; }
            set { _hotelPlatformFilter = value; }
        }

        private string _actionName;

        public string ActionName
        {
            get { return _actionName; }
            set { _actionName = value; }
        }

        private string _functionID;

        public string FunctionID
        {
            get { return _functionID; }
            set { _functionID = value; }
        }

        private string _functionName;

        public string FunctionName
        {
            get { return _functionName; }
            set { _functionName = value; }
        }

        private string _menuID;

        public string MenuID
        {
            get { return _menuID; }
            set { _menuID = value; }
        }

        private int _position;

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        private string _url;

        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }


    }

    public class P_ObjectRelation
    {
        public long ParentObjectID;

        public long ChildObjectID;

        public P_ObjectRelation(long parent, long child)
        {
            ParentObjectID = parent;
            ChildObjectID = child;
        }
    }

    public class LoginInformation
    {
        public string Username;
        public string Password;
        public string SessionID;
        public string IP;
    }

    public class LogoutInformation
    {
        public long UserID;
        public string SessionID;
        public string IP;
    }

    public class RegistrationInformation
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
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

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private bool _gender;

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _roleName;

        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }
    }

}
