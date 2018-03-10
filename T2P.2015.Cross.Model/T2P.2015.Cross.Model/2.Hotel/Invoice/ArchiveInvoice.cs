using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Invoice
{
    public class ArchiveInvoiceInformation
    {
        public int TotalRecord { get; set; }
        public List<ArchiveInvoice> ListArchiveInvoice { get; set; }
        public ArchiveInvoiceInformation()
        {
            TotalRecord = 0;
            ListArchiveInvoice = new List<ArchiveInvoice>();
        }
    }
    public class ArchiveInvoice
    {
        public DateTime ArchiveFrom { get; set; }
        public DateTime ArchiveTo { get; set; }
        public int NumberOfFiles { get; set; }
        public decimal FileSize { get; set; }
        public string FileName { get; set; }
        public string CompanyName { get; set; }
        public DateTime ExpiredDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public long FileID { get; set; }
        public bool IsExpired { get; set; }

        public int TotalRecord { get; set; }
    }
    public class ArchiveHistory
    {
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public string Actor { get; set; }
    }
    public class InvoiceDetail
    {
        public string ReservationNumber { get; set; }
        public string HotelName { get; set; }
        public string TravellerName { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string InvoiceNumber { get; set; }
        public long InvoiceID { get; set; }
        public long B_AccessID { get; set; }

        public long R_B_AccessID { get; set; }

        public DateTime PickupDate { get; set; }
        public DateTime ReturnDate { get; set; }

        public string ProviderName { get; set; }
        public long? B_EventID { get; set; }
    }
    public class FileDetail
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public DateTime ImportDate { get; set; }
        public int TotalRow {get;set;}
    }
    public class ListInvoiceDetailOfFile
    {
        public List<FileDetail> listFile{get;set;}
        public List<InvoiceDetail> ListInvoiceDetail { get; set; }
        public int TotalRecord { get; set; }
    }
}
