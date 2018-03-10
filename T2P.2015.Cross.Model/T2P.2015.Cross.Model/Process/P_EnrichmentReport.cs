using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_EnrichmentReport
    {
        public string FileLocal { get; set; }
        public string ReportType { get; set; }
        public string MessageWarning { get; set; }
        public List<int> ListWeek { get; set; }
        public List<int> ListYear { get; set; }
        public List<M_Company> ListCompany { get; set; }
        public List<M_Country> ListCountry { get; set; }
        public List<P_EnrichmentData> ListEnrichmentData { get; set; }

        public P_EnrichmentReport()
        {
            FileLocal = string.Empty;
            MessageWarning = string.Empty;
            ListWeek = new List<int>();
            ListYear = new List<int>();
            ListCompany = new List<M_Company>();
            ListCountry = new List<M_Country>();
            ListEnrichmentData = new List<P_EnrichmentData>();
        }
    }
  
    public class P_EnrichmentData
    {
        private string _date;

        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _byMonth;

        public string ByMonth
        {
            get { return _byMonth; }
            set { _byMonth = value; }
        }

        private string _byWeekDateTime;

        public string ByWeekDateTime
        {
            get { return _byWeekDateTime; }
            set { _byWeekDateTime = value; }
        }

        private string _byWeekStr;

        public string ByWeekStr
        {
            get { return _byWeekStr; }
            set { _byWeekStr = value; }
        }

        private long _countBooking;

        public long CountBooking
        {
            get { return _countBooking; }
            set { _countBooking = value; }
        }

        private long _countEnriched;

        public long CountEnriched
        {
            get { return _countEnriched; }
            set { _countEnriched = value; }
        }

        private long _countNotEnriched;

        public long CountNotEnriched
        {
            get { return _countNotEnriched; }
            set { _countNotEnriched = value; }
        }

        public P_EnrichmentData()
        {
            Date = string.Empty;
            ByMonth = string.Empty;
            ByWeekDateTime = string.Empty;
            ByWeekStr = string.Empty;
            CountBooking = 0;
            CountEnriched = 0;
            CountNotEnriched = 0;
        }

    }

    public enum P_EnrichmentProcedure
    {
        p_P_Report_Enrichment
    }
}
