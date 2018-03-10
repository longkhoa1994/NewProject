using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.History;
using T2P._2015.Model;

namespace T2P._2015.Cross.Model.Process
{
    public class P_DeletionReport
    {
        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }
        private string checkIn;

        public string CheckIn
        {
            get { return checkIn; }
            set { checkIn = value; }
        }
        private string checkOut;

        public string CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }
    }

    public enum TableName
    {
        A_AssignedPermission,
        A_Function,
        A_Membership,
        A_Menu,
        A_Object,
        A_ObjectFunction,
        A_ObjectRelation,
        A_Role,
        A_RolesTranslation,
        A_UserCompany,
        A_UserHistory,
        A_UserOldPassword,
        A_UserProfile,
        A_UserRole,
        A_UserSetting,
        A_UserTemplate,

        B_Access,
        B_AccessDetail,
        B_Addition,
        B_AllowedServiceCodes,
        B_Booker,
        B_Booking,
        B_BookingDetail,
        B_Comment,
        B_Company,
        B_Header,
        B_History,
        B_Hotel,
        B_HotelContact,
        B_KeyValuePairBooking,
        B_KeyValuePairBookingDetail,
        B_Pos,
        B_Rate,
        B_Suggestion,
        B_Traveler,
        B_PaymentCard, //new table

        D_StatisticData,
        D_StatisticDataDetail,

        F_Header,
        F_Relation,
        F_Transaction,
        F_TransactionAdditionAPC,
        F_VTISummary,
        F_VTITransaction,
        F_VTIZIB,
        F_VTIZIG,

        H_I_Data,
        H_I_Position,
        H_I_Tax,
        H_P_InvoiceError,
        H_P_Validation,

        I_Data,
        I_DataSendTraveler,
        I_Delivery,
        I_DeliveryDetail,
        I_DeliveryNotification,
        I_Error,
        I_Forward,
        I_ForwardLine,
        I_Image,
        I_ImageDelivery,
        I_Import,
        I_PageToImage,
        I_Position,
        I_Relation,
        I_Replace,
        I_Tax,
        I_Suggestion, //new table

        M_CaptureCenter,
        M_City,
        M_Company,
        M_CompanyActor,
        M_CompanyContact,
        M_CompanyGeneralSetting,
        M_CompanyProcess,
        M_CompanyProcessSchedule,
        M_CompanyVATCode,
        M_Condition,
        M_ConditionResult,
        M_Country,
        M_CountryAddition,
        M_CountryCurrency,
        M_CountryOrganization,
        M_CountryTax,
        M_Currency,
        M_DayLightTime,
        M_FileLocation,
        M_Hotel,
        M_HotelContact,
        M_HotelPlatform,
        M_HotelPlatformProcess,
        M_HotelPlatformSetting,
        M_ImageTemplate,
        M_InvoiceErrorCode,
        M_InvoiceErrorCodeTranslation,
        M_IPLocation,
        M_Language,
        M_NameGender,
        M_NotificationTemplate,
        M_NotificationTemplateAttachment,
        M_OfflineHotel,
        M_Organization,
        M_Phrase,
        M_Process,
        M_ProcessActor,
        M_ProcessGeneralSetting,
        M_ProcessSchedule,
        M_ProcessStep,
        M_Reference,
        M_Resource,
        M_ResourceTranslation,
        M_ServiceCode,
        M_ServiceCodeTranslation,
        M_ServiceSetting,
        M_StepType,
        M_SystemLog,
        M_SystemSetting,
        M_TimeZone,
        M_Traveler,

        N_AttachmentPage,
        N_BillingEmail,
        N_BillingEmailAddition,
        N_BillingEmailAttachment,
        N_BillingEmailDetail,
        N_BillingEmailFolder,
        N_BookingBillingEmail,
        N_BookingSentBox,
        N_Collection,
        N_ExtensionRequest,
        N_ExtensionRequestDetail,
        N_Information,
        N_InformationAttachment,
        N_InformationDetail,
        N_PhoneCall,
        N_Rejection,
        N_Remind,
        N_SentBox,
        N_SentBoxAttachment,
        N_SkipNotification,
        N_Task,
        N_CostAcceptance,//new table

        P_BookingStep,
        P_FinancialStep,
        P_InvoiceError,
        P_InvoiceStep,
        P_NextBookingStep,
        P_NextFinancialStep,
        P_NextInvoiceStep,
        P_Validation
    }

    public class P_Comlumn_Not_Delete
    {
        public string B_Company = "CompanyName, CompanyShortName";
        public string B_Hotel = "HotelNo, HotelName, ZipCode, CityName, CountryName, CountryCode, IsSendingEmail, IsSendingFax, CommunicationLanguages, Timezone";
        public string B_Header = "TimeStamp, Version, BookingCount";
        public string B_Access = "BookerID, BookingStatus";
        public string B_Booking = "BookingNo, CheckOut";
        public string B_Addition = "CorrelationID, ResStatus, TimeZone";
        public string B_AllowedServiceCodes = "ServiceCodes";

        public string I_Data = "InvoiceDate, GrossAmount, CurrencyCode, ReadyVTI, IsParking";
        public string I_Position = "ServiceDate, ServiceCode, AmountBeforeTax, AmountAfterTax, TaxRate, IsAllowed";
        public string I_Delivery = "Type";
        public string I_DeliveryNotification = "From, To, SendDate";
        public string I_DataSendTraveler = "SendDate, IsSuccess";
        public string I_Image = "ImageStatus";

        public string F_Header = "FileType, ProductionsDate, ProductionTime, Version, TransactionCount, IsDelivery";
        public string F_Transaction = "DocumentNo, ReservationNumber, HotelName, FinancialStatus, ProcessStatus";
        
        public string N_BillingEmail = "Type, ReceivingDate";
        public string N_Collection = "From, To, SendDate, FaxID, IsSuccess";
        public string N_PhoneCall = "From";
        public string N_Rejection = "From, To, SendDate, FaxID, IsSuccess";
        public string N_Remind = "From, To, SendDate, FaxID, IsSuccess";
        public string N_SentBox = "From, To, SendDate, FaxID, IsImportant,IsSuccess";
        public string N_Task = "ContactTo, ContactWay, Date, Priority, IsDone, DoneBy, Type";

        public string P_Step = "Step, StepStatus, ProcessedDate";
        public string P_NextStep = "Step, StepStatus, ExpectedTime";
        public string P_Validation = "Result";
    }


    public class P_DeletionData
    {
        //20
        public List<long> B_Access_ListID { get; set; }
        public List<long> B_AccessDetail_ListID { get; set; }
        public List<long> B_Addition_ListID { get; set; }
        public List<long> B_AllowedServiceCodes_ListID { get; set; }
        public List<long> B_Booker_ListID { get; set; }
        public List<B_Booking> B_Booking_List { get; set; }
        public List<long> B_Booking_ListID { get; set; }
        public List<long> B_BookingDetail_ListID { get; set; }
        public List<long> B_Comment_ListID { get; set; }
        public List<long> B_Company_ListID { get; set; }
        public List<B_Header> B_Header_List { get; set; }
        public List<long> B_Header_ListID { get; set; }
        public List<long> B_History_ListID { get; set; }
        public List<long> B_Hotel_ListID { get; set; }
        public List<long> B_HotelContact_ListID { get; set; }
        public List<long> B_Pos_ListID { get; set; }
        public List<long> B_Rate_ListID { get; set; }
        public List<long> B_Suggestion_ListID { get; set; }
        public List<long> B_Traveler_ListID { get; set; }
        public List<long> B_KeyValuePairBooking_ListID { get; set; }
        public List<long> B_KeyValuePairBookingDetail_ListID { get; set; }

        public List<long> B_PaymentCard_ListID { get; set; }

        //11
        public List<F_Header> F_Header_List { get; set; }
        public List<long> F_Header_ListID { get; set; }
        public List<long> F_Relation_ListID { get; set; }
        public List<long> F_Transaction_ListID { get; set; }
        public List<long> F_Transaction_DeletedListID { get; set; }
        public List<long> F_TransactionAdditionAPC_ListID { get; set; }
       public List<F_VTISummary> F_VTISummary_List { get; set; }
        public List<long> F_VTISummary_ListID { get; set; }
        public List<long> F_VTITransaction_ListID { get; set; }
        public List<long> F_VTIZIB_ListID { get; set; }
        public List<long> F_VTIZIG_ListID { get; set; }

        //21
        public List<long> I_Data_ListID { get; set; }
        public List<long> I_DataSendTraveler_ListID { get; set; }
        public List<long> I_Delivery_ListID { get; set; }
        public List<long> I_DeliveryDetail_ListID { get; set; }
        public List<I_DeliveryNotification> I_DeliveryNotification_List { get; set; }
        public List<long> I_DeliveryNotification_ListID { get; set; }
        public List<long> I_Error_ListID { get; set; }
        public List<I_Forward> I_Forward_List { get; set; }
        public List<long> I_Forward_ListID { get; set; }
        public List<long> I_ForwardLine_ListID { get; set; }
        public List<I_Image> I_Image_List { get; set; }
        public List<long> I_Image_ListID { get; set; }
        public List<I_Image> I_Image_DeletedList { get; set; }
        public List<long> I_ImageDelivery_ListID { get; set; }
        public List<I_Import> I_Import_List { get; set; }
        public List<long> I_Import_ListID { get; set; }
        public List<long> I_PageToImage_ListID { get; set; }
        public List<long> I_Position_ListID { get; set; }
        public List<long> I_Relation_ListID { get; set; }
        public List<long> I_Replace_ListID { get; set; }
        public List<long> I_Tax_ListID { get; set; }

        public List<long> I_Suggestion_ListID { get; set; }
        
        //5
        public List<long> H_I_Data_ListID { get; set; }
        public List<long> H_I_Position_ListID { get; set; }
        public List<long> H_I_Tax_ListID { get; set; }
        public List<long> H_P_InvoiceError_ListID { get; set; }
        public List<long> H_P_Validation_ListID { get; set; }
       
        //22
        public List<long> N_AttachmentPage_ListID { get; set; }
        public List<N_AttachmentPage> N_AttachmentPage_List { get; set; }
        public List<long> N_BillingEmail_ListID { get; set; }
        public List<N_BillingEmailAddition> N_BillingEmailAddition_List { get; set; }
        public List<long> N_BillingEmailAddition_ListID { get; set; }
        public List<long> N_BillingEmailAttachment_ListID { get; set; }

        public List<N_BillingEmailAttachment> N_BillingEmailAttachment_List { get; set; }
        public List<long> N_BillingEmailDetail_ListID { get; set; }
        public List<long> N_BookingBillingEmail_ListID { get; set; }
        public List<N_SentBoxAttachment> N_SentBoxAttachment_List { get; set; }
        public List<long> N_BookingSentBox_ListID { get; set; }
        public List<long> N_Collection_ListID { get; set; }
        public List<long> N_Information_ListID { get; set; }
        public List<long> N_InformationAttachment_ListID { get; set; }
        public List<N_InformationAttachment> N_InformationAttachment_List { get; set; }
        public List<long> N_InformationDetail_ListID { get; set; }
        public List<long> N_PhoneCall_ListID { get; set; }
        public List<long> N_Rejection_ListID { get; set; }
        public List<long> N_Remind_ListID { get; set; }
        public List<long> N_SentBox_ListID { get; set; }
        public List<long> N_SentBoxAttachment_ListID { get; set; }
        public List<long> N_SkipNotification_ListID { get; set; }
        public List<long> N_Task_ListID { get; set; }

        public List<long> N_CostAcceptance_ListID { get; set; }
        
        //8
        public List<long> P_BookingStep_ListID { get; set; }
        public List<long> P_FinancialStep_ListID { get; set; }
        public List<long> P_InvoiceError_ListID { get; set; }
        public List<long> P_InvoiceStep_ListID { get; set; }
        public List<long> P_NextBookingStep_ListID { get; set; }
        public List<long> P_NextFinancialStep_ListID { get; set; }
        public List<long> P_NextInvoiceStep_ListID { get; set; }
        public List<long> P_Validation_ListID { get; set; }

        public P_DeletionData()
        {
            B_Access_ListID = new List<long>();
            B_AccessDetail_ListID = new List<long>();
            B_Addition_ListID = new List<long>();
            B_AllowedServiceCodes_ListID = new List<long>();
            B_Booker_ListID = new List<long>();
            B_Booking_List = new List<B_Booking>();
            B_Booking_ListID = new List<long>();
            B_BookingDetail_ListID = new List<long>();
            B_Comment_ListID = new List<long>();
            B_Company_ListID = new List<long>();
            B_Header_List = new List<B_Header>();
            B_Header_ListID = new List<long>();
            B_History_ListID = new List<long>();
            B_Hotel_ListID = new List<long>();
            B_HotelContact_ListID = new List<long>();
            B_Pos_ListID = new List<long>();
            B_Rate_ListID = new List<long>();
            B_Suggestion_ListID = new List<long>();
            B_Traveler_ListID = new List<long>();
            B_KeyValuePairBooking_ListID = new List<long>();
            B_KeyValuePairBookingDetail_ListID = new List<long>();
            B_PaymentCard_ListID = new List<long>();
            
            F_Header_ListID = new List<long>();
            F_Relation_ListID = new List<long>();
            F_Transaction_ListID = new List<long>();
            F_TransactionAdditionAPC_ListID = new List<long>();
            F_VTISummary_List = new List<F_VTISummary>();
            F_VTISummary_ListID = new List<long>();
            F_VTITransaction_ListID = new List<long>();
            F_VTIZIB_ListID = new List<long>();
            F_VTIZIG_ListID = new List<long>();
            
            I_Data_ListID = new List<long>();
            I_DataSendTraveler_ListID = new List<long>();
            I_Delivery_ListID = new List<long>();
            I_DeliveryDetail_ListID = new List<long>();
            I_DeliveryNotification_List = new List<I_DeliveryNotification>();
            I_DeliveryNotification_ListID = new List<long>();
            I_Error_ListID = new List<long>();
            I_Forward_List = new List<I_Forward>();
            I_Forward_ListID = new List<long>();
            I_ForwardLine_ListID = new List<long>();
            I_Image_List = new List<I_Image>();
            I_Image_ListID = new List<long>();
            I_Image_DeletedList = new List<I_Image>();
            I_ImageDelivery_ListID = new List<long>();
            I_Import_List = new List<I_Import>();
            I_Import_ListID = new List<long>();
            I_PageToImage_ListID = new List<long>();
            I_Position_ListID = new List<long>();
            I_Relation_ListID = new List<long>();
            I_Replace_ListID = new List<long>();
            I_Tax_ListID = new List<long>();
            I_Suggestion_ListID = new List<long>();
            
            H_I_Data_ListID = new List<long>();
            H_I_Position_ListID = new List<long>();
            H_I_Tax_ListID = new List<long>();
            H_P_InvoiceError_ListID = new List<long>();
            H_P_Validation_ListID = new List<long>();
            
            N_AttachmentPage_ListID = new List<long>();
            N_AttachmentPage_List = new List<N_AttachmentPage>();
            N_BillingEmail_ListID = new List<long>();
            N_BillingEmailAddition_List = new List<N_BillingEmailAddition>();
            N_BillingEmailAddition_ListID = new List<long>();
            N_BillingEmailAttachment_ListID = new List<long>();
            N_BillingEmailAttachment_List = new List<N_BillingEmailAttachment>();
            N_BillingEmailDetail_ListID = new List<long>();
            N_BookingBillingEmail_ListID = new List<long>();
            N_BookingSentBox_ListID = new List<long>();
            N_Collection_ListID = new List<long>();
            N_Information_ListID = new List<long>();
            N_InformationAttachment_ListID = new List<long>();
            N_InformationAttachment_List = new List<N_InformationAttachment>();
            N_InformationDetail_ListID = new List<long>();
            N_PhoneCall_ListID = new List<long>();
            N_Rejection_ListID = new List<long>();
            N_Remind_ListID = new List<long>();
            N_SentBox_ListID = new List<long>();
            N_SentBoxAttachment_List = new List<N_SentBoxAttachment>();
            N_SentBoxAttachment_ListID = new List<long>();
            N_SkipNotification_ListID = new List<long>();
            N_Task_ListID = new List<long>();
            N_CostAcceptance_ListID = new List<long>();
            
            P_BookingStep_ListID = new List<long>();
            P_FinancialStep_ListID = new List<long>();
            P_InvoiceError_ListID = new List<long>();
            P_InvoiceStep_ListID = new List<long>();
            P_NextBookingStep_ListID = new List<long>();
            P_NextFinancialStep_ListID = new List<long>();
            P_NextInvoiceStep_ListID = new List<long>();
            P_Validation_ListID = new List<long>();

        }

    }


    public class P_Deleteion
    {
        public string TableName { get; set; }

        public string ColumnNotDelete { get; set; }

        public string ListID { get; set; }
    }

    public class P_ArchiveBooking : B_Booking
    {
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        private DateTime timeStamp;

        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        private string reservationNo;

        public string ReservationNo
        {
            get { return reservationNo; }
            set { reservationNo = value; }
        }

        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private string hotelNo;

        public string HotelNo
        {
            get { return hotelNo; }
            set { hotelNo = value; }
        }

        private string hoteAddress;

        public string HoteAddress
        {
            get { return hoteAddress; }
            set { hoteAddress = value; }
        }


        private string hotelZipCode;

        public string HotelZipCode
        {
            get { return hotelZipCode; }
            set { hotelZipCode = value; }
        }
        private string hotelCity;

        public string HotelCity
        {
            get { return hotelCity; }
            set { hotelCity = value; }
        }
        private string hotelCountry;

        public string HotelCountry
        {
            get { return hotelCountry; }
            set { hotelCountry = value; }
        }
        private string hotelPhone;

        public string HotelPhone
        {
            get { return hotelPhone; }
            set { hotelPhone = value; }
        }
        private string hotelFax;

        public string HotelFax
        {
            get { return hotelFax; }
            set { hotelFax = value; }
        }
        private string hotelEmail;

        public string HotelEmail
        {
            get { return hotelEmail; }
            set { hotelEmail = value; }
        }

        private string hotelVATNumber;

        public string HotelVATNumber
        {
            get { return hotelVATNumber; }
            set { hotelVATNumber = value; }
        }

        private string hotelContact;

        public string HotelContact
        {
            get { return hotelContact; }
            set { hotelContact = value; }
        }
        private string travelerName;

        public string TravelerName
        {
            get { return travelerName; }
            set { travelerName = value; }
        }
        private string booker;

        public string Booker
        {
            get { return booker; }
            set { booker = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private string companyAddress;

        public string CompanyAddress
        {
            get { return companyAddress; }
            set { companyAddress = value; }
        }
        private string companyZipCode;

        public string CompanyZipCode
        {
            get { return companyZipCode; }
            set { companyZipCode = value; }
        }
        private string companyCity;

        public string CompanyCity
        {
            get { return companyCity; }
            set { companyCity = value; }
        }
        private string companyCountryCode;

        public string CompanyCountryCode
        {
            get { return companyCountryCode; }
            set { companyCountryCode = value; }
        }


        private string companyDateFormat;

        public string CompanyDateFormat
        {
            get { return companyDateFormat; }
            set { companyDateFormat = value; }
        }

        private string serviceCode;

        public string ServiceCode
        {
            get { return serviceCode; }
            set { serviceCode = value; }
        }

    }


    public class P_B_BookingDetailArchiving : B_BookingDetail
    {
        private string travelerName;

        public string TravelerName
        {
            get { return travelerName; }
            set { travelerName = value; }
        }
        private string roomCategory;

        public string RoomCategory
        {
            get { return roomCategory; }
            set { roomCategory = value; }
        }
    }

    public class N_InformationArchiving : N_Information
    {
        private string listAttachment;

        public string ListAttachment
        {
            get { return listAttachment; }
            set { listAttachment = value; }
        }

        private string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
    }


    public class N_SentBoxArchiving : N_SentBox
    {
        private long b_AccessID;

        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }

        private string listAttachment;

        public string ListAttachment
        {
            get { return listAttachment; }
            set { listAttachment = value; }
        }

        private string listOriginalFileName;

        public string ListOriginalFileName
        {
            get { return listOriginalFileName; }
            set { listOriginalFileName = value; }
        }

    }

    //public class N_RemindArchiving : N_Remind
    //{
    //    private string listAttachment;

    //    public string ListAttachment
    //    {
    //        get { return listAttachment; }
    //        set { listAttachment = value; }
    //    } 
    //}

    //public class N_CollectionArchiving: N_Collection
    //{
    //    private string listAttachment;

    //    public string ListAttachment
    //    {
    //        get { return listAttachment; }
    //        set { listAttachment = value; }
    //    } 
    //}

    public class N_RejectionArchiving : N_Rejection
    {
        private string invoiceNo;

        public string InvoiceNo
        {
            get { return invoiceNo; }
            set { invoiceNo = value; }
        }

        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

    }


    public class P_DeletionNotification
    {
        private string subject;
        private string from;
        private string to;
        private string faxID;
        private string body;
        private DateTime sendDate;
    }


    public class P_NotificationHistoryArchiving
    {
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }



        private DateTime sendDate;

        public DateTime SendDate
        {
            get { return sendDate; }
            set { sendDate = value; }
        }
        
    }

    public enum P_DeletionProcedure
    {
        p_Common_Deleting,
        p_Common_PhysicalDeleting,
        p_Common_GetData_ForDeleting,

    }


    public enum ArchivingEmailType
    {
        Remind,
        Collection,
        Rejection,
        CheckOutMail,
        Information,
        SentBox,
        BillingEmail,
        CustomerInvoiceGateway,
    }
}
