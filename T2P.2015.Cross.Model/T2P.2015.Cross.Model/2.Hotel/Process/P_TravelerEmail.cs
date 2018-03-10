using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_TravelerEmail
    {
        public long I_ImageID { get; set; }
        public long I_DataID { get; set; }
        public long B_AccessID { get; set; }
        public long B_BookingID { get; set; }
        public long M_CompanyID { get; set; }
        public long M_ProcessID { get; set; }


        public string BookingNo { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string Traveler { get; set; }
        public string HotelName { get; set; }
        public string HoteAddress { get; set; }
        public string ZipCode { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string TravelerEmail { get; set; }
        public long M_HotelPlatformID { get; set; }

        public bool IsCorrection { get; set; }
       
    }
    public class I_Data_Error_SendTraveler
    {
        public string BookingNo { get; set; }
        public long I_ImageID { get; set; }
        public List<string> ListError { get; set; }
        public I_Data_Error_SendTraveler()
        {
            I_ImageID = 0;
            ListError = new List<string>();
        }
    }

    public class P_TravelerEmail_Detail
    {
        public string StartingText { get; set; }
        public string BookingNo { get; set; }
        public string Traveler { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public string HotelZipCode { get; set; }
        public string HotelCity { get; set; }
        public string HotelCountry { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string InvoiceAmount { get; set; }
        public int Roomnights { get; set; }
        public List<P_TravelerEmail_Position> ListPositionInfo { get; set; }
        public List<P_TravelerEmail_Tax> ListTaxInfo { get; set; }
    }

    public class P_TravelerEmail_Position
    {
        public string ServiceDate { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceCategory { get; set; }
        public string AmountofRoomnights { get; set; }
        public string Price { get; set; }
        public string Total { get; set; }
        public string TaxRate { get; set; }
        public string Net { get; set; }
        public string TaxAmount { get; set; }

    }

    public class P_TravelerEmail_Tax
    {
        public string TaxRate { get; set; }
        public string GrossAmount { get; set; }
        public string NetAmount { get; set; }
        public string TaxAmount { get; set; }
    }

}
