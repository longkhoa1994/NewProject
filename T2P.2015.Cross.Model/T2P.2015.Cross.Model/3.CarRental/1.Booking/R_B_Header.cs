using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_B_Header : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? r_B_ImportID;

        public long? R_B_ImportID
        {
            get { return r_B_ImportID; }
            set { r_B_ImportID = value; }
        }

        private long m_FileLocationID;

        public long M_FileLocationID
        {
            get { return m_FileLocationID; }
            set { m_FileLocationID = value; }
        }

        private string filePath;

        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        private string fileName;

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private string _reservationStatus;

        public string ReservationStatus
        {
            get { return _reservationStatus; }
            set { _reservationStatus = value; }
        }

        private DateTime? _timeStamp;

        public DateTime? TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private string _echoToken;

        public string EchoToken
        {
            get { return _echoToken; }
            set { _echoToken = value; }
        }

        private string _transactionIdentifier;

        public string TransactionIdentifier
        {
            get { return _transactionIdentifier; }
            set { _transactionIdentifier = value; }
        }

        private string _version;

        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }

        private int? _reservationCount;

        public int? ReservationCount
        {
            get { return _reservationCount; }
            set { _reservationCount = value; }
        }

        public override string Table { get { return "R_B_Header"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_B_Header_InsertOrUpdate"; } }
    }

    public enum R_B_HeaderColumns
    {
        ID,
        R_B_ImportID,
        ReservationStatus,
        TimeStamp,
        EchoToken,
        TransactionIdentifier,
        Version,
        ReservationCount,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_B_HeaderProcedure
    {
    }

    public class R_B_HeaderList : List<R_B_Header>
    {
    }
}