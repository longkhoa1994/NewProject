using System.Collections.Generic;
using T2P._2015.Cross.Model._2.Hotel.Process;
using T2P._2015.Model;

namespace T2P._2015.Cross.Model
{
    public class P_ImportBooking_Header_CWT
    {
        public B_Header B_Header { get; set; }
        public List<P_ImportBooking_CWT> ListBooking { get; set; }

        public P_ImportBooking_Header_CWT()
        {
            ListBooking = new List<P_ImportBooking_CWT>();
        }
    }

    public class P_ImportBooking_CWT
    {
        public B_Booking BBooking { get; set; }
        public B_BookingDetail BBookingDetail { get; set; }
        public B_Hotel BHotel { get; set; }
        public B_Traveler BTraveler { get; set; }
        public B_Booker BBooker { get; set; }
        public B_Access BAccess { get; set; }
        public B_AccessDetail BAccessDetail { get; set; }
        public B_Company BCompany { get; set; }
        public M_Company MCompany { get; set; }
        public M_Hotel MHotel { get; set; }
        public M_Traveler MBooker { get; set; }
        public M_Traveler MTraveler { get; set; }
        public P_BookingStep BookingStep { get; set; }
        public List<M_HotelProcess> ListHotelProcess { get; set; }
        public List<M_HotelPayment> ListHotelPayment { get; set; }
        public N_Task TaskwithoutFax { get; set; }

        public List<M_HotelContact> hotelContract { get; set; }

        public P_ImportBooking_CWT()
        {
            ListHotelProcess = new List<M_HotelProcess>();
            ListHotelPayment = new List<M_HotelPayment>();
            hotelContract = new List<M_HotelContact>();
        }
    }

    public class ImportBookingQueue
    {
        public List<P_NextBookingStep> ListNextBookingStep;
        public P_ImportBookingHeader P_ImportBookingHeader;
        public long userID;

        public ImportBookingQueue()
        {
            ListNextBookingStep = new List<P_NextBookingStep>();
            P_ImportBookingHeader = new P_ImportBookingHeader();
        }
    }

    public class UpdateBookingHotelzonQueue
    {
        public string TransactionNo { get; set; }
    }







    //         
    //         if (listBBookingDetailDetail != null && listBBookingDetailDetail.Count > 0)
    //         {
    //             foreach (B_BookingDetail bBookingDetail in listBBookingDetailDetail)
    //             {
    //                 dynamic bBookingDetailID = new Dynamic();
    //                 bBookingDetailID.B_BookingDetailID = bBookingDetail.ID;
    //                 luePairBookingDetailProcedure.p_B_KeyValuePairBookingDetail_Get_By_B_BookingDetailID.ToString(), bBookingDetailID);
    //             }
    //         }

    public class P_DeleteBooking_Hotelzon
    {
        public B_Booking B_Booking { get; set; }
        public B_Access B_Access { get; set; }
        public B_Company B_Company { get; set; }
        public B_Hotel B_Hotel { get; set; }
        public B_Addition B_Addition { get; set; }
        public B_PaymentCard B_PaymentCard { get; set; }
        public B_Booker B_Booker { get; set; }
        public B_Pos B_Pos { get; set; }
        public B_KeyValuePairBookingDetail B_KeyValuePairBookingDetail { set; get; }
        public List<N_CostAcceptance> ListN_CostAcceptance { get; set; }
        public List<B_History> ListB_History { get; set; }
        public List<B_AccessDetail> ListB_AccessDetail { get; set; }
        public List<B_HotelContact> ListB_HotelContact { get; set; }
        public List<B_AllowedServiceCodes> ListB_AllowedServiceCodes { get; set; }
        public List<B_BookingDetail> ListB_BookingDetail { get; set; }
        public List<B_Traveler> ListB_Traveler { get; set; }
        public List<B_Rate> ListB_Rate { get; set; }
        public List<P_BookingStep> ListP_BookingStep { get; set; }
        public List<P_NextBookingStep> ListP_NextBookingStep { get; set; }
        public List<B_DBI> ListB_DBI { get; set; }
        public P_DeleteBooking_Hotelzon()
        {
            ListN_CostAcceptance = new List<N_CostAcceptance>();
            ListP_BookingStep = new List<P_BookingStep>();
            ListP_NextBookingStep = new List<P_NextBookingStep>();
            ListB_DBI = new List<B_DBI>();
            ListB_History = new List<B_History>();
            ListB_AccessDetail = new List<B_AccessDetail>();
            ListB_HotelContact = new List<B_HotelContact>();
            ListB_AllowedServiceCodes = new List<B_AllowedServiceCodes>();
            ListB_BookingDetail = new List<B_BookingDetail>();
            ListB_Traveler = new List<B_Traveler>();
            ListB_Rate = new List<B_Rate>();
        }
    }

