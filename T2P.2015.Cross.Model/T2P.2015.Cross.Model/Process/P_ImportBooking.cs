using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Model;

namespace T2P._2015.Cross.Model
{
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


    }



    public class P_ImportBooking
    {

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
        private B_Booker b_Booker;

        public B_Booker B_Booker
        {
            get { return b_Booker; }
            set { b_Booker = value; }
        }

        private M_Traveler m_Booker;

        public M_Traveler Booker
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

        private bool isProcess;

        public bool IsProcess
        {
            get { return isProcess; }
            set { isProcess = value; }
        }

        private bool isSendHotelPlatfom;

        public bool IsSendHotelPlatform
        {
            get { return isSendHotelPlatfom; }
            set { isSendHotelPlatfom = value; }
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


        private List<P_NextFinancialStep> listP_NextFinancialStep;

        public List<P_NextFinancialStep> ListP_NextFinancialStep
        {
            get { return listP_NextFinancialStep; }
            set { listP_NextFinancialStep = value; }
        }


        public P_ImportBooking()
        {
            IsProcess = true;
            Error = new List<string>();
            ErrorServiceCenter = new List<string>();
            B_HistoryList = new B_HistoryList();
            F_TransactionList = new F_TransactionList();
            ListNextBookingStepInsert = new List<P_NextBookingStep>();
            ListBookingStepInsert = new List<P_BookingStep>();

            ListBookingStepDelete = new List<P_BookingStep>();

            ListNextBookingStepDelete = new List<P_NextBookingStep>();
            ListN_Task = new List<N_Task>();

            F_TransactionListBackCharge = new F_TransactionList();

            ListP_NextFinancialStep = new List<P_NextFinancialStep>();
            ListM_HotelProcess = new List<M_HotelProcess>();
        }

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
