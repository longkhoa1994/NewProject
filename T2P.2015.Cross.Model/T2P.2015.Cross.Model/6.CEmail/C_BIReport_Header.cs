using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_BIReport_Header : BaseModel
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
        private string _from;
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        private string _to;
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        private string _messageID;
        public string MessageID
        {
            get { return _messageID; }
            set { _messageID = value; }
        }
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        private DateTime _receivingDate;
        public DateTime ReceivingDate
        {
            get { return _receivingDate; }
            set { _receivingDate = value; }
        }        

        private DateTime _sendDate;
        public DateTime SendDate
        {
            get { return _sendDate; }
            set { _sendDate = value; }
        }
        private int _fileStatus;
        public int FileStatus
        {
            get { return _fileStatus; }
            set { _fileStatus = value; }
        }
        private int _importStatus;
        public int ImportStatus
        {
            get { return _importStatus; }
            set { _importStatus = value; }
        }
        public override string Table { get { return "C_BIReport_Header"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_BIReport_Header_InsertOrUpdate"; } }
    }
    public enum C_BIReport_HeaderColumns
    {
        ID,
        C_HeaderID,
        M_FileLocationID,
        From,
        To,
        MessageID,
        FileName,
        FilePath,
        Subject,
        ReceivingDate,
        SendDate,
        FileStatus,
        ImportStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum C_BIReport_HeaderProcedure
    {
        p_C_BIReport_Header_CheckMessage
    }
    public class C_BIReport_HeaderList : List<C_BIReport_Header>
    {

    }
}