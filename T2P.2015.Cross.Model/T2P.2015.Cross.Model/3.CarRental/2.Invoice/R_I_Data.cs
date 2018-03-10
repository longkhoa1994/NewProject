using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_I_Data : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _r_I_ImageID;

        public long? R_I_ImageID
        {
            get { return _r_I_ImageID; }
            set { _r_I_ImageID = value; }
        }

        public string ResNo { get; set; }

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

        private string _customerNumber;

        public string CustomerNumber
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }

        private string _customerName;

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        private string _travelerName;

        public string TravelerName
        {
            get { return _travelerName; }
            set { _travelerName = value; }
        }

        private string _rentalNumber;

        public string RentalNumber
        {
            get { return _rentalNumber; }
            set { _rentalNumber = value; }
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

        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        private decimal? _exchangeRate;
        public decimal? ExchangeRate
        {
            get { return _exchangeRate; }
            set { _exchangeRate = value; }
        }
        private string _mopCode;

        public string MOPCode
        {
            get { return _mopCode; }
            set { _mopCode = value; }
        }
        private string _pickupStationCode;

        public string PickupStationCode
        {
            get { return _pickupStationCode; }
            set { _pickupStationCode = value; }
        }
        private string _returnStationCode;

        public string ReturnStationCode
        {
            get { return _returnStationCode; }
            set { _returnStationCode = value; }
        }
        private string _pickupTypeLocation;

        public string PickupTypeLocation
        {
            get { return _pickupTypeLocation; }
            set { _pickupTypeLocation = value; }
        }

        private long _r_I_ImportID;

        public long R_I_ImportID
        {
            get { return _r_I_ImportID; }
            set { _r_I_ImportID = value; }
        }

        private string _rateGrid;

        public string RateGrid
        {
            get { return _rateGrid; }
            set { _rateGrid = value; }
        }
        public string Error { get; set; }
        public override string Table { get { return "R_I_Data"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_I_Data_InsertOrUpdate"; } }
    }

    public enum R_I_DataColumns
    {
        ID,
        R_I_ImageID,
        ResNo,
        R_M_SippCodeID,
        R_M_CarGroupID,
        M_PickupCountryID,
        M_ReturnCountryID,
        CustomerNumber,
        TravelerName,
        RentalNumber,
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
        Comment,
        Error,
        R_I_ImportID,
        CustomerName,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_I_DataProcedure
    {
        p_R_I_Data_GetBy_R_I_ImageID,
        p_R_I_Data_Get_List_By_FinID,
        p_R_I_Data_Get_ForTAccount,
        p_R_I_Data_Get_List_NotMatchFIN_By_R_B_AccessID,
        p_R_I_Data_SearchSuccessfulInvoice,
        p_R_I_Data_GetSuccessfulInvoiceDetail_GetInvoiceImageList,
        p_R_I_Data_GetSuccessfulInvoiceDetail_Header,
        p_R_I_Data_GetSuccessfulInvoiceDetail_Position,
        p_R_I_Data_GetSuccessfulInvoiceDetail_Tax,
        p_R_I_Data_GetByInvoiceNumber,
        p_R_I_Data_Debit_GetBy_R_B_AccessID_NotRelation,
        p_R_I_Data_GetWeeklyClaimsReport,
        p_R_I_Data_GetByToken,
        p_R_I_Data_Get_Debit_By_R_B_AccessID,
        p_R_I_Data_GetForSendEscalationReport
    }

    public class R_I_DataList : List<R_I_Data>
    {
    }

    public class R_I_DataReport : R_I_Data
    {
        public long R_B_AccessID { get; set; }
        public string BookingNo { get; set; }
        public string Email { get; set; }
        public string PickupCountry { get; set; }
        public string ReturnCountry { get; set; }
        public long M_CompanyID { get; set; }
        public long ParentID { get; set; }
        public string ReportStatus { get; set; }
        public string ReportDescription { get; set; }
        public string RateGrid { get; set; }
        public long M_CarRentalProviderID { get; set; }
    }

    public enum R_I_DataReportProcedure
    {
        p_R_I_DataReport_GetForClaimsReport,
        p_R_I_DataReport_GetForReport
    }
}