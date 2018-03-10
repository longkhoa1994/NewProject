using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_ForwardBooking
    {
        private B_Booker b_Booker;
        public B_Booker B_Booker
        {
            get { return b_Booker; }
            set { b_Booker = value; }
        }

        private M_Company m_Company;
        public M_Company M_Company
        {
            get { return m_Company; }
            set { m_Company = value; }
        }

        private M_Hotel m_Hotel;
        public M_Hotel M_Hotel
        {
            get { return m_Hotel; }
            set { m_Hotel = value; }
        }

        private M_Country m_Country;
        public M_Country M_Country
        {
            get { return m_Country; }
            set { m_Country = value; }
        }

        private M_HotelPlatform m_HotelPlatform;
        public M_HotelPlatform M_HotelPlatform
        {
            get { return m_HotelPlatform; }
            set { m_HotelPlatform = value; }
        }

        private M_Process m_Process;
        public M_Process M_Process 
        {
            get { return m_Process; }
            set { m_Process = value; }
        }

        private B_Booking b_Booking;
        public B_Booking B_Booking
        {
            get { return b_Booking; }
            set { b_Booking = value; }
        }
    }

   
}
