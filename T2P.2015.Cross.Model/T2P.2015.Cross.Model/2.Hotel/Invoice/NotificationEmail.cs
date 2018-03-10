using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Invoice
{
    public class NotificationEmail
    {
        long? i_ArchiveID;

        public long? I_ArchiveID
        {
            get { return i_ArchiveID; }
            set { i_ArchiveID = value; }
        }
        string platformLogo;

        public string PlatformLogo
        {
            get { return platformLogo; }
            set { platformLogo = value; }
        }
        string companyLogo;

        public string CompanyLogo
        {
            get { return companyLogo; }
            set { companyLogo = value; }
        }
        long? templateID;

        public long? TemplateID
        {
            get { return templateID; }
            set { templateID = value; }
        }


        string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }


        string bodyText;

        public string BodyText
        {
            get { return bodyText; }
            set { bodyText = value; }
        }


        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
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
        string hotelIP;

        public string HotelIP
        {
            get { return hotelIP; }
            set { hotelIP = value; }
        }
        string hotelIISPath;

        public string HotelIISPath
        {
            get { return hotelIISPath; }
            set { hotelIISPath = value; }
        }
        string companyIP;

        public string CompanyIP
        {
            get { return companyIP; }
            set { companyIP = value; }
        }
        string companyIISPath;

        public string CompanyIISPath
        {
            get { return companyIISPath; }
            set { companyIISPath = value; }
        }
        DateTime? startDate;

        public DateTime? StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        DateTime? endDate;

        public DateTime? EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        DateTime? deletionDate;

        public DateTime? DeletionDate
        {
            get { return deletionDate; }
            set { deletionDate = value; }
        }
        string hRSBillingFax;

        public string HRSBillingFax
        {
            get { return hRSBillingFax; }
            set { hRSBillingFax = value; }
        }
        string fileStatus;

        public string FileStatus
        {
            get { return fileStatus; }
            set { fileStatus = value; }
        }
        long? expiredIn;

        public long? ExpiredIn
        {
            get { return expiredIn; }
            set { expiredIn = value; }
        }

        string _period;

        public string Period
        {
            get { return _period; }
            set { _period = value; }
        }

        int _numberOfDay;

        public int NumberOfDay
        {
            get { return _numberOfDay; }
            set { _numberOfDay = value; }
        }

        public List<InvoiceDetail> ListInvoiceData;
        public List<FileDetail> listFile;

        int _hour;

        public int Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }
        private long? _i_ArchiveRequestID;

        public long? I_ArchiveRequestID
        {
            get { return _i_ArchiveRequestID; }
            set { _i_ArchiveRequestID = value; }
        }
        private int _platformType;

        public int PlatformType
        {
            get { return _platformType; }
            set { _platformType = value; }
        }
        private long _m_LanguageID;

        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
    }
}
