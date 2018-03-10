using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model._3.CarRental._7.Process;

namespace T2P._2015.Cross.Model
{
    public class R_P_InvoiceCaptureList
    {

        private long _imageID;

        public long ImageID
        {
            get { return _imageID; }
            set { _imageID = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string _carProviderName;

        public string CarProviderName
        {
            get { return _carProviderName; }
            set { _carProviderName = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }


        private DateTime _receivedDate;

        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }

        private DateTime? _pickupDate;

        public DateTime? PickupDate
        {
            get { return _pickupDate; }
            set { _pickupDate = value; }
        }

        private string _pickupTime;

        public string PickupTime
        {
            get { return _pickupTime; }
            set { _pickupTime = value; }
        }

        private DateTime? _returnDate;

        public DateTime? ReturnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; }
        }

        private string _returnTime;

        public string ReturnTime
        {
            get { return _returnTime; }
            set { _returnTime = value; }
        }

        private string _countryCode;

        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }

        private string _pickupPlace;

        public string PickupPlace
        {
            get { return _pickupPlace; }
            set { _pickupPlace = value; }
        }

        private string _returnPlace;

        public string ReturnPlace
        {
            get { return _returnPlace; }
            set { _returnPlace = value; }
        }

        private string _status;

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        private int page;

        public int Page
        {
            get { return page; }
            set { page = value; }
        }

