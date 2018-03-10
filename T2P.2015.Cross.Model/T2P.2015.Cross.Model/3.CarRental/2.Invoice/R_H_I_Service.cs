using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_H_I_Service : BaseModel
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

        private string _serviceName;

        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }

        private decimal? _quantity;

        public decimal? Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private decimal? _unitPrice;

        public decimal? UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
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

        private bool? _isError;

        public bool? IsError
        {
            get { return _isError; }
            set { _isError = value; }
        }

        public override string Table { get { return "R_H_I_Service"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_H_I_Service_InsertOrUpdate"; } }
    }

    public enum R_H_I_ServiceColumns
    {
        ID,
        R_H_I_DataID,
        ServiceName,
        Quantity,
        UnitPrice,
        NetAmount,
        TaxRate,
        TaxAmount,
        GrossAmount,
        IsError,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_H_I_ServiceProcedure
    {
    }

    public class R_H_I_ServiceList : List<R_H_I_Service>
    {
    }
}