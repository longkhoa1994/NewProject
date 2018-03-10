using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class R_P_Escalation : R_I_Data
    {
        private long r_B_AccessID;

        public long R_B_AccessID
        {
            get { return r_B_AccessID; }
            set { r_B_AccessID = value; }
        }
        string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private long r_I_dataID;

        public long R_I_dataID
        {
            get { return r_I_dataID; }
            set { r_I_dataID = value; }
        }

        string travelerName;

        public string TravelerName
        {
            get { return travelerName; }
            set { travelerName = value; }
        }

        string travelerEmail;

        public string TravelerEmail
        {
            get { return travelerEmail; }
            set { travelerEmail = value; }
        }

        long m_CompanyID;

        public long M_CompanyID
        {
            get { return m_CompanyID; }
            set { m_CompanyID = value; }
        }
        string companyNameGroup;

        public string CompanyNameGroup
        {
            get { return companyNameGroup; }
            set { companyNameGroup = value; }
        }

        string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        long m_CarRentalProviderID;

        public long M_CarRentalProviderID
        {
            get { return m_CarRentalProviderID; }
            set { m_CarRentalProviderID = value; }
        }
       
        string carRentalName;

        public string CarRentalName
        {
            get { return carRentalName; }
            set { carRentalName = value; }
        }

        DateTime pickUpDate;

        public DateTime PickupDate
        {
            get { return pickUpDate; }
            set { pickUpDate = value; }
        }

        bool isReplace;

        public bool IsReplace
        {
            get { return isReplace; }
            set { isReplace = value; }
        }

        string mailServer;

        public string MailServer
        {
            get { return mailServer; }
            set { mailServer = value; }
        }
        string mailUsername;

        public string MailUsername
        {
            get { return mailUsername; }
            set { mailUsername = value; }
        }
        string mailPassword;

        public string MailPassword
        {
            get { return mailPassword; }
            set { mailPassword = value; }
        }
        public DateTime ClaimDate { get; set; }

        public long R_M_PlatformID { get; set; }

        public long NewID { get; set; }

        public long R_N_RejectionID { get; set; }

        public string  EmailEscalation { get; set; }

        public string IISSmartBillingLogo { get; set; }
    }

    public class R_P_Escalation_Information
    {
        public List<R_N_EscalationRejection> List_R_N_EscalationRejection { get; set; }

        public R_N_Rejection R_N_Rejection { get; set; }

        public R_N_Escalation R_N_Escalation { get; set; }

        public R_P_Escalation_Information()
        {
            List_R_N_EscalationRejection = new List<R_N_EscalationRejection>();
        }
    }

    
    
}
