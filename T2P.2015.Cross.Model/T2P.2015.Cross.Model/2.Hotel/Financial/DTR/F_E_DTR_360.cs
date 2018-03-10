using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_360 : BaseModel
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
        private string _rentLocId;
        public string RentLocId
        {
            get { return _rentLocId; }
            set { _rentLocId = value; }
        }
        private string _custServ800Num;
        public string CustServ800Num
        {
            get { return _custServ800Num; }
            set { _custServ800Num = value; }
        }
        private string _rentClass;
        public string RentClass
        {
            get { return _rentClass; }
            set { _rentClass = value; }
        }
        private decimal? _dailyRentRate;
        public decimal? DailyRentRate
        {
            get { return _dailyRentRate; }
            set { _dailyRentRate = value; }
        }
        private decimal? _ratePerMile;
        public decimal? RatePerMile
        {
            get { return _ratePerMile; }
            set { _ratePerMile = value; }
        }
        private decimal? _totalMiles;
        public decimal? TotalMiles
        {
            get { return _totalMiles; }
            set { _totalMiles = value; }
        }
        private decimal? _maxFreeMiles;
        public decimal? MaxFreeMiles
        {
            get { return _maxFreeMiles; }
            set { _maxFreeMiles = value; }
        }
        private string _insurInd;
        public string InsurInd
        {
            get { return _insurInd; }
            set { _insurInd = value; }
        }
        private decimal? _insurCharges;
        public decimal? InsurCharges
        {
            get { return _insurCharges; }
            set { _insurCharges = value; }
        }
        private string _adjAmtIndic;
        public string AdjAmtIndic
        {
            get { return _adjAmtIndic; }
            set { _adjAmtIndic = value; }
        }
        private decimal? _adjAmt;
        public decimal? AdjAmt
        {
            get { return _adjAmt; }
            set { _adjAmt = value; }
        }
        private string _programCd;
        public string ProgramCd
        {
            get { return _programCd; }
            set { _programCd = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_360"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_360_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_360Columns
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
        RentAgreeNo,
        RentName,
        RentReturnCity,
        RentReturnState,
        RentReturnDate,
        RentLocId,
        CustServ800Num,
        RentClass,
        DailyRentRate,
        RatePerMile,
        TotalMiles,
        MaxFreeMiles,
        InsurInd,
        InsurCharges,
        AdjAmtIndic,
        AdjAmt,
        ProgramCd,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_360Procedure
    {
        p_F_E_DTR_360_GetBy_F_E_DTR_320ID
    }
    public class F_E_DTR_360List : List<F_E_DTR_360>
    {

    }
}