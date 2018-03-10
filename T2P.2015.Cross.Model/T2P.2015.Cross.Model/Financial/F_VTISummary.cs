using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_VTISummary : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_FileLocationID;

        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }

        private string _transactionIdentify;

        public string TransactionIdentify
        {
            get { return _transactionIdentify; }
            set { _transactionIdentify = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private DateTime _vTICreatedDateTime;

        public DateTime VTICreatedDateTime
        {
            get { return _vTICreatedDateTime; }
            set { _vTICreatedDateTime = value; }
        }

        private int _numberOfTransaction;

        public int NumberOfTransaction
        {
            get { return _numberOfTransaction; }
            set { _numberOfTransaction = value; }
        }

        private decimal _debitAmount;

        public decimal DebitAmount
        {
            get { return _debitAmount; }
            set { _debitAmount = value; }
        }

        private decimal _creditAmount;

        public decimal CreditAmount
        {
            get { return _creditAmount; }
            set { _creditAmount = value; }
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private string _fileName;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private int _errorCode;

        public int ErrorCode
        {
            get { return _errorCode; }
            set { _errorCode = value; }
        }

        private string _errorText;


        public string ErrorText
        {
            get { return _errorText; }
            set { _errorText = value; }
        }

        public override string Table { get { return "F_VTISummary"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_F_VTISummary_InsertOrUpdate"; } }
    }

    public enum F_VTISummaryColumns
    {
        ID,
        M_FileLocationID,
        TransactionIdentify,
        Type,
        VTICreatedDateTime,
        NumberOfTransaction,
        DebitAmount,
        CreditAmount,
        FilePath,
        FileName,
        ErrorCode,
        ErrorText,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum F_VTISummaryProcedure
    {
        p_F_VTISummary_GetListForDeleting,
        p_F_VTISummary_GetListIDForDeleting,
    }

    public class F_VTISummaryList : List<F_VTISummary>
    {
    }
}