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
        private long? _i_ImageID;
        public long? I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }

        private decimal? _taxNet;
        [Extract]
        public decimal? TaxNet
        {
            get { return _taxNet; }
            set { _taxNet = value; }
        }

        private decimal? _taxRate;

        [ExtractPercent]
        [Extract]
        public decimal? TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
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

        private string _coordinates;
        public string Coordinates
        {
            get { return _coordinates; }
            set { _coordinates = value; }
        }

        public override string Table { get { return "I_SuggestTax"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_SuggestTax_InsertOrUpdate"; } }
    }
    public enum I_SuggestTaxColumns
    {
        ID,
        I_ImageID,

        TaxRate,
        TaxNet,
        TaxAmount,
        TaxGross,
        TaxCoordinates,

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