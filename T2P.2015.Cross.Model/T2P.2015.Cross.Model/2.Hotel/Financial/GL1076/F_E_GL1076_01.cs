using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_GL1076_01 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _f_E_GL1076_00ID;

        public long F_E_GL1076_00ID
        {
            get { return _f_E_GL1076_00ID; }
            set { _f_E_GL1076_00ID = value; }
        }

        private long? _f_TransactionID;
        public long? F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _serviceEstablishmentNumber;
        public string ServiceEstablishmentNumber
        {
            get { return _serviceEstablishmentNumber; }
            set { _serviceEstablishmentNumber = value; }
        }
        private string _billingAccountNumber;
        public string BillingAccountNumber
        {
            get { return _billingAccountNumber; }
            set { _billingAccountNumber = value; }
        }
        private string _billingBasicControlAccountNumber;
        public string BillingBasicControlAccountNumber
        {
            get { return _billingBasicControlAccountNumber; }
            set { _billingBasicControlAccountNumber = value; }
        }
        private string _requestingControlAccountNumber;
        public string RequestingControlAccountNumber
        {
            get { return _requestingControlAccountNumber; }
            set { _requestingControlAccountNumber = value; }
        }
        private string _marketCode;
        public string MarketCode
        {
            get { return _marketCode; }
            set { _marketCode = value; }
        }
        private string _globalClientOriginIdentifier;
        public string GlobalClientOriginIdentifier
        {
            get { return _globalClientOriginIdentifier; }
            set { _globalClientOriginIdentifier = value; }
        }
        private string _originatingBasicControlAccountNumber;
        public string OriginatingBasicControlAccountNumber
        {
            get { return _originatingBasicControlAccountNumber; }
            set { _originatingBasicControlAccountNumber = value; }
        }
        private string _originatingCardMemberAccountNumber;
        public string OriginatingCardMemberAccountNumber
        {
            get { return _originatingCardMemberAccountNumber; }
            set { _originatingCardMemberAccountNumber = value; }
        }
        private string _lineItemDetailTransactionID;
        public string LineItemDetailTransactionID
        {
            get { return _lineItemDetailTransactionID; }
            set { _lineItemDetailTransactionID = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        private string _recordofChargeIdentifierNumber;
        public string RecordofChargeIdentifierNumber
        {
            get { return _recordofChargeIdentifierNumber; }
            set { _recordofChargeIdentifierNumber = value; }
        }
        private DateTime? _billDate;
        public DateTime? BillDate
        {
            get { return _billDate; }
            set { _billDate = value; }
        }
        private DateTime? _chargeDate;
        public DateTime? ChargeDate
        {
            get { return _chargeDate; }
            set { _chargeDate = value; }
        }
        private DateTime? _businessProcessDate1;
        public DateTime? BusinessProcessDate1
        {
            get { return _businessProcessDate1; }
            set { _businessProcessDate1 = value; }
        }
        private string _transactionSequenceNumber;
        public string TransactionSequenceNumber
        {
            get { return _transactionSequenceNumber; }
            set { _transactionSequenceNumber = value; }
        }
        private DateTime? _businessProcessDate2;
        public DateTime? BusinessProcessDate2
        {
            get { return _businessProcessDate2; }
            set { _businessProcessDate2 = value; }
        }
        private string _batchCode;
        public string BatchCode
        {
            get { return _batchCode; }
            set { _batchCode = value; }
        }
        private string _cardMemberEmbossedName;
        public string CardMemberEmbossedName
        {
            get { return _cardMemberEmbossedName; }
            set { _cardMemberEmbossedName = value; }
        }
        private string _costCenterCode;
        public string CostCenterCode
        {
            get { return _costCenterCode; }
            set { _costCenterCode = value; }
        }
        private string _employeeID;
        public string EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }
        private string _universalNumber;
        public string UniversalNumber
        {
            get { return _universalNumber; }
            set { _universalNumber = value; }
        }
        private string _supplierReferenceNumber;
        public string SupplierReferenceNumber
        {
            get { return _supplierReferenceNumber; }
            set { _supplierReferenceNumber = value; }
        }
        private string _cardMemberReferenceNumber;
        public string CardMemberReferenceNumber
        {
            get { return _cardMemberReferenceNumber; }
            set { _cardMemberReferenceNumber = value; }
        }
        private DateTime? _cardMemberReferenceNumber2;
        public DateTime? CardMemberReferenceNumber2
        {
            get { return _cardMemberReferenceNumber2; }
            set { _cardMemberReferenceNumber2 = value; }
        }
        private DateTime? _cardMemberReferenceNumber3;
        public DateTime? CardMemberReferenceNumber3
        {
            get { return _cardMemberReferenceNumber3; }
            set { _cardMemberReferenceNumber3 = value; }
        }
        private string _cardMemberReferenceNumber4;
        public string CardMemberReferenceNumber4
        {
            get { return _cardMemberReferenceNumber4; }
            set { _cardMemberReferenceNumber4 = value; }
        }
        private string _shiptoPostalCode;
        public string ShiptoPostalCode
        {
            get { return _shiptoPostalCode; }
            set { _shiptoPostalCode = value; }
        }
        private string _cardMemberStateProvince;
        public string CardMemberStateProvince
        {
            get { return _cardMemberStateProvince; }
            set { _cardMemberStateProvince = value; }
        }
        private string _transactionISOCountryCode;
        public string TransactionISOCountryCode
        {
            get { return _transactionISOCountryCode; }
            set { _transactionISOCountryCode = value; }
        }
        private string _billedCurrencyCode;
        public string BilledCurrencyCode
        {
            get { return _billedCurrencyCode; }
            set { _billedCurrencyCode = value; }
        }
        private int? _billedDecimalPlacesNumber;
        public int? BilledDecimalPlacesNumber
        {
            get { return _billedDecimalPlacesNumber; }
            set { _billedDecimalPlacesNumber = value; }
        }
        private string _localCurrencyCode;
        public string LocalCurrencyCode
        {
            get { return _localCurrencyCode; }
            set { _localCurrencyCode = value; }
        }
        private int? _localDecimalPlacesNumber;
        public int? LocalDecimalPlacesNumber
        {
            get { return _localDecimalPlacesNumber; }
            set { _localDecimalPlacesNumber = value; }
        }
        private string _billedAmountSignIndicator;
        public string BilledAmountSignIndicator
        {
            get { return _billedAmountSignIndicator; }
            set { _billedAmountSignIndicator = value; }
        }
        private decimal? _billedAmount;
        public decimal? BilledAmount
        {
            get { return _billedAmount; }
            set { _billedAmount = value; }
        }
        private string _billedTotalTaxSignIndicator;
        public string BilledTotalTaxSignIndicator
        {
            get { return _billedTotalTaxSignIndicator; }
            set { _billedTotalTaxSignIndicator = value; }
        }
        private decimal? _billedTotalTaxAmount;
        public decimal? BilledTotalTaxAmount
        {
            get { return _billedTotalTaxAmount; }
            set { _billedTotalTaxAmount = value; }
        }
        private string _localChargeAmountSignIndicator;
        public string LocalChargeAmountSignIndicator
        {
            get { return _localChargeAmountSignIndicator; }
            set { _localChargeAmountSignIndicator = value; }
        }
        private decimal? _localChargeAmount;
        public decimal? LocalChargeAmount
        {
            get { return _localChargeAmount; }
            set { _localChargeAmount = value; }
        }
        private string _localTaxAmountSignIndicator;
        public string LocalTaxAmountSignIndicator
        {
            get { return _localTaxAmountSignIndicator; }
            set { _localTaxAmountSignIndicator = value; }
        }
        private decimal? _localTaxAmount;
        public decimal? LocalTaxAmount
        {
            get { return _localTaxAmount; }
            set { _localTaxAmount = value; }
        }
        private string _chargeDescriptionLine1;
        public string ChargeDescriptionLine1
        {
            get { return _chargeDescriptionLine1; }
            set { _chargeDescriptionLine1 = value; }
        }
        private string _chargeDescriptionLine2;
        public string ChargeDescriptionLine2
        {
            get { return _chargeDescriptionLine2; }
            set { _chargeDescriptionLine2 = value; }
        }
        private string _ticketPrefix;
        public string TicketPrefix
        {
            get { return _ticketPrefix; }
            set { _ticketPrefix = value; }
        }
        private string _ticketNumber;
        public string TicketNumber
        {
            get { return _ticketNumber; }
            set { _ticketNumber = value; }
        }
        private DateTime? _travelDepartureDate;
        public DateTime? TravelDepartureDate
        {
            get { return _travelDepartureDate; }
            set { _travelDepartureDate = value; }
        }
        private string _filler2;
        public string Filler2
        {
            get { return _filler2; }
            set { _filler2 = value; }
        }
        private string _descriptiveBillLine3;
        public string DescriptiveBillLine3
        {
            get { return _descriptiveBillLine3; }
            set { _descriptiveBillLine3 = value; }
        }
        private string _passengerName;
        public string PassengerName
        {
            get { return _passengerName; }
            set { _passengerName = value; }
        }
        private string _filler3;
        public string Filler3
        {
            get { return _filler3; }
            set { _filler3 = value; }
        }
        private string _classCode;
        public string ClassCode
        {
            get { return _classCode; }
            set { _classCode = value; }
        }
        private string _filler4;
        public string Filler4
        {
            get { return _filler4; }
            set { _filler4 = value; }
        }
        private string _descriptiveBillLine4;
        public string DescriptiveBillLine4
        {
            get { return _descriptiveBillLine4; }
            set { _descriptiveBillLine4 = value; }
        }
        private string _ticketRouting;
        public string TicketRouting
        {
            get { return _ticketRouting; }
            set { _ticketRouting = value; }
        }
        private string _filler5;
        public string Filler5
        {
            get { return _filler5; }
            set { _filler5 = value; }
        }
        private string _iATACarrierCode;
        public string IATACarrierCode
        {
            get { return _iATACarrierCode; }
            set { _iATACarrierCode = value; }
        }
        private string _filler6;
        public string Filler6
        {
            get { return _filler6; }
            set { _filler6 = value; }
        }
        private string _mISIndustryCode;
        public string MISIndustryCode
        {
            get { return _mISIndustryCode; }
            set { _mISIndustryCode = value; }
        }
        private string _genesisDetailIndustryCode;
        public string GenesisDetailIndustryCode
        {
            get { return _genesisDetailIndustryCode; }
            set { _genesisDetailIndustryCode = value; }
        }
        private string _sICCode;
        public string SICCode
        {
            get { return _sICCode; }
            set { _sICCode = value; }
        }
        private string _financialCategoryCode;
        public string FinancialCategoryCode
        {
            get { return _financialCategoryCode; }
            set { _financialCategoryCode = value; }
        }
        private string _transactionTypeCode;
        public string TransactionTypeCode
        {
            get { return _transactionTypeCode; }
            set { _transactionTypeCode = value; }
        }
        private string _transactionFeeIndicator;
        public string TransactionFeeIndicator
        {
            get { return _transactionFeeIndicator; }
            set { _transactionFeeIndicator = value; }
        }
        private string _supplierFederalTaxIdentifier;
        public string SupplierFederalTaxIdentifier
        {
            get { return _supplierFederalTaxIdentifier; }
            set { _supplierFederalTaxIdentifier = value; }
        }
        private string _serviceEstablishmentSupplierTaxClass;
        public string ServiceEstablishmentSupplierTaxClass
        {
            get { return _serviceEstablishmentSupplierTaxClass; }
            set { _serviceEstablishmentSupplierTaxClass = value; }
        }
        private string _goodsandServicesTaxSignIndicator;
        public string GoodsandServicesTaxSignIndicator
        {
            get { return _goodsandServicesTaxSignIndicator; }
            set { _goodsandServicesTaxSignIndicator = value; }
        }
        private decimal? _goodsandServicesTaxAmount;
        public decimal? GoodsandServicesTaxAmount
        {
            get { return _goodsandServicesTaxAmount; }
            set { _goodsandServicesTaxAmount = value; }
        }
        private int? _goodsandServicesTaxDecimalPlacesNumber;
        public int? GoodsandServicesTaxDecimalPlacesNumber
        {
            get { return _goodsandServicesTaxDecimalPlacesNumber; }
            set { _goodsandServicesTaxDecimalPlacesNumber = value; }
        }
        private string _iSOMerchantCategoryCode;
        public string ISOMerchantCategoryCode
        {
            get { return _iSOMerchantCategoryCode; }
            set { _iSOMerchantCategoryCode = value; }
        }
        private string _filler7;
        public string Filler7
        {
            get { return _filler7; }
            set { _filler7 = value; }
        }

        public override string Table { get { return "F_E_GL1076_01"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_GL1076_01_InsertOrUpdate"; } }
    }
    public enum F_E_GL1076_01Columns
    {
        ID,
        F_E_GL1076_00ID,
        F_TransactionID,
        RecordType,
        ServiceEstablishmentNumber,
        BillingAccountNumber,
        BillingBasicControlAccountNumber,
        RequestingControlAccountNumber,
        MarketCode,
        GlobalClientOriginIdentifier,
        OriginatingBasicControlAccountNumber,
        OriginatingCardMemberAccountNumber,
        LineItemDetailTransactionID,
        Filler,
        RecordofChargeIdentifierNumber,
        BillDate,
        ChargeDate,
        BusinessProcessDate1,
        TransactionSequenceNumber,
        BusinessProcessDate2,
        BatchCode,
        CardMemberEmbossedName,
        CostCenterCode,
        EmployeeID,
        UniversalNumber,
        SupplierReferenceNumber,
        CardMemberReferenceNumber,
        CardMemberReferenceNumber2,
        CardMemberReferenceNumber3,
        CardMemberReferenceNumber4,
        ShiptoPostalCode,
        CardMemberStateProvince,
        TransactionISOCountryCode,
        BilledCurrencyCode,
        BilledDecimalPlacesNumber,
        LocalCurrencyCode,
        LocalDecimalPlacesNumber,
        BilledAmountSignIndicator,
        BilledAmount,
        BilledTotalTaxSignIndicator,
        BilledTotalTaxAmount,
        LocalChargeAmountSignIndicator,
        LocalChargeAmount,
        LocalTaxAmountSignIndicator,
        LocalTaxAmount,
        ChargeDescriptionLine1,
        ChargeDescriptionLine2,
        TicketPrefix,
        TicketNumber,
        TravelDepartureDate,
        Filler2,
        DescriptiveBillLine3,
        PassengerName,
        Filler3,
        ClassCode,
        Filler4,
        DescriptiveBillLine4,
        TicketRouting,
        Filler5,
        IATACarrierCode,
        Filler6,
        MISIndustryCode,
        GenesisDetailIndustryCode,
        SICCode,
        FinancialCategoryCode,
        TransactionTypeCode,
        TransactionFeeIndicator,
        SupplierFederalTaxIdentifier,
        ServiceEstablishmentSupplierTaxClass,
        GoodsandServicesTaxSignIndicator,
        GoodsandServicesTaxAmount,
        GoodsandServicesTaxDecimalPlacesNumber,
        ISOMerchantCategoryCode,
        Filler7,
        CreatedDate,
        CreatedBy,
        UpdatedDate,
        Updatedby,
        Status,
    }
    public enum F_E_GL1076_01Procedure
    {
        p_F_E_GL1076_01_Get_By_F_E_GL_1076_00ID,
        p_F_E_GL1076_01_Get_By_F_TransactionID
    }
    public class F_E_GL1076_01List : List<F_E_GL1076_01>
    {

    }
}