using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._3.CarRental._7.Process
{
    public class R_P_NextInvoiceStep_SendApproval :R_P_NextInvoiceStep
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
        string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private long m_LanguageID;

        public long M_LanguageID
        {
            get { return m_LanguageID; }
            set { m_LanguageID = value; }
        }

        long m_CarRentalProviderID;

        public long M_CarRentalProviderID
        {
            get { return m_CarRentalProviderID; }
            set { m_CarRentalProviderID = value; }
        }
        long _r_M_PlatformID;

        public long R_M_PlatformID
        {
            get { return _r_M_PlatformID; }
            set { _r_M_PlatformID = value; }
        }
        string carRentalName;

        public string CarRentalName
        {
            get { return carRentalName; }
            set { carRentalName = value; }
        }
        DateTime pickUpTime;

        public DateTime PickUpTime
        {
            get { return pickUpTime; }
            set { pickUpTime = value; }
        }
        decimal startingKM;

        public decimal StartingKM
        {
            get { return startingKM; }
            set { startingKM = value; }
        }
        string pickUpLocation;

        public string PickUpLocation
        {
            get { return pickUpLocation; }
            set { pickUpLocation = value; }
        }
        string countryPickup;

        public string CountryPickup
        {
            get { return countryPickup; }
            set { countryPickup = value; }
        }
        DateTime returnTime;

        public DateTime ReturnTime
        {
            get { return returnTime; }
            set { returnTime = value; }
        }
        string countryReturn;


        private decimal returnKM;

        public decimal ReturnKM
        {
            get { return returnKM; }
            set { returnKM = value; }
        }

        public string CountryReturn
        {
            get { return countryReturn; }
            set { countryReturn = value; }
        }
        string ariPlusLogo;

        public string AriPlusLogo
        {
            get { return ariPlusLogo; }
            set { ariPlusLogo = value; }
        }

        public string  IISSmartBillingLogo { get; set; }

        string t2PLogo;

        public string T2PLogo
        {
            get { return t2PLogo; }
            set { t2PLogo = value; }
        }
        string hotelLogo;

        public string HotelLogo
        {
            get { return hotelLogo; }
            set { hotelLogo = value; }
        }
        string companyLogo;

        public string CompanyLogo
        {
            get { return companyLogo; }
            set { companyLogo = value; }
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
        string faxNumber;

        public string FaxNumber
        {
            get { return faxNumber; }
            set { faxNumber = value; }
        }
        string iISPathCompany;

        public string IISPathCompany
        {
            get { return iISPathCompany; }
            set { iISPathCompany = value; }
        }
        string iPLocalPathCompany;

        public string IPLocalPathCompany
        {
            get { return iPLocalPathCompany; }
            set { iPLocalPathCompany = value; }
        }
        bool isReplace;

        public bool IsReplace
        {
            get { return isReplace; }
            set { isReplace = value; }
        }

        public string ReturnLocation { get; set; }

        public decimal GrossAmount { get; set; }

        public string IISPathHotelPlatform { get; set; }

        public string IPLocalPathHotelPlatform { get; set; }

        public string Currency { get; set; }

        public decimal BillingAmount { get; set; }

        public string BillingCurrency { get; set; }

        public int NumberCheckOutMail { get; set; }

        private string _carProcess;

        public string CarProcess
        {
            get { return _carProcess; }
            set { _carProcess = value; }
        }

        private bool _hasRateGrid;
        public bool HasRateGrid
        {
            get { return _hasRateGrid; }
            set { _hasRateGrid = value; }
        }

        public string ImageType { get; set; }

        public bool HasAtt { get; set; }

        public bool IsDebitError { get; set; }

        public string ImageStatus { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }
        public string ImageFilePath { get; set; }

        public string MOPCode { get; set; }

        public string EmailApproval { get; set; }
        public string InvoiceNumber { get; set; }
    }
}
