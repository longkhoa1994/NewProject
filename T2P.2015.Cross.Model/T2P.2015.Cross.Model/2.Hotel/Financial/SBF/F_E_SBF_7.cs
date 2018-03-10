using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_SBF_7 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_E_SBF_2ID;
        public long F_E_SBF_2ID
        {
            get { return _f_E_SBF_2ID; }
            set { _f_E_SBF_2ID = value; }
        }
        private string _recordTypeID;
        public string RecordTypeID
        {
            get { return _recordTypeID; }
            set { _recordTypeID = value; }
        }
        private string _acctNum;
        public string AcctNum
        {
            get { return _acctNum; }
            set { _acctNum = value; }
        }
        private float? _totDebits;
        public float? TotDebits
        {
            get { return _totDebits; }
            set { _totDebits = value; }
        }
        private float? _totCredits;
        public float? TotCredits
        {
            get { return _totCredits; }
            set { _totCredits = value; }
        }
        private float? _totPayments;
        public float? TotPayments
        {
            get { return _totPayments; }
            set { _totPayments = value; }
        }
        private DateTime? _closingDate;
        public DateTime? ClosingDate
        {
            get { return _closingDate; }
            set { _closingDate = value; }
        }
        private float? _prevBal;
        public float? PrevBal
        {
            get { return _prevBal; }
            set { _prevBal = value; }
        }
        private float? _currBal;
        public float? CurrBal
        {
            get { return _currBal; }
            set { _currBal = value; }
        }
        private string _creditLimit;
        public string CreditLimit
        {
            get { return _creditLimit; }
            set { _creditLimit = value; }
        }
        private float? _currPayDue;
        public float? CurrPayDue
        {
            get { return _currPayDue; }
            set { _currPayDue = value; }
        }
        private string _numPayPastDue;
        public string NumPayPastDue
        {
            get { return _numPayPastDue; }
            set { _numPayPastDue = value; }
        }
        private string _highestDegreeDelinq;
        public string HighestDegreeDelinq
        {
            get { return _highestDegreeDelinq; }
            set { _highestDegreeDelinq = value; }
        }
        private float? _amtPastDue;
        public float? AmtPastDue
        {
            get { return _amtPastDue; }
            set { _amtPastDue = value; }
        }
        private float? _disputedAmt;
        public float? DisputedAmt
        {
            get { return _disputedAmt; }
            set { _disputedAmt = value; }
        }
        private string _numOfCards;
        public string NumOfCards
        {
            get { return _numOfCards; }
            set { _numOfCards = value; }
        }
        private string _acctInDisputeFlag;
        public string AcctInDisputeFlag
        {
            get { return _acctInDisputeFlag; }
            set { _acctInDisputeFlag = value; }
        }
        private string _tBRLevel1;
        public string TBRLevel1
        {
            get { return _tBRLevel1; }
            set { _tBRLevel1 = value; }
        }
        private string _tBRLevel2;
        public string TBRLevel2
        {
            get { return _tBRLevel2; }
            set { _tBRLevel2 = value; }
        }
        private string _tBRLevel3;
        public string TBRLevel3
        {
            get { return _tBRLevel3; }
            set { _tBRLevel3 = value; }
        }
        private string _tBRLevel4;
        public string TBRLevel4
        {
            get { return _tBRLevel4; }
            set { _tBRLevel4 = value; }
        }
        private string _tBRLevel5;
        public string TBRLevel5
        {
            get { return _tBRLevel5; }
            set { _tBRLevel5 = value; }
        }
        private string _tBRLevel6;
        public string TBRLevel6
        {
            get { return _tBRLevel6; }
            set { _tBRLevel6 = value; }
        }
        private string _tBRLevel7;
        public string TBRLevel7
        {
            get { return _tBRLevel7; }
            set { _tBRLevel7 = value; }
        }
        private string _tBRLevel8;
        public string TBRLevel8
        {
            get { return _tBRLevel8; }
            set { _tBRLevel8 = value; }
        }
        private string _prevBalFlag;
        public string PrevBalFlag
        {
            get { return _prevBalFlag; }
            set { _prevBalFlag = value; }
        }
        private string _currBalFlag;
        public string CurrBalFlag
        {
            get { return _currBalFlag; }
            set { _currBalFlag = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_SBF_7"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_SBF_7_InsertOrUpdate"; } }
    }
    public enum F_E_SBF_7Columns
    {
        ID,
        F_E_SBF_2ID,
        RecordTypeID,
        AcctNum,
        TotDebits,
        TotCredits,
        TotPayments,
        ClosingDate,
        PrevBal,
        CurrBal,
        CreditLimit,
        CurrPayDue,
        NumPayPastDue,
        HighestDegreeDelinq,
        AmtPastDue,
        DisputedAmt,
        NumOfCards,
        AcctInDisputeFlag,
        TBRLevel1,
        TBRLevel2,
        TBRLevel3,
        TBRLevel4,
        TBRLevel5,
        TBRLevel6,
        TBRLevel7,
        TBRLevel8,
        PrevBalFlag,
        CurrBalFlag,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_SBF_7Procedure
    {
        p_F_E_SBF_7_GetBySBF_2ID,
        p_F_E_SBF_7_GetFromImportFIN
    }
    public class F_E_SBF_7List : List<F_E_SBF_7>
    {

    }
}