using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model._3.CarRental._7.Process
{

    public class R_P_Unmatchable : V_Pagination
    {
        public string Sender { get; set; }
        public string Subject { get; set; }

        public string ResNo { get; set; }

        public string RentalNo { get; set; }
        public string Traveler { get; set; }

        public DateTime? From { get; set; }
        public DateTime? To { get; set; }

        public List<string> ListCompanyCode { get; set; }

        public R_P_Unmatchable()
        {
            Sender = string.Empty;
            Subject = string.Empty;
            ResNo = string.Empty;
            RentalNo = string.Empty;
            Traveler = string.Empty;
            ListCompanyCode = new List<string>();
        }

    }

    public class R_P_UnmatchableSetBooking
    {
        public bool IsSuccess { get; set; }

        public bool IsExistBookingNo { get; set; }
      
    }

    public class R_P_UnmatchableImage
    {
        public List<R_P_Unmatchable_ImageList> ListImage { get; set; }

        public long TotalRecord { get; set; }

        public R_P_UnmatchableImage()
        {
            ListImage = new List<R_P_Unmatchable_ImageList>();
            TotalRecord = 0;
        }
    }

    public class R_P_Unmatchable_ImageList
    {
        private long _r_N_BillingEmailID;

        public long R_N_BillingEmailID
        {
            get { return _r_N_BillingEmailID; }
            set { _r_N_BillingEmailID = value; }
        }
        private string to;

        public string To
        {
            get { return to; }
            set { to = value; }
        }
        private string from;

        public string From
        {
            get { return from; }
            set { from = value; }
        }
        private DateTime receivingDate;

        public DateTime ReceivingDate
        {
            get { return receivingDate; }
            set { receivingDate = value; }
        }

        private DateTime createdDate;

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }

        private string subject;

        public string Subject
        {
            get { return subject; }
            set { subject = value; }
        }
        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        private string oldComment;

        public string OldComment
        {
            get { return oldComment; }
            set { oldComment = value; }
        }

        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string imageStatus;

        public string ImageStatus
        {
            get { return imageStatus; }
            set { imageStatus = value; }
        }
        private string body;

        public string Body
        {
            get { return body; }
            set { body = value; }
        }

        private string bookingNo;

        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private string oldBookingNo;

        public string OldBookingNo
        {
            get { return oldBookingNo; }
            set { oldBookingNo = value; }
        }

        private string iISPath;

        public string IISPath
        {
            get { return iISPath; }
            set { iISPath = value; }
        }


        private string _messageID;

        public string MessageID
        {
            get { return _messageID; }
            set { _messageID = value; }
        }

        private string _inReplyTo;

        public string InReplyTo
        {
            get { return _inReplyTo; }
            set { _inReplyTo = value; }
        }


        private string _originalAttachementName;

        public string OriginalAttachementName
        {
            get { return _originalAttachementName; }
            set { _originalAttachementName = value; }
        }

        private string _attachmentName;

        public string AttachmentName
        {
            get { return _attachmentName; }
            set { _attachmentName = value; }
        }


        private string _attachmentIISPath;

        public string AttachmentIISPath
        {
            get { return _attachmentIISPath; }
            set { _attachmentIISPath = value; }
        }


        private string _attachmentLocalPath;

        public string AttachmentLocalPath
        {
            get { return _attachmentLocalPath; }
            set { _attachmentLocalPath = value; }
        }


        private bool _isExistBookingNo;

        public bool IsExistBookingNo
        {
            get { return _isExistBookingNo; }
            set { _isExistBookingNo = value; }
        }

        private DateTime? _pickUpTime;

        public DateTime? PickUpTime
        {
            get { return _pickUpTime; }
            set { _pickUpTime = value; }
        }

        private string _travelerName;

        public string TravelerName
        {
            get { return _travelerName; }
            set { _travelerName = value; }
        }

        public bool IsMatchAgain { get; set; }
    }

    public class R_P_UnmatchableFIN
    {
        public List<R_P_Unmatchable_FINList> ListFIN { get; set; }

        public long TotalRecord { get; set;}

        public R_P_UnmatchableFIN()
        {
            ListFIN = new List<R_P_Unmatchable_FINList>();
            TotalRecord = 0;
        }
    }

    public class R_P_Unmatchable_FINList
    {
        private string fileType;

        public string FileType
        {
            get { return fileType; }
            set { fileType = value; }
        }
        private long _r_F_HeaderID;

        public long R_F_HeaderID
        {
            get { return _r_F_HeaderID; }
            set { _r_F_HeaderID = value; }
        }
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string documentNo;

        public string DocumentNo
        {
            get { return documentNo; }
            set { documentNo = value; }
        }
        private string reservationNumber;

        public string ReservationNumber
        {
            get { return reservationNumber; }
            set { reservationNumber = value; }
        }
        private DateTime salesDate;

        public DateTime SalesDate
        {
            get { return salesDate; }
            set { salesDate = value; }
        }
        private DateTime createdDate;

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        private decimal grossAmount;

        public decimal GrossAmount
        {
            get { return grossAmount; }
            set { grossAmount = value; }
        }
        private string currency;

        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        private string travelerName;

        public string TravelerName
        {
            get { return travelerName; }
            set { travelerName = value; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        private string oldComment;

        public string OldComment
        {
            get { return oldComment; }
            set { oldComment = value; }
        }

        private DateTime? _pickupDate;

        public DateTime? PickupDate
        {
            get { return _pickupDate; }
            set { _pickupDate = value; }
        }
    }


    public enum R_P_UnmatchableProcedure
    {
        p_R_P_Unmatchable_GetListFIN,
        p_R_P_Unmatchable_GetListImage,
    }
}
