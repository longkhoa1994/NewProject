using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CountryCurrency : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_CountryID;
        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }
        private long? _m_CurrencyID;
        public long? M_CurrencyID
        {
            get { return _m_CurrencyID; }
            set { _m_CurrencyID = value; }
        }
        private bool _isAutoFill;
        public bool IsAutoFill
        {
            get { return _isAutoFill; }
            set { _isAutoFill = value; }
        }
        public override string Table { get { return "M_CountryCurrency"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CountryCurrency_InsertOrUpdate"; } }
    }
    public enum M_CountryCurrencyColumns
    {
        ID,
        M_CountryID,
        M_CurrencyID,
        IsAutoFill,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CountryCurrencyProcedure
    {
        p_M_CountryCurrency_GetByCountry
    }
    public class M_CountryCurrencyList : List<M_CountryCurrency>
    {

    }
}