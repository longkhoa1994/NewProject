using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.View;

namespace T2P._2015.Cross.Model.Process
{
    public class P_OCRMonitor_Search : V_Pagination
    {
        private long companyID;

        public long CompanyID
        {
            get { return companyID; }
            set { companyID = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private string resNo;

        public string ResNo
        {
            get { return resNo; }
            set { resNo = value; }
        }

        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        private int priority;

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        private DateTime? fromDate;

        public DateTime? FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }

        private DateTime? toDate;

        public DateTime? ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    public class P_OCRMonitor
    {
        private int _isSpecialCase;

        public int IsSpecialCase
        {
            get { return _isSpecialCase; }
            set { _isSpecialCase = value; }
        }

        private long id;

        public long ID
        {
            get { return id; }
            set { id = value; }
        }
        private long i_ImageID;

        public long I_ImageID
        {
            get { return i_ImageID; }
            set { i_ImageID = value; }
        }
        private DateTime processedDate;

        public DateTime ProcessedDate
        {
            get { return processedDate; }
            set { processedDate = value; }
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
        private long m_HotelID;

        public long HotelID
        {
            get { return m_HotelID; }
            set { m_HotelID = value; }
        }
        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }
        private long m_CompanyID;

        public long CompanyID
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

        private string travelerName;

        public string TravelerName
        {
            get { return travelerName; }
            set { travelerName = value; }
        }

        private string imageStatus;

        public string ImageStatus
        {
            get { return imageStatus; }
            set { imageStatus = value; }
        }
        private long? sAccessID;

        public long? SAccessID
        {
            get { return sAccessID; }
            set { sAccessID = value; }
        }
        private long? sHotelID;

        public long? SHotelID
        {
            get { return sHotelID; }
            set { sHotelID = value; }
        }

        private string _sHotel;

        public string SHotel
        {
            get { return _sHotel; }
            set { _sHotel = value; }
        }

        private long? sCompanyID;

        public long? SCompanyID
        {
            get { return sCompanyID; }
            set { sCompanyID = value; }
        }
        private string _sCompany;

        public string SCompany
        {
            get { return _sCompany; }
            set { _sCompany = value; }
        }
        private string sTraveler;

        public string STraveler
        {
            get { return sTraveler; }
            set { sTraveler = value; }
        }
        private DateTime? sCheckin;

        public DateTime? SCheckin
        {
            get { return sCheckin; }
            set { sCheckin = value; }
        }
        private DateTime? sCheckout;

        public DateTime? SCheckout
        {
            get { return sCheckout; }
            set { sCheckout = value; }
        }

        private string sBookingNo;

        public string SBookingNo
        {
            get { return sBookingNo; }
            set { sBookingNo = value; }
        }

        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        private int priority;

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }
    }

    public class P_Report_OCR
    {
        private P_Report_OCR_Pie pieChart;

        public P_Report_OCR_Pie PieChart
        {
            get { return pieChart; }
            set { pieChart = value; }
        }

        private List<P_Report_OCR_Line> lineChart;

        public List<P_Report_OCR_Line> LineChart
        {
            get { return lineChart; }
            set { lineChart = value; }
        }

        private List<P_Report_OCR_Hotel> listHotel;

        public List<P_Report_OCR_Hotel> ListHotel
        {
            get { return listHotel; }
            set { listHotel = value; }
        }

        public P_Report_OCR()
        {
            PieChart = new P_Report_OCR_Pie();
            LineChart = new List<P_Report_OCR_Line>();
            ListHotel = new List<P_Report_OCR_Hotel>();
        }
    }

    public class P_Report_OCR_Pie
    {
        private long total;

        public long Total
        {
            get { return total; }
            set { total = value; }
        }

        private long oCR;

        public long OCR
        {
            get { return oCR; }
            set { oCR = value; }
        }

        private long suggest;

        public long Suggest
        {
            get { return suggest; }
            set { suggest = value; }
        }

        private long fail;

        public long Fail
        {
            get { return fail; }
            set { fail = value; }
        }
    }

    public class P_Report_OCR_Line
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private string month;

        public string Month
        {
            get { return month; }
            set { month = value; }
        }

        private decimal number;

        public decimal Number
        {
            get { return number; }
            set { number = value; }
        }

        private decimal numberMatched;

        public decimal NumberMatched
        {
            get { return numberMatched; }
            set { numberMatched = value; }
        }
    }
    public class P_Report_OCR_Hotel : P_Report_OCR_Pie
    {
        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }
        private string hotelNo;

        public string HotelNo
        {
            get { return hotelNo; }
            set { hotelNo = value; }
        }

        private string countryCode;

        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }

        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private decimal percent;

        public decimal Percent
        {
            get { return percent; }
            set { percent = value; }
        }
    }

    public enum P_OCRMonitorProcedure
    {
        p_I_Image_Get_List_MatchingOCR,
        p_I_Image_Get_List_MatchingOCR_Total,
        p_Report_OCR_LineChart,
        p_Report_OCR_Chart,
        p_Report_OCR_Hotel

    }
}
