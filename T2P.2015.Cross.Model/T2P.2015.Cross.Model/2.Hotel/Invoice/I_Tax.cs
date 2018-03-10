using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Tax : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _i_DataID;

        public long I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
        }

        private decimal? _taxAmount;

        
        public decimal? TaxAmount
        {
            get { return _taxAmount; }
            set { _taxAmount = value; }
        }

        private decimal? _taxRate;

        
        public decimal? TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }

        private string _taxCode;

        
        public string TaxCode
        {
            get { return _taxCode; }
            set { _taxCode = value; }
        }

        private decimal? _netAmount;

        
        public decimal? NetAmount
        {
            get { return _netAmount; }
            set { _netAmount = value; }
        }

        private decimal? _grossAmount;

        
        public decimal? GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        private string _currencyCode;

        
        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        public override string Table { get { return "I_Tax"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_I_Tax_InsertOrUpdate"; } }
    }

    public enum I_TaxColumns
    {
        ID,
        I_DataID,
        TaxAmount,
        TaxRate,
        TaxCode,
        NetAmount,
        GrossAmount,
        CurrencyCode,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum I_TaxProcedure
    {
        p_I_Tax_GetByI_DataID,
        p_I_Tax_GetListByListI_DataID,
        p_I_Tax_GetListForDeleting,
    }

    public class I_TaxList : List<I_Tax>
    {
    }
}