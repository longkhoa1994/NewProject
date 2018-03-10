using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Report
{
    public class P_Report_Checkout
    {
        private string _messageWarning;

        public string MessageWarning
        {
            get { return _messageWarning; }
            set { _messageWarning = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private List<P_Report_Checkout_Point> _listPoint;

        public List<P_Report_Checkout_Point> ListPoint
        {
            get { return _listPoint; }
            set { _listPoint = value; }
        }
    }

    public class P_Report_Checkout_Point
    {
        private string _fromWeek;

        public string FromWeek
        {
            get { return _fromWeek; }
            set { _fromWeek = value; }
        }

        private DateTime _fromDate;

        public DateTime FromDate
        {
            get { return _fromDate; }
            set { _fromDate = value; }
        }

        private DateTime _toDate;

        public DateTime ToDate
        {
            get { return _toDate; }
            set { _toDate = value; }
        }

        private long _number;
        
        public long Number
        {
            get { return _number; }
            set { _number = value; }
        }
               
    }

    public enum P_Report_Checkout_StoreProcedure
    {
        p_CheckoutChart_Get,
        p_Report_Checkout_Month,
        p_Report_Checkout_Week
    }

}
