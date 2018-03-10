using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class P_RImportBookingHeader
    {
        R_B_Header r_B_Header;

        public R_B_Header R_B_Header
        {
            get { return r_B_Header; }
            set { r_B_Header = value; }
        }
        List<P_RImportBooking> listR_Booking;
        public List<P_RImportBooking> ListR_Booking
        {
            get { return listR_Booking; }
            set { listR_Booking = value; }
        }
    }

    [Serializable]
    public class P_RImportBooking
    {
        R_B_Access r_B_Access;

        public R_B_Access R_B_Access
        {
            get { return r_B_Access; }
            set { r_B_Access = value; }
        }

        R_B_Booking r_B_Booking;

        public R_B_Booking R_B_Booking
        {
            get { return r_B_Booking; }
            set { r_B_Booking = value; }
        }
        R_B_Booking r_B_BookingOld;
        public R_B_Booking R_B_BookingOld
        {
            get { return r_B_BookingOld; }
            set { r_B_BookingOld = value; }
        }
        M_Traveler m_Traveler;

        public M_Traveler M_Traveler
        {
            get { return m_Traveler; }
            set { m_Traveler = value; }
        }


        M_Company m_Company;

        public M_Company M_Company
        {
            get { return m_Company; }
            set { m_Company = value; }
        }
        List<R_F_Transaction> transactionList;

        public List<R_F_Transaction> TransactionList
        {
            get { return transactionList; }
            set { transactionList = value; }
        }

        List<R_P_NextFinancialStep> stepList;

        public List<R_P_NextFinancialStep> StepList
        {
            get { return stepList; }
            set { stepList = value; }
        }

        public string ReservationStatus { get; set; }

        R_B_Header r_B_Header;

        public R_B_Header R_B_Header
        {
            get { return r_B_Header; }
            set { r_B_Header = value; }
        }


        public P_RImportBooking()
        {
            TransactionList = new List<R_F_Transaction>();
            StepList = new List<R_P_NextFinancialStep>();
        }

    }
}
