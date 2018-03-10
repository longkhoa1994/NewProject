using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_TransactionAdditionQonqa : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_TransactionID;
        public long F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }
        private string _recordIdentifier;
        public string RecordIdentifier
        {
            get { return _recordIdentifier; }
            set { _recordIdentifier = value; }
        }
        private string _processorIndicator;
        public string ProcessorIndicator
        {
            get { return _processorIndicator; }
            set { _processorIndicator = value; }
        }
        private string _processorTransactionCode;
        public string ProcessorTransactionCode
        {
            get { return _processorTransactionCode; }
            set { _processorTransactionCode = value; }
        }
        private string _processorReferenceNumber;
        public string ProcessorReferenceNumber
        {
            get { return _processorReferenceNumber; }
            set { _processorReferenceNumber = value; }
        }
        private decimal _companyID;
        public decimal CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }
        private string _errorCode;
        public string ErrorCode
        {
            get { return _errorCode; }
            set { _errorCode = value; }
        }
        private int? _qSCycleCount;
        public int? QSCycleCount
        {
            get { return _qSCycleCount; }
            set { _qSCycleCount = value; }
        }
        private int _waitingTimeInDays;
        public int WaitingTimeInDays
        {
            get { return _waitingTimeInDays; }
            set { _waitingTimeInDays = value; }
        }
        private int _mCC;
        public int MCC
        {
            get { return _mCC; }
            set { _mCC = value; }
        }
        private DateTime _postingDate;
        public DateTime PostingDate
        {
            get { return _postingDate; }
            set { _postingDate = value; }
        }
        private string _postingTime;
        public string PostingTime
        {
            get { return _postingTime; }
            set { _postingTime = value; }
        }
        private string _authorisationCode;
        public string AuthorisationCode
        {
            get { return _authorisationCode; }
            set { _authorisationCode = value; }
        }
        private float? _conversionRate;
        public float? ConversionRate
        {
            get { return _conversionRate; }
            set { _conversionRate = value; }
        }
        private string _accountCurrency;
        public string AccountCurrency
        {
            get { return _accountCurrency; }
            set { _accountCurrency = value; }
        }
        private float _transactionGrossAmountAccountCurrency;
        public float TransactionGrossAmountAccountCurrency
        {
            get { return _transactionGrossAmountAccountCurrency; }
            set { _transactionGrossAmountAccountCurrency = value; }
        }
        private string _merchantAcceptorID;
        public string MerchantAcceptorID
        {
            get { return _merchantAcceptorID; }
            set { _merchantAcceptorID = value; }
        }
        private string _financialMerchantStreet;
        public string FinancialMerchantStreet
        {
            get { return _financialMerchantStreet; }
            set { _financialMerchantStreet = value; }
        }
        private string _financialMerchantZIPCode;
        public string FinancialMerchantZIPCode
        {
            get { return _financialMerchantZIPCode; }
            set { _financialMerchantZIPCode = value; }
        }
        private string _financialMerchantCity;
        public string FinancialMerchantCity
        {
            get { return _financialMerchantCity; }
            set { _financialMerchantCity = value; }
        }
        private string _financialMerchantCountryCode;
        public string FinancialMerchantCountryCode
        {
            get { return _financialMerchantCountryCode; }
            set { _financialMerchantCountryCode = value; }
        }
        private string _financialMerchantTaxID;
        public string FinancialMerchantTaxID
        {
            get { return _financialMerchantTaxID; }
            set { _financialMerchantTaxID = value; }
        }
        private string _documentNumber;
        public string DocumentNumber
        {
            get { return _documentNumber; }
            set { _documentNumber = value; }
        }
        private string _merchantCustomIDName;
        public string MerchantCustomIDName
        {
            get { return _merchantCustomIDName; }
            set { _merchantCustomIDName = value; }
        }
        private string _merchantCustomID;
        public string MerchantCustomID
        {
            get { return _merchantCustomID; }
            set { _merchantCustomID = value; }
        }
        private string _ticketNummer;
        public string TicketNummer
        {
            get { return _ticketNummer; }
            set { _ticketNummer = value; }
        }
        private string _passengerName;
        public string PassengerName
        {
            get { return _passengerName; }
            set { _passengerName = value; }
        }
        private string _agencyCode;
        public string AgencyCode
        {
            get { return _agencyCode; }
            set { _agencyCode = value; }
        }
        private string _agencyName;
        public string AgencyName
        {
            get { return _agencyName; }
            set { _agencyName = value; }
        }
        private DateTime? _ticketIssueDate;
        public DateTime? TicketIssueDate
        {
            get { return _ticketIssueDate; }
            set { _ticketIssueDate = value; }
        }
        private string _tripLegs;
        public string TripLegs
        {
            get { return _tripLegs; }
            set { _tripLegs = value; }
        }
        private int? _couponSegmentCount;
        public int? CouponSegmentCount
        {
            get { return _couponSegmentCount; }
            set { _couponSegmentCount = value; }
        }
        private string _flightNumber;
        public string FlightNumber
        {
            get { return _flightNumber; }
            set { _flightNumber = value; }
        }
        private DateTime? _departureDate;
        public DateTime? DepartureDate
        {
            get { return _departureDate; }
            set { _departureDate = value; }
        }
        private string _serviceClass;
        public string ServiceClass
        {
            get { return _serviceClass; }
            set { _serviceClass = value; }
        }
        private string _carrierCode;
        public string CarrierCode
        {
            get { return _carrierCode; }
            set { _carrierCode = value; }
        }
        private string _fareBasisCode;
        public string FareBasisCode
        {
            get { return _fareBasisCode; }
            set { _fareBasisCode = value; }
        }
        private string _vUNummer;
        public string VUNummer
        {
            get { return _vUNummer; }
            set { _vUNummer = value; }
        }
        private string _merchantICA;
        public string MerchantICA
        {
            get { return _merchantICA; }
            set { _merchantICA = value; }
        }
        private string _terminalNumber;
        public string TerminalNumber
        {
            get { return _terminalNumber; }
            set { _terminalNumber = value; }
        }
        public override string Table { get { return "F_TransactionAdditionQonqa"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_TransactionAdditionQonqa_InsertOrUpdate"; } }
    }
    public enum F_TransactionAdditionQonqaColumns
    {
        ID,
        F_TransactionID,
        RecordIdentifier,
        ProcessorIndicator,
        ProcessorTransactionCode,
        ProcessorReferenceNumber,
        CompanyID,
        ErrorCode,
        QSCycleCount,
        WaitingTimeInDays,
        MCC,
        PostingDate,
        PostingTime,
        AuthorisationCode,
        ConversionRate,
        AccountCurrency,
        TransactionGrossAmountAccountCurrency,
        MerchantAcceptorID,
        FinancialMerchantStreet,
        FinancialMerchantZIPCode,
        FinancialMerchantCity,
        FinancialMerchantCountryCode,
        FinancialMerchantTaxID,
        DocumentNumber,
        MerchantCustomIDName,
        MerchantCustomID,
        TicketNummer,
        PassengerName,
        AgencyCode,
        AgencyName,
        TicketIssueDate,
        TripLegs,
        CouponSegmentCount,
        FlightNumber,
        DepartureDate,
        ServiceClass,
        CarrierCode,
        FareBasisCode,
        VUNummer,
        MerchantICA,
        TerminalNumber,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_TransactionAdditionQonqaProcedure
    {

    }
    public class F_TransactionAdditionQonqaList : List<F_TransactionAdditionQonqa>
    {

    }

    public enum F_TransactionAdditionQonqaColumnsLength
    {
        ID,
        F_TransactionID,
        RecordIdentifier = 3,
        ProcessorIndicator = 4,
        ProcessorTransactionCode = 4,
        ProcessorReferenceNumber = 23,
        CompanyID = 16,
        ErrorCode = 10,
        QSCycleCount = 3,
        WaitingTimeInDays = 2,
        MCC = 4,
        PostingDate = 8,
        PostingTime = 7,
        AuthorisationCode = 8,
        ConversionRate = 26,
        AccountCurrency = 3,
        TransactionGrossAmountAccountCurrency = 13,
        MerchantAcceptorID = 15,
        FinancialMerchantStreet = 50,
        FinancialMerchantZIPCode = 10,
        FinancialMerchantCity  = 17,
        FinancialMerchantCountryCode = 3,
        FinancialMerchantTaxID = 20,
        DocumentNumber = 15,
        MerchantCustomIDName = 6,
        MerchantCustomID = 76,
        TicketNummer = 15,
        PassengerName  = 30,
        AgencyCode  = 8,
        AgencyName  = 25,
        TicketIssueDate = 8,
        TripLegs = 80,
        CouponSegmentCount = 2,
        FlightNumber = 5,
        DepartureDate = 8,
        ServiceClass = 2, 
        CarrierCode = 2,
        FareBasisCode = 15,
        VUNummer = 15,
        MerchantICA = 11,
        TerminalNumber = 15,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
}