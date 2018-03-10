using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.History
{
    [Serializable]
    public class H_I_Tax:BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _h_I_DataID;

        public long H_I_DataID
        {
            get { return _h_I_DataID; }
            set { _h_I_DataID = value; }
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

        public override string Table { get { return "H_I_Tax"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_H_I_Tax_InsertOrUpdate"; } }
                
    }
    public enum H_I_TaxColumns
    {
        ID,
        H_I_DataID,
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

    public enum H_I_TaxProcedure
    {
        p_H_I_Tax_InsertOrUpdate,
        p_H_I_Tax_GetBy_H_I_DataID, 
        p_H_I_Tax_GetListByListH_I_DataID,
        p_H_I_Tax_GetListForDeleting,
    }

    public class H_I_TaxList : List<H_I_Tax>
    {
    }
}