    public class P_ImportBookingHeader
    {
        private M_HotelPlatform m_HotelPlatform;

        public M_HotelPlatform M_HotelPlatform
        {
            get { return m_HotelPlatform; }
            set { m_HotelPlatform = value; }
        }

        private B_Header b_Header;

        public B_Header B_Header
        {
            get { return b_Header; }
            set { b_Header = value; }
        }

        private P_ImportBookingList p_ImportBookingList;

        public P_ImportBookingList P_ImportBookingList
        {
            get { return p_ImportBookingList; }
            set { p_ImportBookingList = value; }
        }

        public string MessageError { get; set; }

        public bool isImportSuccess { get; set; }
    }

    public class ResultImportBookingExcelFile
    {
        public bool IsSuccess { get; set; }

        public string ErrorMessage { get; set; }

        public int TotalBookingImport { get; set; }

        public List<P_ImportBooking> ListImportFail { get; set; }

        public ResultImportBookingExcelFile()
        {
            ListImportFail = new List<P_ImportBooking>();
        }
    }

    public class P_ImportBookingExcel
    {
        public List<P_ImportBooking> allBookings { get; set; }

        public List<P_NextBookingStep> listNextBookingSteps { get; set; }

        public List<P_ImportBookingHeader> listImportBookingHeader { get; set; }

        public bool IsSuccess { get; set; }

        public string ErrorMessage { get; set; }

        public P_ImportBookingExcel()
        {
            listNextBookingSteps = new List<P_NextBookingStep>();
            listImportBookingHeader = new List<P_ImportBookingHeader>();
            allBookings = new List<P_ImportBooking>();
        }


    }

    public class P_ImportBooking
    {
        public bool isCancelBookingStop { get; set; }
        public List<M_HotelProcess> ListHotelProcess { get; set; }
        public B_Header B_Header { get; set; }
        public bool isImportSuccess { get; set; }
        public List<M_HotelPayment> ListHotelPayment { get; set; }

        private List<B_AccessDetail> listBAccessDetail;
        public List<B_AccessDetail> ListBAccessDetail
        {
            get { return listBAccessDetail; }
            set { listBAccessDetail = value; }
        }

        public List<B_AllowedServiceCodes> ListAllowedServiceCode { get; set; }

        public List<long> m_listTravelerExists { get; set; }

        public List<M_Traveler> m_listTravelerNotExists { get; set; }

        private List<M_Traveler> m_listTraveler;

        public List<M_Traveler> m_ListTraveler
        {
            get { return m_listTraveler; }
            set { m_listTraveler = value; }
        }

        public List<B_Traveler> b_ListTraveler { get; set; }
        public bool isValid { get; set; }


        private M_CompanyDBI m_companyDBI;

        public M_CompanyDBI M_companyDBI
        {
            get { return m_companyDBI; }
            set { m_companyDBI = value; }
        }
        public string BookingStatus { get; set; }
        public string AllowedServiceCode { get; set; }

        private B_Access b_Access;

        public B_Access B_Access
        {
            get { return b_Access; }
            set { b_Access = value; }
        }

        private B_Booking b_Booking;

        public B_Booking B_Booking
        {
            get { return b_Booking; }
            set { b_Booking = value; }
        }

        private B_BookingDetail b_BookingDetail;

        public B_BookingDetail B_BookingDetail
        {
            get { return b_BookingDetail; }
            set { b_BookingDetail = value; }
        }

        private List<string> error;

        public List<string> Error
        {
            get { return error; }
            set { error = value; }
        }

