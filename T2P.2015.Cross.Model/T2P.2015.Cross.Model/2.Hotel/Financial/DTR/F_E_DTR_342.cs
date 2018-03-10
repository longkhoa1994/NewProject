using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_342 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _F_E_DTR_341ID;
        public long? F_E_DTR_341ID
        {
            get { return _F_E_DTR_341ID; }
            set { _F_E_DTR_341ID = value; }
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
        private string _aquirRefNum;
        public string AquirRefNum
        {
            get { return _aquirRefNum; }
            set { _aquirRefNum = value; }
        }
        private decimal? _addendumSeqNo;
        public decimal? AddendumSeqNo
        {
            get { return _addendumSeqNo; }
            set { _addendumSeqNo = value; }
        }
        private string _productCode;
        public string ProductCode
        {
            get { return _productCode; }
            set { _productCode = value; }
        }
        private string _itemDescription;
        public string ItemDescription
        {
            get { return _itemDescription; }
            set { _itemDescription = value; }
        }
        private string _itemQuantity;
        public string ItemQuantity
        {
            get { return _itemQuantity; }
            set { _itemQuantity = value; }
        }
        private string _itemUnitOfMeasure;
        public string ItemUnitOfMeasure
        {
            get { return _itemUnitOfMeasure; }
            set { _itemUnitOfMeasure = value; }
        }
        private decimal? _unitCost;
        public decimal? UnitCost
        {
            get { return _unitCost; }
            set { _unitCost = value; }
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
        private decimal? _itemTotal;
        public decimal? ItemTotal
        {
            get { return _itemTotal; }
            set { _itemTotal = value; }
        }
        private string _taxExemptIndicator;
        public string TaxExemptIndicator
        {
            get { return _taxExemptIndicator; }
            set { _taxExemptIndicator = value; }
        }
        private string _purchaseOrganiationPartNumber;
        public string PurchaseOrganiationPartNumber
        {
            get { return _purchaseOrganiationPartNumber; }
            set { _purchaseOrganiationPartNumber = value; }
        }
        private string _modelNumber;
        public string ModelNumber
        {
            get { return _modelNumber; }
            set { _modelNumber = value; }
        }
        private string _universalProductCode;
        public string UniversalProductCode
        {
            get { return _universalProductCode; }
            set { _universalProductCode = value; }
        }
        private string _supplierStockKeepingUnitNumber;
        public string SupplierStockKeepingUnitNumber
        {
            get { return _supplierStockKeepingUnitNumber; }
            set { _supplierStockKeepingUnitNumber = value; }
        }
        private string _supplierCatalogNumber;
        public string SupplierCatalogNumber
        {
            get { return _supplierCatalogNumber; }
            set { _supplierCatalogNumber = value; }
        }
        private string _manufacturerPartNumber;
        public string ManufacturerPartNumber
        {
            get { return _manufacturerPartNumber; }
            set { _manufacturerPartNumber = value; }
        }
        private string _taxType;
        public string TaxType
        {
            get { return _taxType; }
            set { _taxType = value; }
        }
        private decimal? _netItemAmount;
        public decimal? NetItemAmount
        {
            get { return _netItemAmount; }
            set { _netItemAmount = value; }
        }
        private decimal? _grossAmount;
        public decimal? GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }
        private string _itemNumber;
        public string ItemNumber
        {
            get { return _itemNumber; }
            set { _itemNumber = value; }
        }
        private string _commodityCode;
        public string CommodityCode
        {
            get { return _commodityCode; }
            set { _commodityCode = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_342"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_342_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_342Columns
    {
        ID,
        F_E_DTR_341ID,
        RecordType,
        BusinessIca,
        ProviderId3,
        ProviderId2,
        ProviderId1,
        ClientProductCode,
        Tbr,
        AcctNo,
        AquirRefNum,
        AddendumSeqNo,
        ProductCode,
        ItemDescription,
        ItemQuantity,
        ItemUnitOfMeasure,
        UnitCost,
        TaxAmount,
        TaxRate,
        ItemTotal,
        TaxExemptIndicator,
        PurchaseOrganiationPartNumber,
        ModelNumber,
        UniversalProductCode,
        SupplierStockKeepingUnitNumber,
        SupplierCatalogNumber,
        ManufacturerPartNumber,
        TaxType,
        NetItemAmount,
        GrossAmount,
        ItemNumber,
        CommodityCode,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_342Procedure
    {
        p_F_E_DTR_342_GetBy_F_E_DTR_341ID
    }
    public class F_E_DTR_342List : List<F_E_DTR_342>
    {

    }
}