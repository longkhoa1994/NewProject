using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Report
{
    public class BookingHotelReport
    {
        public long B_AccessID { get; set; }
        public string Platform { get; set; }
        public string BookingNo { get; set; }
        public DateTime CheckOut { get; set; }
        public int NumberofRooms { get; set; }
        public string BookingStatus { get; set; }
        public int Months { get; set; }
        public string HotelName { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCountryName { get; set; }
        public string CompanyCountryCode { get; set; }
        public string CompanyGroup { get; set; }
        public string CustomerContract { get; set; }
        public string TravelerName { get; set; }
        public string HoteAddress { get; set; }
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string HotelCountryCode { get; set; }
        public string HotelCountryName { get; set; }
        public string HotelVATNumber { get; set; }
        public DateTime? ExportedDate { get; set; }
    }
    public enum BookingHotelReportStoreProcedure
    {
        p_Report_Booking_Hotel_Report,
        p_Report_Booking_Hotel_Report_Count,
        p_S_InsertDataToReportFinishHistory
    }
}
