using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_TamaraFile : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        private long _m_FileLocationID;
        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }
        private string _fileType;
        public string FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
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
        private string _tokenStringPCI;
        public string TokenStringPCI
        {
            get { return _tokenStringPCI; }
            set { _tokenStringPCI = value; }
        }
        private bool? _isSuccess;
        public bool? IsSuccess
        {
            get { return _isSuccess; }
            set { _isSuccess = value; }
        }
        public override string Table { get { return "F_TamaraFile"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_TamaraFile_InsertOrUpdate"; } }
    }
    public enum F_TamaraFileColumns
    {
        ID,
        B_AccessID,
        M_FileLocationID,
        FileType,
        FileName,
        FilePath,
        TokenStringPCI,
        IsSuccess,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_TamaraFileProcedure
    {

    }
    
    public class F_TamaraFileList : List<F_TamaraFile>
    {

    }

    public enum F_TamaraFileType
    {
        EN,
        MA
    }
}