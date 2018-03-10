using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_Export_CSV : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _c_Export_HeaderID;
        public long C_Export_HeaderID
        {
            get { return _c_Export_HeaderID; }
            set { _c_Export_HeaderID = value; }
        }
        private string _fileType;
        public string FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
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
        public override string Table { get { return "C_Export_CSV"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_Export_CSV_InsertOrUpdate"; } }
    }
    public enum C_Export_CSVColumns
    {
        ID,
        C_Export_HeaderID,
        FileType,
        M_FileLocationID,
        FileName,
        FilePath,
        CreatedBy,
        CreatedDateTime,
        UpdatedBy,
        UpdatedDateTime,
        Status,
    }
    public enum C_Export_CSVProcedure
    {

    }
    public class C_Export_CSVList : List<C_Export_CSV>
    {

    }
}