        private int pageSize;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value; }
        }

        private string orderBy;

        public string OrderBy
        {
            get { return orderBy; }
            set { orderBy = value; }
        }

        private string orderDirection;

        public string OrderDirection
        {
            get { return orderDirection; }
            set { orderDirection = value; }
        }

        private bool _isLocked;

        public bool IsLocked
        {
            get { return _isLocked; }
            set { _isLocked = value; }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private DateTime _updatedDate;

        public DateTime UpdatedDate
        {
            get { return _updatedDate; }
            set { _updatedDate = value; }
        }
        private long _updatedBy;

        public long UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }


        private int _totalRecords;

        public int TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }

    }

    public class R_P_InvoiceCapture_CommonData
    {
        public List<M_CarRentalProvider> ListCarProvider { get; set; }
        public List<M_Country> ListCountry { get; set; }

        public List<R_M_CarGroup> ListCarGroup { get; set; }

        public List<R_M_SippCode> ListSippCode { get; set; }

        public List<M_Currency> ListCurrency { get; set; }

        public List<R_M_InvoiceErrorCode> ListErrorCode { get; set; }

        public List<R_M_InvoiceErrorCode> LstErrorCodeService { get; set; }

        public List<R_M_Surcharge> ListSurcharge { get; set; }

        public List<M_Code> ListCode { get; set; }

        
    }

    public class R_P_Invoice_Capture : R_I_Data
    {
        public string TravellerEmail { get; set; }
        public string TravellerFirstName { get; set; }
        public string TravellerLastName { get; set; }
        public string RateGrid { get; set; }
        public string ProcessType { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public R_I_Relation Relation { get; set; }
        private long _r_I_DataID;

        public long R_I_DataID
        {
            get { return _r_I_DataID; }
            set { _r_I_DataID = value; }
        }

        private long? _r_I_ImageIdOld;

        public long? R_I_ImageIdOld
        {
            get { return _r_I_ImageIdOld; }
            set { _r_I_ImageIdOld = value; }
        }

        private DateTime? _pickupDate;

        public DateTime? PickupDate
        {
            get { return _pickupDate; }
            set { _pickupDate = value; }
        }

        private DateTime? _returnDate;

        public DateTime? ReturnDate
        {
            get { return _returnDate; }
            set { _returnDate = value; }
        }

        private string _pickupCountryCode;

        public string PickupCountryCode
        {
            get { return _pickupCountryCode; }
            set { _pickupCountryCode = value; }
        }

        private string _returnCountryCode;

        public string ReturnCountryCode
        {
            get { return _returnCountryCode; }
            set { _returnCountryCode = value; }
        }


        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _companyAddress;

        public string CompanyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }

        private string _companyZipCode;

        public string CompanyZipCode
        {
            get { return _companyZipCode; }
            set { _companyZipCode = value; }
        }

        private string _companyCityName;

        public string CompanyCityName
        {
            get { return _companyCityName; }
            set { _companyCityName = value; }
        }

        private string _companyCountryName;

        public string CompanyCountryName
        {
            get { return _companyCountryName; }
            set { _companyCountryName = value; }
        }

        private string _companyCountryCode;

        public string CompanyCountryCode
        {
            get { return _companyCountryCode; }
            set { _companyCountryCode = value; }
        }

        private string _logoProviderURL;

        public string LogoProviderURL
        {
            get { return _logoProviderURL; }
            set { _logoProviderURL = value; }
        }

        private long _m_CompanyID;

        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private string _pickupHour;

        public string PickupHour
        {
            get { return _pickupHour; }
            set { _pickupHour = value; }
        }

        private string _pickupMinute;

        public string PickupMinute
        {
            get { return _pickupMinute; }
            set { _pickupMinute = value; }
        }

        private string _returnHour;

        public string ReturnHour
        {
            get { return _returnHour; }
            set { _returnHour = value; }
        }

        private string _returnMinute;

        public string ReturnMinute
        {
            get { return _returnMinute; }
            set { _returnMinute = value; }
        }

        private string _carProviderName;

        public string CarProviderName
        {
            get { return _carProviderName; }
            set { _carProviderName = value; }
        }

        private long _carProviderID;

        public long CarProviderID
        {
            get { return _carProviderID; }
            set { _carProviderID = value; }
        }

        private long _spendTimeReturnCar;

        public long SpendTimeReturnCar
        {
            get { return _spendTimeReturnCar; }
            set { _spendTimeReturnCar = value; }
        }

        private string _fullPath;

        public string FullPath
        {
            get { return _fullPath; }
            set { _fullPath = value; }
        }

        private string _sippCode;

        public string SippCode
        {
            get { return _sippCode; }
            set { _sippCode = value; }
        }

        private string _descriptionSippCode;

        public string DescriptionSippCode
        {
            get { return _descriptionSippCode; }
            set { _descriptionSippCode = value; }
        }

        private string _descriptionCarGroup;

        public string DescriptionCarGroup
        {
            get { return _descriptionCarGroup; }
            set { _descriptionCarGroup = value; }
        }


        private string _crCarGroup;

        public string CRCarGroup
        {
            get { return _crCarGroup; }
            set { _crCarGroup = value; }
        }

        private bool _acceptTraveler;

        public bool AcceptTraveler
        {
            get { return _acceptTraveler; }
            set { _acceptTraveler = value; }
        }

        private string _traveler;

        public string Traveler
        {
            get { return _traveler; }
            set { _traveler = value; }
        }

        private string _carProcess;

        public string CarProcess
        {
            get { return _carProcess; }
            set { _carProcess = value; }
        }


        private long _currentServiceID;

        public long CurrentServiceID
        {
            get { return _currentServiceID; }
            set { _currentServiceID = value; }
        }

        private bool _isManual;

        public bool IsManual
        {
            get { return _isManual; }
            set { _isManual = value; }
        }

        private bool _isSecondNewDebit;

        public bool IsSecondNewDebit
        {
            get { return _isSecondNewDebit; }
            set { _isSecondNewDebit = value; }
        }
        public bool isMatch { get; set; }

        public string Comment { get; set; }
        public R_I_Image Image { get; set; }

        public R_I_Image OldImage { get; set; }

        public List<R_I_Service> ListService { get; set; }
        public List<R_I_Tax> ListTax { get; set; }

        public List<R_I_Error> ListInvoiceError { get; set; }

        public List<P_Image_Data> ListInvoiceReplace { get; set; }
        public List<P_Image_Data> ListInvoiceOriginal { get; set; }
        
        public List<R_P_CarGroupSippCode> ListCarGroupSippCode { get; set; }

        public List<R_M_Service_Keyword> ListServiceKeyword { get; set; }

        public List<R_M_Surcharge> ListSurcharge { get; set; }

        public List<R_M_InvoiceErrorCode> ListErrorCode { get; set; }

        public R_P_NextInvoiceStep NextInvoiceStep { get; set; }

        public R_P_InvoiceStep InvoiceStep { get; set; }

        public R_P_ImportBooking FileBooking { get; set; }


        public R_F_Header Header { get; set; }

        public R_F_Transaction Transaction { get; set; }

        public R_P_Validation Validation { get; set; }
        public List<R_N_Task> NTask { get; set; }

        public string AttachmentLocalPath { get; set; }
        public string OriginalAttachementName { get; set; }
        public string AttachmentIISPath { get; set; }

        public long R_N_BillingEmailID { get; set; }

        public string MailUsername { get; set; }

        public long M_CarRentalProviderSettingID { get; set; }

        public string From { get; set; }

        public string Subject { get; set; }

        public string MessageID { get; set; }

        private DateTime _createdDateEmail;

        public DateTime CreatedDateEmail
        {
            get { return _createdDateEmail; }
            set { _createdDateEmail = value; }
        }


        public R_P_Invoice_Capture()
        {
            SpendTimeReturnCar = 0;
            ListInvoiceOriginal = new List<P_Image_Data>();
            ListService = new List<R_I_Service>();
            ListTax = new List<R_I_Tax>();
            ListInvoiceError = new List<R_I_Error>();
            ListCarGroupSippCode = new List<R_P_CarGroupSippCode>();
            ListServiceKeyword = new List<R_M_Service_Keyword>();
            ListSurcharge = new List<R_M_Surcharge>();
        }
    }

    public class R_P_LockCapture
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public long? NextImageID { get; set; }
    }

    public class R_P_LockInvoice
    {
        public long R_I_ImageID { get; set; }

        public long UserID { get; set; }
        public DateTime LockTime { get; set; }
    }

    public class R_P_CarGroupSippCode : R_M_CarGroupSippCode
    {
        public string CarGroup { get; set; }

        public string SippCode { get; set; }
    }

    public enum R_P_InvoiceCaptureProcedure
    {
        p_R_InvoiceCapture_Get_ListSearch,
        p_R_I_GetForCapture,
        p_R_I_GetForCaptureNext
    }

}
