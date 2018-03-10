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

        private int? _quantity;

        public int? Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
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
        private string _suggestedServiceCode;

        public string SuggestedServiceCode
        {
            get { return _suggestedServiceCode; }
            set { _suggestedServiceCode = value; }
        }

        private int? _approvalStatus;
        public int? ApprovalStatus
        {
            get { return _approvalStatus; }
            set { _approvalStatus = value; }
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
        Quantity,
        AmountBeforeTax,
        SinglePrice,
        AmountAfterTax,
        TaxAmount,
        TaxRate,
        CurrencyCode,
        IsAllowed,
        SuggestedServiceCode,
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
        p_I_Position_GetByI_DataID_ForDelivery,
        p_I_Position_GetByDataID_WithError,
        p_I_Position_GetAllBy_B_AccessID,
        p_I_Position_GetByDataID_WithError_LeftJoin,
        p_I_Position_GetBy_B_AccessID_WithError,
        p_Service_GetByDataID_WithError,
        p_I_Position_GetListForOldInvoiceByBookingNo
    }

    public class I_PositionList : List<I_Position>
    {
    }

    public class InvoiceContractPosition : I_Position
    {
        private long? _referId;
        public long? ReferId
        {
            get { return _referId; }
            set { _referId = value; }
        }
    }

    public class P_InvoicePosition : I_Position
    {
        private string error;

        public string Error
        {
            get { return error; }
            set { error = value; }
        }
        private long errortype;

        public long ErrorType
        {
            get { return errortype; }
            set { errortype = value; }
        }

        private string imageStatus;

        public string ImageStatus
        {
            get { return imageStatus; }
            set { imageStatus = value; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        public bool IsGrouping { get; set; }
        public List<P_InvoicePosition> SubInvoice { get; set; }
    }
}