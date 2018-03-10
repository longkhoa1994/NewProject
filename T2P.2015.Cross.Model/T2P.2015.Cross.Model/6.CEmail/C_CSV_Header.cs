using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_CSV_Header : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _c_HeaderID;
        public long C_HeaderID
        {
            get { return _c_HeaderID; }
            set { _c_HeaderID = value; }
        }

        private long _m_FileLocationID;
        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
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
        public override string Table { get { return "C_CSV_Header"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_CSV_Header_InsertOrUpdate"; } }
    }
    public enum C_CSV_HeaderColumns
    {
        ID,
        C_HeaderID,
        M_FileLocationID,
        FileName,
        FilePath,
        FileStatus,
        ImportStatus,
        CreatedBy,
        CreatedDateTime,
        UpdatedBy,
        UpdatedDateTime,
        Status,
    }
    public enum C_CSV_HeaderProcedure
    {
        p_C_CSV_Header_Get_ForDelivery
    }
    public class C_CSV_HeaderList : List<C_CSV_Header>
    {

    }

    public enum C_CSVFileStatus
    {
        Store = 1,
        ReadyExport = 2,
        Exported = 3,
        FailedExport = 4
    }
}