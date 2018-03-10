using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_GL1025_0 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _f_ImportFileID;
        public long? F_ImportFileID
        {
            get { return _f_ImportFileID; }
            set { _f_ImportFileID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _reportingGroup;
        public string ReportingGroup
        {
            get { return _reportingGroup; }
            set { _reportingGroup = value; }
        }
        private string _recipientNumber;
        public string RecipientNumber
        {
            get { return _recipientNumber; }
            set { _recipientNumber = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        private string _reportPrefix;
        public string ReportPrefix
        {
            get { return _reportPrefix; }
            set { _reportPrefix = value; }
        }
        private string _reportNumber;
        public string ReportNumber
        {
            get { return _reportNumber; }
            set { _reportNumber = value; }
        }
        private string _filler2;
        public string Filler2
        {
            get { return _filler2; }
            set { _filler2 = value; }
        }
        private string _clientDataFileVersion;
        public string ClientDataFileVersion
        {
            get { return _clientDataFileVersion; }
            set { _clientDataFileVersion = value; }
        }
        private string _filler3;
        public string Filler3
        {
            get { return _filler3; }
            set { _filler3 = value; }
        }
        private string _fileFrequencyDeliveryIndicator;
        public string FileFrequencyDeliveryIndicator
        {
            get { return _fileFrequencyDeliveryIndicator; }
            set { _fileFrequencyDeliveryIndicator = value; }
        }
        private string _filler4;
        public string Filler4
        {
            get { return _filler4; }
            set { _filler4 = value; }
        }
        private DateTime? _dataFileCreateDate;
        public DateTime? DataFileCreateDate
        {
            get { return _dataFileCreateDate; }
            set { _dataFileCreateDate = value; }
        }
        private string _filler5;
        public string Filler5
        {
            get { return _filler5; }
            set { _filler5 = value; }
        }
        private DateTime? _dataFileJulianDate;
        public DateTime? DataFileJulianDate
        {
            get { return _dataFileJulianDate; }
            set { _dataFileJulianDate = value; }
        }
        private string _filler6;
        public string Filler6
        {
            get { return _filler6; }
            set { _filler6 = value; }
        }
        private string _fileVersionNumber;
        public string FileVersionNumber
        {
            get { return _fileVersionNumber; }
            set { _fileVersionNumber = value; }
        }
        private string _filler7;
        public string Filler7
        {
            get { return _filler7; }
            set { _filler7 = value; }
        }
        private string _fileVersionDate;
        public string FileVersionDate
        {
            get { return _fileVersionDate; }
            set { _fileVersionDate = value; }
        }
        private string _filler8;
        public string Filler8
        {
            get { return _filler8; }
            set { _filler8 = value; }
        }
        private string _fileTypeIndicator;
        public string FileTypeIndicator
        {
            get { return _fileTypeIndicator; }
            set { _fileTypeIndicator = value; }
        }
        private string _filler9;
        public string Filler9
        {
            get { return _filler9; }
            set { _filler9 = value; }
        }
        private int? _totalRecordCount;
        public int? TotalRecordCount
        {
            get { return _totalRecordCount; }
            set { _totalRecordCount = value; }
        }
        private string _filler10;
        public string Filler10
        {
            get { return _filler10; }
            set { _filler10 = value; }
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
        private string _filler11;
        public string Filler11
        {
            get { return _filler11; }
            set { _filler11 = value; }
        }
        private string _signIndicator;
        public string SignIndicator
        {
            get { return _signIndicator; }
            set { _signIndicator = value; }
        }
        private decimal? _totalDailyUnbilledAmount_NeutralCurrency;
        public decimal? TotalDailyUnbilledAmount_NeutralCurrency
        {
            get { return _totalDailyUnbilledAmount_NeutralCurrency; }
            set { _totalDailyUnbilledAmount_NeutralCurrency = value; }
        }
        private string _filler12;
        public string Filler12
        {
            get { return _filler12; }
            set { _filler12 = value; }
        }
        private string _signIndicator2;
        public string SignIndicator2
        {
            get { return _signIndicator2; }
            set { _signIndicator2 = value; }
        }
        private decimal? _totalCardMemberBalance_NeutralCurrency;
        public decimal? TotalCardMemberBalance_NeutralCurrency
        {
            get { return _totalCardMemberBalance_NeutralCurrency; }
            set { _totalCardMemberBalance_NeutralCurrency = value; }
        }
        private string _filler13;
        public string Filler13
        {
            get { return _filler13; }
            set { _filler13 = value; }
        }
        private string _dataFileCreateRunTime;
        public string DataFileCreateRunTime
        {
            get { return _dataFileCreateRunTime; }
            set { _dataFileCreateRunTime = value; }
        }
        private int? _totalTransactionCount;
        public int? TotalTransactionCount
        {
            get { return _totalTransactionCount; }
            set { _totalTransactionCount = value; }
        }
        private string _filler14;
        public string Filler14
        {
            get { return _filler14; }
            set { _filler14 = value; }
        }
        public override string Table { get { return "F_E_GL1025_0"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_GL1025_0_InsertOrUpdate"; } }
    }
    public enum F_E_GL1025_0Columns
    {
        ID,
        F_ImportFileID,
        RecordType,
        ReportingGroup,
        RecipientNumber,
        Filler,
        ReportPrefix,
        ReportNumber,
        Filler2,
        ClientDataFileVersion,
        Filler3,
        FileFrequencyDeliveryIndicator,
        Filler4,
        DataFileCreateDate,
        Filler5,
        DataFileJulianDate,
        Filler6,
        FileVersionNumber,
        Filler7,
        FileVersionDate,
        Filler8,
        FileTypeIndicator,
        Filler9,
        TotalRecordCount,
        Filler10,
        NeutralISOCurrencyCode,
        DecimalPlaceIndicator_NeutralCurrency,
        Filler11,
        SignIndicator,
        TotalDailyUnbilledAmount_NeutralCurrency,
        Filler12,
        SignIndicator2,
        TotalCardMemberBalance_NeutralCurrency,
        Filler13,
        DataFileCreateRunTime,
        TotalTransactionCount,
        Filler14,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_GL1025_0Procedure
    {

    }
    public class F_E_GL1025_0List : List<F_E_GL1025_0>
    {

    }
}