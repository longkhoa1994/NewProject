using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_H_I_Data : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _r_I_DataID;

        public long? R_I_DataID
        {
            get { return _r_I_DataID; }
            set { _r_I_DataID = value; }
        }

        private long? _r_I_ImageID;

        public long? R_I_ImageID
        {
            get { return _r_I_ImageID; }
            set { _r_I_ImageID = value; }
        }

        private long? _r_M_SippCodeID;

        public long? R_M_SippCodeID
        {
            get { return _r_M_SippCodeID; }
            set { _r_M_SippCodeID = value; }
        }

        private long? _r_M_CarGroupID;

        public long? R_M_CarGroupID
        {
            get { return _r_M_CarGroupID; }
            set { _r_M_CarGroupID = value; }
        }

        private long? _m_PickupCountryID;

        public long? M_PickupCountryID
        {
            get { return _m_PickupCountryID; }
            set { _m_PickupCountryID = value; }
        }

        private long? _m_ReturnCountryID;

        public long? M_ReturnCountryID
        {
            get { return _m_ReturnCountryID; }
            set { _m_ReturnCountryID = value; }
        }

        private string _invoiceNumber;

        public string InvoiceNumber
        {
            get { return _invoiceNumber; }
            set { _invoiceNumber = value; }
        }

        private DateTime? _invoiceDate;

        public DateTime? InvoiceDate
        {
            get { return _invoiceDate; }
            set { _invoiceDate = value; }
        }

        private string _carGroup;

        public string CarGroup
        {
            get { return _carGroup; }
            set { _carGroup = value; }
        }

        private decimal? _netAmount;

        public decimal? NetAmount
        {
            get { return _netAmount; }
            set { _netAmount = value; }
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

        private string _currency;

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        private decimal? billingAmount;

        public decimal? BillingAmount
        {
            get { return billingAmount; }
            set { billingAmount = value; }
        }

        private string _billingCurrency;

        public string BillingCurrency
        {
            get { return _billingCurrency; }
            set { _billingCurrency = value; }
        }

        private DateTime? _pickUpTime;

        public DateTime? PickUpTime
        {
            get { return _pickUpTime; }
            set { _pickUpTime = value; }
        }

        private DateTime? _returnTime;

        public DateTime? ReturnTime
        {
            get { return _returnTime; }
            set { _returnTime = value; }
        }

        private string _pickUpLocation;

        public string PickUpLocation
        {
            get { return _pickUpLocation; }
            set { _pickUpLocation = value; }
        }

        private string _returnLocation;

        public string ReturnLocation
        {
            get { return _returnLocation; }
            set { _returnLocation = value; }
        }

        private decimal? _startingKM;

        public decimal? StartingKM
        {
            get { return _startingKM; }
            set { _startingKM = value; }
        }

        private decimal? _returnKM;

        public decimal? ReturnKM
        {
            get { return _returnKM; }
            set { _returnKM = value; }
        }

        private decimal? _distance;

        public decimal? Distance
        {
            get { return _distance; }
            set { _distance = value; }
        }

        public override string Table { get { return "R_H_I_Data"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_H_I_Data_InsertOrUpdate"; } }
    }

    public enum R_H_I_DataColumns
    {
        ID,
        R_I_DataID,
        R_I_ImageID,
        R_M_SippCodeID,
        R_M_CarGroupID,
        M_PickupCountryID,
        M_ReturnCountryID,
        InvoiceNumber,
        InvoiceDate,
        CarGroup,
        NetAmount,
        TaxAmount,
        GrossAmount,
        Currency,
        BillingAmount,
        BillingCurrency,
        PickUpTime,
        ReturnTime,
        PickUpLocation,
        ReturnLocation,
        StartingKM,
        ReturnKM,
        Distance,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_H_I_DataProcedure
    {
        p_R_I_Data_SearchSuccessfulInvoice,
    }

    public class R_H_I_DataList : List<R_H_I_Data>
    {
    }
}