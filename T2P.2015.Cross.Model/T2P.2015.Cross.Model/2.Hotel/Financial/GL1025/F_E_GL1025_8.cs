using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_GL1025_8 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_E_GL1025_0ID;
        public long F_E_GL1025_0ID
        {
            get { return _f_E_GL1025_0ID; }
            set { _f_E_GL1025_0ID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private DateTime? _dataFileContentDate;
        public DateTime? DataFileContentDate
        {
            get { return _dataFileContentDate; }
            set { _dataFileContentDate = value; }
        }
        private DateTime? _dataFileContentDate_Julian;
        public DateTime? DataFileContentDate_Julian
        {
            get { return _dataFileContentDate_Julian; }
            set { _dataFileContentDate_Julian = value; }
        }
        private string _noDataContentIndicator;
        public string NoDataContentIndicator
        {
            get { return _noDataContentIndicator; }
            set { _noDataContentIndicator = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        private int? _recordCount;
        public int? RecordCount
        {
            get { return _recordCount; }
            set { _recordCount = value; }
        }
        private string _marketCode;
        public string MarketCode
        {
            get { return _marketCode; }
            set { _marketCode = value; }
        }
        private string _iSOCurrencyCode_PrimaryCurrency;
        public string ISOCurrencyCode_PrimaryCurrency
        {
            get { return _iSOCurrencyCode_PrimaryCurrency; }
            set { _iSOCurrencyCode_PrimaryCurrency = value; }
        }
        private int? _decimalPlaceIndicator_PrimaryCurrency;
        public int? DecimalPlaceIndicator_PrimaryCurrency
        {
            get { return _decimalPlaceIndicator_PrimaryCurrency; }
            set { _decimalPlaceIndicator_PrimaryCurrency = value; }
        }
        private string _iSOCurrencyCode_SecondaryCurrency;
        public string ISOCurrencyCode_SecondaryCurrency
        {
            get { return _iSOCurrencyCode_SecondaryCurrency; }
            set { _iSOCurrencyCode_SecondaryCurrency = value; }
        }
        private int? _decimalPlaceIndicator_SecondaryCurrency;
        public int? DecimalPlaceIndicator_SecondaryCurrency
        {
            get { return _decimalPlaceIndicator_SecondaryCurrency; }
            set { _decimalPlaceIndicator_SecondaryCurrency = value; }
        }
        private string _iSOCurrencyCode_NeutralCurrency;
        public string ISOCurrencyCode_NeutralCurrency
        {
            get { return _iSOCurrencyCode_NeutralCurrency; }
            set { _iSOCurrencyCode_NeutralCurrency = value; }
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
        private decimal? _totalDailyUnbilledAmount_PrimaryCurrency;
        public decimal? TotalDailyUnbilledAmount_PrimaryCurrency
        {
            get { return _totalDailyUnbilledAmount_PrimaryCurrency; }
            set { _totalDailyUnbilledAmount_PrimaryCurrency = value; }
        }
        private string _signIndicator2;
        public string SignIndicator2
        {
            get { return _signIndicator2; }
            set { _signIndicator2 = value; }
        }
        private decimal? _totalDailyUnbilledAmount_SecondaryCurrency;
        public decimal? TotalDailyUnbilledAmount_SecondaryCurrency
        {
            get { return _totalDailyUnbilledAmount_SecondaryCurrency; }
            set { _totalDailyUnbilledAmount_SecondaryCurrency = value; }
        }
        private string _signIndicator3;
        public string SignIndicator3
        {
            get { return _signIndicator3; }
            set { _signIndicator3 = value; }
        }
        private decimal? _totalDailyUnbilledAmount_NeutralCurrency;
        public decimal? TotalDailyUnbilledAmount_NeutralCurrency
        {
            get { return _totalDailyUnbilledAmount_NeutralCurrency; }
            set { _totalDailyUnbilledAmount_NeutralCurrency = value; }
        }
        private string _filler3;
        public string Filler3
        {
            get { return _filler3; }
            set { _filler3 = value; }
        }
        private string _signIndicator4;
        public string SignIndicator4
        {
            get { return _signIndicator4; }
            set { _signIndicator4 = value; }
        }
        private decimal? _totalCardMemberBalance_PrimaryCurrency;
        public decimal? TotalCardMemberBalance_PrimaryCurrency
        {
            get { return _totalCardMemberBalance_PrimaryCurrency; }
            set { _totalCardMemberBalance_PrimaryCurrency = value; }
        }
        private string _signIndicator5;
        public string SignIndicator5
        {
            get { return _signIndicator5; }
            set { _signIndicator5 = value; }
        }
        private decimal? _totalCardMemberBalance_SecondaryCurrency;
        public decimal? TotalCardMemberBalance_SecondaryCurrency
        {
            get { return _totalCardMemberBalance_SecondaryCurrency; }
            set { _totalCardMemberBalance_SecondaryCurrency = value; }
        }
        private string _signIndicator6;
        public string SignIndicator6
        {
            get { return _signIndicator6; }
            set { _signIndicator6 = value; }
        }
        private decimal? _totalCardMemberBalance_NeutralCurrency;
        public decimal? TotalCardMemberBalance_NeutralCurrency
        {
            get { return _totalCardMemberBalance_NeutralCurrency; }
            set { _totalCardMemberBalance_NeutralCurrency = value; }
        }
        private int? _totalMarketTransactionCount;
        public int? TotalMarketTransactionCount
        {
            get { return _totalMarketTransactionCount; }
            set { _totalMarketTransactionCount = value; }
        }
        private string _filler4;
        public string Filler4
        {
            get { return _filler4; }
            set { _filler4 = value; }
        }
        public override string Table { get { return "F_E_GL1025_8"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_GL1025_8_InsertOrUpdate"; } }
    }
    public enum F_E_GL1025_8Columns
    {
        ID,
        F_E_GL1025_0ID,
        RecordType,
        DataFileContentDate,
        DataFileContentDate_Julian,
        NoDataContentIndicator,
        Filler,
        RecordCount,
        MarketCode,
        ISOCurrencyCode_PrimaryCurrency,
        DecimalPlaceIndicator_PrimaryCurrency,
        ISOCurrencyCode_SecondaryCurrency,
        DecimalPlaceIndicator_SecondaryCurrency,
        ISOCurrencyCode_NeutralCurrency,
        DecimalPlaceIndicator_NeutralCurrency,
        Filler2,
        SignIndicator,
        TotalDailyUnbilledAmount_PrimaryCurrency,
        SignIndicator2,
        TotalDailyUnbilledAmount_SecondaryCurrency,
        SignIndicator3,
        TotalDailyUnbilledAmount_NeutralCurrency,
        Filler3,
        SignIndicator4,
        TotalCardMemberBalance_PrimaryCurrency,
        SignIndicator5,
        TotalCardMemberBalance_SecondaryCurrency,
        SignIndicator6,
        TotalCardMemberBalance_NeutralCurrency,
        TotalMarketTransactionCount,
        Filler4,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_GL1025_8Procedure
    {

    }
    public class F_E_GL1025_8List : List<F_E_GL1025_8>
    {

    }
}