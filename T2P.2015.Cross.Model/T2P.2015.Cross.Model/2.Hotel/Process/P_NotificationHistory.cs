//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using T2P._2015.Cross.Enum;

//namespace T2P._2015.Cross.Model.Process
//{
//    public class P_NotificationModel : BaseModel
//    {
//        public long? B_AccessID { get; set; }
//        public long? F_TransactionID { get; set; }
//        public long? I_ImageID { get; set; }

//        public long I_DataID { get; set; }

//        public EmailType EmailType { get; set; }

//        public string EmailInvoice { get; set; }

//        public long M_NotificationTemplateID { get; set; }
//        public string From { get; set; }
//        public string To { get; set; }
//        public DateTime SendDate { get; set; }
//        public string Subject { get; set; }
//        public string Body { get; set; }
//        public string MessageID { get; set; }
//        public string FaxID { get; set; }
//        public string FaxResult { get; set; }
//        public int? IsSuccess { get; set; }

//        public List<string> ListAtt { get; set; }
//        List<P_NotificationModelDetail> listDetail;

//        public List<P_NotificationModelDetail> ListDetail
//        {
//            get { return listDetail; }
//            set { listDetail = value; }
//        }
//        public P_NotificationModel()
//        {
//            ListAtt = new List<string>();
//            ListDetail = new List<P_NotificationModelDetail>();
//        }

//    }


//    public class P_NotificationModelDetail : BaseModel
//    {
//        public long? B_AccessID { get; set; }
//        public long? F_TransactionID { get; set; }
//        public long? I_ImageID { get; set; }

//        public long I_DataID { get; set; }
//    }

//    public class P_NotificationHistory
//    {
//        private int _index;

//        public int Index
//        {
//            get { return _index; }
//            set { _index = value; }
//        }
//        private DateTime _date;

//        public DateTime Date
//        {
//            get { return _date; }
//            set { _date = value; }
//        }

//        private List<P_Notification> _listNotification;

//        public List<P_Notification> ListNotification
//        {
//            get { return _listNotification; }
//            set { _listNotification = value; }
//        }

//        public P_NotificationHistory()
//        {
//            ListNotification = new List<P_Notification>();
//        }
//    }
//    public class P_Notification
//    {
//        private string _doneBy;

//        public string DoneBy
//        {
//            get { return _doneBy; }
//            set { _doneBy = value; }
//        }

//        private long _iD;

//        public long ID
//        {
//            get { return _iD; }
//            set { _iD = value; }
//        }
//        private string side;

//        public string Side
//        {
//            get { return side; }
//            set { side = value; }
//        }
//        private string type;

//        public string Type
//        {
//            get { return type; }
//            set { type = value; }
//        }

//        private string _category;

//        public string Category
//        {
//            get { return _category; }
//            set { _category = value; }
//        }

//        private string from;

//        public string From
//        {
//            get { return from; }
//            set { from = value; }
//        }
//        private string to;

//        public string To
//        {
//            get { return to; }
//            set { to = value; }
//        }

//        public string cc;
//        public string CC
//        {
//            get { return cc; }
//            set { cc = value; }
//        }

//        private DateTime date;

//        public DateTime Date
//        {
//            get { return date; }
//            set { date = value; }
//        }
//        private string subject;

//        public string Subject
//        {
//            get { return subject; }
//            set { subject = value; }
//        }
//        private string body;

//        public string Body
//        {
//            get { return body; }
//            set { body = value; }
//        }
//        private string footer;

//        public string Footer
//        {
//            get { return footer; }
//            set { footer = value; }
//        }
//        public DateTime? ValidFrom { get; set; }
//        public DateTime? ValidTo { get; set; }
//        private int isSuccess;

//        public int IsSuccess
//        {
//            get { return isSuccess; }
//            set { isSuccess = value; }
//        }
//        private string priority;

//        public string Priority
//        {
//            get { return priority; }
//            set { priority = value; }
//        }

//        private DateTime _createdDate;

//        public DateTime CreatedDate
//        {
//            get { return _createdDate; }
//            set { _createdDate = value; }
//        }

