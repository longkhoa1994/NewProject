using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class ProcessStatusPushFIN : ProcessStatus
    {
        public long FinHeaderID { get; set; }
    }

    public class ResultPushFIN
    {
        public string CompanyCode { get; set; }
        public List<ProcessStatusPushFIN> ListResult { get; set; }

        public ResultPushFIN()
        {
            CompanyCode = string.Empty;
            ListResult = new List<ProcessStatusPushFIN>();
        }
    }

    public class F_PushFin_Header
    {
        public long F_HeaderID { get; set; }
        public DateTime Timestamp { get; set; }
        public string Type { get; set; }
        public string TransactionIdentify { get; set; }
        public string CompanyIdentify { get; set; }
        public string CompanyName { get; set; }
        public string SequenceID { get; set; }
        public int TransactionCount { get; set; }
        public int ReprintCount { get; set; }
        public string Version { get; set; }
        public long TotalTransaction { get; set; }
        public string HotelPlatformName { get; set; }
        public string PrefixFileName { get; set; }
        public List<F_PushFin_Transaction> FinancialTransaction { get; set; }

        public F_PushFin_Header()
        {
            Timestamp = DateTime.Now;
            Type = string.Empty;
            TransactionIdentify = string.Empty;
            CompanyName = string.Empty;
            CompanyIdentify = string.Empty;
            SequenceID = string.Empty;
            TransactionCount = 0;
            ReprintCount = 0;
            Version = string.Empty;
            TotalTransaction = 0;
            HotelPlatformName = string.Empty;
            FinancialTransaction = new List<F_PushFin_Transaction>();
        }
    }

    public class F_PushFin_Transaction
    {
        public long? FinancialID { get; set; }
        public string CardNumber { get; set; }
        public string CurrencyCode { get; set; }
        public string DocumentNo { get; set; }
        public decimal GrossAmount { get; set; }
        public string TravelerName { get; set; }
        public string HotelName { get; set; }
        public string ReservationNumber { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal? GrossAmountBC { get; set; }
        public bool GrossAmountBCSpecified { get; set; }
        public string CurrencyCodeBC { get; set; }
        public decimal? ExchangeRate { get; set; }
        public bool ExchangeRateSpecified { get; set; }
        public decimal? ExchangeFee { get; set; }
        public bool ExchangeFeeSpecified { get; set; }
        public F_PushFin_TransactionAddition FinancialAddition { get; set; }
        public bool IsUpdatedAddition { get; set; }
        public F_PushFin_Transaction()
        {
            FinancialID = 0;
            CardNumber = string.Empty;
            CurrencyCode = string.Empty;
            DocumentNo = string.Empty;
            GrossAmount = 0;
            TravelerName = string.Empty;
            HotelName = string.Empty;
            ReservationNumber = string.Empty;
            CheckIn = new DateTime();
            CheckOut = new DateTime();
            SalesDate = new DateTime();
            GrossAmountBC = 0;
            GrossAmountBCSpecified = false;
            CurrencyCodeBC = string.Empty;
            ExchangeRate = 0;
            ExchangeRateSpecified = false;
            ExchangeFee = 0;
            ExchangeFeeSpecified = false;
            FinancialAddition = new F_PushFin_TransactionAddition();
        }
    }

    public class F_PushFin_TransactionAddition
    {
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

        public F_PushFin_TransactionAddition()
        {
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
