using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Invoice
{
    public class I_QACorrection : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _I_DataID;
        public long I_DataID
        {
            get { return _I_DataID; }
            set { _I_DataID = value; }
        }
        private long _requestID;
        public long  RequestID
        {
            get { return _requestID; }
            set { _requestID = value; }
        }

        private DateTime _requestDate;
        public DateTime RequestDate
        {
            get { return _requestDate; }
            set { _requestDate = value; }
        }
        private long? _replyID;
        public long? ReplyID
        {
            get { return _replyID; }
            set { _replyID = value; }
        }

        private DateTime _replyDate;
        public DateTime ReplyDate
        {
            get { return _replyDate; }
            set { _replyDate = value; }
        }
        private string _question;
        public string Question
        {
            get { return _question; }
            set { _question = value; }
        }


        private string _answer;
        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        public override string Table { get { return "I_QACorrection"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_QACorrection_InsertOrUpdate"; } }
    }



    public class QACorrection
    {
        private  long b_AccessID;

        public long BAccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }

        private string _hotelPlatformName;

        public string HotelPlatformName
        {
            get { return _hotelPlatformName; }
            set { _hotelPlatformName = value; }
        }
        private string _bookingNo;

        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }

        private string _invoiceNo;

        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }

        private string _request;
        public string Request
        {
            get { return _request; }
            set { _request = value; }
        }


        private string _reply;
        public string Reply
        {
            get { return _reply; }
            set { _reply = value; }
        }

        private string _question;
        public string Question
        {
            get { return _question; }
            set { _question = value; }
        }


        private string _answer;
        public string Answer
        {
            get { return _answer; }
            set { _answer = value; }
        }

        private DateTime _requestDate;
        public DateTime RequestDate
        {
            get { return _requestDate; }
            set { _requestDate = value; }
        }

        private DateTime _replyDate;
        public DateTime ReplyDate
        {
            get { return _replyDate; }
            set { _replyDate = value; }
        }
       

    }

    /*
    public class DiscussibleCorrection
    {
        public List<QACorrection> listQACorrection {get; set;}

        private long _totalRecord;
        public long TotalRecord
        {
            get { return _totalRecord; }
            set { _totalRecord = value; }
        }
        public DiscussibleCorrection()
        {
            listQACorrection = new List<QACorrection>();
            _totalRecord = 0;
        }
    }
     */

    public enum I_QAProcedure
    {
        p_QACorrection_Get_ListSearch_V2,
        p_QACorrection_Get_ListSearch,
        p_QACorrection_Get_ListSearch_Total,
        p_QACorrection_Get_QuestionBy_I_DataID,
        p_QACorrection_Update_Answer

    }
}
