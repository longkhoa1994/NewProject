using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_GL1025_2 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_E_GL1025_1ID;
        public long F_E_GL1025_1ID
        {
            get { return _f_E_GL1025_1ID; }
            set { _f_E_GL1025_1ID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _basicControlAccountNumber;
        public string BasicControlAccountNumber
        {
            get { return _basicControlAccountNumber; }
            set { _basicControlAccountNumber = value; }
        }
        private string _basicControlAccountName;
        public string BasicControlAccountName
        {
            get { return _basicControlAccountName; }
            set { _basicControlAccountName = value; }
        }
        private string _cardMemberAccountNumber;
        public string CardMemberAccountNumber
        {
            get { return _cardMemberAccountNumber; }
            set { _cardMemberAccountNumber = value; }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _middleName;
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }
        private string _cardMemberEmbossedName;
        public string CardMemberEmbossedName
        {
            get { return _cardMemberEmbossedName; }
            set { _cardMemberEmbossedName = value; }
        }
        private string _accountType;
        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }
        private string _cardMemberStatusCode;
        public string CardMemberStatusCode
        {
            get { return _cardMemberStatusCode; }
            set { _cardMemberStatusCode = value; }
        }
        private string _orignalCardMemberNumber;
        public string OrignalCardMemberNumber
        {
            get { return _orignalCardMemberNumber; }
            set { _orignalCardMemberNumber = value; }
        }
        private string _cancelCode;
        public string CancelCode
        {
            get { return _cancelCode; }
            set { _cancelCode = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        private string _liabilityCode;
        public string LiabilityCode
        {
            get { return _liabilityCode; }
            set { _liabilityCode = value; }
        }
        private string _corporationID;
        public string CorporationID
        {
            get { return _corporationID; }
            set { _corporationID = value; }
        }
        private string _primaryISOCurrencyCode;
        public string PrimaryISOCurrencyCode
        {
            get { return _primaryISOCurrencyCode; }
            set { _primaryISOCurrencyCode = value; }
        }
        private int? _decimalPlaceIndicator_PrimaryCurrency;
        public int? DecimalPlaceIndicator_PrimaryCurrency
        {
            get { return _decimalPlaceIndicator_PrimaryCurrency; }
            set { _decimalPlaceIndicator_PrimaryCurrency = value; }
        }
        private string _secondaryISOCurrencyCode;
        public string SecondaryISOCurrencyCode
        {
            get { return _secondaryISOCurrencyCode; }
            set { _secondaryISOCurrencyCode = value; }
        }
        private int? _decimalPlaceIndicator_SecondaryCurrency;
        public int? DecimalPlaceIndicator_SecondaryCurrency
        {
            get { return _decimalPlaceIndicator_SecondaryCurrency; }
            set { _decimalPlaceIndicator_SecondaryCurrency = value; }
        }
        private string _neutralISOCurrencyCode;
        public string NeutralISOCurrencyCode
        {
            get { return _neutralISOCurrencyCode; }
            set { _neutralISOCurrencyCode = value; }
        }
        private int? _decimalPlaceIndicator_NeutralCurrency;
        public int? DecimalPlaceIndicator_NeutralCurrency
        {
            get { return _decimalPlaceIndicator_NeutralCurrency; }
            set { _decimalPlaceIndicator_NeutralCurrency = value; }
        }
        private string _filler2;
        public string Filler2
        {
            get { return _filler2; }
            set { _filler2 = value; }
        }
        private string _signIndicator;
        public string SignIndicator
        {
            get { return _signIndicator; }
            set { _signIndicator = value; }
        }
        private decimal? _debitRecordBalance_PrimaryCurrency;
        public decimal? DebitRecordBalance_PrimaryCurrency
        {
            get { return _debitRecordBalance_PrimaryCurrency; }
            set { _debitRecordBalance_PrimaryCurrency = value; }
        }
        private decimal? _debitRecordBalance_SecondaryCurrency;
        public decimal? DebitRecordBalance_SecondaryCurrency
        {
            get { return _debitRecordBalance_SecondaryCurrency; }
            set { _debitRecordBalance_SecondaryCurrency = value; }
        }
        private decimal? _debitRecordBalance_NeutralCurrency;
        public decimal? DebitRecordBalance_NeutralCurrency
        {
            get { return _debitRecordBalance_NeutralCurrency; }
            set { _debitRecordBalance_NeutralCurrency = value; }
        }
        private int? _cardMemberDebitRecordCount;
        public int? CardMemberDebitRecordCount
        {
            get { return _cardMemberDebitRecordCount; }
            set { _cardMemberDebitRecordCount = value; }
        }
        private string _filler3;
        public string Filler3
        {
            get { return _filler3; }
            set { _filler3 = value; }
        }
        private string _signIndicator2;
        public string SignIndicator2
        {
            get { return _signIndicator2; }
            set { _signIndicator2 = value; }
        }
        private decimal? _creditRecordBalance_PrimaryCurrency;
        public decimal? CreditRecordBalance_PrimaryCurrency
        {
            get { return _creditRecordBalance_PrimaryCurrency; }
            set { _creditRecordBalance_PrimaryCurrency = value; }
        }
        private decimal? _creditRecordBalance_SecondaryCurrency;
        public decimal? CreditRecordBalance_SecondaryCurrency
        {
            get { return _creditRecordBalance_SecondaryCurrency; }
            set { _creditRecordBalance_SecondaryCurrency = value; }
        }
        private decimal? _creditRecordBalance_NeutralCurrency;
        public decimal? CreditRecordBalance_NeutralCurrency
        {
            get { return _creditRecordBalance_NeutralCurrency; }
            set { _creditRecordBalance_NeutralCurrency = value; }
        }
        private int? _cardMemberCreditRecordCount;
        public int? CardMemberCreditRecordCount
        {
            get { return _cardMemberCreditRecordCount; }
            set { _cardMemberCreditRecordCount = value; }
        }
        private string _filler4;
        public string Filler4
        {
            get { return _filler4; }
            set { _filler4 = value; }
        }
        private string _signIndicator3;
        public string SignIndicator3
        {
            get { return _signIndicator3; }
            set { _signIndicator3 = value; }
        }
        private decimal? _cardMemberBalance_PrimaryCurrency;
        public decimal? CardMemberBalance_PrimaryCurrency
        {
            get { return _cardMemberBalance_PrimaryCurrency; }
            set { _cardMemberBalance_PrimaryCurrency = value; }
        }
        private string _signIndicator4;
        public string SignIndicator4
        {
            get { return _signIndicator4; }
            set { _signIndicator4 = value; }
        }
        private decimal? _cardMemberBalance_SecondaryCurrency;
        public decimal? CardMemberBalance_SecondaryCurrency
        {
            get { return _cardMemberBalance_SecondaryCurrency; }
            set { _cardMemberBalance_SecondaryCurrency = value; }
        }
        private string _signIndicator5;
        public string SignIndicator5
        {
            get { return _signIndicator5; }
            set { _signIndicator5 = value; }
        }
        private decimal? _cardMemberBalance_NeutralCurrency;
        public decimal? CardMemberBalance_NeutralCurrency
        {
            get { return _cardMemberBalance_NeutralCurrency; }
            set { _cardMemberBalance_NeutralCurrency = value; }
        }
        private decimal? _cardMemberTotalRecordCount;
        public decimal? CardMemberTotalRecordCount
        {
            get { return _cardMemberTotalRecordCount; }
            set { _cardMemberTotalRecordCount = value; }
        }
        private string _filler5;
        public string Filler5
        {
            get { return _filler5; }
            set { _filler5 = value; }
        }
        private string _signIndicator6;
        public string SignIndicator6
        {
            get { return _signIndicator6; }
            set { _signIndicator6 = value; }
        }
        private decimal? _gSTAmountTotal;
        public decimal? GSTAmountTotal
        {
            get { return _gSTAmountTotal; }
            set { _gSTAmountTotal = value; }
        }
        private decimal? _gSTAmountTotal_NeutralCurrency;
        public decimal? GSTAmountTotal_NeutralCurrency
        {
            get { return _gSTAmountTotal_NeutralCurrency; }
            set { _gSTAmountTotal_NeutralCurrency = value; }
        }
        private string _filler6;
        public string Filler6
        {
            get { return _filler6; }
            set { _filler6 = value; }
        }
        private string _signIndicator7;
        public string SignIndicator7
        {
            get { return _signIndicator7; }
            set { _signIndicator7 = value; }
        }
        private decimal? _previousCardMemberBalance_PrimaryCurrency;
        public decimal? PreviousCardMemberBalance_PrimaryCurrency
        {
            get { return _previousCardMemberBalance_PrimaryCurrency; }
            set { _previousCardMemberBalance_PrimaryCurrency = value; }
        }
        private string _signIndicator8;
        public string SignIndicator8
        {
            get { return _signIndicator8; }
            set { _signIndicator8 = value; }
        }
        private decimal? _previousCardMemberBalance_SecondaryCurrency;
        public decimal? PreviousCardMemberBalance_SecondaryCurrency
        {
            get { return _previousCardMemberBalance_SecondaryCurrency; }
            set { _previousCardMemberBalance_SecondaryCurrency = value; }
        }
        private string _signIndicator9;
        public string SignIndicator9
        {
            get { return _signIndicator9; }
            set { _signIndicator9 = value; }
        }
        private decimal? _previousCardMemberBalance_NeutralCurrency;
        public decimal? PreviousCardMemberBalance_NeutralCurrency
        {
            get { return _previousCardMemberBalance_NeutralCurrency; }
            set { _previousCardMemberBalance_NeutralCurrency = value; }
        }
        private string _filler7;
        public string Filler7
        {
            get { return _filler7; }
            set { _filler7 = value; }
        }
        private string _signIndicator10;
        public string SignIndicator10
        {
            get { return _signIndicator10; }
            set { _signIndicator10 = value; }
        }
        private decimal? _accumulatedCardMemberDebits_PrimaryCurrency;
        public decimal? AccumulatedCardMemberDebits_PrimaryCurrency
        {
            get { return _accumulatedCardMemberDebits_PrimaryCurrency; }
            set { _accumulatedCardMemberDebits_PrimaryCurrency = value; }
        }
        private decimal? _accumulatedCardMemberDebits_SecondaryCurrency;
        public decimal? AccumulatedCardMemberDebits_SecondaryCurrency
        {
            get { return _accumulatedCardMemberDebits_SecondaryCurrency; }
            set { _accumulatedCardMemberDebits_SecondaryCurrency = value; }
        }
        private decimal? _accumulatedCardMemberDebits_NeutralCurrency;
        public decimal? AccumulatedCardMemberDebits_NeutralCurrency
        {
            get { return _accumulatedCardMemberDebits_NeutralCurrency; }
            set { _accumulatedCardMemberDebits_NeutralCurrency = value; }
        }
        private int? _accumulatedDebitRecordCount;
        public int? AccumulatedDebitRecordCount
        {
            get { return _accumulatedDebitRecordCount; }
            set { _accumulatedDebitRecordCount = value; }
        }
        private string _filler8;
        public string Filler8
        {
            get { return _filler8; }
            set { _filler8 = value; }
        }
        private string _signIndicator11;
        public string SignIndicator11
        {
            get { return _signIndicator11; }
            set { _signIndicator11 = value; }
        }
        private decimal? _accumulatedCardMemberCredits_PrimaryCurrency;
        public decimal? AccumulatedCardMemberCredits_PrimaryCurrency
        {
            get { return _accumulatedCardMemberCredits_PrimaryCurrency; }
            set { _accumulatedCardMemberCredits_PrimaryCurrency = value; }
        }
        private decimal? _accumulatedCardMemberCredits_SecondaryCurrency;
        public decimal? AccumulatedCardMemberCredits_SecondaryCurrency
        {
            get { return _accumulatedCardMemberCredits_SecondaryCurrency; }
            set { _accumulatedCardMemberCredits_SecondaryCurrency = value; }
        }
        private decimal? _accumulatedCardMemberCredits_NeutralCurrency;
        public decimal? AccumulatedCardMemberCredits_NeutralCurrency
        {
            get { return _accumulatedCardMemberCredits_NeutralCurrency; }
            set { _accumulatedCardMemberCredits_NeutralCurrency = value; }
        }
        private int? _accumulatedCreditRecordCount;
        public int? AccumulatedCreditRecordCount
        {
            get { return _accumulatedCreditRecordCount; }
            set { _accumulatedCreditRecordCount = value; }
        }
        private string _filler9;
        public string Filler9
        {
            get { return _filler9; }
            set { _filler9 = value; }
        }
        private decimal? _dollarBalanceConversionRate;
        public decimal? DollarBalanceConversionRate
        {
            get { return _dollarBalanceConversionRate; }
            set { _dollarBalanceConversionRate = value; }
        }
        private int? _dollarBalanceConversionRate_DecimalPlaceIndicator;
        public int? DollarBalanceConversionRate_DecimalPlaceIndicator
        {
            get { return _dollarBalanceConversionRate_DecimalPlaceIndicator; }
            set { _dollarBalanceConversionRate_DecimalPlaceIndicator = value; }
        }
        private string _signIndicator12;
        public string SignIndicator12
        {
            get { return _signIndicator12; }
            set { _signIndicator12 = value; }
        }
        private decimal? _dollarBalanceConversionAmount;
        public decimal? DollarBalanceConversionAmount
        {
            get { return _dollarBalanceConversionAmount; }
            set { _dollarBalanceConversionAmount = value; }
        }
        private int? _dollarBalanceConversionAmount_DecimalPlaceIndicator;
        public int? DollarBalanceConversionAmount_DecimalPlaceIndicator
        {
            get { return _dollarBalanceConversionAmount_DecimalPlaceIndicator; }
            set { _dollarBalanceConversionAmount_DecimalPlaceIndicator = value; }
        }
        private string _billCycleCode;
        public string BillCycleCode
        {
            get { return _billCycleCode; }
            set { _billCycleCode = value; }
        }
        private string _filler10;
        public string Filler10
        {
            get { return _filler10; }
            set { _filler10 = value; }
        }
        public override string Table { get { return "F_E_GL1025_2"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_GL1025_2_InsertOrUpdate"; } }
    }
    public enum F_E_GL1025_2Columns
    {
        ID,
        F_E_GL1025_1ID,
        RecordType,
        BasicControlAccountNumber,
        BasicControlAccountName,
        CardMemberAccountNumber,
        LastName,
        FirstName,
        MiddleName,
        CardMemberEmbossedName,
        AccountType,
        CardMemberStatusCode,
        OrignalCardMemberNumber,
        CancelCode,
        Filler,
        LiabilityCode,
        CorporationID,
        PrimaryISOCurrencyCode,
        DecimalPlaceIndicator_PrimaryCurrency,
        SecondaryISOCurrencyCode,
        DecimalPlaceIndicator_SecondaryCurrency,
        NeutralISOCurrencyCode,
        DecimalPlaceIndicator_NeutralCurrency,
        Filler2,
        SignIndicator,
        DebitRecordBalance_PrimaryCurrency,
        DebitRecordBalance_SecondaryCurrency,
        DebitRecordBalance_NeutralCurrency,
        CardMemberDebitRecordCount,
        Filler3,
        SignIndicator2,
        CreditRecordBalance_PrimaryCurrency,
        CreditRecordBalance_SecondaryCurrency,
        CreditRecordBalance_NeutralCurrency,
        CardMemberCreditRecordCount,
        Filler4,
        SignIndicator3,
        CardMemberBalance_PrimaryCurrency,
        SignIndicator4,
        CardMemberBalance_SecondaryCurrency,
        SignIndicator5,
        CardMemberBalance_NeutralCurrency,
        CardMemberTotalRecordCount,
        Filler5,
        SignIndicator6,
        GSTAmountTotal,
        GSTAmountTotal_NeutralCurrency,
        Filler6,
        SignIndicator7,
        PreviousCardMemberBalance_PrimaryCurrency,
        SignIndicator8,
        PreviousCardMemberBalance_SecondaryCurrency,
        SignIndicator9,
        PreviousCardMemberBalance_NeutralCurrency,
        Filler7,
        SignIndicator10,
        AccumulatedCardMemberDebits_PrimaryCurrency,
        AccumulatedCardMemberDebits_SecondaryCurrency,
        AccumulatedCardMemberDebits_NeutralCurrency,
        AccumulatedDebitRecordCount,
        Filler8,
        SignIndicator11,
        AccumulatedCardMemberCredits_PrimaryCurrency,
        AccumulatedCardMemberCredits_SecondaryCurrency,
        AccumulatedCardMemberCredits_NeutralCurrency,
        AccumulatedCreditRecordCount,
        Filler9,
        DollarBalanceConversionRate,
        DollarBalanceConversionRate_DecimalPlaceIndicator,
        SignIndicator12,
        DollarBalanceConversionAmount,
        DollarBalanceConversionAmount_DecimalPlaceIndicator,
        BillCycleCode,
        Filler10,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_GL1025_2Procedure
    {

    }
    public class F_E_GL1025_2List : List<F_E_GL1025_2>
    {

    }
}