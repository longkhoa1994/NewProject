using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_371 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _F_E_DTR_370ID;
        public long? F_E_DTR_370ID
        {
            get { return _F_E_DTR_370ID; }
            set { _F_E_DTR_370ID = value; }
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
        private string _postTime;
        public string PostTime
        {
            get { return _postTime; }
            set { _postTime = value; }
        }
        private DateTime? _checkInDate;
        public DateTime? CheckInDate
        {
            get { return _checkInDate; }
            set { _checkInDate = value; }
        }
        private DateTime? _checkOutDate;
        public DateTime? CheckOutDate
        {
            get { return _checkOutDate; }
            set { _checkOutDate = value; }
        }
        private string _folioNum;
        public string FolioNum
        {
            get { return _folioNum; }
            set { _folioNum = value; }
        }
        private decimal? _roomRate;
        public decimal? RoomRate
        {
            get { return _roomRate; }
            set { _roomRate = value; }
        }
        private string _renterName;
        public string RenterName
        {
            get { return _renterName; }
            set { _renterName = value; }
        }
        private int _lodgingDuration;
        public int LodgingDuration
        {
            get { return _lodgingDuration; }
            set { _lodgingDuration = value; }
        }
        private decimal? _checkInTime;
        public decimal? CheckInTime
        {
            get { return _checkInTime; }
            set { _checkInTime = value; }
        }
        private decimal? _checkOutTime;
        public decimal? CheckOutTime
        {
            get { return _checkOutTime; }
            set { _checkOutTime = value; }
        }
        private decimal? _lodgingProgram;
        public decimal? LodgingProgram
        {
            get { return _lodgingProgram; }
            set { _lodgingProgram = value; }
        }
        private decimal? _chargeTypeCode;
        public decimal? ChargeTypeCode
        {
            get { return _chargeTypeCode; }
            set { _chargeTypeCode = value; }
        }
        private decimal? _lodgingRoomRate2;
        public decimal? LodgingRoomRate2
        {
            get { return _lodgingRoomRate2; }
            set { _lodgingRoomRate2 = value; }
        }
        private decimal? _lodgingRoomRate3;
        public decimal? LodgingRoomRate3
        {
            get { return _lodgingRoomRate3; }
            set { _lodgingRoomRate3 = value; }
        }
        private decimal? _numberOfNightsAtRoomRate2;
        public decimal? NumberOfNightsAtRoomRate2
        {
            get { return _numberOfNightsAtRoomRate2; }
            set { _numberOfNightsAtRoomRate2 = value; }
        }
        private decimal? _numberOfNightsAtRoomRate3;
        public decimal? NumberOfNightsAtRoomRate3
        {
            get { return _numberOfNightsAtRoomRate3; }
            set { _numberOfNightsAtRoomRate3 = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_371"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_371_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_371Columns
    {
        ID,
        F_E_DTR_370ID,
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
        PostTime,
        CheckInDate,
        CheckOutDate,
        FolioNum,
        RoomRate,
        RenterName,
        LodgingDuration,
        CheckInTime,
        CheckOutTime,
        LodgingProgram,
        ChargeTypeCode,
        LodgingRoomRate2,
        LodgingRoomRate3,
        NumberOfNightsAtRoomRate2,
        NumberOfNightsAtRoomRate3,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_371Procedure
    {
        p_F_E_DTR_371_GetBy_F_E_DTR_370ID
    }
    public class F_E_DTR_371List : List<F_E_DTR_371>
    {

    }
}