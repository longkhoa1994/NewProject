using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_DTR_361 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _f_I_DTR_360ID;
        public long? F_I_DTR_360ID
        {
            get { return _f_I_DTR_360ID; }
            set { _f_I_DTR_360ID = value; }
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
        private string _rentAgreeNo;
        public string RentAgreeNo
        {
            get { return _rentAgreeNo; }
            set { _rentAgreeNo = value; }
        }
        private string _rentName;
        public string RentName
        {
            get { return _rentName; }
            set { _rentName = value; }
        }
        private string _rentReturnCity;
        public string RentReturnCity
        {
            get { return _rentReturnCity; }
            set { _rentReturnCity = value; }
        }
        private string _rentReturnState;
        public string RentReturnState
        {
            get { return _rentReturnState; }
            set { _rentReturnState = value; }
        }
        private DateTime? _rentReturnDate;
        public DateTime? RentReturnDate
        {
            get { return _rentReturnDate; }
            set { _rentReturnDate = value; }
        }
        private string _rentClass;
        public string RentClass
        {
            get { return _rentClass; }
            set { _rentClass = value; }
        }
        private decimal? _totalMiles;
        public decimal? TotalMiles
        {
            get { return _totalMiles; }
            set { _totalMiles = value; }
        }
        private string _rentPickupCity;
        public string RentPickupCity
        {
            get { return _rentPickupCity; }
            set { _rentPickupCity = value; }
        }
        private string _rentPickupState;
        public string RentPickupState
        {
            get { return _rentPickupState; }
            set { _rentPickupState = value; }
        }
        private DateTime? _rentPickupDate;
        public DateTime? RentPickupDate
        {
            get { return _rentPickupDate; }
            set { _rentPickupDate = value; }
        }
        private string _rentalAgencyName;
        public string RentalAgencyName
        {
            get { return _rentalAgencyName; }
            set { _rentalAgencyName = value; }
        }
        private string _rentalAgencyCity;
        public string RentalAgencyCity
        {
            get { return _rentalAgencyCity; }
            set { _rentalAgencyCity = value; }
        }
        private string _rentalAgencyCountryCode;
        public string RentalAgencyCountryCode
        {
            get { return _rentalAgencyCountryCode; }
            set { _rentalAgencyCountryCode = value; }
        }
        private decimal? _autoRentalPickupTime;
        public decimal? AutoRentalPickupTime
        {
            get { return _autoRentalPickupTime; }
            set { _autoRentalPickupTime = value; }
        }
        private decimal? _autoRentalReturnTime;
        public decimal? AutoRentalReturnTime
        {
            get { return _autoRentalReturnTime; }
            set { _autoRentalReturnTime = value; }
        }
        private string _autoRentalRegionCode;
        public string AutoRentalRegionCode
        {
            get { return _autoRentalRegionCode; }
            set { _autoRentalRegionCode = value; }
        }
        private string _autoRentalPickupRegionCode;
        public string AutoRentalPickupRegionCode
        {
            get { return _autoRentalPickupRegionCode; }
            set { _autoRentalPickupRegionCode = value; }
        }
        private string _autoRentalReturnRegionCode;
        public string AutoRentalReturnRegionCode
        {
            get { return _autoRentalReturnRegionCode; }
            set { _autoRentalReturnRegionCode = value; }
        }
        private string _autoRentalAuditAdjustmentIndicator;
        public string AutoRentalAuditAdjustmentIndicator
        {
            get { return _autoRentalAuditAdjustmentIndicator; }
            set { _autoRentalAuditAdjustmentIndicator = value; }
        }
        private decimal? _autoRentalAuditAdjustmentAmount;
        public decimal? AutoRentalAuditAdjustmentAmount
        {
            get { return _autoRentalAuditAdjustmentAmount; }
            set { _autoRentalAuditAdjustmentAmount = value; }
        }
        private string _autoRentalPickupLocation;
        public string AutoRentalPickupLocation
        {
            get { return _autoRentalPickupLocation; }
            set { _autoRentalPickupLocation = value; }
        }
        private string _autoRentalDistanceUnitOfMeasure;
        public string AutoRentalDistanceUnitOfMeasure
        {
            get { return _autoRentalDistanceUnitOfMeasure; }
            set { _autoRentalDistanceUnitOfMeasure = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_I_DTR_361"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_DTR_361_InsertOrUpdate"; } }
    }
    public enum F_I_DTR_361Columns
    {
        ID,
        F_I_DTR_360ID,
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
        RentAgreeNo,
        RentName,
        RentReturnCity,
        RentReturnState,
        RentReturnDate,
        RentClass,
        TotalMiles,
        RentPickupCity,
        RentPickupState,
        RentPickupDate,
        RentalAgencyName,
        RentalAgencyCity,
        RentalAgencyCountryCode,
        AutoRentalPickupTime,
        AutoRentalReturnTime,
        AutoRentalRegionCode,
        AutoRentalPickupRegionCode,
        AutoRentalReturnRegionCode,
        AutoRentalAuditAdjustmentIndicator,
        AutoRentalAuditAdjustmentAmount,
        AutoRentalPickupLocation,
        AutoRentalDistanceUnitOfMeasure,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_I_DTR_361Procedure
    {
        p_F_I_DTR_361_GetBy_F_I_DTR_360ID
    }
    public class F_I_DTR_361List : List<F_I_DTR_361>
    {

    }
}