using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace T2P._2015.Service.API.Models
{
    public abstract class BaseRC_CheckoutChart
    {
        public string Type { get; set; }
        public int Amount { get; set; }
        public int ProviderID { get; set; }
    }

    public class RC_CheckoutChart
    {
        public List<RC_CheckoutChart_StatisticDetail> Checkout { get; set; }
        public List<RC_CheckoutChart_StatisticDetail> Invoice { get; set; }
        public List<RC_CheckoutChart_StatisticDetail> Received { get; set; }

        public RC_CheckoutChart()
        {
            Checkout = new List<RC_CheckoutChart_StatisticDetail>();
            Invoice = new List<RC_CheckoutChart_StatisticDetail>();
            Received = new List<RC_CheckoutChart_StatisticDetail>();
        }

        //public void InputDate(DateTime fromDate, DateTime toDate)
        //{
        //    throw new NotImplementedException();
        //}
    }
    public class RC_CheckoutChartWeek
    {
        public List<RC_CheckoutChart_StatisticDetailByWeeks> CheckoutWeek { get; set; }
        public List<RC_CheckoutChart_StatisticDetailByWeeks> InvoiceWeek { get; set; }
        public List<RC_CheckoutChart_StatisticDetailByWeeks> ReceivedWeek { get; set; }

        public RC_CheckoutChartWeek()
        {
            CheckoutWeek = new List<RC_CheckoutChart_StatisticDetailByWeeks>();
            InvoiceWeek = new List<RC_CheckoutChart_StatisticDetailByWeeks>();
            ReceivedWeek = new List<RC_CheckoutChart_StatisticDetailByWeeks>();
        }
    }
    public class RC_CheckoutChart_StatisticDetailByWeeks : BaseRC_CheckoutChart
    {
        public int WeekNo { set; get; }
        public int Year { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
     
    }
    //public class RC_CheckoutChartMonth
    //{
    //    public List<RC_CheckoutChartMonth_Detail> CheckoutMonth {get; set;}
    //    public List<RC_CheckoutChartMonth_Detail> InvoiceMonth { get; set; }
    //    public List<RC_CheckoutChartMonth_Detail> ReceivedMonth { get; set; }
        
    //    public RC_CheckoutChartMonth()
    //    {
    //        CheckoutMonth = new List<RC_CheckoutChartMonth_Detail>();
    //        InvoiceMonth = new List<RC_CheckoutChartMonth_Detail>();
    //        ReceivedMonth = new List<RC_CheckoutChartMonth_Detail>();
    //    }
    //}
     

    //public class  RC_CheckoutChartMonth_Detail
    //{
    //    public DateTime Month { get; set; }
    //    public int Amount { get; set; }
    
    //}
     
    public class RC_CheckoutChart_StatisticDetail : BaseRC_CheckoutChart
    {

        public DateTime CheckoutDate { get; set; }
      
    }
    public enum RC_CheckoutChart_StatisticDetailProcedure
    {
        p_RentalCar_Report_Checkout_Day,
        p_RentalCar_Report_Invoice_Day,
        p_RentalCar_Report_Received_Day
    }
}