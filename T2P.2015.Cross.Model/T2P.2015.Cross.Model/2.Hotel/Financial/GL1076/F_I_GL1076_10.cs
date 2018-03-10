using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_GL1076_10 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }

        private long _f_I_GL1076_01ID;

        public long F_I_GL1076_01ID
        {
            get { return _f_I_GL1076_01ID; }
            set { _f_I_GL1076_01ID = value; }
        }

        private string _lIDTransactionID;
        public string LIDTransactionID
        {
            get { return _lIDTransactionID; }
            set { _lIDTransactionID = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        private int? _lIDLineID;
        public int? LIDLineID
        {
            get { return _lIDLineID; }
            set { _lIDLineID = value; }
        }
        private int? _lineIdentifier;
        public int? LineIdentifier
        {
            get { return _lineIdentifier; }
            set { _lineIdentifier = value; }
        }
        private string _quantityInvoicedSignIndicator;
        public string QuantityInvoicedSignIndicator
        {
            get { return _quantityInvoicedSignIndicator; }
            set { _quantityInvoicedSignIndicator = value; }
        }
        private decimal? _quantityInvoiced;
        public decimal? QuantityInvoiced
        {
            get { return _quantityInvoiced; }
            set { _quantityInvoiced = value; }
        }
        private string _quantityUnitofMeasure;
        public string QuantityUnitofMeasure
        {
            get { return _quantityUnitofMeasure; }
            set { _quantityUnitofMeasure = value; }
        }
        private string _unitPriceSignIndicator;
        public string UnitPriceSignIndicator
        {
            get { return _unitPriceSignIndicator; }
            set { _unitPriceSignIndicator = value; }
        }
        private decimal? _unitPrice;
        public decimal? UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        private string _extendedAmountSignIndicator;
        public string ExtendedAmountSignIndicator
        {
            get { return _extendedAmountSignIndicator; }
            set { _extendedAmountSignIndicator = value; }
        }
        private decimal? _extendedAmount;
        public decimal? ExtendedAmount
        {
            get { return _extendedAmount; }
            set { _extendedAmount = value; }
        }
        private string _totalLineValueSignIndicator;
        public string TotalLineValueSignIndicator
        {
            get { return _totalLineValueSignIndicator; }
            set { _totalLineValueSignIndicator = value; }
        }
        private decimal? _totalLineValueAmount;
        public decimal? TotalLineValueAmount
        {
            get { return _totalLineValueAmount; }
            set { _totalLineValueAmount = value; }
        }
        private string _itemDescription;
        public string ItemDescription
        {
            get { return _itemDescription; }
            set { _itemDescription = value; }
        }
        private DateTime? _vendorPartNumber;
        public DateTime? VendorPartNumber
        {
            get { return _vendorPartNumber; }
            set { _vendorPartNumber = value; }
        }
        private string _manufacturerPartNumber;
        public string ManufacturerPartNumber
        {
            get { return _manufacturerPartNumber; }
            set { _manufacturerPartNumber = value; }
        }
        private string _supplierCatalogNumber;
        public string SupplierCatalogNumber
        {
            get { return _supplierCatalogNumber; }
            set { _supplierCatalogNumber = value; }
        }
        private string _uNSPSCCode;
        public string UNSPSCCode
        {
            get { return _uNSPSCCode; }
            set { _uNSPSCCode = value; }
        }
        private string _vendorManufacturerName;
        public string VendorManufacturerName
        {
            get { return _vendorManufacturerName; }
            set { _vendorManufacturerName = value; }
        }
        private string _leaseLicenseNumber;
        public string LeaseLicenseNumber
        {
            get { return _leaseLicenseNumber; }
            set { _leaseLicenseNumber = value; }
        }
        private string _serviceAgreementNumber;
        public string ServiceAgreementNumber
        {
            get { return _serviceAgreementNumber; }
            set { _serviceAgreementNumber = value; }
        }
        private string _freightSignIndicator;
        public string FreightSignIndicator
        {
            get { return _freightSignIndicator; }
            set { _freightSignIndicator = value; }
        }
        private decimal? _freightAmount;
        public decimal? FreightAmount
        {
            get { return _freightAmount; }
            set { _freightAmount = value; }
        }
        private string _handlingSignIndicator;
        public string HandlingSignIndicator
        {
            get { return _handlingSignIndicator; }
            set { _handlingSignIndicator = value; }
        }
        private decimal? _handlingAmount;
        public decimal? HandlingAmount
        {
            get { return _handlingAmount; }
            set { _handlingAmount = value; }
        }
        private string _discountSignIndicator;
        public string DiscountSignIndicator
        {
            get { return _discountSignIndicator; }
            set { _discountSignIndicator = value; }
        }
        private decimal? _discountAmount;
        public decimal? DiscountAmount
        {
            get { return _discountAmount; }
            set { _discountAmount = value; }
        }
        private string _flatRateSignIndicator;
        public string FlatRateSignIndicator
        {
            get { return _flatRateSignIndicator; }
            set { _flatRateSignIndicator = value; }
        }
        private decimal? _flatRateAmount;
        public decimal? FlatRateAmount
        {
            get { return _flatRateAmount; }
            set { _flatRateAmount = value; }
        }
        private string _lostDamagedItemsSignIndicator;
        public string LostDamagedItemsSignIndicator
        {
            get { return _lostDamagedItemsSignIndicator; }
            set { _lostDamagedItemsSignIndicator = value; }
        }
        private decimal? _lostDamagedItemsAmount;
        public decimal? LostDamagedItemsAmount
        {
            get { return _lostDamagedItemsAmount; }
            set { _lostDamagedItemsAmount = value; }
        }
        private string _oneTimeMiscellaneousChargesSignIndicator;
        public string OneTimeMiscellaneousChargesSignIndicator
        {
            get { return _oneTimeMiscellaneousChargesSignIndicator; }
            set { _oneTimeMiscellaneousChargesSignIndicator = value; }
        }
        private decimal? _oneTimeMiscellaneousChargesAmount;
        public decimal? OneTimeMiscellaneousChargesAmount
        {
            get { return _oneTimeMiscellaneousChargesAmount; }
            set { _oneTimeMiscellaneousChargesAmount = value; }
        }
        private string _otherChargesSignIndicator;
        public string OtherChargesSignIndicator
        {
            get { return _otherChargesSignIndicator; }
            set { _otherChargesSignIndicator = value; }
        }
        private decimal? _otherChargesAmount;
        public decimal? OtherChargesAmount
        {
            get { return _otherChargesAmount; }
            set { _otherChargesAmount = value; }
        }
        private string _miscellaneousChargesSignIndicator;
        public string MiscellaneousChargesSignIndicator
        {
            get { return _miscellaneousChargesSignIndicator; }
            set { _miscellaneousChargesSignIndicator = value; }
        }
        private decimal? _miscellaneousChargesAmount;
        public decimal? MiscellaneousChargesAmount
        {
            get { return _miscellaneousChargesAmount; }
            set { _miscellaneousChargesAmount = value; }
        }
        private string _leaseCostSignIndicator;
        public string LeaseCostSignIndicator
        {
            get { return _leaseCostSignIndicator; }
            set { _leaseCostSignIndicator = value; }
        }
        private decimal? _leaseCostAmount;
        public decimal? LeaseCostAmount
        {
            get { return _leaseCostAmount; }
            set { _leaseCostAmount = value; }
        }
        private string _serviceCreditSignIndicator;
        public string ServiceCreditSignIndicator
        {
            get { return _serviceCreditSignIndicator; }
            set { _serviceCreditSignIndicator = value; }
        }
        private decimal? _serviceCreditAmount;
        public decimal? ServiceCreditAmount
        {
            get { return _serviceCreditAmount; }
            set { _serviceCreditAmount = value; }
        }
        private string _filler2;
        public string Filler2
        {
            get { return _filler2; }
            set { _filler2 = value; }
        }

        public override string Table { get { return "F_I_GL1076_10"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_GL1076_10_InsertOrUpdate"; } }
    }
    public enum F_I_GL1076_10Columns
    {
        ID,
        RecordType,
        F_I_GL1076_01ID,
        LIDTransactionID,
        Filler,
        LIDLineID,
        LineIdentifier,
        QuantityInvoicedSignIndicator,
        QuantityInvoiced,
        QuantityUnitofMeasure,
        UnitPriceSignIndicator,
        UnitPrice,
        ExtendedAmountSignIndicator,
        ExtendedAmount,
        TotalLineValueSignIndicator,
        TotalLineValueAmount,
        ItemDescription,
        VendorPartNumber,
        ManufacturerPartNumber,
        SupplierCatalogNumber,
        UNSPSCCode,
        VendorManufacturerName,
        LeaseLicenseNumber,
        ServiceAgreementNumber,
        FreightSignIndicator,
        FreightAmount,
        HandlingSignIndicator,
        HandlingAmount,
        DiscountSignIndicator,
        DiscountAmount,
        FlatRateSignIndicator,
        FlatRateAmount,
        LostDamagedItemsSignIndicator,
        LostDamagedItemsAmount,
        OneTimeMiscellaneousChargesSignIndicator,
        OneTimeMiscellaneousChargesAmount,
        OtherChargesSignIndicator,
        OtherChargesAmount,
        MiscellaneousChargesSignIndicator,
        MiscellaneousChargesAmount,
        LeaseCostSignIndicator,
        LeaseCostAmount,
        ServiceCreditSignIndicator,
        ServiceCreditAmount,
        Filler2,
        CreatedDate,
        CreatedBy,
        UpdatedDate,
        Updatedby,
        Status,
    }
    public enum F_I_GL1076_10Procedure
    {
        p_F_I_GL1076_10_Get_By_F_I_GL_1076_01ID,
        p_F_I_GL1076_10_Get_By_F_TransactionID
    }
    public class F_I_GL1076_10List : List<F_I_GL1076_10>
    {

    }
}