using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    [Serializable]
    public class B_Booking_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public string BookingNo { get; set; }

        public string TransactionNumber { get; set; }

        public decimal GrossAmount { get; set; }

        public string PaymentMethod { get; set; }

        public string CurrencyCode { get; set; }

        public DateTime? BookingDate { get; set; }

        public DateTime? CancellationDate { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public int? DeploymentID { get; set; }

        public string InvoiceRecipientEmail { get; set; }

        public int? Option { get; set; }

        public string Company_CustomerNo { get; set; }

        public string Company_CustomerName { get; set; }

        public string Company_CustomerName_Latin { get; set; }

        public string Company_CustomerName_Umlaut { get; set; }

        public int Company_CheckInfo { get; set; }

        public string Hotel_HotelNo { get; set; }

        public string Booker_FirstName { get; set; }

        public string Booker_LastName { get; set; }

        public string Booker_ZipCode { get; set; }

        public string Booker_Street { get; set; }

        public string Booker_Email { get; set; }

        public string Pos_CompanyID { get; set; }

        public string Pos_CompanyName { get; set; }

        public int? B_BookingID { get; set; }

        public int? BookerID { get; set; }

        public int? B_AccessID { get; set; }

        public int? M_CompanyID { get; set; }

        public int? M_HotelID { get; set; }

        public int? M_HotelPlatformID { get; set; }

        public int? M_ProcessID { get; set; }

        public int? M_CompanyProcessID { get; set; }

        public int? M_PaymentProviderID { get; set; }

        public int Status { get; set; }

        public bool IsECS { get; set; }

        public bool IsProcess { get; set; }

        public bool IsUpdateFinCLO { get; set; }

        public bool IsSendHotelPlatform { get; set; }

        public bool IsSendServiceCenter { get; set; }

        public bool IsUpdateCompany { get; set; }

        public static string Table = "B_Booking_Raw";
    }
}
