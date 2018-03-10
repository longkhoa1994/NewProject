using System;
using System.Collections.Generic;
using T2P._2015.Cross.Enum;
using T2P._2015.Cross.Model.Process;
using T2P._2015.Model;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Booking : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private long _b_HeaderID;

        public long B_HeaderID
        {
            get { return _b_HeaderID; }
            set { _b_HeaderID = value; }
        }

        private long? _b_EventID;

        public long? B_EventID
        {
            get { return _b_EventID; }
            set { _b_EventID = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string transactionNumber;

        public string TransactionNumber
        {
            get { return transactionNumber; }
            set { transactionNumber = value; }
        }

        private decimal _grossAmount;

        public decimal GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        private string _paymentMethod;

        public string PaymentMethod
        {
            get { return _paymentMethod; }
            set { _paymentMethod = value; }
        }

        private string _currencyCode;

        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        private DateTime? _bookingDate;


        public DateTime? BookingDate
        {
            get { return _bookingDate; }
            set { _bookingDate = value; }
        }

        private DateTime? _cancellationDate;


        public DateTime? CancellationDate
        {
            get { return _cancellationDate; }
            set { _cancellationDate = value; }
        }
        private long? _deploymentID;

        public long? DeploymentID
        {
            get { return _deploymentID; }
            set { _deploymentID = value; }
        }
        private string _invoiceRecipientEmail;

        public string InvoiceRecipientEmail
        {
            get { return _invoiceRecipientEmail; }
            set { _invoiceRecipientEmail = value; }
        }
        private int? _option;

        public int? Option
        {
            get { return _option; }
            set { _option = value; }
        }
        private DateTime _checkIn;

        public DateTime CheckIn
        {
            get { return _checkIn; }
            set { _checkIn = value; }
        }

        private DateTime _checkOut;

        public DateTime CheckOut
        {
            get { return _checkOut; }
            set { _checkOut = value; }
        }

        public bool IsManually { get; set; }


        public long InventorySystem { get; set; }

        public Policies Policies { get; set; }

        public override string Table { get { return "B_Booking"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Booking_InsertOrUpdate"; } }

        public B_Booking()
        {
            PaymentMethod = string.Empty;
            IsManually = false;
        }

        public static B_Booking DefaultTest()
        {
            var booking = new B_Booking()
            {
                CreatedDate = DateTime.UtcNow
            };
            return booking;
        }
    }

    public class B_Booking_Extend : B_Booking
    {
        public long M_HotelPlatformID { get; set; }
        public string BookingStatus { get; set; }
        public string HotelName { get; set; }
        public string CompanyName { get; set; }
        public string ListTraveller { get; set; }
        public B_Booking_Extend()
        {
            M_HotelPlatformID = 0;
            HotelName = string.Empty;
            CompanyName = string.Empty;
            ListTraveller = string.Empty;
        }
    }

    public class B_Booking_ForMatching : B_Booking
    {
        public long M_HotelPlatformID { get; set; }
        public long M_ProcessID { get; set; }
        public int BookingType { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string ListTraveller { get; set; }
        public string ListImage { get; set; }
        public string ListFIN { get; set; }
        public string ListAllowedServiceCode { get; set; }
        public string ContractNo { get; set; }
        public string BookerName { get; set; }
        public DateTime? CancellationDate { get; set; }
        public long TotalRow { get; set; }
        public B_Booking_ForMatching()
        {
            M_HotelPlatformID = 0;
            M_ProcessID = 0;
            BookingType = 0;
            HotelName = string.Empty;
            HotelAddress = string.Empty;
            CompanyName = string.Empty;
            CompanyAddress = string.Empty;
            ListTraveller = string.Empty;
            ListImage = string.Empty;
            ListFIN = string.Empty;
            ListAllowedServiceCode = string.Empty;
        }
    }   

    public class B_Booking_ForServiceCenterTemplate : B_Booking
    {
        public string Travellers { get; set; }
        public string HotelName { get; set; }
        public string Booker { get; set; }
        public string HotelNo { get; set; }
        public string HotelVATNumber { get; set; }
        public string HotelAddress { get; set; }
        public string HotelEmail { get; set; }
        public string HotelFax { get; set; }
        public long HotelM_LanguageID { get; set; }
        public string CompanyName { get; set; }
        public string CompanyNo { get; set; }
        public string CompanyVATNumber { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyFax { get; set; }
        public string InvoiceNumber { get; set; }
        public string InvoiceAmount { get; set; }
        public string InvoiceWaitingFINAmount { get; set; }
        public string InvoiceIncorrectCompanyAmount { get; set; }
        public string ServiceNotAllowedInvoiceAmount { get; set; }
        public string Transactions { get; set; }
        public string UserSignature { get; set; }
        public string HotelTel { get; set; }
        public string BillingEmail { get; set; }
        public string BillingFax { get; set; }
        public string ExpirationDate { get; set; }
        public string VCCNumber { get; set; }
        public string RejectedServices { get; set; }
      
        public string UserSignatureDecode
        {
            get { return T2P._2015.Cross.Utility.Conversion.Conversion.ObjectToString(System.Net.WebUtility.HtmlDecode(this.UserSignature)); }
        }

    }

    public class B_Booking_ForImportFin : B_Booking
    {
        public long M_ProcessID { get; set; }
        public string ProcessName { get; set; }
    }

    public enum B_BookingColumns
    {
        ID,
        B_AccessID,
        B_HeaderID,
        BookingNo,
        GrossAmount,
        PaymentMethod,
        CurrencyCode,
        BookingDate,
        CancellationDate,
        CheckIn,
        CheckOut,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_BookingProcedure
    {
        //p_B_Booking_Get_Search,
        p_B_Booking_GetSearch,
        p_B_Booking_GetSearch_GetTotal,
        p_B_Booking_Get_By_B_AccessID,
        p_B_Booking_CheckInfoHDE,
        p_B_Booking_GetByBookingNo,
        p_B_Booking_GetByHotelEmail,
        p_B_Booking_Get_Information,
        p_P_Matching_GetBooking,
        p_P_Matching_GetBooking_Count,
        p_B_Booking_GetInfoForCollectionLetter,
        p_B_Booking_GetByBookingNoFor_MatchBillingEmail,
        p_B_Booking_GetListForWeeklyLetterHRS,
        p_B_Booking_GetListForWeeklyReportToAirplus,
        p_B_Booking_Get_BookingNoForServiceCenterTemplate,
        p_B_Booking_GetList_ByBookingAccess_WithoutStatus,
        p_B_Booking_GetListForDeleting,
        p_B_Booking_GetListForPhysicalDeleting,
        p_B_Booking_GetListForArchiving_Deleting,
        p_B_Booking_CheckInfoBCD,
        p_B_Booking_GetListByCallID,
        p_B_Booking_GetListByListCallID,
        p_B_Booking_Check_GenerateBookingNo,
        p_B_BookingDetail_Get_IsModify,
        p_B_Booking_CompanySpecialAgreementWithHotel,
        p_B_Booking_CheckInfoByTransaction,
        p_BookingInfor_Rejection,
		p_B_Booking_GetBookingAndPlatform_By_B_AccessID,
        p_B_Booking_UpdateBookingOffline,
        p_B_Booking_GetBy_DBISearch,
        p_B_Booking_GetBy_DBISearch_TotalRecords,
        p_B_Booking_GetList_Stop_ForATXPremium_Process,
        p_B_Booking_GetSearch_Detail,
        p_B_Booking_Get_CancelBooking_ExistFinOrInv,
        p_B_Booking_Validation_Hotelzon,
        p_B_Booking_CheckDuplicated_Booking_Hotelzon,
        p_B_Booking_GetByImageID,
        p_B_Booking_GetBookingNotFinishAfter5Week,
        p_B_Booking_CheckValidCancelByB_AccessID
    }

    public class B_BookingList : List<B_Booking>
    {
    }

    public class P_AdditionReservation_Request 
    {
        public List<long> ListID { get; set; }

        public string Type { get; set; }
        public P_AdditionReservation_Request()
        {
            ListID = new List<long>();
        }
    }

    public class P_AdditionReservation_Respond
    {
        public long B_AccessID { get; set; }
        public string TravelerName { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public string BC1 { get; set; }
        public string BC2 { get; set; }
        public string FC1 { get; set; }
        public string FC2 { get; set; }
        public string IR1 { get; set; }
        public string IR2 { get; set; }
        public string NoOfFin { get; set; }
        public string NoOfInvoice { get; set; }
        public string CheckingStatus { get; set; }
        public int Task { get; set; }
    }

    public class P_OfflineReservation_Hotel
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
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

        private bool _acceptVCC;

        public bool AcceptVCC
        {
            get { return _acceptVCC; }
            set { _acceptVCC = value; }
        }
    }

    public class P_OfflineReservation_HotelContact
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_HotelID;

        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
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

        private string _phoneNumber;

        
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private string _cellPhone;

        
        public string CellPhone
        {
            get { return _cellPhone; }
            set { _cellPhone = value; }
        }

        private string _extensionNumber;

        
        public string ExtensionNumber
        {
            get { return _extensionNumber; }
            set { _extensionNumber = value; }
        }

        private string _position;

        
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        private string _skype;

        
        public string Skype
        {
            get { return _skype; }
            set { _skype = value; }
        }

        private string _fax;

        
        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        private string _convertedFaxNumber;

        public string ConvertedFaxNumber
        {
            get { return _convertedFaxNumber; }
            set { _convertedFaxNumber = value; }
        }

        private string _comment;

        
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private string _email;

        
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private bool _isDefault;

        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }
    }

    public class P_OfflineReservation_Reservation
    {
        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        private string _timResNo;

        public string TimResNo
        {
            get { return _timResNo; }
            set { _timResNo = value; }
        }

        private string _hotelResNo;

        public string HotelResNo
        {
            get { return _hotelResNo; }
            set { _hotelResNo = value; }
        }

        private DateTime _bookingDate;

        public DateTime BookingDate
        {
            get { return _bookingDate; }
            set { _bookingDate = value; }
        }

        private DateTime _checkInDate;

        public DateTime CheckInDate
        {
            get { return _checkInDate; }
            set { _checkInDate = value; }
        }

        private DateTime _checkOutDate;

        public DateTime CheckOutDate
        {
            get { return _checkOutDate; }
            set { _checkOutDate = value; }
        }

        private int _roomNight;

        public int RoomNight
        {
            get { return _roomNight; }
            set { _roomNight = value; }
        }

        private bool _singleRoom;

        public bool SingleRoom
        {
            get { return _singleRoom; }
            set { _singleRoom = value; }
        }

        private bool _doubleRoom;

        public bool DoubleRoom
        {
            get { return _doubleRoom; }
            set { _doubleRoom = value; }
        }

        private DateTime? _cancellationDate;

        public DateTime? CancellationDate
        {
            get { return _cancellationDate; }
            set { _cancellationDate = value; }
        }

        private string _hour;

        public string Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }

        private string _minute;

        public string Minute
        {
            get { return _minute; }
            set { _minute = value; }
        }

        private string _salTraveler;

        public string SalTraveler
        {
            get { return _salTraveler; }
            set { _salTraveler = value; }
        }

        private string _fNTraveler;

        public string FNTraveler
        {
            get { return _fNTraveler; }
            set { _fNTraveler = value; }
        }

        private string _lNTraveler;

        public string LNTraveler
        {
            get { return _lNTraveler; }
            set { _lNTraveler = value; }
        }

        private string _phoneTraveler;

        public string PhoneTraveler
        {
            get { return _phoneTraveler; }
            set { _phoneTraveler = value; }
        }

        private string _emailTraveler;

        public string EmailTraveler
        {
            get { return _emailTraveler; }
            set { _emailTraveler = value; }
        }

        private long _locationTravelerID;

        public long LocationTravelerID
        {
            get { return _locationTravelerID; }
            set { _locationTravelerID = value; }
        }

        private string _salTraveler2;

        public string SalTraveler2
        {
            get { return _salTraveler2; }
            set { _salTraveler2 = value; }
        }

        private string _fNTraveler2;

        public string FNTraveler2
        {
            get { return _fNTraveler2; }
            set { _fNTraveler2 = value; }
        }

        private string _lNTraveler2;

        public string LNTraveler2
        {
            get { return _lNTraveler2; }
            set { _lNTraveler2 = value; }
        }

        private string _phoneTraveler2;

        public string PhoneTraveler2
        {
            get { return _phoneTraveler2; }
            set { _phoneTraveler2 = value; }
        }

        private string _emailTraveler2;

        public string EmailTraveler2
        {
            get { return _emailTraveler2; }
            set { _emailTraveler2 = value; }
        }

        private long _locationTravelerID2;

        public long LocationTravelerID2
        {
            get { return _locationTravelerID2; }
            set { _locationTravelerID2 = value; }
        }

        private string _salBooker;

        public string SalBooker
        {
            get { return _salBooker; }
            set { _salBooker = value; }
        }

        private string _fNBooker;

        public string FNBooker
        {
            get { return _fNBooker; }
            set { _fNBooker = value; }
        }

        private string _lNBooker;

        public string LNBooker
        {
            get { return _lNBooker; }
            set { _lNBooker = value; }
        }

        private string _phoneBooker;

        public string PhoneBooker
        {
            get { return _phoneBooker; }
            set { _phoneBooker = value; }
        }

        private string _emailBooker;

        public string EmailBooker
        {
            get { return _emailBooker; }
            set { _emailBooker = value; }
        }

        private bool _isGuaranty;

        public bool IsGuaranty
        {
            get { return _isGuaranty; }
            set { _isGuaranty = value; }
        }

        public string ResNo { get; set; }

        public List<P_OfflineReservation_OtherTraveler> ListOtherTraveler { get; set; }
    }

    public class P_OfflineReservation_OtherTraveler
    {
        public string EmailTraveler { get; set; }
        public string FNTraveler { get; set; }
        public string LNTraveler { get; set; }
        public long LocationTravelerID { get; set; }
        public string PhoneTraveler { get; set; }
        public string SalTraveler { get; set; }
        public P_OfflineReservation_DefaultDBI DBI_Setting { get; set; }
    }
    public class P_OfflineReservation_DefaultDBI
    {
        public string DBI_PK { get; set; }
        public string DBI_DS { get; set; }
        public string DBI_KS { get; set; }
        public string DBI_AE { get; set; }
        public DateTime? DBI_BD { get; set; }
        public string DBI_PR { get; set; }
        public string DBI_AU { get; set; }
        public string DBI_RZ { get; set; }
        public string DBI_IK { get; set; }
    }
    public class P_OfflineReservation_Payment
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

        private string _cityName;

        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
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

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _logoURL;

        public string LogoURL
        {
            get { return _logoURL; }
            set { _logoURL = value; }
        }

        private string _logoPlatform;

        public string LogoPlatform
        {
            get { return _logoPlatform; }
            set { _logoPlatform = value; }
        }

        private string _customerNo;

        public string CustomerNo
        {
            get { return _customerNo; }
            set { _customerNo = value; }
        }

        private bool _selfPayment;

        public bool SelfPayment
        {
            get { return _selfPayment; }
            set { _selfPayment = value; }
        }

        private bool _creditCard;

        public bool CreditCard
        {
            get { return _creditCard; }
            set { _creditCard = value; }
        }

        private DateTime? _costAcceptanceDate;

        public DateTime? CostAcceptanceDate
        {
            get { return _costAcceptanceDate; }
            set { _costAcceptanceDate = value; }
        }

        private decimal _finalPrice;

        public decimal FinalPrice
        {
            get { return _finalPrice; }
            set { _finalPrice = value; }
        }

        private decimal _pricePerNight;

        public decimal PricePerNight
        {
            get { return _pricePerNight; }
            set { _pricePerNight = value; }
        }

        private string _currency;

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        private bool _deposit;

        public bool Deposit
        {
            get { return _deposit; }
            set { _deposit = value; }
        }

        //Traveler 1
        public string DBI_PK { get; set; }
        public string DBI_DS { get; set; }
        public string DBI_KS { get; set; }
        public string DBI_AE { get; set; }
        public DateTime? DBI_BD { get; set; }
        public string DBI_PR { get; set; }
        public string DBI_AU { get; set; }
        public string DBI_RZ { get; set; }
        public string DBI_IK { get; set; }
        //Traveler 2
        public string DBI_PK2 { get; set; }
        public string DBI_DS2 { get; set; }
        public string DBI_KS2 { get; set; }
        public string DBI_AE2 { get; set; }
        public DateTime? DBI_BD2 { get; set; }
        public string DBI_PR2 { get; set; }
        public string DBI_AU2 { get; set; }
        public string DBI_RZ2 { get; set; }
        public string DBI_IK2 { get; set; }

        public List<M_ServiceCode> ListAllowedServiceCode { get; set; }

        public P_OfflineReservation_Payment()
        {
            DBI_PK = string.Empty;
            DBI_DS = string.Empty;
            DBI_KS = string.Empty;
            DBI_AE = string.Empty;
            DBI_BD = new DateTime();
            DBI_PR = string.Empty;
            DBI_AU = string.Empty;
            DBI_RZ = string.Empty;
            DBI_IK = string.Empty;

            DBI_PK2 = string.Empty;
            DBI_DS2 = string.Empty;
            DBI_KS2 = string.Empty;
            DBI_AE2 = string.Empty;
            DBI_BD2 = new DateTime();
            DBI_PR2 = string.Empty;
            DBI_AU2 = string.Empty;
            DBI_RZ2 = string.Empty;
            DBI_IK2 = string.Empty;

            ListAllowedServiceCode = new List<M_ServiceCode>();
        }
    }

    public class P_Import_OfflineReservation
    {
        public P_OfflineReservation_Hotel hotel { get; set; }
        public P_OfflineReservation_Reservation reservation { get; set; }
        public P_OfflineReservation_Payment company { get; set; }
        public P_OfflineReservation_HotelContact hotelContact { get; set; }
        public bool IsSendingTraveler { get; set; }
        public bool IsSendingBooker { get; set; }
        public string BookingPlatform { get; set; }

        public P_Import_OfflineReservation()
        {
            hotel = new P_OfflineReservation_Hotel();
            reservation = new P_OfflineReservation_Reservation();
            company = new P_OfflineReservation_Payment();
            IsSendingBooker = false;
            IsSendingTraveler = false;
            hotelContact = new P_OfflineReservation_HotelContact();
        }
    }

    public class P_ValidateHotel_OfflineReservation
    {
        public bool isHotelName { get; set; }
        public bool isAddress { get; set; }
        public bool isZipCode { get; set; }
        public bool isCityName { get; set; }
        public bool isCountryName { get; set; }
        public bool isFax { get; set; }
        public bool isEmail { get; set; }
    }

    public class P_ValidateReservation_OfflineReservation
    {
        public bool isReservationNo { get; set; }
        public bool isCheckinDate { get; set; }
        public bool isCheckoutDate { get; set; }
        public bool isBookingDate { get; set; }
        public bool isCancellationDate { get; set; }
        public bool isFNTraveler { get; set; }
        public bool isLNTraveler { get; set; }
        public bool isEmailTraveler { get; set; }
        public bool isFNBooker { get; set; }
        public bool isLNBooker { get; set; }
        public bool isEmailBooker { get; set; }
    }

    public class P_ValidatePayment_OfflineReservation
    {
        public bool isPaymentMethod { get; set; }
        public bool isFinalPrice { get; set; }
        public bool isCurrency { get; set; }
        public bool isAllowedServiceCode { get; set; }
        public bool isCostAcceptanceDate { get; set; }
    }

    public class P_Validate_OfflineReservation
    {
        public P_ValidateHotel_OfflineReservation validateHotel { get; set; }
        public P_ValidateReservation_OfflineReservation validateReservation { get; set; }
        public P_ValidatePayment_OfflineReservation validatePayment { get; set; }
        public int validateHotelCount { get; set; }
        public int validateReservationCount { get; set; }
        public int validatePaymentCount { get; set; }
        public P_Validate_OfflineReservation()
        {
            validateHotel = new P_ValidateHotel_OfflineReservation();
            validateReservation = new P_ValidateReservation_OfflineReservation();
            validatePayment = new P_ValidatePayment_OfflineReservation();
            validateHotelCount = 0;
            validateReservationCount = 0;
            validatePaymentCount = 0;
        }
    }

    public class P_Data_OfflineReservation
    {
        public string PDFPath { get; set; }
        public List<P_Preprocessing_Page> ListPage { get; set; }
        public B_Header BHeader { get; set; }
        public B_Booking BBooking { get; set; }
        public B_BookingDetail BBookingDetail { get; set; }
        public B_BookingDetail BBookingDetail2 { get; set; }
        public List<B_BookingDetail> BListBookingDetail { get; set; }
        public B_DBI BDBI { get; set; }
        public B_DBI BDBI2 { get; set; }
        public List<B_DBI> ListBDI { get; set; }
        public B_Hotel BHotel { get; set; }
        public B_Pos BPos { get; set; }
        public B_Traveler BTraveler { get; set; }
        public B_Traveler BTraveler2 { get; set; }
        public List<B_Traveler> BListTraveler { get; set; }
        public B_Booker BBooker { get; set; }
        public B_Access BAccess { get; set; }
        public B_AccessDetail BAccessDetail { get; set; }
        public B_AccessDetail BAccessDetail2 { get; set; }
        public List<B_AccessDetail> ListBAccessDetail { get; set; }
        public B_Company BCompany { get; set; }
        public M_Hotel MHotel { get; set; }
        public M_Traveler MBooker { get; set; }
        public M_Traveler MTraveler { get; set; }
        public M_Traveler MTraveler2 { get; set; }
        public List<M_Traveler> MListTraveler { get; set; }
        public N_Task TaskCheckHotel { get; set; }
        public N_Task TaskForPayment { get; set; }
        public P_NextBookingStep NextBookingStep { get; set; }
        public List<M_HotelProcess> ListHotelProcess { get; set; }
        public List<M_HotelPayment> ListHotelPayment { get; set; }
        public List<B_AllowedServiceCodes> ListAllowedServiceCode { get; set; }
        public P_Data_OfflineReservation()
        {
            ListHotelProcess = new List<M_HotelProcess>();
            ListHotelPayment = new List<M_HotelPayment>();
            ListAllowedServiceCode = new List<B_AllowedServiceCodes>();
            ListPage = new List<P_Preprocessing_Page>();
            MListTraveler = new List<M_Traveler>();
            BListBookingDetail = new List<B_BookingDetail>();
            ListBAccessDetail = new List<B_AccessDetail>();
            BListTraveler = new List<B_Traveler>();
            ListBDI = new List<B_DBI>();
        }
    }
     public class B_Booking_Modify:BaseModel
    {
        private bool isModify;

        public bool IsModify
        {
            get { return isModify; }
            set { isModify = value; }
        }
        private long id;

        public long ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}