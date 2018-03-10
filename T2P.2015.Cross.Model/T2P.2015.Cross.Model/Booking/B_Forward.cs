using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Forward : BaseModel
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

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private string _filename;

        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        private string _transactionIdentifier;

        public string TransactionIdentifier
        {
            get { return _transactionIdentifier; }
            set { _transactionIdentifier = value; }
        }

        private DateTime _forwardedDatetime;

        public DateTime ForwardedDatetime
        {
            get { return _forwardedDatetime; }
            set { _forwardedDatetime = value; }
        }

        public override string Table { get { return "B_Forward"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Forward_InsertOrUpdate"; } }
    }

    public enum B_ForwardColumns
    {
        ID,
        M_FileLocationID,
        FilePath,
        Filename,
        TransactionIdentifier,
        ForwardedDatetime,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_ForwardProcedure
    {
    }

    public class B_ForwardList : List<B_Forward>
    {
    }
}