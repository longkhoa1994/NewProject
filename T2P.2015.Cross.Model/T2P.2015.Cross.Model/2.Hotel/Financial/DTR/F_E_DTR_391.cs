using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_391 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _F_E_DTR_390ID;
        public long? F_E_DTR_390ID
        {
            get { return _F_E_DTR_390ID; }
            set { _F_E_DTR_390ID = value; }
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
        private string _productCd;
        public string ProductCd
        {
            get { return _productCd; }
            set { _productCd = value; }
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
        private decimal? _extendedItemAmt;
        public decimal? ExtendedItemAmt
        {
            get { return _extendedItemAmt; }
            set { _extendedItemAmt = value; }
        }
        private string _netOrGrossInd;
        public string NetOrGrossInd
        {
            get { return _netOrGrossInd; }
            set { _netOrGrossInd = value; }
        }
        private string _vatRateApplied;
        public string VatRateApplied
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
        private string _dbCrInd;
        public string DbCrInd
        {
            get { return _dbCrInd; }
            set { _dbCrInd = value; }
        }
        private string _altTaxId;
        public string AltTaxId
        {
            get { return _altTaxId; }
            set { _altTaxId = value; }
        }
        private string _discountIndicato;
        public string DiscountIndicato
        {
            get { return _discountIndicato; }
            set { _discountIndicato = value; }
        }
        private decimal? _discountAmount;
        public decimal? DiscountAmount
        {
            get { return _discountAmount; }
            set { _discountAmount = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_391"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_391_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_391Columns
    {
        ID,
        F_E_DTR_390ID,
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
        ProductCd,
        ItemDescription,
        ItemQuantity,
        ItemUnitOfMeasure,
        ExtendedItemAmt,
        NetOrGrossInd,
        VatRateApplied,
        VatTypeApplied,
        VatAmount,
        DbCrInd,
        AltTaxId,
        DiscountIndicato,
        DiscountAmount,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_391Procedure
    {
        p_F_E_DTR_391_GetBy_F_E_DTR_390ID
    }
    public class F_E_DTR_391List : List<F_E_DTR_391>
    {

    }
}