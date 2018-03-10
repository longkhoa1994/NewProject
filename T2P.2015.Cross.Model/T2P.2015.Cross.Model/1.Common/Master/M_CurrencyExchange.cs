using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CurrencyExchange : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _fromCurrency;
        public string FromCurrency
        {
            get { return _fromCurrency; }
            set { _fromCurrency = value; }
        }

        private string _toCurrency;
        public string ToCurrency
        {
            get { return _toCurrency; }
            set { _toCurrency = value; }
        }

        private decimal _rate;
        public decimal Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        public override string Table { get { return "M_CurrencyExchange"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CurrencyExchange_InsertOrUpdate"; } }
    }

    public class M_TotalRecords
    {
        public int TotalRecords { get; set; }

        public M_TotalRecords()
        {
            TotalRecords = 0;
        }
    }
    public enum M_CurrencyExchangeColumns
    {
        ID,
        FromCurrency,
        ToCurrency,
        Rate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CurrencyExchangeProcedure
    {
        p_M_CurrencyExchange_Get_ListSearch,
        p_M_CurrencyExchange_Get_TotalRecords,
        p_M_CurrencyExchange_UpdateOrInsertRate,
        p_M_CurrencyExchange_Get_ToUpdate_M_CurrencyExchangeDetail,
        p_M_CurrencyExchange_GetByFromCurrencyAndToCurrency,
        p_M_CurrencyExchange_GetLastUpdatedRecords
    }
    public class M_CurrencyExchangeList : List<M_CurrencyExchange>
    {

    }
}