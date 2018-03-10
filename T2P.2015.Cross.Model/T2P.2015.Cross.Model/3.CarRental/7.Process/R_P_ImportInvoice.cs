using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._3.CarRental._7.Process
{
    public class R_P_ImportInvoice
    {
        public R_P_ImportInvoice()
        {
            ListImportInvoice = new List<R_I_ImportExtend>();
            TotalRecords = 0;
        }

        public List<R_I_ImportExtend> ListImportInvoice { get; set; }
        public long TotalRecords { get; set; }
    }

    public class R_P_InvoiceData
    {
        public R_P_InvoiceData()
        {
            ListR_P_Invoice = new List<R_P_Invoice>();
            TotalRecords = 0;
        }

        public List<R_P_Invoice> ListR_P_Invoice { get; set; }
        public long TotalRecords { get; set; }
    }

    public class R_P_Invoice
    {
        public long? R_B_AccessID { get; set; }
        public string CarRentalName { get; set; }

        public string BookingNo { get; set; }

        public string InvoiceNumber { get; set; }

        public string CustomerNumber { get; set; }

        public string CustomerName { get; set; }

        public string Traveler { get; set; }

        public string PickupCountry { get; set; }

        public string CountryName { get; set; }

        public string CarGroup { get; set; }

        public string Description { get; set; }

        private decimal? _netAmount;

        public decimal? NetAmount
        {
            get { return _netAmount; }
            set { _netAmount = value; }
        }

        private decimal? _taxAmount;

        public decimal? TaxAmount
        {
            get { return _taxAmount; }
            set { _taxAmount = value; }
        }

        private decimal? _grossAmount;

        public decimal? GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        public int Status { get; set; }

        public long TotalRecords { get; set; }

        public string RateGridType { get; set; }
    }
    
}