//        private long _referenceID;

//        public long ReferenceID
//        {
//            get { return _referenceID; }
//            set { _referenceID = value; }
//        }

//        private string messageID;

//        public string MessageID
//        {
//            get { return messageID; }
//            set { messageID = value; }
//        }

//        private DateTime _updatedDate;

//        public DateTime UpdatedDate
//        {
//            get { return _updatedDate; }
//            set { _updatedDate = value; }
//        }

//        private long? b_AccessID;

//        public long? B_AccessID
//        {
//            get { return b_AccessID; }
//            set { b_AccessID = value; }
//        }

//        private List<P_NotificationDetail> _listDetail;

//        public List<P_NotificationDetail> ListDetail
//        {
//            get { return _listDetail; }
//            set { _listDetail = value; }
//        }

//        private List<P_CostAcceptanceDetail> _costAcceptanceDetails;

//        public List<P_CostAcceptanceDetail> CostAcceptanceDetails
//        {
//            get { return _costAcceptanceDetails; }
//            set { _costAcceptanceDetails = value; }
//        }


//        private bool _isLoadingBody;

//        public bool IsLoadingBody
//        {
//            get { return _isLoadingBody; }
//            set { _isLoadingBody = value; }
//        }

//        private int _isChangeWording;

//        public int IsChangeWording
//        {
//            get { return _isChangeWording; }
//            set { _isChangeWording = value; }
//        }

//        private long _bookingPlatformID;

//        public long BookingPlatformID
//        {
//            get { return _bookingPlatformID; }
//            set { _bookingPlatformID = value; }
//        }

//        private bool _isSmartBilling;

//        public bool IsSmartBilling
//        {
//            get { return _isSmartBilling; }
//            set { _isSmartBilling = value; }
//        }

//        private bool _showFullListDetail;

//        public bool ShowFullListDetail
//        {
//            get { return _showFullListDetail; }
//            set { _showFullListDetail = value; }
//        }

//        private double _timeZone;
//        public double TimeZone
//        {
//            get { return _timeZone; }
//            set { _timeZone = value; }
//        }

//        public bool ShowAtt { get; set; }

//        public P_Notification()
//        {
//            ListDetail = new List<P_NotificationDetail>();
//            CostAcceptanceDetails = new List<P_CostAcceptanceDetail>();
//        }

//        public string Name { get; set; }
//    }

//    public class P_NotificationDetail
//    {
//        private long _iD;

//        public long ID
//        {
//            get { return _iD; }
//            set { _iD = value; }
//        }

//        private string _originalFilename;

//        public string OriginalFilename
//        {
//            get { return _originalFilename; }
//            set { _originalFilename = value; }
//        }

//        private string _filename;

//        public string Filename
//        {
//            get { return _filename; }
//            set { _filename = value; }
//        }

//        private string _pDFFilename;

//        public string PDFFilename
//        {
//            get { return _pDFFilename; }
//            set { _pDFFilename = value; }
//        }

//        private string _filePath;

//        public string FilePath
//        {
//            get { return _filePath; }
//            set { _filePath = value; }
//        }
//        private string _iP;

//        public string IP
//        {
//            get { return _iP; }
//            set { _iP = value; }
//        }

//        private string _iISPath;

//        public string IISPath
//        {
//            get { return _iISPath; }
//            set { _iISPath = value; }
//        }


//        private string localPath;

//        public string LocalPath
//        {
//            get { return localPath; }
//            set { localPath = value; }
//        }

//        private string iISPathFile;

//        public string IISPathFile
//        {
//            get { return iISPathFile; }
//            set { iISPathFile = value; }
//        }
//        public string Description { get; set; }
//    }

//    public class P_CostAcceptanceDetail 
//    {
//        public bool IsSuccessStatus { get; set; }
//        public string StatusCode { get; set; }
//        public string Description { get; set; }
//    }

//    public enum P_NotificationHistoryProcedure
//    {
//        p_P_NotificationHistory_Get_ByBooking,
//        p_R_P_NotificationHistory_Get_ByBooking,
//        p_P_GetCostAcceptanceDetailById
//    }
//}
