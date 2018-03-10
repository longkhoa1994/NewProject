using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_TransactionSummary : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_HeaderID;
        public long F_HeaderID
        {
            get { return _f_HeaderID; }
            set { _f_HeaderID = value; }
        }
        private string _recordIdentifier;
        public string RecordIdentifier
        {
            get { return _recordIdentifier; }
            set { _recordIdentifier = value; }
        }
        private string _fileIndicator;
        public string FileIndicator
        {
            get { return _fileIndicator; }
            set { _fileIndicator = value; }
        }
        private string _uniqueFileID;
        public string UniqueFileID
        {
            get { return _uniqueFileID; }
            set { _uniqueFileID = value; }
        }
        private int _genericFinancialComplaintTransactionCount;
        public int GenericFinancialComplaintTransactionCount
        {
            get { return _genericFinancialComplaintTransactionCount; }
            set { _genericFinancialComplaintTransactionCount = value; }
        }
        private int _lineCount;
        public int LineCount
        {
            get { return _lineCount; }
            set { _lineCount = value; }
        }
        private float _transactionAmountSum;
        public float TransactionAmountSum
        {
            get { return _transactionAmountSum; }
            set { _transactionAmountSum = value; }
        }
        private float _absoluteTransactionSum;
        public float AbsoluteTransactionSum
        {
            get { return _absoluteTransactionSum; }
            set { _absoluteTransactionSum = value; }
        }
        public override string Table { get { return "F_TransactionSummary"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_TransactionSummary_InsertOrUpdate"; } }
    }
    public enum F_TransactionSummaryColumns
    {
        ID,
        F_HeaderID,
        RecordIdentifier,
        FileIndicator,
        UniqueFileID,
        GenericFinancialComplaintTransactionCount,
        LineCount,
        TransactionAmountSum,
        AbsoluteTransactionSum,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_TransactionSummaryProcedure
    {

    }
    public class F_TransactionSummaryList : List<F_TransactionSummary>
    {

    }

    public enum F_TransactionSummaryLenght
    {
        length = 60,
    }

    public enum F_TransactionSummaryColumnsLenght
    {
        ID,
        F_HeaderID,
        RecordIdentifier = 3,
        FileIndicator = 11,
        UniqueFileID = 10,
        GenericFinancialComplaintTransactionCount = 5,
        LineCount = 5,
        TransactionAmountSum = 13,
        AbsoluteTransactionSum = 13,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
}