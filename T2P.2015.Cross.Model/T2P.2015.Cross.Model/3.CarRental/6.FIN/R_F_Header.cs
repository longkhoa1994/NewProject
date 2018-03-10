using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_F_Header : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _fileType;

        public string FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
        }
        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private string _transactionIdentify;

        public string TransactionIdentify
        {
            get { return _transactionIdentify; }
            set { _transactionIdentify = value; }
        }

        private string _companyIdentify;

        public string CompanyIdentify
        {
            get { return _companyIdentify; }
            set { _companyIdentify = value; }
        }

        private string companyName;

        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }


        private string _sequenceID;

        public string SequenceID
        {
            get { return _sequenceID; }
            set { _sequenceID = value; }
        }

        private int? _transactionCount;

        public int? TransactionCount
        {
            get { return _transactionCount; }
            set { _transactionCount = value; }
        }

        private int? totalTransaction;

        public int? TotalTransaction
        {
            get { return totalTransaction; }
            set { totalTransaction = value; }
        }

        private decimal? totalAmount;

        public decimal? TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        private int? _reprintCounter;

        public int? ReprintCounter
        {
            get { return _reprintCounter; }
            set { _reprintCounter = value; }
        }

        private DateTime? importDate;

        public DateTime? ImportDate
        {
            get { return importDate; }
            set { importDate = value; }
        }

        public override string Table { get { return "R_F_Header"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_F_Header_InsertOrUpdate"; } }
    }

    public enum R_F_HeaderColumns
    {
        ID,
        FileType,
        FileName,
        TransactionIdentify,
        CompanyIdentify,
        SequenceID,
        TransactionCount,
        ReprintCounter,
        ImportDate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_F_HeaderProcedure
    {
        p_R_F_Header_CheckHeader,
    }

    public class R_F_HeaderList : List<R_F_Header>
    {
    }
}