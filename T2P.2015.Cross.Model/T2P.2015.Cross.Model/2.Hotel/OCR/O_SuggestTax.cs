using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class O_SuggestTax : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _o_SuggestHeaderID;

        public long? O_SuggestHeaderID
        {
            get { return _o_SuggestHeaderID; }
            set { _o_SuggestHeaderID = value; }
        }

        private decimal? _taxRate;
        [Extract]
        public decimal? TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }

        private decimal? _taxNet;
        [Extract]
        public decimal? TaxNet
        {
            get { return _taxNet; }
            set { _taxNet = value; }
        }

        private decimal? _taxAmount;
        [Extract]
        public decimal? TaxAmount
        {
            get { return _taxAmount; }
            set { _taxAmount = value; }
        }

        private decimal? _taxGross;
        [Extract]
        public decimal? TaxGross
        {
            get { return _taxGross; }
            set { _taxGross = value; }
        }

        public override string Table { get { return "O_SuggestTax"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_SuggestTax_InsertOrUpdate"; } }
    }

    public enum O_SuggestTaxColumns
    {
        ID,
        O_SuggestHeaderID,

        TaxRate,
        TaxNet,
        TaxAmount,
        TaxGross,

        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum O_SuggestTaxProcedure
    {
    }

    public class O_SuggestTaxList : List<O_SuggestTax>
    {
    }
}