        private List<string> errorServiceCenter;

        public List<string> ErrorServiceCenter
        {
            get { return errorServiceCenter; }
            set { errorServiceCenter = value; }
        }

        private B_KeyValuePairBooking b_KeyValuePairBooking;

        public B_KeyValuePairBooking B_KeyValuePairBooking
        {
            get { return b_KeyValuePairBooking; }
            set { b_KeyValuePairBooking = value; }
        }

        private P_ImportBookingDetailList p_ImportBookingDetailList;

        public P_ImportBookingDetailList P_ImportBookingDetailList
        {
            get { return p_ImportBookingDetailList; }
            set { p_ImportBookingDetailList = value; }
        }

        private B_PaymentCard b_PaymentCard;

        public B_PaymentCard B_PaymentCard
        {
            get { return b_PaymentCard; }
            set { b_PaymentCard = value; }
        }

        private B_PaymentCard b_PaymentCard2;

        public B_PaymentCard B_PaymentCard2
        {
            get { return b_PaymentCard2; }
            set { b_PaymentCard2 = value; }
        }

        private B_Addition b_Addition;

        public B_Addition B_Addition
        {
            get { return b_Addition; }
            set { b_Addition = value; }
        }

        private B_Hotel b_Hotel;

        public B_Hotel B_Hotel
        {
            get { return b_Hotel; }
            set { b_Hotel = value; }
        }

        private B_HotelContactList b_HotelContactList;

        public B_HotelContactList B_HotelContactList
        {
            get { return b_HotelContactList; }
            set { b_HotelContactList = value; }
        }

        private M_Hotel m_Hotel;

        public M_Hotel M_Hotel
        {
            get { return m_Hotel; }
            set { m_Hotel = value; }
        }

        private List<M_HotelPayment> listM_HotelPayment;

        public List<M_HotelPayment> ListM_HotelPayment
        {
            get { return listM_HotelPayment; }
            set { listM_HotelPayment = value; }
        }

        private List<M_HotelProcess> listM_HotelProcess;

        public List<M_HotelProcess> ListM_HotelProcess
        {
            get { return listM_HotelProcess; }
            set { listM_HotelProcess = value; }
        }

        private M_HotelContactList m_HotelContactList;

        public M_HotelContactList M_HotelContactList
        {
            get { return m_HotelContactList; }
            set { m_HotelContactList = value; }
        }

        private B_AllowedServiceCodesList b_AllowedServiceCodesList;

        public B_AllowedServiceCodesList B_AllowedServiceCodesList
        {
            get { return b_AllowedServiceCodesList; }
            set { b_AllowedServiceCodesList = value; }
        }

        private B_Pos b_Pos;

        public B_Pos B_Pos
        {
            get { return b_Pos; }
            set { b_Pos = value; }
        }

        private B_Company b_Company;

        public B_Company B_Company
        {
            get { return b_Company; }
            set { b_Company = value; }
        }

        private M_Company m_Company;

        public M_Company M_Company
        {
            get { return m_Company; }
            set { m_Company = value; }
        }

        private M_CompanyProcess m_CompanyProcess;

        public M_CompanyProcess M_CompanyProcess
        {
            get { return m_CompanyProcess; }
            set { m_CompanyProcess = value; }
        }

        private List<M_CompanyProcessDetail> m_CompanyProcessDetail;

        public List<M_CompanyProcessDetail> ListM_CompanyProcessDetail
        {
            get { return m_CompanyProcessDetail; }
            set { m_CompanyProcessDetail = value; }
        }

        private List<M_CompanyProcessSetting> m_CompanyProcessSettings;

        public List<M_CompanyProcessSetting> ListM_CompanyProcessSetting
        {
            get { return m_CompanyProcessSettings; }
            set { m_CompanyProcessSettings = value; }
        }

        private List<M_CompanyProcessSchedule> m_CompanyProcessSchedules;

        public List<M_CompanyProcessSchedule> ListM_CompanyProcessSchedule
        {
            get { return m_CompanyProcessSchedules; }
            set { m_CompanyProcessSchedules = value; }
        }


