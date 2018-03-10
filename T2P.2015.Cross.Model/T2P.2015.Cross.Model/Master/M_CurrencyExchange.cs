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

        public override string Table { get { return "M_CurrencyExchange"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CurrencyExchange_InsertOrUpdate"; } }
    }
    public enum M_CurrencyExchangeColumns
    {
        ID,
        FromCurrency,
        ToCurrency,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CurrencyExchangeProcedure
    {

    }
    public class M_CurrencyExchangeList : List<M_CurrencyExchange>
    {

    }
}