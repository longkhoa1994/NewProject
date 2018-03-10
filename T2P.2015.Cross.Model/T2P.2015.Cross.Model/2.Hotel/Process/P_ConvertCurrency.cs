using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_CurrencyExchange
    {
        public long ID { get; set; }
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public DateTime Date { get; set; }
        public decimal Rate { get; set; }
    }

    public enum P_CurrencyExchangeProcedure
    {
        p_P_CurrencyExchange_Get_ByTransactionDate
    }

    public class P_ConvertCurrency_Fixer
    {
        public string @base { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }
    }

    public class Rates
    {
        public decimal AUD { get; set; }
        public decimal BGN { get; set; }
        public decimal BRL { get; set; }
        public decimal CAD { get; set; }
        public decimal CHF { get; set; }
        public decimal CNY { get; set; }
        public decimal CZK { get; set; }
        public decimal DKK { get; set; }
        public decimal EUR { get; set; }
        public decimal GBP { get; set; }
        public decimal HKD { get; set; }
        public decimal HRK { get; set; }
        public decimal HUF { get; set; }
        public decimal IDR { get; set; }
        public decimal ILS { get; set; }
        public decimal INR { get; set; }
        public decimal JPY { get; set; }
        public decimal KRW { get; set; }
        public decimal MXN { get; set; }
        public decimal MYR { get; set; }
        public decimal NOK { get; set; }
        public decimal NZD { get; set; }
        public decimal PHP { get; set; }
        public decimal PLN { get; set; }
        public decimal RON { get; set; }
        public decimal RUB { get; set; }
        public decimal SEK { get; set; }
        public decimal SGD { get; set; }
        public decimal THB { get; set; }
        public decimal TRY { get; set; }
        public decimal USD { get; set; }
        public decimal ZAR { get; set; }
    }

    public class P_ConvertCurrency_Yahoo
    {
        public Query query { get; set; }
    }

    public class Rate2
    {
        public string id { get; set; }
        public string Name { get; set; }
        public string Rate { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Ask { get; set; }
        public string Bid { get; set; }
    }

    public class Results
    {
        public List<Rate2> rate { get; set; }
    }

    public class Query
    {
        public int count { get; set; }
        public string created { get; set; }
        public string lang { get; set; }
        public Results results { get; set; }
    }
}
