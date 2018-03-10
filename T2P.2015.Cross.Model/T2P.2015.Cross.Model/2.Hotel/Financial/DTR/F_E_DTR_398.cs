using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_398 : BaseModel
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
        private DateTime? _weekEnding;
        public DateTime? WeekEnding
        {
            get { return _weekEnding; }
            set { _weekEnding = value; }
        }
        private string _employeeTempName;
        public string EmployeeTempName
        {
            get { return _employeeTempName; }
            set { _employeeTempName = value; }
        }
        private string _tempSocialSecurityNumber;
        public string TempSocialSecurityNumber
        {
            get { return _tempSocialSecurityNumber; }
            set { _tempSocialSecurityNumber = value; }
        }
        private string _jobCode;
        public string JobCode
        {
            get { return _jobCode; }
            set { _jobCode = value; }
        }
        private string _overtimeHours;
        public string OvertimeHours
        {
            get { return _overtimeHours; }
            set { _overtimeHours = value; }
        }
        private decimal? _overtimeRate;
        public decimal? OvertimeRate
        {
            get { return _overtimeRate; }
            set { _overtimeRate = value; }
        }
        private string _regularHours;
        public string RegularHours
        {
            get { return _regularHours; }
            set { _regularHours = value; }
        }
        private decimal? _regularHoursRate;
        public decimal? RegularHoursRate
        {
            get { return _regularHoursRate; }
            set { _regularHoursRate = value; }
        }
        private string _requestorNameId;
        public string RequestorNameId
        {
            get { return _requestorNameId; }
            set { _requestorNameId = value; }
        }
        private string _doubletimeHours;
        public string DoubletimeHours
        {
            get { return _doubletimeHours; }
            set { _doubletimeHours = value; }
        }
        private decimal? _doubletimeRate;
        public decimal? DoubletimeRate
        {
            get { return _doubletimeRate; }
            set { _doubletimeRate = value; }
        }
        private string _trainingHours;
        public string TrainingHours
        {
            get { return _trainingHours; }
            set { _trainingHours = value; }
        }
        private decimal? _trainingRate;
        public decimal? TrainingRate
        {
            get { return _trainingRate; }
            set { _trainingRate = value; }
        }
        private decimal? _shiftDifferentialAmount;
        public decimal? ShiftDifferentialAmount
        {
            get { return _shiftDifferentialAmount; }
            set { _shiftDifferentialAmount = value; }
        }
        private string _workShift;
        public string WorkShift
        {
            get { return _workShift; }
            set { _workShift = value; }
        }
        private string _reasonForUse;
        public string ReasonForUse
        {
            get { return _reasonForUse; }
            set { _reasonForUse = value; }
        }
        private string _reasonForEndCode;
        public string ReasonForEndCode
        {
            get { return _reasonForEndCode; }
            set { _reasonForEndCode = value; }
        }
        private string _officeCode;
        public string OfficeCode
        {
            get { return _officeCode; }
            set { _officeCode = value; }
        }
        private string _nationalIdentifier;
        public string NationalIdentifier
        {
            get { return _nationalIdentifier; }
            set { _nationalIdentifier = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_398"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_398_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_398Columns
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
        WeekEnding,
        EmployeeTempName,
        TempSocialSecurityNumber,
        JobCode,
        OvertimeHours,
        OvertimeRate,
        RegularHours,
        RegularHoursRate,
        RequestorNameId,
        DoubletimeHours,
        DoubletimeRate,
        TrainingHours,
        TrainingRate,
        ShiftDifferentialAmount,
        WorkShift,
        ReasonForUse,
        ReasonForEndCode,
        OfficeCode,
        NationalIdentifier,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_398Procedure
    {
        p_F_E_DTR_398_GetBy_F_E_DTR_320ID
    }
    public class F_E_DTR_398List : List<F_E_DTR_398>
    {

    }
}