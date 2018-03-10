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

        private float? _net;

        public float? Net
        {
            get { return _net; }
            set { _net = value; }
        }

        private float? _rate;

        public float? Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        private float? _tax;

        public float? Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }

        private float? _gross;

        public float? Gross
        {
            get { return _gross; }
            set { _gross = value; }
        }

        public override string Table { get { return "O_SuggestTax"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_SuggestTax_InsertOrUpdate"; } }
    }

    public enum O_SuggestTaxColumns
    {
        ID,
        O_SuggestHeaderID,
        Net,
        Rate,
        Tax,
        Gross,
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