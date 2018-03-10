using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_H_I_Tax : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _r_H_I_DataID;

        public long? R_H_I_DataID
        {
            get { return _r_H_I_DataID; }
            set { _r_H_I_DataID = value; }
        }

        private decimal? _netAmount;

        public decimal? NetAmount
        {
            get { return _netAmount; }
            set { _netAmount = value; }
        }

        private decimal? _taxRate;

        public decimal? TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }

        private decimal? _taxAmount;

        public decimal? TaxAmount
        {
            get { return _taxAmount; }
            set { _taxAmount = value; }
        }

        private decimal? _grossAmount;

        public decimal? GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        public override string Table { get { return "R_H_I_Tax"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_H_I_Tax_InsertOrUpdate"; } }
    }

    public enum R_H_I_TaxColumns
    {
        ID,
        R_H_I_DataID,
        NetAmount,
        TaxRate,
        TaxAmount,
        GrossAmount,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_H_I_TaxProcedure
    {
    }

    public class R_H_I_TaxList : List<R_H_I_Tax>
    {
    }
}