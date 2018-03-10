using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._3.CarRental._7.Process
{
    public class R_P_ComposeEmail
    {
    }

    public class R_B_Booking_Get_ForServiceCenterTemplate
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private long r_B_AccessID;

        public long R_B_AccessID
        {
            get { return r_B_AccessID; }
            set { r_B_AccessID = value; }
        }
        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }
        private DateTime pickupDate;

        public DateTime PickupDate
        {
            get { return pickupDate; }
            set { pickupDate = value; }
        }
        private string pickupTime;

        public string PickupTime
        {
            get { return pickupTime; }
            set { pickupTime = value; }
        }
        private string pickupCity;

        public string PickupCity
        {
            get { return pickupCity; }
            set { pickupCity = value; }
        }
        private string pickupCountry;

        public string PickupCountry
        {
            get { return pickupCountry; }
            set { pickupCountry = value; }
        }
        private DateTime returnDate;

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        private string returnTime;

        public string ReturnTime
        {
            get { return returnTime; }
            set { returnTime = value; }
        }
        private string returnCity;

        public string ReturnCity
        {
            get { return returnCity; }
            set { returnCity = value; }
        }
        private string returnCountry;

        public string ReturnCountry
        {
            get { return returnCountry; }
            set { returnCountry = value; }
        }
        private string bookingStatus;

        public string BookingStatus
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }
        private long _m_TravelerID;

        public long M_TravelerID
        {
            get { return _m_TravelerID; }
            set { _m_TravelerID = value; }
        }
        private string traveler;

        public string Traveler
        {
            get { return traveler; }
            set { traveler = value; }
        }
        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        private long _m_CompanyID;

        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private long _m_CarRentalProviderID;

        public long M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
        }
        private string provider;

        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }
        private string providerEmail;

        public string ProviderEmail
        {
            get { return providerEmail; }
            set { providerEmail = value; }
        }
        private string providerPhone;

        public string ProviderPhone
        {
            get { return providerPhone; }
            set { providerPhone = value; }
        }
        private string mailUsername;

        public string MailUsername
        {
            get { return mailUsername; }
            set { mailUsername = value; }
        }
        private string faxNumber;

        public string FaxNumber
        {
            get { return faxNumber; }
            set { faxNumber = value; }
        }

        private string _transactions;

        public string Transactions
        {
            get { return _transactions; }
            set { _transactions = value; }
        }


        private string _userSignature;

        public string UserSignature
        {
            get { return _userSignature; }
            set { _userSignature = value; }
        }

        private string _invoiceAmount;

        public string InvoiceAmount
        {
            get { return _invoiceAmount; }
            set { _invoiceAmount = value; }
        }

        public string CaseNumber { get; set; }
    }


    public class vm_CRSendEmail
    {
        public long M_CarRentalProviderSettingID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string InReplyTo { get; set; }
        public List<vm_Attachment_Request> ListLocalPathAttachment { get; set; }
        public long R_B_AccessID { get; set; }
        public string BookingNo { get; set; }

        public vm_CRSendEmail()
        {
            M_CarRentalProviderSettingID = 0;
            From = string.Empty;
            To = string.Empty;
            CC = string.Empty;
            BCC = string.Empty;
            Subject = string.Empty;
            Body = string.Empty;
            InReplyTo = string.Empty;
            BookingNo = string.Empty;
            R_B_AccessID = 0;
        }
    }

    public class vm_Attachment_Request
    {
        public string LocalPathAttachment { get; set; }
        public string OriginalFilename { get; set; }

        public vm_Attachment_Request()
        {
            LocalPathAttachment = string.Empty;
            OriginalFilename = string.Empty;
        }
    }

}
