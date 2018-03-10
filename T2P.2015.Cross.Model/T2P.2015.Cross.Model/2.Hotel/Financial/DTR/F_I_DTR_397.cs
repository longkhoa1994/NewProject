using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_DTR_397 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _f_I_DTR_320ID;
        public long? F_I_DTR_320ID
        {
            get { return _f_I_DTR_320ID; }
            set { _f_I_DTR_320ID = value; }
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
        private string _serviceDescriptorCode;
        public string ServiceDescriptorCode
        {
            get { return _serviceDescriptorCode; }
            set { _serviceDescriptorCode = value; }
        }
        private string _trackingNumberPickupNumber;
        public string TrackingNumberPickupNumber
        {
            get { return _trackingNumberPickupNumber; }
            set { _trackingNumberPickupNumber = value; }
        }
        private decimal? _shippingNetAmount;
        public decimal? ShippingNetAmount
        {
            get { return _shippingNetAmount; }
            set { _shippingNetAmount = value; }
        }
        private decimal? _incentiveAmount;
        public decimal? IncentiveAmount
        {
            get { return _incentiveAmount; }
            set { _incentiveAmount = value; }
        }
        private DateTime? _pickupDate;
        public DateTime? PickupDate
        {
            get { return _pickupDate; }
            set { _pickupDate = value; }
        }
        private decimal? _numberOfPackages;
        public decimal? NumberOfPackages
        {
            get { return _numberOfPackages; }
            set { _numberOfPackages = value; }
        }
        private decimal? _packageWeight;
        public decimal? PackageWeight
        {
            get { return _packageWeight; }
            set { _packageWeight = value; }
        }
        private decimal? _packageWeightUnitOfMeasure;
        public decimal? PackageWeightUnitOfMeasure
        {
            get { return _packageWeightUnitOfMeasure; }
            set { _packageWeightUnitOfMeasure = value; }
        }
        private string _shippingPartyNameLine1;
        public string ShippingPartyNameLine1
        {
            get { return _shippingPartyNameLine1; }
            set { _shippingPartyNameLine1 = value; }
        }
        private string _shippingPartyAddressLine1;
        public string ShippingPartyAddressLine1
        {
            get { return _shippingPartyAddressLine1; }
            set { _shippingPartyAddressLine1 = value; }
        }
        private string _shippingPartyPostalCode;
        public string ShippingPartyPostalCode
        {
            get { return _shippingPartyPostalCode; }
            set { _shippingPartyPostalCode = value; }
        }
        private string _deliveryPartyNameLine1;
        public string DeliveryPartyNameLine1
        {
            get { return _deliveryPartyNameLine1; }
            set { _deliveryPartyNameLine1 = value; }
        }
        private string _deliveryPartyAddressLine1;
        public string DeliveryPartyAddressLine1
        {
            get { return _deliveryPartyAddressLine1; }
            set { _deliveryPartyAddressLine1 = value; }
        }
        private string _deliveryPartyCountryCode;
        public string DeliveryPartyCountryCode
        {
            get { return _deliveryPartyCountryCode; }
            set { _deliveryPartyCountryCode = value; }
        }
        private string _deliveryPartyPostalCode;
        public string DeliveryPartyPostalCode
        {
            get { return _deliveryPartyPostalCode; }
            set { _deliveryPartyPostalCode = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_I_DTR_397"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_DTR_397_InsertOrUpdate"; } }
    }
    public enum F_I_DTR_397Columns
    {
        ID,
        F_I_DTR_320ID,
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
        ServiceDescriptorCode,
        TrackingNumberPickupNumber,
        ShippingNetAmount,
        IncentiveAmount,
        PickupDate,
        NumberOfPackages,
        PackageWeight,
        PackageWeightUnitOfMeasure,
        ShippingPartyNameLine1,
        ShippingPartyAddressLine1,
        ShippingPartyPostalCode,
        DeliveryPartyNameLine1,
        DeliveryPartyAddressLine1,
        DeliveryPartyCountryCode,
        DeliveryPartyPostalCode,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_I_DTR_397Procedure
    {
        p_F_I_DTR_397_GetBy_F_I_DTR_320ID
    }
    public class F_I_DTR_397List : List<F_I_DTR_397>
    {

    }
}