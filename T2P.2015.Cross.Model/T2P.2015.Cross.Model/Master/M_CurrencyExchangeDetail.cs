using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CurrencyExchangeDetail : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_CurrencyExchangeID;
        public long? M_CurrencyExchangeID
        {
            get { return _m_CurrencyExchangeID; }
            set { _m_CurrencyExchangeID = value; }
        }
        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        private decimal _rate;
        public decimal Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
        public override string Table { get { return "M_CurrencyExchangeDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CurrencyExchangeDetail_InsertOrUpdate"; } }
    }
    public enum M_CurrencyExchangeDetailColumns
    {
        ID,
        M_CurrencyExchangeID,
        Date,
        Rate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CurrencyExchangeDetailProcedure
    {
        p_M_CurrencyExchangeDetail_Get_ByCurrencyExchangeID
    }
    public class M_CurrencyExchangeDetailList : List<M_CurrencyExchangeDetail>
    {

    }
}