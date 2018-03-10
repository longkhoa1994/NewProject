using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Import : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private DateTime _importDateTime;

        public DateTime ImportDateTime
        {
            get { return _importDateTime; }
            set { _importDateTime = value; }
        }

        private long _m_FileLocationID;

        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }

        private string _filename;

        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public override string Table { get { return "I_Import"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_I_Import_InsertOrUpdate"; } }
    }

    public enum I_ImportColumns
    {
        ID,
        ImportDateTime,
        M_FileLocationID,
        Filename,
        FilePath,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum I_ImportProcedure
    {
        p_I_Import_GetListForDeleting,
        p_I_Import_GetListIDForDeleting,
    }

    public class I_ImportList : List<I_Import>
    {
    }
}