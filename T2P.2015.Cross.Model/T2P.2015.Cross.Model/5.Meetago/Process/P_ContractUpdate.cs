using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model._5.Meetago.Booking;
using T2P._2015.Cross.Model._5.Meetago.Contract;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_ContractUpdate
    {
        public long ID { get; set; }
        public string EventNo { get; set; }
        public string EventTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public B_Hotel Hotel { get; set; }
        public B_Company Company { get; set; }
        public B_Contract Contract { get; set; }
        public IList<B_Booker> Bookers { get; set; }
        public IList<B_Package> Packages { get; set; }
        public IList<B_Package> AdditionServices { get; set; }
        public IList<B_Room> Rooms { get; set; }
    }

    public class P_ContractImport
    {
        public long ID { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
        public string MessageError { get; set; }
    }

    public class P_HistoryUploadContract
    {
        public long B_ContractFileID { get; set; }
        public string UploadFileName { get; set; }
        public string MeetingID { get; set; }
        public string MeetingName { get; set; }
        public string BookingNo { get; set; }
        public string ContractNo { get; set; }
        public string OfferNo { get; set; }
        public string ImportBy { get; set; }
        public DateTime ImportDate { get; set; }
        public bool IsLocked { get; set; }
        public long? UserLockID { get; set; }
        public string UserLockFullName { get; set; }
        public string PDFFilePath { get; set; }
    }

    public class P_InvoicePositionMapping
    {
        public string Token;
        public long? B_AccessID;

        public List<P_IPosition> listIPosition { get; set; }

        public HighLevelApprove highLevelApprove { get; set; }
    }

    public class P_IPosition
    {
        public long I_PositionID { get; set; }
        public bool? IsAccept { get; set; }
        public string RejectComment { get; set; }
    }

    public class HighLevelApprove 
    {
        public string Email {get; set;}
        public string FullName { get; set; }
        public string Comment {get;set;}
        public bool IsSecondApproval { get; set; }

        public HighLevelApprove()
        {
            Email = string.Empty;
            Comment = string.Empty;
            IsSecondApproval = false;
        }
    }
    public class P_HistoryUploadContractList
    {
        public List<P_HistoryUploadContract> ListContract;
        public long TotalRecords;

        public P_HistoryUploadContractList()
        {
            ListContract = new List<P_HistoryUploadContract>();
        }
    }
}