        private List<M_CompanyGeneralSetting> m_CompanyGeneralSetting;

        public List<M_CompanyGeneralSetting> ListM_CompanyGeneralSetting
        {
            get { return m_CompanyGeneralSetting; }
            set { m_CompanyGeneralSetting = value; }
        }

        public B_Traveler B_traveler { get; set; }


        private B_Booker b_Booker;

        public B_Booker B_Booker
        {
            get { return b_Booker; }
            set { b_Booker = value; }
        }

        private M_Traveler m_Booker;

        public M_Traveler M_Booker
        {
            get { return m_Booker; }
            set { m_Booker = value; }
        }

        private B_HistoryList b_HistoryList;

        public B_HistoryList B_HistoryList
        {
            get { return b_HistoryList; }
            set { b_HistoryList = value; }
        }

        private B_DBI b_DBI;

        public B_DBI B_DBI
        {
            get { return b_DBI; }
            set { b_DBI = value; }
        }

        public B_DBI B_DBIPCI { get; set; }

        private F_TransactionList f_TransactionList;

        public F_TransactionList F_TransactionList
        {
            get { return f_TransactionList; }
            set { f_TransactionList = value; }
        }

        private F_TransactionList f_TransactionListBackCharge;

        public F_TransactionList F_TransactionListBackCharge
        {
            get { return f_TransactionListBackCharge; }
            set { f_TransactionListBackCharge = value; }
        }

        private List<P_NextBookingStep> listNextBookingStepInsert;

        public List<P_NextBookingStep> ListNextBookingStepInsert
        {
            get { return listNextBookingStepInsert; }
            set { listNextBookingStepInsert = value; }
        }

        private List<P_NextBookingStep> listNextBookingStepDelete;

        public List<P_NextBookingStep> ListNextBookingStepDelete
        {
            get { return listNextBookingStepDelete; }
            set { listNextBookingStepDelete = value; }
        }

        private List<P_BookingStep> listBookingStepInsert;

        public List<P_BookingStep> ListBookingStepInsert
        {
            get { return listBookingStepInsert; }
            set { listBookingStepInsert = value; }
        }

        private List<P_BookingStep> listBookingStepDelete;

        public List<P_BookingStep> ListBookingStepDelete
        {
            get { return listBookingStepDelete; }
            set { listBookingStepDelete = value; }
        }

        public string PaymentProvider { get; set; }

        private bool isProcess;

        public bool IsProcess
        {
            get { return isProcess; }
            set { isProcess = value; }
        }

        public bool IsPCI { get; set; }
        public bool IsECS { get; set; }

        private bool isSendHotelPlatfom;

        public bool IsSendHotelPlatform
        {
            get { return isSendHotelPlatfom; }
            set { isSendHotelPlatfom = value; }
        }

        private bool isUpdateCompany;

        public bool IsUpdateCompany
        {
            get { return isUpdateCompany; }
            set { isUpdateCompany = value; }
        }

        private bool isUpdateFinCLO;

        public bool IsUpdateFinCLO
        {
            get { return isUpdateFinCLO; }
            set { isUpdateFinCLO = value; }
        }

        private bool isSendServiceCenter;

        public bool IsSendServiceCenter
        {
            get { return isSendServiceCenter; }
            set { isSendServiceCenter = value; }
        }

        private List<N_Task> listN_Task;

        public List<N_Task> ListN_Task
        {
            get { return listN_Task; }
            set { listN_Task = value; }
        }

        private List<N_Task> listN_TaskFaxAndEmail;

        public List<N_Task> ListN_TaskFaxAndEmail
        {
            get { return listN_TaskFaxAndEmail; }
            set { listN_TaskFaxAndEmail = value; }
        }

        public string ImportType { get; set; }
        public string ErrorDescr { get; set; }

        private List<P_NextFinancialStep> listP_NextFinancialStep;

        public List<P_NextFinancialStep> ListP_NextFinancialStep
        {
            get { return listP_NextFinancialStep; }
            set { listP_NextFinancialStep = value; }
        }
        public bool IsReactivate { get; set; }

