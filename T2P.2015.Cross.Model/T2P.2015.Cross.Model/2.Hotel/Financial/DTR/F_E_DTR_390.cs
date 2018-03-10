using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_390 : BaseModel
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
        private string _oilCompany;
        public string OilCompany
        {
            get { return _oilCompany; }
            set { _oilCompany = value; }
        }
        private string _merchStAddr;
        public string MerchStAddr
        {
            get { return _merchStAddr; }
            set { _merchStAddr = value; }
        }
        private string _merchZip;
        public string MerchZip
        {
            get { return _merchZip; }
            set { _merchZip = value; }
        }
        private decimal? _purchaseTime;
        public decimal? PurchaseTime
        {
            get { return _purchaseTime; }
            set { _purchaseTime = value; }
        }
        private string _serviceType;
        public string ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; }
        }
        private string _productCd;
        public string ProductCd
        {
            get { return _productCd; }
            set { _productCd = value; }
        }
        private decimal? _unitPrice;
        public decimal? UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }
        private string _unitOfMeasure;
        public string UnitOfMeasure
        {
            get { return _unitOfMeasure; }
            set { _unitOfMeasure = value; }
        }
        private decimal? _quantity;
        public decimal? Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        private decimal? _saleAmount;
        public decimal? SaleAmount
        {
            get { return _saleAmount; }
            set { _saleAmount = value; }
        }
        private decimal? _odometer;
        public decimal? Odometer
        {
            get { return _odometer; }
            set { _odometer = value; }
        }
        private string _vehicleNum;
        public string VehicleNum
        {
            get { return _vehicleNum; }
            set { _vehicleNum = value; }
        }
        private string _driverIdNum;
        public string DriverIdNum
        {
            get { return _driverIdNum; }
            set { _driverIdNum = value; }
        }
        private decimal? _productTypeCd;
        public decimal? ProductTypeCd
        {
            get { return _productTypeCd; }
            set { _productTypeCd = value; }
        }
        private string _newProductCd;
        public string NewProductCd
        {
            get { return _newProductCd; }
            set { _newProductCd = value; }
        }
        private decimal? _couponDiscAmt;
        public decimal? CouponDiscAmt
        {
            get { return _couponDiscAmt; }
            set { _couponDiscAmt = value; }
        }
        private decimal? _taxAmt1;
        public decimal? TaxAmt1
        {
            get { return _taxAmt1; }
            set { _taxAmt1 = value; }
        }
        private decimal? _taxAmt2;
        public decimal? TaxAmt2
        {
            get { return _taxAmt2; }
            set { _taxAmt2 = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_390"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_390_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_390Columns
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
        OilCompany,
        MerchStAddr,
        MerchZip,
        PurchaseTime,
        ServiceType,
        ProductCd,
        UnitPrice,
        UnitOfMeasure,
        Quantity,
        SaleAmount,
        Odometer,
        VehicleNum,
        DriverIdNum,
        ProductTypeCd,
        NewProductCd,
        CouponDiscAmt,
        TaxAmt1,
        TaxAmt2,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_390Procedure
    {
        p_F_E_DTR_390_GetBy_F_E_DTR_320ID
    }
    public class F_E_DTR_390List : List<F_E_DTR_390>
    {

    }
}