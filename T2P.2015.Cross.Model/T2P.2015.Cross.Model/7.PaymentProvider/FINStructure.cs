using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._7.PaymentProvider
{
    [Serializable]
    public class FINStructure
    {
        public DateTime? CreatedDate { get; set; }
        public string FileName { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime? Checkin { get; set; }
        public DateTime? Checkout { get; set; }
        public string TravelerName { get; set; }
        public string TransactionNo { get; set; }
        public string VATHotelNo { get; set; }
        public string HotelName { get; set; }
        public string Country { get; set; }
        public string Company { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Currency { get; set; }

        public string Type { get; set; }

        public long F_VTITransactionID { get; set; }
        public string ReservationNo { get; set; }
        public long B_AccessID { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorCodeUpdatedBy { get; set; }
        public DateTime? ErrorCodeUpdatedDate { get; set; }
        public string ErrorCodeUpdatedDateString { get; set; }

        public List<M_ErrorCode> ListErrors { get; set; }
        public List<PositionDetail> ListPositions { get; set; }

        public string FileType { get; set; }
        public string HotelZipCode { get; set; }
        public int? EnrichmentStatus { get; set; }

        public string CompanyVATCode { get; set; }
    }
}