        public P_ImportBooking()
        {
            isCancelBookingStop = false;
            b_Access = new B_Access();
            IsProcess = true;
            IsUpdateCompany = false;
            IsUpdateFinCLO = false;
            IsPCI = false;
            Error = new List<string>();
            ErrorServiceCenter = new List<string>();
            B_HistoryList = new B_HistoryList();
            F_TransactionList = new F_TransactionList();
            ListNextBookingStepInsert = new List<P_NextBookingStep>();
            ListBookingStepInsert = new List<P_BookingStep>();

            ListBookingStepDelete = new List<P_BookingStep>();

            ListNextBookingStepDelete = new List<P_NextBookingStep>();
            ListN_Task = new List<N_Task>();
            ListN_TaskFaxAndEmail = new List<N_Task>(); ;

            F_TransactionListBackCharge = new F_TransactionList();

            ListP_NextFinancialStep = new List<P_NextFinancialStep>();
            ListM_HotelProcess = new List<M_HotelProcess>();
            ListM_HotelPayment = new List<M_HotelPayment>();
            ListM_CompanyProcessDetail = new List<M_CompanyProcessDetail>();

            ListM_CompanyProcessSetting = new List<M_CompanyProcessSetting>();
            ListM_CompanyProcessSchedule = new List<M_CompanyProcessSchedule>();
            ListM_CompanyGeneralSetting = new List<M_CompanyGeneralSetting>();

            listTransactionRelation = new List<F_Relation>();

            m_companyDBI = new M_CompanyDBI();

            IsReactivate = false;
            m_ListTraveler = new List<M_Traveler>();
            b_ListTraveler = new List<B_Traveler>();
            ListAllowedServiceCode = new List<B_AllowedServiceCodes>();
            ListBAccessDetail = new List<B_AccessDetail>();
            m_listTravelerExists = new List<long>();
            m_listTravelerNotExists = new List<M_Traveler>();
            ListHotelProcess = new List<M_HotelProcess>();
            ListHotelPayment = new List<M_HotelPayment>();
        }

        //private M_CompanyAddition m_CompanyAddition;

        //public M_CompanyAddition M_CompanyAddition
        //{
        //    get { return m_CompanyAddition; }
        //    set { m_CompanyAddition = value; }
        //}

        public List<F_Relation> listTransactionRelation { get; set; }

        public bool IsUpdated { get; set; }
    }

    public class P_ImportBookingList : List<P_ImportBooking>
    {
    }

    public class P_ImportBookingDetail
    {
        private B_BookingDetail b_BookingDetail;

        public B_BookingDetail B_BookingDetail
        {
            get { return b_BookingDetail; }
            set { b_BookingDetail = value; }
        }

        private B_RateList b_RateList;

        public B_RateList B_RateList
        {
            get { return b_RateList; }
            set { b_RateList = value; }
        }

        private B_TravelerList b_TravelerList;

        public B_TravelerList B_TravelerList
        {
            get { return b_TravelerList; }
            set { b_TravelerList = value; }
        }

        private B_DBI b_DBIField;

        public B_DBI B_DBIField
        {
            get { return b_DBIField; }
            set { b_DBIField = value; }
        }

        private B_KeyValuePairBookingDetail b_KeyValuePairBookingDetail;

        public B_KeyValuePairBookingDetail B_KeyValuePairBookingDetail
        {
            get { return b_KeyValuePairBookingDetail; }
            set { b_KeyValuePairBookingDetail = value; }
        }

        private P_TravelerAccessList p_TravelerAccessList;

        public P_TravelerAccessList P_TravelerAccessList
        {
            get { return p_TravelerAccessList; }
            set { p_TravelerAccessList = value; }
        }
    }

    public class P_ImportBookingDetailList : List<P_ImportBookingDetail>
    {
    }

    public class P_TravellerAccess
    {
        private M_Traveler m_Traveler;

        public M_Traveler M_Traveler
        {
            get { return m_Traveler; }
            set { m_Traveler = value; }
        }

        private B_AccessDetail b_AccessDetail;

        public B_AccessDetail B_AccessDetail
        {
            get { return b_AccessDetail; }
            set { b_AccessDetail = value; }
        }
    }

    public class P_TravelerAccessList : List<P_TravellerAccess>
    {
    }
}