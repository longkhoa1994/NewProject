using System;
using System.Collections.Generic;
using T2P._2015.Cross.Enum;
using T2P._2015.Cross.Model.Report;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model.Process
{
    [Serializable]
    public class P_ServiceDesk
    {
        private long _totalRecords;

        public long TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }

        private List<A_UserProfile> _listUser;

        public List<A_UserProfile> ListUser
        {
            get { return _listUser; }
            set { _listUser = value; }
        }

        private List<P_ServiceDesk_Hotel> _listServiceDesk;

        public List<P_ServiceDesk_Hotel> ListServiceDesk
        {
            get { return _listServiceDesk; }
            set { _listServiceDesk = value; }
        }

        private List<P_ServiceDesk_HotelPlatformSetting> _listSetting;

        public List<P_ServiceDesk_HotelPlatformSetting> ListSetting
        {
            get { return _listSetting; }
            set { _listSetting = value; }
        }

        private List<A_UserTemplate> _listTemplate;

        public List<A_UserTemplate> ListTemplate
        {
            get { return _listTemplate; }
            set { _listTemplate = value; }
        }

        public P_ServiceDesk()
        {
            ListServiceDesk = new List<P_ServiceDesk_Hotel>();
        }
    }

    public class P_ServiceDesk_HotelPlatformSetting
    {
        private long _m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }

        private long _m_HotelPlatformSettingID;

        public long M_HotelPlatformSettingID
        {
            get { return _m_HotelPlatformSettingID; }
            set { _m_HotelPlatformSettingID = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
    [Serializable]
    public class P_ServiceDesk_Hotel
    {
        private long _hotelID;

        public long HotelID
        {
            get { return _hotelID; }
            set { _hotelID = value; }
        }

        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }

        private string _hotelEmail;

        public string HotelEmail
        {
            get { return _hotelEmail; }
            set { _hotelEmail = value; }
        }

        private string _hotelPhone;

        public string HotelPhone
        {
            get { return _hotelPhone; }
            set { _hotelPhone = value; }
        }

        private string _contactHTML;

        public string ContactHTML
        {
            get { return _contactHTML; }
            set { _contactHTML = value; }
        }

        private List<M_HotelContact> _listHotelContact;

        public List<M_HotelContact> ListHotelContact
        {
            get { return _listHotelContact; }
            set { _listHotelContact = value; }
        }

        private List<P_ServiceDesk_BookingList> _listService;

        public List<P_ServiceDesk_BookingList> ListService
        {
            get { return _listService; }
            set { _listService = value; }
        }
    }

    public class P_ServiceDesk_BookingList
    {
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private long _hotelID;

        public long HotelID
        {
            get { return _hotelID; }
            set { _hotelID = value; }
        }

        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }

        private string _hotelCountryCode;

        public string HotelCountryCode
        {
            get { return _hotelCountryCode; }
            set { _hotelCountryCode = value; }
        }

        private string _hotelEmail;

        public string HotelEmail
        {
            get { return _hotelEmail; }
            set { _hotelEmail = value; }
        }

        private string _hotelPhone;

        public string HotelPhone
        {
            get { return _hotelPhone; }
            set { _hotelPhone = value; }
        }

        private long _companyID;

        public long CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _companyCountryCode;

        public string CompanyCountryCode
        {
            get { return _companyCountryCode; }
            set { _companyCountryCode = value; }
        }

        private long _bookingID;

        public long BookingID
        {
            get { return _bookingID; }
            set { _bookingID = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string _traveler;

        public string Traveler
        {
            get { return _traveler; }
            set { _traveler = value; }
        }

        private DateTime _checkOut;

        public DateTime CheckOut
        {
            get { return _checkOut; }
            set { _checkOut = value; }
        }

        private string _createdBy;

        public string CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        private DateTime _actionDate;

        public DateTime ActionDate
        {
            get { return _actionDate; }
            set { _actionDate = value; }
        }

        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private string _assignTo;

        public string AssignTo
        {
            get { return _assignTo; }
            set { _assignTo = value; }
        }

        private long _m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }

        private long _imageID;

        public long ImageID
        {
            get { return _imageID; }
            set { _imageID = value; }
        }

        private long _finID;

        public long FinID
        {
            get { return _finID; }
            set { _finID = value; }
        }

        private long _taskID;

        public long TaskID
        {
            get { return _taskID; }
            set { _taskID = value; }
        }
    }

    public enum P_ServiceDeskProcedure
    {
        //service desk 2
        p_P_ServiceDesk_Get_Open,
        p_P_ServiceDesk_Get_Incomming,
        p_P_ServiceDesk_Get_Done,

        p_P_ServiceDesk_Get_Open_Total,
        p_P_ServiceDesk_Get_Incomming_Total,
        p_P_ServiceDesk_Get_Done_Total,

        p_P_ServiceDesk_Get_Open_Detail,
        p_P_ServiceDesk_Get_Incomming_Detail,
        p_P_ServiceDesk_Get_Done_Detail,

        p_P_ServiceDesk_Get_Open_Ungroup,
        p_P_ServiceDesk_Get_Incomming_Ungroup,
        p_P_ServiceDesk_Get_Done_Ungroup,

        p_P_ServiceDesk_Get_Open_Ungroup_Total,
        p_P_ServiceDesk_Get_Incomming_Ungroup_Total,
        p_P_ServiceDesk_Get_Done_Ungroup_Total,

        //Service Desk - New Version
        p_P_ServiceDesk_Get_Open2,
        p_P_ServiceDesk_Get_Incomming2,
        p_P_ServiceDesk_Get_Done2,

        p_P_ServiceDesk_Get_Open_Total2,
        p_P_ServiceDesk_Get_Incomming_Total2,
        p_P_ServiceDesk_Get_Done_Total2,

        p_P_ServiceDesk_Get_Open_Detail2,
        p_P_ServiceDesk_Get_Incomming_Detail2,
        p_P_ServiceDesk_Get_Done_Detail2,

        p_P_ServiceDesk_Get_Open_Ungroup2,
        p_P_ServiceDesk_Get_Incomming_Ungroup2,
        p_P_ServiceDesk_Get_Done_Ungroup2,

        p_P_ServiceDesk_Get_Open_Ungroup_Total2,
        p_P_ServiceDesk_Get_Incomming_Ungroup_Total2,
        p_P_ServiceDesk_Get_Done_Ungroup_Total2,

        //Service Desk - Test New Version
        p_P_ServiceDesk_Get_Open3,
        p_P_ServiceDesk_Get_Incomming3,
        p_P_ServiceDesk_Get_Done3,

        p_P_ServiceDesk_Get_Open_Total3,
        p_P_ServiceDesk_Get_Incomming_Total3,
        p_P_ServiceDesk_Get_Done_Total3,

        p_P_ServiceDesk_Get_Open_Detail3,
        p_P_ServiceDesk_Get_Incomming_Detail3,
        p_P_ServiceDesk_Get_Done_Detail3,

        p_P_ServiceDesk_Get_Open_Ungroup3,
        p_P_ServiceDesk_Get_Incomming_Ungroup3,
        p_P_ServiceDesk_Get_Done_Ungroup3,

        p_P_ServiceDesk_Get_Open_Ungroup_Total3,
        p_P_ServiceDesk_Get_Incomming_Ungroup_Total3,
        p_P_ServiceDesk_Get_Done_Ungroup_Total3,

        sp_B_Booking_GetByHotelID,
    }

    public class P_ServiceDesk_Request : V_Pagination
    {
        private int _topNumber;

        public int TopNumber
        {
            get { return _topNumber; }
            set { _topNumber = value; }
        }

        private string _action;

        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }

        private string _hotelNo;

        public string HotelNo
        {
            get { return _hotelNo; }
            set { _hotelNo = value; }
        }


        private bool _isGroup;

        public bool IsGroup
        {
            get { return _isGroup; }
            set { _isGroup = value; }
        }

        private string _resNo;

        public string ResNo
        {
            get { return _resNo; }
            set { _resNo = value; }
        }

        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
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

        private string _countryName;

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }

        private long _countryID;

        public long CountryID
        {
            get { return _countryID; }
            set { _countryID = value; }
        }

        private long _assignTo;

        public long AssignTo
        {
            get { return _assignTo; }
            set { _assignTo = value; }
        }

        private DateTime? _checkoutFrom;

        public DateTime? CheckoutFrom
        {
            get { return _checkoutFrom; }
            set { _checkoutFrom = value; }
        }

        private DateTime? _checkoutTo;

        public DateTime? CheckoutTo
        {
            get { return _checkoutTo; }
            set { _checkoutTo = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private List<long> _listCompany;

        public List<long> ListCompany
        {
            get { return _listCompany; }
            set { _listCompany = value; }
        }

        private string orderByDetail;

        public string OrderByDetail
        {
            get { return orderByDetail; }
            set { orderByDetail = value; }
        }

        private string orderDirectionDetail;

        public string OrderDirectionDetail
        {
            get { return orderDirectionDetail; }
            set { orderDirectionDetail = value; }
        }

        private bool _contract;

        public bool Contract
        {
            get { return _contract; }
            set { _contract = value; }
        }

        private bool _nonContract;

        public bool NonContract
        {
            get { return _nonContract; }
            set { _nonContract = value; }
        }

        private List<string> _listAPHotel;

        public List<string> ListAPHotel
        {
            get { return _listAPHotel; }
            set { _listAPHotel = value; }
        }

        private List<string> _listPriority;

        public List<string> ListPriority
        {
            get { return _listPriority; }
            set { _listPriority = value; }
        }

        public P_ServiceDesk_Request()
        {
            ListCompany = new List<long>();
            ListAPHotel = new List<string>();
            ListPriority = new List<string>();
        }
    }

    public class P_ServiceDesk_Task
    {
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _page;

        public string Page
        {
            get { return _page; }
            set { _page = value; }
        }

        private bool _invoiceExpected;

        public bool InvoiceExpected
        {
            get { return _invoiceExpected; }
            set { _invoiceExpected = value; }
        }

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private long _relatedID;

        public long RelatedID
        {
            get { return _relatedID; }
            set { _relatedID = value; }
        }

        private bool _hasCall;

        public bool HasCall
        {
            get { return _hasCall; }
            set { _hasCall = value; }
        }

        private bool _isFollowUp;

        public bool IsFollowUp
        {
            get { return _isFollowUp; }
            set { _isFollowUp = value; }
        }

        private long _phoneID;

        public long PhoneID
        {
            get { return _phoneID; }
            set { _phoneID = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private string _caller;

        public string Caller
        {
            get { return _caller; }
            set { _caller = value; }
        }

        private string _recipient;

        public string Recipient
        {
            get { return _recipient; }
            set { _recipient = value; }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private int _duration;

        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private long _taskID;

        public long TaskID
        {
            get { return _taskID; }
            set { _taskID = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _contactTo;

        public string ContactTo
        {
            get { return _contactTo; }
            set { _contactTo = value; }
        }

        private string _contactNumber;

        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }

        private long _assignedTo;

        public long AssignedTo
        {
            get { return _assignedTo; }
            set { _assignedTo = value; }
        }

        private string _assignedUser;

        public string AssignedUser
        {
            get { return _assignedUser; }
            set { _assignedUser = value; }
        }

        private DateTime? _date;

        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _priority;

        public string Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        private string _isDone;

        public string IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }

        private DateTime _createDate;

        public DateTime CreateDate
        {
            get { return _createDate; }
            set { _createDate = value; }
        }

        private string _creator;

        public string Creator
        {
            get { return _creator; }
            set { _creator = value; }
        }

        private int _taskStatus;

        public int TaskStatus
        {
            get { return _taskStatus; }
            set { _taskStatus = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private long _stepID;

        public long StepID
        {
            get { return _stepID; }
            set { _stepID = value; }
        }

        private long _n_PhoneCallID;

        public long N_PhoneCallID
        {
            get { return _n_PhoneCallID; }
            set { _n_PhoneCallID = value; }
        }

        private long _m_HotelID;

        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }

        
    }

    public class P_ServiceDesk_AssignTask
    {
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _assignTo;

        public long AssignTo
        {
            get { return _assignTo; }
            set { _assignTo = value; }
        }
    }

    public class P_ServiceDesk_Task_Delete
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _taskID;

        public long TaskID
        {
            get { return _taskID; }
            set { _taskID = value; }
        }
    }

    public class P_ServiceDesk2
    {
        private string _fileLocal;

        public string FileLocal
        {
            get { return _fileLocal; }
            set { _fileLocal = value; }
        }

        private long _totalRecords;

        public long TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }

        private List<A_UserProfile> _listUser;

        public List<A_UserProfile> ListUser
        {
            get { return _listUser; }
            set { _listUser = value; }
        }

        private List<P_ServiceDesk2_Hotel> _listHotel;

        public List<P_ServiceDesk2_Hotel> ListHotel
        {
            get { return _listHotel; }
            set { _listHotel = value; }
        }

        private List<P_ServiceDesk2_Ungroup> listUngroup;

        public List<P_ServiceDesk2_Ungroup> ListUngroup
        {
            get { return listUngroup; }
            set { listUngroup = value; }
        }

        public P_ServiceDesk2()
        {
            ListHotel = new List<P_ServiceDesk2_Hotel>();
            ListBookingCall = new List<N_BookingPhoneCall>();
            ListCall = new List<CallLog>();
        }

        private List<CallLog> listCall;

        public List<CallLog> ListCall
        {
            get { return listCall; }
            set { listCall = value; }
        }

         private List<N_BookingPhoneCall> _listBookingCall;

        public List<N_BookingPhoneCall> ListBookingCall
        {
            get { return _listBookingCall; }
            set { _listBookingCall = value; }
        }
       
    }

    public class P_ServiceDesk2_Hotel
    {
        private int _permission;

        public int Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }

        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string hotelNo;

        public string HotelNo
        {
            get { return hotelNo; }
            set { hotelNo = value; }
        }

        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private string hoteAddress;

        public string HoteAddress
        {
            get { return hoteAddress; }
            set { hoteAddress = value; }
        }

        private string zipCode;

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        private string cityName;

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        private long m_CountryID;

        public long M_CountryID
        {
            get { return m_CountryID; }
            set { m_CountryID = value; }
        }

        private string countryCode;

        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string fax;

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private long issues;

        public long Issues
        {
            get { return issues; }
            set { issues = value; }
        }

        private long highIssues;

        public long HighIssues
        {
            get { return highIssues; }
            set { highIssues = value; }
        }

        private long overdueIssues;

        public long OverdueIssues
        {
            get { return overdueIssues; }
            set { overdueIssues = value; }
        }

        private long totalHighIssues;

        public long TotalHighIssues
        {
            get { return totalHighIssues; }
            set { totalHighIssues = value; }
        }

        private List<M_HotelContact> _listHotelContact;

        public List<M_HotelContact> ListHotelContact
        {
            get { return _listHotelContact; }
            set { _listHotelContact = value; }
        }

        private string countryCodeNumber;

        public string CountryCodeNumber
        {
            get { return countryCodeNumber; }
            set { countryCodeNumber = value; }
        }


    }

    public class P_ServiceDesk2_Booking
    {
        private string _hotelPlatformName;

        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }

        private int _permission;

        public int Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }

        private bool _invoiceExpected;

        public bool InvoiceExpected
        {
            get { return _invoiceExpected; }
            set { _invoiceExpected = value; }
        }


        private string _doneBy;

        public string DoneBy
        {
            get { return _doneBy; }
            set { _doneBy = value; }
        }

        private string _contactTo;

        public string ContactTo
        {
            get { return _contactTo; }
            set { _contactTo = value; }
        }

        private string _assignedUser;

        public string AssignedUser
        {
            get { return _assignedUser; }
            set { _assignedUser = value; }
        }

        private string _contactNumber;

        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }

        private IssueType issueType;

        public IssueType IssueType
        {
            get { return issueType; }
            set { issueType = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private long b_AccessID;

        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private string priority;

        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        private int overdue;

        public int Overdue
        {
            get { return overdue; }
            set { overdue = value; }
        }

        private long m_CompanyID;

        public long M_CompanyID
        {
            get { return m_CompanyID; }
            set { m_CompanyID = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private DateTime checkIn;

        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        private DateTime checkOut;

        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        private long stepID;

        public long StepID
        {
            get { return stepID; }
            set { stepID = value; }
        }

        private long relatedID;

        public long RelatedID
        {
            get { return relatedID; }
            set { relatedID = value; }
        }

        private string information;

        public string Information
        {
            get { return information; }
            set { information = value; }
        }

        private string additionInformation;

        public string AdditionInformation
        {
            get { return additionInformation; }
            set { additionInformation = value; }
        }

        private DateTime? informationDate;

        public DateTime? InformationDate
        {
            get { return informationDate; }
            set { informationDate = value; }
        }

        private DateTime? actionDate;

        public DateTime? ActionDate
        {
            get { return actionDate; }
            set { actionDate = value; }
        }

        private string createdBy;

        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private long assignedTo;

        public long AssignedTo
        {
            get { return assignedTo; }
            set { assignedTo = value; }

        }

        private string _travelerName;

        public string TravelerName
        {
            get { return _travelerName; }
            set { _travelerName = value; }
        }
    }

    public class P_ServiceDesk2_Task
    {
        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private long relatedID;

        public long RelatedID
        {
            get { return relatedID; }
            set { relatedID = value; }
        }

        private string _contactTo;

        public string ContactTo
        {
            get { return _contactTo; }
            set { _contactTo = value; }
        }

        private string _contactNumber;

        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }

        private long _assignedTo;

        public long AssignedTo
        {
            get { return _assignedTo; }
            set { _assignedTo = value; }
        }

        private string _assignedUser;

        public string AssignedUser
        {
            get { return _assignedUser; }
            set { _assignedUser = value; }
        }

        private DateTime? _date;

        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _priority;

        public string Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        private bool _invoiceExpected;

        public bool InvoiceExpected
        {
            get { return _invoiceExpected; }
            set { _invoiceExpected = value; }
        }

        private bool hasCall;

        public bool HasCall
        {
            get { return hasCall; }
            set { hasCall = value; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }


        private string _recipient;

        public string Recipient
        {
            get { return _recipient; }
            set { _recipient = value; }
        }

        private string phoneNumber;

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        private long _stepID;

        public long StepID
        {
            get { return _stepID; }
            set { _stepID = value; }
        }

        private List<P_ServiceDesk2_Task> _listTask;

        public List<P_ServiceDesk2_Task> ListTask
        {
            get { return _listTask; }
            set { _listTask = value; }
        }

        private long? m_HotelID;

        public long? M_HotelID
        {
            get { return m_HotelID; }
            set { m_HotelID = value; }
        }
    }

    public class P_ServiceDesk2_Call
    {

        private List<long> _b_AccessID;

        public List<long> B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private string _caller;

        public string Caller
        {
            get { return _caller; }
            set { _caller = value; }
        }

        private string _recipient;

        public string Recipient
        {
            get { return _recipient; }
            set { _recipient = value; }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private int _duration;

        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
    }

    public class P_ServiceDesk2_Ungroup
    {
        private string _hotelPlatformName;

        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }

        private int _permission;

        public int Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }

        private string _doneBy;

        public string DoneBy
        {
            get { return _doneBy; }
            set { _doneBy = value; }
        }


        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string hotelNo;

        public string HotelNo
        {
            get { return hotelNo; }
            set { hotelNo = value; }
        }

        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private string hoteAddress;

        public string HoteAddress
        {
            get { return hoteAddress; }
            set { hoteAddress = value; }
        }

        private string zipCode;

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        private string cityName;

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }

        private long m_CountryID;

        public long M_CountryID
        {
            get { return m_CountryID; }
            set { m_CountryID = value; }
        }

        private string countryCode;

        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string fax;

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private List<M_HotelContact> _listHotelContact;

        public List<M_HotelContact> ListHotelContact
        {
            get { return _listHotelContact; }
            set { _listHotelContact = value; }
        }

        private IssueType issueType;

        public IssueType IssueType
        {
            get { return issueType; }
            set { issueType = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        private long b_AccessID;

        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private string priority;

        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        private int overdue;

        public int Overdue
        {
            get { return overdue; }
            set { overdue = value; }
        }

        private long m_CompanyID;

        public long M_CompanyID
        {
            get { return m_CompanyID; }
            set { m_CompanyID = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private DateTime checkIn;

        public DateTime CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }

        private DateTime checkOut;

        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }

        private long stepID;

        public long StepID
        {
            get { return stepID; }
            set { stepID = value; }
        }

        private long relatedID;

        public long RelatedID
        {
            get { return relatedID; }
            set { relatedID = value; }
        }

        private string information;

        public string Information
        {
            get { return information; }
            set { information = value; }
        }

        private string additionInformation;

        public string AdditionInformation
        {
            get { return additionInformation; }
            set { additionInformation = value; }
        }

        private DateTime? informationDate;

        public DateTime? InformationDate
        {
            get { return informationDate; }
            set { informationDate = value; }
        }

        private DateTime? actionDate;

        public DateTime? ActionDate
        {
            get { return actionDate; }
            set { actionDate = value; }
        }

        private string createdBy;

        public string CreatedBy
        {
            get { return createdBy; }
            set { createdBy = value; }
        }

        private string assignedTo;

        public string AssignedTo
        {
            get { return assignedTo; }
            set { assignedTo = value; }

        }

        private string _travelerName;

        public string TravelerName
        {
            get { return _travelerName; }
            set { _travelerName = value; }
        }

        private string countryCodeNumber;

        public string CountryCodeNumber
        {
            get { return countryCodeNumber; }
            set { countryCodeNumber = value; }
        }



    }
}