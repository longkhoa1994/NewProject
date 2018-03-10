using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class P_SendRequestDBI : P_NextInvoiceStep
    {
        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        private string pDFFilename;

        public string PDFFilename
        {
            get { return pDFFilename; }
            set { pDFFilename = value; }
        }
        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
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

        private long m_CompanyID;

        public long M_CompanyID
        {
            get { return m_CompanyID; }
            set { m_CompanyID = value; }
        }
        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private long parentID;

        public long ParentID
        {
            get { return parentID; }
            set { parentID = value; }
        }
        private long m_LanguageID;

        public long M_LanguageID
        {
            get { return m_LanguageID; }
            set { m_LanguageID = value; }
        }
        private long m_ProcessID;

        public long M_ProcessID
        {
            get { return m_ProcessID; }
            set { m_ProcessID = value; }
        }
        private string ariPlusLogo;

        public string AriPlusLogo
        {
            get { return ariPlusLogo; }
            set { ariPlusLogo = value; }
        }
        private string t2PLogo;

        public string T2PLogo
        {
            get { return t2PLogo; }
            set { t2PLogo = value; }
        }
        private string hotelLogo;

        public string HotelLogo
        {
            get { return hotelLogo; }
            set { hotelLogo = value; }
        }
        private string companyLogo;

        public string CompanyLogo
        {
            get { return companyLogo; }
            set { companyLogo = value; }
        }
        private string mailServer;

        public string MailServer
        {
            get { return mailServer; }
            set { mailServer = value; }
        }
        private string mailUsername;

        public string MailUsername
        {
            get { return mailUsername; }
            set { mailUsername = value; }
        }
        private string mailPassword;

        public string MailPassword
        {
            get { return mailPassword; }
            set { mailPassword = value; }
        }
        private string m_HotelPlatformName;

        public string HotelPlatformName
        {
            get { return m_HotelPlatformName; }
            set { m_HotelPlatformName = value; }
        }
        private string cityName;

        public string CityName
        {
            get { return cityName; }
            set { cityName = value; }
        }
        private string zIPCode;

        public string ZIPCode
        {
            get { return zIPCode; }
            set { zIPCode = value; }
        }
        private string companyAddress;

        public string CompanyAddress
        {
            get { return companyAddress; }
            set { companyAddress = value; }
        }
        private string faxNumber;

        public string FaxNumber
        {
            get { return faxNumber; }
            set { faxNumber = value; }
        }
        private long m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return m_HotelPlatformID; }
            set { m_HotelPlatformID = value; }
        }
        private long m_CompanyProcessID;

        public long M_CompanyProcessID
        {
            get { return m_CompanyProcessID; }
            set { m_CompanyProcessID = value; }
        }

        private string iISPathHotelPlatform;

        public string IISPathHotelPlatform
        {
            get { return iISPathHotelPlatform; }
            set { iISPathHotelPlatform = value; }
        }

        private string iPLocalPathHotelPlatform;

        public string IPLocalPathHotelPlatform
        {
            get { return iPLocalPathHotelPlatform; }
            set { iPLocalPathHotelPlatform = value; }
        }
        private string iISPathCompany;

        public string IISPathCompany
        {
            get { return iISPathCompany; }
            set { iISPathCompany = value; }
        }

        private string iPLocalPathCompany;

        public string IPLocalPathCompany
        {
            get { return iPLocalPathCompany; }
            set { iPLocalPathCompany = value; }
        }
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private long i_DataID;

        public long I_DataID
        {
            get { return i_DataID; }
            set { i_DataID = value; }
        }
    }
}
