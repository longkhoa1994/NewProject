using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Enum;
using T2P._2015.Model;
using VCC;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Caching_Import_Booking_Hotelzon
    {
        public string ResNo { get; set; }
        public string TransactionNumber { get; set; }
        public string BookingStatus { get; set; }
    }

    public class P_Caching_Import_Booking_BCD_HDE
    {
        public string ResNo { get; set; }
        public string BookingStatus { get; set; }
    }

    public class P_BookingSearch
    {
        private long _companyParentID;

        public long CompanyParentID
        {
            get { return _companyParentID; }
            set { _companyParentID = value; }
        }

        private long _companyProcessID;

        public long CompanyProcessID
        {
            get { return _companyProcessID; }
            set { _companyProcessID = value; }
        }

        private string _checkingStatus;

        public string CheckingStatus
        {
            get { return _checkingStatus; }
            set { _checkingStatus = value; }
        }

        private string _parentCompanyName;

        public string ParentCompanyName
        {
            get { return _parentCompanyName; }
            set { _parentCompanyName = value; }
        }

        private string _parentCompanyShortName;

        public string ParentCompanyShortName
        {
            get { return _parentCompanyShortName; }
            set { _parentCompanyShortName = value; }
        }

        private string _statusCostAcceptance;

        public string StatusCostAcceptance
        {
            get { return _statusCostAcceptance; }
            set { _statusCostAcceptance = value; }
        }


        private long totalRecord;

        public long TotalRecord
        {
            get { return totalRecord; }
            set { totalRecord = value; }
        }

        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private long bookingID;

        public long BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }
        private string companyName;

        private string companyList;

        public string CompanyList
        {
            get { return companyList; }
            set { companyList = value; }
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private string companyShortName;

        public string CompanyShortName
        {
            get { return companyShortName; }
            set { companyShortName = value; }
        }

        private string _companyAlias;

        public string CompanyAlias
        {
            get { return _companyAlias; }
            set { _companyAlias = value; }
        }

        private long companyID;

        public long CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        private string customerNo;

        public string CustomerNo
        {
            get { return customerNo; }
            set { customerNo = value; }
        }

        private string subID;

        public string SubID
        {
            get { return subID; }
            set { subID = value; }
        }

        private string hotelNo;

        private string hotelList;

        public string HotelList
        {
            get { return hotelList; }
            set { hotelList = value; }
        }

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
        private string travelerName;

        public string TravelerName
        {
            get { return travelerName; }
            set { travelerName = value; }
        }

        private string travelerID;

        public string TravelerID
        {
            get { return travelerID; }
            set { travelerID = value; }
        }

        private string bC1;

        public string BC1
        {
            get { return bC1; }
            set { bC1 = value; }
        }
        private string bC2;

        public string BC2
        {
            get { return bC2; }
            set { bC2 = value; }
        }
        private string bSP;

        public string BSP
        {
            get { return bSP; }
            set { bSP = value; }
        }
        private string bCA;

        public string BCA
        {
            get { return bCA; }
            set { bCA = value; }
        }
        private string fC1;

        public string FC1
        {
            get { return fC1; }
            set { fC1 = value; }
        }
        private string fC2;

        public string FC2
        {
            get { return fC2; }
            set { fC2 = value; }
        }
        private string iR1;

        public string IR1
        {
            get { return iR1; }
            set { iR1 = value; }
        }
        private string iR2;

        public string IR2
        {
            get { return iR2; }
            set { iR2 = value; }
        }
        private string noOfInvoice;

        public string NoOfInvoice
        {
            get { return noOfInvoice; }
            set { noOfInvoice = value; }
        }
        private string noOfFin;

        public string NoOfFin
        {
            get { return noOfFin; }
            set { noOfFin = value; }
        }

        private string bookingStatus;

        public string BookingStatus
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }

        private string bookerName;

        public string BookerName
        {
            get { return bookerName; }
            set { bookerName = value; }
        }

        private string _paymentMethod;

        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }

        private string _hotelPlatformName;

        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }
        public int _validateFkey;
        public int ValidateFkey
        {
            get { return _validateFkey; }
            set { _validateFkey = value; }
        }
        private int _task;
        public int Task
        {
            get { return _task; }
            set { _task = value; }
        }

        public long EventID { get; set; }

        public string EventNo { get; set; }

        public string EventTitle { get; set; }

        public DateTime? EventStartDate { get; set; }

        public DateTime? EventEndDate { get; set; }
        public int EventStatus { get; set; }
        public string ImageStatus { get; set; }
        public long? ImageID { get; set; }
        private DateTime _processedDate;

        public DateTime ProcessedDate
        {
            get { return _processedDate; }
            set { _processedDate = value; }
        }

        public string OfferNumber { get; set; }
        public string ContractNumber { get; set; }

        public DateTime? ContractDate { get; set; }
        public string Inquirer { get; set; }

        public long IsAp1 { get; set; }
        public long IsAp2 { get; set; }

        public long ApprovalStatus { get; set; }
        public long Approval2Status { get; set; }
        public string ProcessName { get; set; }
        public string IsMeetingHas1stRejection { get; set; }
        public string IsMeetingHas2ndRejection { get; set; }

        public string CompanyParentName { get; set; }
    }

    public class P_BookingSearch_Company
    {
        private string _parentCompanyName;

        public string ParentCompanyName
        {
            get { return _parentCompanyName; }
            set { _parentCompanyName = value; }
        }

        private string _parentCompanyShortName;

        public string ParentCompanyShortName
        {
            get { return _parentCompanyShortName; }
            set { _parentCompanyShortName = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _companyAlias;

        public string CompanyAlias
        {
            get { return _companyAlias; }
            set { _companyAlias = value; }
        }

        private long _companyID;

        public long CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }

        private string _customerNo;

        public string CustomerNo
        {
            get { return _customerNo; }
            set { _customerNo = value; }
        }

        private string _subID;

        public string SubID
        {
            get { return _subID; }
            set { _subID = value; }
        }

        private List<P_BookingSearch> _listBooking;

        public List<P_BookingSearch> ListBooking
        {
            get { return _listBooking; }
            set { _listBooking = value; }
        }

        private long _totalRecords;

        public long TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }
    }

    public class P_Booking_Detail_Extend : B_BookingDetail
    {
        private long _travelerID;

        public long TravelerID
        {
            get { return _travelerID; }
            set { _travelerID = value; }
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
        private string _employeeNo_PK;

        public string EmployeeNo_PK
        {
            get { return _employeeNo_PK; }
            set { _employeeNo_PK = value; }
        }
        private string _costCenter_KS;

        public string CostCenter_KS
        {
            get { return _costCenter_KS; }
            set { _costCenter_KS = value; }
        }
        private string _departmentNo_DS;

        public string DepartmentNo_DS
        {
            get { return _departmentNo_DS; }
            set { _departmentNo_DS = value; }
        }
        private string _accountingUnit_AE;

        public string AccountingUnit_AE
        {
            get { return _accountingUnit_AE; }
            set { _accountingUnit_AE = value; }
        }
        private string _internalAccount_IK;

        public string InternalAccount_IK
        {
            get { return _internalAccount_IK; }
            set { _internalAccount_IK = value; }
        }
        private DateTime ?_processingDate_BD;

        public DateTime ?ProcessingDate_BD
        {
            get { return _processingDate_BD; }
            set { _processingDate_BD = value; }
        }
        private string _projectNo_PR;

        public string ProjectNo_PR
        {
            get { return _projectNo_PR; }
            set { _projectNo_PR = value; }
        }
        private string _orderNo_AU;

        public string OrderNo_AU
        {
            get { return _orderNo_AU; }
            set { _orderNo_AU = value; }
        }
        private string _actionNo_AK;

        public string ActionNo_AK
        {
            get { return _actionNo_AK; }
            set { _actionNo_AK = value; }
        }
        private string _finalDestination_RZ;

        public string FinalDestination_RZ
        {
            get { return _finalDestination_RZ; }
            set { _finalDestination_RZ = value; }
        }
        private string _dBI;

        public string DBI
        {
            get { return _dBI; }
            set { _dBI = value; }
        }
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
        public string Name_CostCenter_KS { get; set; }
        public string Name_EmployeeNo_PK { get; set; }
        public string Name_DepartmentNo_DS { get; set; }
        public string Name_AccountingUnit_AE { get; set; }
        public string Name_InternalAccount_IK { get; set; }
        public string Name_CustomerName_BD { get; set; }
        public string Name_ProjectNo_PR { get; set; }
        public string Name_OrderNo_AU { get; set; }
        public string Name_ActionNo_AK { get; set; }
        public string Name_FinalDestination_RZ { get; set; }

        public P_Booking_Detail_Extend()
        {
            IsAE = false;
            IsAU = false;
            IsBD = false;
            IsDS = false;
            IsIK = false;
            IsKS = false;
            IsPK = false;
            IsPR = false;
            IsRZ = false;
            IsAK = false;

        }


    }

    public class P_Booking_Detail : B_BookingDetail
    {
        private List<P_Booking_Detail_Traveler> _listTraveler;

        public List<P_Booking_Detail_Traveler> ListTraveler
        {
            get { return _listTraveler; }
            set { _listTraveler = value; }
        }
        private string _employeeNo_PK;

        public string EmployeeNo_PK
        {
            get { return _employeeNo_PK; }
            set { _employeeNo_PK = value; }
        }
        private string _costCenter_KS;

        public string CostCenter_KS
        {
            get { return _costCenter_KS; }
            set { _costCenter_KS = value; }
        }
        private string _departmentNo_DS;

        public string DepartmentNo_DS
        {
            get { return _departmentNo_DS; }
            set { _departmentNo_DS = value; }
        }
        private string _accountingUnit_AE;

        public string AccountingUnit_AE
        {
            get { return _accountingUnit_AE; }
            set { _accountingUnit_AE = value; }
        }
        private string _internalAccount_IK;

        public string InternalAccount_IK
        {
            get { return _internalAccount_IK; }
            set { _internalAccount_IK = value; }
        }
        private DateTime ? _processingDate_BD;

        public DateTime ? ProcessingDate_BD
        {
            get { return _processingDate_BD; }
            set { _processingDate_BD = value; }
        }
        private string _projectNo_PR;

        public string ProjectNo_PR
        {
            get { return _projectNo_PR; }
            set { _projectNo_PR = value; }
        }
        private string _orderNo_AU;

        public string OrderNo_AU
        {
            get { return _orderNo_AU; }
            set { _orderNo_AU = value; }
        }
        private string _actionNo_AK;

        public string ActionNo_AK
        {
            get { return _actionNo_AK; }
            set { _actionNo_AK = value; }
        }
        private string _finalDestination_RZ;

        public string FinalDestination_RZ
        {
            get { return _finalDestination_RZ; }
            set { _finalDestination_RZ = value; }
        }
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

        public string Name_CostCenter_KS { get; set; }
        public string Name_EmployeeNo_PK { get; set; }
        public string Name_DepartmentNo_DS { get; set; }
        public string Name_AccountingUnit_AE { get; set; }
        public string Name_InternalAccount_IK { get; set; }
        public string Name_CustomerName_BD { get; set; }
        public string Name_ProjectNo_PR { get; set; }
        public string Name_OrderNo_AU { get; set; }
        public string Name_ActionNo_AK { get; set; }
        public string Name_FinalDestination_RZ { get; set; }
    }

    public class P_Booking_Detail_Traveler
    {
        private long _travelerID;

        public long TravelerID
        {
            get { return _travelerID; }
            set { _travelerID = value; }
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
    }

    public class P_Booking_VCC : B_DBI
    {
        private DateTime _bookingDate;

        public DateTime BookingDate
        {
            get { return _bookingDate; }
            set { _bookingDate = value; }
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

        private long m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return m_HotelPlatformID; }
            set { m_HotelPlatformID = value; }
        }

        private DateTime checkin;

        public DateTime Checkin
        {
            get { return checkin; }
            set { checkin = value; }
        }

        private DateTime checkout;

        public DateTime Checkout
        {
            get { return checkout; }
            set { checkout = value; }
        }

        private string travelerName;

        public string TravelerName
        {
            get { return travelerName; }
            set { travelerName = value; }
        }

        private DateTime? costAcceptanceDate;

        public DateTime? CostAcceptanceDate
        {
            get { return costAcceptanceDate; }
            set { costAcceptanceDate = value; }
        }

        private decimal grossAmount;

        public decimal GrossAmount
        {
            get { return grossAmount; }
            set { grossAmount = value; }
        }

        private int currency;

        public int Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        private string currencyCode;
        public string CurrencyCode
        {
            get { return currencyCode; }
            set { currencyCode = value; }
        }

        private string uRL;

        public string URL
        {
            get { return uRL; }
            set { uRL = value; }
        }

        private string iP;

        public string IP
        {
            get { return iP; }
            set { iP = value; }
        }

        private string userName;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string company;

        public string Company
        {
            get { return company; }
            set { company = value; }
        }

        private long paymentProvider;

        public long PaymentProvider
        {
            get { return paymentProvider; }
            set { paymentProvider = value; }
        }

        public string PaymentInterface { get; set; }

        private string cA_FrontCard;

        public string CA_FrontCard
        {
            get { return cA_FrontCard; }
            set { cA_FrontCard = value; }
        }

        private string cA_BackCard;

        public string CA_BackCard
        {
            get { return cA_BackCard; }
            set { cA_BackCard = value; }
        }

        private string billingAccountID;

        public string BillingAccountID
        {
            get { return billingAccountID; }
            set { billingAccountID = value; }
        }

        private string cANumber;

        public string CANumber
        {
            get { return cANumber; }
            set { cANumber = value; }
        }

        private string expireDate;

        public string ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }

        private int _percent;

        public int Percent
        {
            get { return _percent; }
            set { _percent = value; }
        }

        private bool _isDeposit;

        public bool IsDeposit
        {
            get { return _isDeposit; }
            set { _isDeposit = value; }
        }

        private string _hotelPlatformType;

        public string HotelPlatformType
        {
            get { return _hotelPlatformType; }
            set { _hotelPlatformType = value; }
        }

        private int _maxTransaction;

        public int MaxTransaction
        {
            get { return _maxTransaction; }
            set { _maxTransaction = value; }
        }

        private string _tAFType;

        public string TAFType
        {
            get { return _tAFType; }
            set { _tAFType = value; }
        }


        private decimal _tAF;

        public decimal TAF
        {
            get { return _tAF; }
            set { _tAF = value; }
        }

        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        private string bookerName;

        public string BookerName
        {
            get { return bookerName; }
            set { bookerName = value; }
        }

        private string eventTitle;

        public string EventTitle
        {
            get { return eventTitle; }
            set { eventTitle = value; }
        }

        private string bookingStatus;

        public string BookingStatus
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }

        private string _pCI_AccountName;

        public string PCI_AccountName
        {
            get { return _pCI_AccountName; }
            set { _pCI_AccountName = value; }
        }
        public string PCI_AccountStatus { get; set; }
        public int CountryCurrency { get; set; }
        public decimal MaxAmount { get; set; }
        public decimal Rate { get; set; }

    }

    public class P_DBI
    {
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private string value;

        public string Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

       
    }
}
