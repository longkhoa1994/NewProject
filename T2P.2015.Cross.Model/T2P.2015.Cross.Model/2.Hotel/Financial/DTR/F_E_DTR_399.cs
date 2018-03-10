using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_399 : BaseModel
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
        private string _packageTrackingNumber;
        public string PackageTrackingNumber
        {
            get { return _packageTrackingNumber; }
            set { _packageTrackingNumber = value; }
        }
        private string _numberOfPackages;
        public string NumberOfPackages
        {
            get { return _numberOfPackages; }
            set { _numberOfPackages = value; }
        }
        private string _serviceDescription;
        public string ServiceDescription
        {
            get { return _serviceDescription; }
            set { _serviceDescription = value; }
        }
        private string _actualWeightUnitOfMeasure;
        public string ActualWeightUnitOfMeasure
        {
            get { return _actualWeightUnitOfMeasure; }
            set { _actualWeightUnitOfMeasure = value; }
        }
        private DateTime? _shipDate;
        public DateTime? ShipDate
        {
            get { return _shipDate; }
            set { _shipDate = value; }
        }
        private string _shipTime;
        public string ShipTime
        {
            get { return _shipTime; }
            set { _shipTime = value; }
        }
        private string _shipperAccountNumber;
        public string ShipperAccountNumber
        {
            get { return _shipperAccountNumber; }
            set { _shipperAccountNumber = value; }
        }
        private string _receiverBillingNumber;
        public string ReceiverBillingNumber
        {
            get { return _receiverBillingNumber; }
            set { _receiverBillingNumber = value; }
        }
        private DateTime? _deliveryDate;
        public DateTime? DeliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }
        private string _deliveryTime;
        public string DeliveryTime
        {
            get { return _deliveryTime; }
            set { _deliveryTime = value; }
        }
        private string _origniationSenderName;
        public string OrigniationSenderName
        {
            get { return _origniationSenderName; }
            set { _origniationSenderName = value; }
        }
        private string _originationAddress;
        public string OriginationAddress
        {
            get { return _originationAddress; }
            set { _originationAddress = value; }
        }
        private string _originationAddress2;
        public string OriginationAddress2
        {
            get { return _originationAddress2; }
            set { _originationAddress2 = value; }
        }
        private string _originationStateCode;
        public string OriginationStateCode
        {
            get { return _originationStateCode; }
            set { _originationStateCode = value; }
        }
        private string _originationCityName;
        public string OriginationCityName
        {
            get { return _originationCityName; }
            set { _originationCityName = value; }
        }
        private string _originationZipCode;
        public string OriginationZipCode
        {
            get { return _originationZipCode; }
            set { _originationZipCode = value; }
        }
        private string _originationCountryCode;
        public string OriginationCountryCode
        {
            get { return _originationCountryCode; }
            set { _originationCountryCode = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_399"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_399_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_399Columns
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
        PackageTrackingNumber,
        NumberOfPackages,
        ServiceDescription,
        ActualWeightUnitOfMeasure,
        ShipDate,
        ShipTime,
        ShipperAccountNumber,
        ReceiverBillingNumber,
        DeliveryDate,
        DeliveryTime,
        OrigniationSenderName,
        OriginationAddress,
        OriginationAddress2,
        OriginationStateCode,
        OriginationCityName,
        OriginationZipCode,
        OriginationCountryCode,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_399Procedure
    {
        p_F_E_DTR_399_GetBy_F_E_DTR_320ID
    }
    public class F_E_DTR_399List : List<F_E_DTR_399>
    {

    }
}