using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Utility.Conversion;


namespace T2P._2015.Cross.Model
{
    public class NotificationReport : BaseModel
    {
        private long b_AccessID;

        public long B_AccessID
        {
            get { return b_AccessID; }
            set { b_AccessID = value; }
        }
        private string reservationNo;

        public string ReservationNo
        {
            get { return reservationNo; }
            set { reservationNo = value; }
        }
        private string hotelName;

        private string _listInvoiceStr;

        public string ListInvoiceStr
        {
            get { return _listInvoiceStr; }
            set { _listInvoiceStr = value; }
        }

        public List<I_Invoice_ForNotificationReport> ListInvoice
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(ListInvoiceStr))
                {
                    return ListInvoiceStr.Split('|').Select(s => new I_Invoice_ForNotificationReport
                    {
                        ID = Conversion.ObjectToLong(s.Split('*')[0]),
                        InvoiceNo = Conversion.ObjectToString(s.Split('*')[1])
                    }).ToList();
                }
                else
                {
                    return new List<I_Invoice_ForNotificationReport>();
                }


            }

        }



        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }
        private string hotelAddress;

        public string HotelAddress
        {
            get { return hotelAddress; }
            set { hotelAddress = value; }
        }
        private DateTime checkOut;

        public DateTime CheckOut
        {
            get { return checkOut; }
            set { checkOut = value; }
        }
        private bool _isSentRemind;

        public bool IsSentRemind
        {
            get { return _isSentRemind; }
            set { _isSentRemind = value; }
        }
        private int _countFirstCollection;

        public int CountFirstCollection
        {
            get { return _countFirstCollection; }
            set { _countFirstCollection = value; }
        }

        private int _countSecondCollection;

        public int CountSecondCollection
        {
            get { return _countSecondCollection; }
            set { _countSecondCollection = value; }
        }

        private int _countLastCollection;

        public int CountLastCollection
        {
            get { return _countLastCollection; }
            set { _countLastCollection = value; }
        }

        private int _countFirstRejection;

        public int CountFirstRejection
        {
            get { return _countFirstRejection; }
            set { _countFirstRejection = value; }
        }

        private int _countSecondRejection;

        public int CountSecondRejection
        {
            get { return _countSecondRejection; }
            set { _countSecondRejection = value; }
        }

        private int _countLastRejection;

        public int CountLastRejection
        {
            get { return _countLastRejection; }
            set { _countLastRejection = value; }
        }

        private int _numberOfPhoneCall;

        public int NumberOfPhoneCall
        {
            get { return _numberOfPhoneCall; }
            set { _numberOfPhoneCall = value; }
        }
        private string hotelPlatformName;

        public string HotelPlatformName
        {
            get { return hotelPlatformName; }
            set { hotelPlatformName = value; }
        }
    }


    public class I_Invoice_ForNotificationReport
    {
        public long ID { get; set; }
        public string InvoiceNo { get; set; }
    }

    public enum NotificationReportStoreProcedure
    {
        p_MonthlyReport_Get_NotificationReport
    }
}
