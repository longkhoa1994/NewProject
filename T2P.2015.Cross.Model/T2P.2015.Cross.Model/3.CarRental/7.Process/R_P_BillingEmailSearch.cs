using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.Process;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model._3.CarRental._7.Process
{
    public class R_P_BillingEmailSearch : V_Pagination
    {
        public long M_CarRentalProviderSettingID { get; set; }
        public string MailBoxType {get; set;}
        public string MailBoxCategory { get; set; }
        public string EmailType { get; set; }
        public string EmailAddress { get; set; }
        public string ResNo { get; set; }
        public string Subject { get; set; }
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string Body { get; set; }

        public bool IsSearch { get; set; }

        public R_P_BillingEmailSearch()
        {
            M_CarRentalProviderSettingID = 0;
            MailBoxType = string.Empty;
            MailBoxCategory = string.Empty;
            EmailType = string.Empty;
            EmailAddress = string.Empty;
            ResNo = string.Empty;
            Subject = string.Empty;
            Body = string.Empty;
            IsSearch = false;
        }
    }


    public class R_P_BillingEmailAction
    {
        public string Action { get; set; }
        public string MailBoxType {get; set;}

        public List<long> ListEmailID {get; set;}

        public List<string> ListEmailType { get; set; }

        public R_P_BillingEmailAction()
        {
            Action = string.Empty;
            MailBoxType = string.Empty;
            ListEmailID = new List<long>();
            ListEmailType = new List<string>();
        }
    }

    public class R_P_BillingEmail
    {
        public List<R_P_BillingEmail_GetSereach> ListEmail { get; set; }
        public long TotalRecords { get; set; }

        public long TotalUnread { get; set; }

        public long TotalUnreadArchive { get; set; }

        public long TotalUnreadInform { get; set; }

        public long TotalUnreadData { get; set; }
        public R_P_BillingEmail()
        {
            ListEmail = new List<R_P_BillingEmail_GetSereach>();
            TotalRecords = 0;
            TotalUnread = 0;
            TotalUnreadArchive = 0;
            TotalUnreadInform = 0;
            TotalUnreadData = 0;
        }
    }

    public class R_P_BillingEmailNumber
    {
        public long TotalInformation { get; set; }

        public long TotalInvoice { get; set;}

        public long TotalArchive { get; set; }

        public long TotalSentBox { get; set; }

        public long TotalTrash { get; set; }

        public R_P_BillingEmailNumber()
        {
            TotalArchive = 0;
            TotalInformation = 0;
            TotalInvoice = 0;
            TotalSentBox = 0;
            TotalTrash = 0;
        }
    }

    public class R_P_BillingEmail_GetSereach 
    {

        private string mailBoxType;

        public string MailBoxType
        {
            get { return mailBoxType; }
            set { mailBoxType = value; }
        }
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        private string emailAddress;

        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }

        private DateTime emailDate;

        public DateTime EmailDate
        {
            get { return emailDate; }
            set { emailDate = value; }
        }

        private int numberAtt;

        public int NumberAtt
        {
            get { return numberAtt; }
            set { numberAtt = value; }
        }

        private bool isRead;

        public bool IsRead
        {
            get { return isRead; }
            set { isRead = value; }
        }

        private bool isImportant;

        public bool IsImportant
        {
            get { return isImportant; }
            set { isImportant = value; }
        }

        private string from;

        public string From
        {
            get { return from; }
            set { from = value; }
        }

        private string to;

        public string To
        {
            get { return to; }
            set { to = value; }
        }


        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public bool HasConversation { get; set; }

        public R_P_BillingEmail_GetSereach()
        {
            ID = 0;
            Subject = string.Empty;
            EmailAddress = string.Empty;
            NumberAtt = 0;
            IsRead = false;
            IsImportant = false;
            From = string.Empty;
            To = string.Empty;
            Type = string.Empty;
        }
    }


    public class R_P_BookingForBillingEmail
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string provider;

        public string Provider
        {
            get { return provider; }
            set { provider = value; }
        }
        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private string _invoiceNumber;

        public string InvoiceNumber
        {
            get { return _invoiceNumber; }
            set { _invoiceNumber = value; }
        }

        private string r_B_AccessID;

        public string R_B_AccessID
        {
            get { return r_B_AccessID; }
            set { r_B_AccessID = value; }
        }

        private string traveler;

        public string Traveler
        {
            get { return traveler; }
            set { traveler = value; }
        }

        private DateTime pickupDate;

        public DateTime PickupDate
        {
            get { return pickupDate; }
            set { pickupDate = value; }
        }

        private DateTime returnDate;

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }

        private string pickupTime;

        public string PickupTime
        {
            get { return pickupTime; }
            set { pickupTime = value; }
        }
        private string returnTime;

        public string ReturnTime
        {
            get { return returnTime; }
            set { returnTime = value; }
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

        private long _m_CompanyID;

        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private long _r_I_ImageID;

        public long R_I_ImageID
        {
            get { return _r_I_ImageID; }
            set { _r_I_ImageID = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }
        public bool IsComment { get; set; }

        public string ImageStatus { get; set; }
    }



    public class R_P_BillingEmailCommonData
    {
        public List<M_CarRentalProvider> ListProvider {get; set;}

        public  List<M_CarRentalProviderSetting> ListProviderSetting {get; set;}

        public R_P_BillingEmailCommonData()
        {
            ListProvider = new List<M_CarRentalProvider>();
            ListProviderSetting = new List<M_CarRentalProviderSetting>();
        }
    }

    public class R_P_BillingEmailDetail
    {
        public R_P_BillingEmailDetailData EmailDetail {get; set;}

        public List<R_P_BillingEmailDetailAtt> ListAttachmentFile { get; set; }

        public List<R_P_BookingBillingEmail> ListEmailBooking { get; set; }

        public List<P_Notification_Conversation> ListConversation { get; set; }

        public R_P_BillingEmailDetail()
        {
            EmailDetail = new R_P_BillingEmailDetailData();
            ListAttachmentFile = new List<R_P_BillingEmailDetailAtt>();
            ListEmailBooking = new List<R_P_BookingBillingEmail>();
            ListConversation = new List<P_Notification_Conversation>();
        }

    }



    public class R_P_BookingBillingEmail
    {
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

        private string bookingStatus;

        public string BookingStatus
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }
    }

    public class R_P_BillingEmailDetailData
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string mailboxType;

        public string MailboxType
        {
            get { return mailboxType; }
            set { mailboxType = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string from;

        public string From
        {
            get { return from; }
            set { from = value; }
        }

        private string to;

        public string To
        {
            get { return to; }
            set { to = value; }
        }
        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }

        private string body;

        public string Body
        {
            get { return body; }
            set { body = value; }
        }
        private string bodyFilter;

        public string BodyFilter
        {
            get { return bodyFilter; }
            set { bodyFilter = value; }
        }

        private int status;

        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private DateTime emailDate;

        public DateTime EmailDate
        {
            get { return emailDate; }
            set { emailDate = value; }
        }

        private string cC;

        public string CC
        {
            get { return cC; }
            set { cC = value; }
        }

        private string messageID;

        public string MessageID
        {
            get { return messageID; }
            set { messageID = value; }
        }

        private string inReplyTo;

        public string InReplyTo
        {
            get { return inReplyTo; }
            set { inReplyTo = value; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        private bool isRead;

        public bool IsRead
        {
            get { return isRead; }
            set { isRead = value; }
        }


        private bool isImportant;

        public bool IsImportant
        {
            get { return isImportant; }
            set { isImportant = value; }
        }

    }

    public class R_P_BillingEmailDetailAtt
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private string originalFilename;

        public string OriginalFilename
        {
            get { return originalFilename; }
            set { originalFilename = value; }
        }

        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private string fileNameLowerCase;

        public string FileNameLowerCase
        {
            get { return fileNameLowerCase; }
            set { fileNameLowerCase = value; }
        }

        private string localPath;

        public string LocalPath
        {
            get { return localPath; }
            set { localPath = value; }
        }
        private string iISPath;

        public string IISPath
        {
            get { return iISPath; }
            set { iISPath = value; }
        }

        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }
    }



}
