using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Position : BaseModel
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

        private DateTime? _serviceDate;

        
        public DateTime? ServiceDate
        {
            get { return _serviceDate; }
            set { _serviceDate = value; }
        }

        private string _serviceCode;

        
        public string ServiceCode
        {
            get { return _serviceCode; }
            set { _serviceCode = value; }
        }

        private string _serviceDescription;

        
        public string ServiceDescription
        {
            get { return _serviceDescription; }
            set { _serviceDescription = value; }
        }

        private decimal? _amountBeforeTax;

        
        public decimal? AmountBeforeTax
        {
            get { return _amountBeforeTax; }
            set { _amountBeforeTax = value; }
        }

        private decimal? _singlePrice;

        
        public decimal? SinglePrice
        {
            get { return _singlePrice; }
            set { _singlePrice = value; }
        }

        private decimal? _amountAfterTax;

        
        public decimal? AmountAfterTax
        {
            get { return _amountAfterTax; }
            set { _amountAfterTax = value; }
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

        private string _currencyCode;

        
        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        private int? _isAllowed;
        public int? IsAllowed
        {
            get { return _isAllowed; }
            set { _isAllowed = value; }
        }

        public override string Table { get { return "I_Position"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_I_Position_InsertOrUpdate"; } }
    }

    public enum I_PositionColumns
    {
        ID,
        I_DataID,
        ServiceDate,
        ServiceCode,
        ServiceDescription,
        AmountBeforeTax,
        SinglePrice,
        AmountAfterTax,
        TaxAmount,
        TaxRate,
        CurrencyCode,
        IsAllowed,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum I_PositionProcedure
    {
        p_I_Position_GetByI_DataID,
        p_I_Position_GetListByListI_DataID,
        p_I_Position_GetListForDeleting,
    } 

    public class I_PositionList : List<I_Position>
    {
    }
}