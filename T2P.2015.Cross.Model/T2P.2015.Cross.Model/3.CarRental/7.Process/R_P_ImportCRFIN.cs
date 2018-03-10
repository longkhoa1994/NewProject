using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._3.CarRental._7.Process
{
    public class R_P_ImportCRFIN
    {
        public string FileType { get; set; }
        public string TransactionIdentify { get; set; }
        public string CompanyIdentify { get; set; }
        public string SequenceID { get; set; }
        public int TransactionCount { get; set; }
        public int ReprintCounter { get; set; }


        public string CompanyName { get; set; }
        public string FileName { get; set; }
        public int TotalTransaction { get; set; }
        public decimal TotalAmount { get; set; }

        public DateTime ImportDate { get; set; }

        public List<R_P_FIN> ListTransaction { get; set; }

        public R_P_ImportCRFIN()
        {
            FileType = string.Empty;
            TransactionIdentify = string.Empty;
            CompanyIdentify = string.Empty;
            SequenceID = string.Empty;
            TransactionCount = 0;
            CompanyName = string.Empty;
            FileName = string.Empty;
            TotalTransaction = 0;
            TotalAmount = 0;
            ListTransaction = new List<R_P_FIN>();
        }
    }

    public class R_P_FIN
    {
        public long? FinancialID { get; set; }
        public string DocumentNo { get; set; }
        public string ReservationNumber { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal GrossAmount { get; set; }
        public string Currency { get; set; }
        public string CarRentalProvider { get; set; }
        public string TravelerName { get; set; }
        public string FinancialStatus { get; set; }
        public DateTime? PickupDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string DBI_PK { get; set; }
        public string DBI_KS { get; set; }
        public string DBI_DS { get; set; }
        public string DBI_AE { get; set; }
        public string DBI_IK { get; set; }
        public string DBI_BD { get; set; }
        public string DBI_PR { get; set; }
        public string DBI_AU { get; set; }
        public string DBI_AK { get; set; }
        public string DBI_RZ { get; set; }

        public R_P_FIN()
        {
            FinancialID = 0;
            DocumentNo = string.Empty;
            ReservationNumber = string.Empty;
            SalesDate = new DateTime();
            GrossAmount = 0;
            Currency = string.Empty;
            CarRentalProvider = string.Empty;
            FinancialStatus = string.Empty;
            DBI_PK = string.Empty;
            DBI_KS = string.Empty;
            DBI_DS = string.Empty;
            DBI_AE = string.Empty;
            DBI_IK = string.Empty;
            DBI_BD = string.Empty;
            DBI_PR = string.Empty;
            DBI_AU = string.Empty;
            DBI_AK = string.Empty;
            DBI_RZ = string.Empty;
        }
    }
}
