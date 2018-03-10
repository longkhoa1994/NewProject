using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_SuggestTax : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _i_SuggestHeaderID;
        public long? I_SuggestHeaderID
        {
            get { return _i_SuggestHeaderID; }
            set { _i_SuggestHeaderID = value; }
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
        public override string Table { get { return "I_SuggestTax"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_SuggestTax_InsertOrUpdate"; } }
    }
    public enum I_SuggestTaxColumns
    {
        ID,
        I_SuggestHeaderID,
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
    public enum I_SuggestTaxProcedure
    {
        p_I_SuggestTax_GetBySuggestHeaderID
    }
    public class I_SuggestTaxList : List<I_SuggestTax>
    {

    }
}