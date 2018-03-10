using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_Image : BaseModel
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
        public override string Table { get { return "C_Image"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_Image_InsertOrUpdate"; } }
    }
    public enum C_ImageColumns
    {
        ID,
        C_HeaderID,
        M_FileLocationID,
        FileName,
        FilePath,
        CreatedBy,
        CreatedDateTime,
        UpdatedBy,
        UpdatedDateTime,
        Status,
    }
    public enum C_ImageProcedure
    {

    }
    public class C_ImageList : List<C_Image>
    {

    }
}