using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_340 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _F_E_DTR_320ID;
        public long? F_E_DTR_320ID
        {
            get { return _F_E_DTR_320ID; }
            set { _F_E_DTR_320ID = value; }
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
        private string _processCode;
        public string ProcessCode
        {
            get { return _processCode; }
            set { _processCode = value; }
        }
        private string _itemDescription;
        public string ItemDescription
        {
            get { return _itemDescription; }
            set { _itemDescription = value; }
        }
        private decimal? _itemQuantity;
        public decimal? ItemQuantity
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
        private decimal? _extendedItemAmount;
        public decimal? ExtendedItemAmount
        {
            get { return _extendedItemAmount; }
            set { _extendedItemAmount = value; }
        }
        private string _netOrGrossInd;
        public string NetOrGrossInd
        {
            get { return _netOrGrossInd; }
            set { _netOrGrossInd = value; }
        }
        private decimal? _vatRateApplied;
        public decimal? VatRateApplied
        {
            get { return _vatRateApplied; }
            set { _vatRateApplied = value; }
        }
        private string _vatTypeApplied;
        public string VatTypeApplied
        {
            get { return _vatTypeApplied; }
            set { _vatTypeApplied = value; }
        }
        private decimal? _vatAmount;
        public decimal? VatAmount
        {
            get { return _vatAmount; }
            set { _vatAmount = value; }
        }
        private string _discountIndicator;
        public string DiscountIndicator
        {
            get { return _discountIndicator; }
            set { _discountIndicator = value; }
        }
        private decimal? _itemDiscountAmount;
        public decimal? ItemDiscountAmount
        {
            get { return _itemDiscountAmount; }
            set { _itemDiscountAmount = value; }
        }
        private string _commodityCode;
        public string CommodityCode
        {
            get { return _commodityCode; }
            set { _commodityCode = value; }
        }
        private decimal? _unitCost;
        public decimal? UnitCost
        {
            get { return _unitCost; }
            set { _unitCost = value; }
        }
        private string _addendumSeqNoOne;
        public string AddendumSeqNoOne
        {
            get { return _addendumSeqNoOne; }
            set { _addendumSeqNoOne = value; }
        }
        private decimal? _vatItemQuantity;
        public decimal? VatItemQuantity
        {
            get { return _vatItemQuantity; }
            set { _vatItemQuantity = value; }
        }
        private string _vatItemUnitOfMeasure;
        public string VatItemUnitOfMeasure
        {
            get { return _vatItemUnitOfMeasure; }
            set { _vatItemUnitOfMeasure = value; }
        }
        private string _vgisIndicator;
        public string VgisIndicator
        {
            get { return _vgisIndicator; }
            set { _vgisIndicator = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_340"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_340_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_340Columns
    {
        ID,
        F_E_DTR_320ID,
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
        ProcessCode,
        ItemDescription,
        ItemQuantity,
        ItemUnitOfMeasure,
        ExtendedItemAmount,
        NetOrGrossInd,
        VatRateApplied,
        VatTypeApplied,
        VatAmount,
        DiscountIndicator,
        ItemDiscountAmount,
        CommodityCode,
        UnitCost,
        AddendumSeqNoOne,
        VatItemQuantity,
        VatItemUnitOfMeasure,
        VgisIndicator,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_340Procedure
    {
        p_F_E_DTR_340_GetBy_F_E_DTR_320ID
    }
    public class F_E_DTR_340List : List<F_E_DTR_340>
    {

    }
}