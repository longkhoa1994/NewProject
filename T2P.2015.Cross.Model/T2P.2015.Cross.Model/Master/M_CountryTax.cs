using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CountryTax : BaseModel
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
        private long? _m_ServiceCodeID;
        public long? M_ServiceCodeID
        {
            get { return _m_ServiceCodeID; }
            set { _m_ServiceCodeID = value; }
        }
        private decimal? _taxRate;
        public decimal? TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }
        public override string Table { get { return "M_CountryTax"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CountryTax_InsertOrUpdate"; } }
    }
    public enum M_CountryTaxColumns
    {
        ID,
        M_CountryID,
        M_ServiceCodeID,
        TaxRate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CountryTaxProcedure
    {

    }
    public class M_CountryTaxList : List<M_CountryTax>
    {

    }
}