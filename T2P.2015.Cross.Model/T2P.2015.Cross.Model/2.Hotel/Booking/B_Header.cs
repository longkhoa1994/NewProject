using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Header : BaseModel
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

        private string _fileName;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private string _transactionIdentifier;

        public string TransactionIdentifier
        {
            get { return _transactionIdentifier; }
            set { _transactionIdentifier = value; }
        }

        private DateTime _timeStamp;

        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }

        private string _version;

        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }

        private int _bookingCount;

        public int BookingCount
        {
            get { return _bookingCount; }
            set { _bookingCount = value; }
        }

        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
        public override string Table { get { return "B_Header"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Header_InsertOrUpdate"; } }
    }

    public enum B_HeaderColumns
    {
        ID,
        M_FileLocationID,
        FilePath,
        FileName,
        TransactionIdentifier,
        TimeStamp,
        Version,
        BookingCount,
        FileStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_HeaderProcedure
    {
        p_B_Header_Check_Exist,
        p_B_Header_GetListForDeleting,
        p_B_Header_GetListIDForDeleting,
    }

    public class B_HeaderList : List<B_Header>
    {
    }
}