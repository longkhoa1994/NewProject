using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ExchangeRate : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _fromCurrencyID;
        public long FromCurrencyID
        {
            get { return _fromCurrencyID; }
            set { _fromCurrencyID = value; }
        }
        private string _fromCurrencyCode;
        public string FromCurrencyCode
        {
            get { return _fromCurrencyCode; }
            set { _fromCurrencyCode = value; }
        }
        private long _toCurrencyID;
        public long ToCurrencyID
        {
            get { return _toCurrencyID; }
            set { _toCurrencyID = value; }
        }
        private string _toCurrencyCode;
        public string ToCurrencyCode
        {
            get { return _toCurrencyCode; }
            set { _toCurrencyCode = value; }
        }
        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private decimal _exchangeRate;

        public decimal ExchangeRate
        {
            get { return _exchangeRate; }
            set { _exchangeRate = value; }
        }

        public override string Table { get { return "M_ExchangeRate"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_ExchangeRate_InsertOrUpdate"; } }
    }
    public enum M_ExchangeRateColumns
    {
        ID,
        FromCurrencyID,
        FromCurrencyCode,
        ToCurrencyID,
        ToCurrencyCode,
        Date,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_ExchangeRateProcedure
    {
        p_M_ExchangeRate_Get_ByTransactionDate
    }
    public class M_ExchangeRateList : List<M_ExchangeRate>
    {

    }
}