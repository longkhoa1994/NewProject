using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_DTR_320 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _f_I_DTR_310ID;
        public long? F_I_DTR_310ID
        {
            get { return _f_I_DTR_310ID; }
            set { _f_I_DTR_310ID = value; }
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
        private string _businessIca;
        public string BusinessIca
        {
            get { return _businessIca; }
            set { _businessIca = value; }
        }
        private string _providerId3;
        public string ProviderId3
        {
            get { return _providerId3; }
            set { _providerId3 = value; }
        }
        private string _providerId2;
        public string ProviderId2
        {
            get { return _providerId2; }
            set { _providerId2 = value; }
        }
        private string _providerId1;
        public string ProviderId1
        {
            get { return _providerId1; }
            set { _providerId1 = value; }
        }
        private string _clientProductCode;
        public string ClientProductCode
        {
            get { return _clientProductCode; }
            set { _clientProductCode = value; }
        }
        private string _tbr;
        public string Tbr
        {
            get { return _tbr; }
            set { _tbr = value; }
        }
        private string _acctNo;
        public string AcctNo
        {
            get { return _acctNo; }
            set { _acctNo = value; }
        }
        private string _dbCr;
        public string DbCr
        {
            get { return _dbCr; }
            set { _dbCr = value; }
        }
        private decimal? _transAmt;
        public decimal? TransAmt
        {
            get { return _transAmt; }
            set { _transAmt = value; }
        }
        private DateTime? _postingDate;
        public DateTime? PostingDate
        {
            get { return _postingDate; }
            set { _postingDate = value; }
        }
        private DateTime? _transDate;
        public DateTime? TransDate
        {
            get { return _transDate; }
            set { _transDate = value; }
        }
        private string _refNum;
        public string RefNum
        {
            get { return _refNum; }
            set { _refNum = value; }
        }
        private string _merchName;
        public string MerchName
        {
            get { return _merchName; }
            set { _merchName = value; }
        }
        private string _merchCity;
        public string MerchCity
        {
            get { return _merchCity; }
            set { _merchCity = value; }
        }
        private string _merchState;
        public string MerchState
        {
            get { return _merchState; }
            set { _merchState = value; }
        }
        private string _sICCode;
        public string SICCode
        {
            get { return _sICCode; }
            set { _sICCode = value; }
        }
        private decimal? _amtOrigCurrency;
        public decimal? AmtOrigCurrency
        {
            get { return _amtOrigCurrency; }
            set { _amtOrigCurrency = value; }
        }
        private string _origCurrencyCd;
        public string OrigCurrencyCd
        {
            get { return _origCurrencyCd; }
            set { _origCurrencyCd = value; }
        }
        private DateTime? _currencyConvJul;
        public DateTime? CurrencyConvJul
        {
            get { return _currencyConvJul; }
            set { _currencyConvJul = value; }
        }
        private string _postedCurrencyC;
        public string PostedCurrencyC
        {
            get { return _postedCurrencyC; }
            set { _postedCurrencyC = value; }
        }
        private string _aquiringIca;
        public string AquiringIca
        {
            get { return _aquiringIca; }
            set { _aquiringIca = value; }
        }
        private decimal? _addendumDetlCnt;
        public decimal? AddendumDetlCnt
        {
            get { return _addendumDetlCnt; }
            set { _addendumDetlCnt = value; }
        }
        private string _customerRefNumber;
        public string CustomerRefNumber
        {
            get { return _customerRefNumber; }
            set { _customerRefNumber = value; }
        }
        private decimal? _vatSalesTaxAmt;
        public decimal? VatSalesTaxAmt
        {
            get { return _vatSalesTaxAmt; }
            set { _vatSalesTaxAmt = value; }
        }
        private decimal? _freightAmt;
        public decimal? FreightAmt
        {
            get { return _freightAmt; }
            set { _freightAmt = value; }
        }
        private string _destZip;
        public string DestZip
        {
            get { return _destZip; }
            set { _destZip = value; }
        }
        private string _merchTyp;
        public string MerchTyp
        {
            get { return _merchTyp; }
            set { _merchTyp = value; }
        }
        private string _merchZip;
        public string MerchZip
        {
            get { return _merchZip; }
            set { _merchZip = value; }
        }
        private decimal? _dutyAmt;
        public decimal? DutyAmt
        {
            get { return _dutyAmt; }
            set { _dutyAmt = value; }
        }
        private string _merchVatTaxId;
        public string MerchVatTaxId
        {
            get { return _merchVatTaxId; }
            set { _merchVatTaxId = value; }
        }
        private string _merchStProvCd;
        public string MerchStProvCd
        {
            get { return _merchStProvCd; }
            set { _merchStProvCd = value; }
        }
        private string _shipFromPostal;
        public string ShipFromPostal
        {
            get { return _shipFromPostal; }
            set { _shipFromPostal = value; }
        }
        private decimal? _altVatSalesTax;
        public decimal? AltVatSalesTax
        {
            get { return _altVatSalesTax; }
            set { _altVatSalesTax = value; }
        }
        private string _destCountryCd;
        public string DestCountryCd
        {
            get { return _destCountryCd; }
            set { _destCountryCd = value; }
        }
        private decimal? _airlineAddendum;
        public decimal? AirlineAddendum
        {
            get { return _airlineAddendum; }
            set { _airlineAddendum = value; }
        }
        private decimal? _carRentAddendum;
        public decimal? CarRentAddendum
        {
            get { return _carRentAddendum; }
            set { _carRentAddendum = value; }
        }
        private decimal? _lodgingAddendum;
        public decimal? LodgingAddendum
        {
            get { return _lodgingAddendum; }
            set { _lodgingAddendum = value; }
        }
        private decimal? _genericAddendum;
        public decimal? GenericAddendum
        {
            get { return _genericAddendum; }
            set { _genericAddendum = value; }
        }
        private decimal? _preauthAddendum;
        public decimal? PreauthAddendum
        {
            get { return _preauthAddendum; }
            set { _preauthAddendum = value; }
        }
        private decimal? _temphelpAddendum;
        public decimal? TemphelpAddendum
        {
            get { return _temphelpAddendum; }
            set { _temphelpAddendum = value; }
        }
        private string _transactionInvoice;
        public string TransactionInvoice
        {
            get { return _transactionInvoice; }
            set { _transactionInvoice = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        private string _shipfromZipCode;
        public string ShipfromZipCode
        {
            get { return _shipfromZipCode; }
            set { _shipfromZipCode = value; }
        }
        private string _shipfromGeoCode;
        public string ShipfromGeoCode
        {
            get { return _shipfromGeoCode; }
            set { _shipfromGeoCode = value; }
        }
        private string _taxcalcSlsUseFlag;
        public string TaxcalcSlsUseFlag
        {
            get { return _taxcalcSlsUseFlag; }
            set { _taxcalcSlsUseFlag = value; }
        }
        private decimal? _taxcalcSlsUseRate;
        public decimal? TaxcalcSlsUseRate
        {
            get { return _taxcalcSlsUseRate; }
            set { _taxcalcSlsUseRate = value; }
        }
        private decimal? _estimatedTaxAmt;
        public decimal? EstimatedTaxAmt
        {
            get { return _estimatedTaxAmt; }
            set { _estimatedTaxAmt = value; }
        }
        private decimal? _fleetFuelAddCt;
        public decimal? FleetFuelAddCt
        {
            get { return _fleetFuelAddCt; }
            set { _fleetFuelAddCt = value; }
        }
        private decimal? _fleetNonfuelAddCt;
        public decimal? FleetNonfuelAddCt
        {
            get { return _fleetNonfuelAddCt; }
            set { _fleetNonfuelAddCt = value; }
        }
        private string _merchantId;
        public string MerchantId
        {
            get { return _merchantId; }
            set { _merchantId = value; }
        }
        private string _tranTypCd;
        public string TranTypCd
        {
            get { return _tranTypCd; }
            set { _tranTypCd = value; }
        }
        private string _srcDecPos;
        public string SrcDecPos
        {
            get { return _srcDecPos; }
            set { _srcDecPos = value; }
        }
        private string _companyAcct;
        public string CompanyAcct
        {
            get { return _companyAcct; }
            set { _companyAcct = value; }
        }
        private string _billingAcct;
        public string BillingAcct
        {
            get { return _billingAcct; }
            set { _billingAcct = value; }
        }
        private string _merchantCountryCd;
        public string MerchantCountryCd
        {
            get { return _merchantCountryCd; }
            set { _merchantCountryCd = value; }
        }
        private decimal? _transId;
        public decimal? TransId
        {
            get { return _transId; }
            set { _transId = value; }
        }
        private string _tranCode;
        public string TranCode
        {
            get { return _tranCode; }
            set { _tranCode = value; }
        }
        private string _merchantAddress;
        public string MerchantAddress
        {
            get { return _merchantAddress; }
            set { _merchantAddress = value; }
        }
        private string _merchantLocationText;
        public string MerchantLocationText
        {
            get { return _merchantLocationText; }
            set { _merchantLocationText = value; }
        }
        private string _filler2;
        public string Filler2
        {
            get { return _filler2; }
            set { _filler2 = value; }
        }
        public override string Table { get { return "F_I_DTR_320"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_DTR_320_InsertOrUpdate"; } }
    }
    public enum F_I_DTR_320Columns
    {
        ID,
        F_I_DTR_310ID,
        F_TransactionID,
        RecordType,
        BusinessIca,
        ProviderId3,
        ProviderId2,
        ProviderId1,
        ClientProductCode,
        Tbr,
        AcctNo,
        DbCr,
        TransAmt,
        PostingDate,
        TransDate,
        RefNum,
        MerchName,
        MerchCity,
        MerchState,
        SICCode,
        AmtOrigCurrency,
        OrigCurrencyCd,
        CurrencyConvJul,
        PostedCurrencyC,
        AquiringIca,
        AddendumDetlCnt,
        CustomerRefNumber,
        VatSalesTaxAmt,
        FreightAmt,
        DestZip,
        MerchTyp,
        MerchZip,
        DutyAmt,
        MerchVatTaxId,
        MerchStProvCd,
        ShipFromPostal,
        AltVatSalesTax,
        DestCountryCd,
        AirlineAddendum,
        CarRentAddendum,
        LodgingAddendum,
        GenericAddendum,
        PreauthAddendum,
        TemphelpAddendum,
        TransactionInvoice,
        Filler,
        ShipfromZipCode,
        ShipfromGeoCode,
        TaxcalcSlsUseFlag,
        TaxcalcSlsUseRate,
        EstimatedTaxAmt,
        FleetFuelAddCt,
        FleetNonfuelAddCt,
        MerchantId,
        TranTypCd,
        SrcDecPos,
        CompanyAcct,
        BillingAcct,
        MerchantCountryCd,
        TransId,
        TranCode,
        MerchantAddress,
        MerchantLocationText,
        Filler2,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_I_DTR_320Procedure
    {
        p_F_I_DTR_320_GetByF_I_DTR_310ID,
        p_F_I_DTR_320_GetBy_F_I_DTR_310ID,
        p_F_I_DTR_320_GetByTransaction,
    }
    public class F_I_DTR_320List : List<F_I_DTR_320>
    {

    }
}