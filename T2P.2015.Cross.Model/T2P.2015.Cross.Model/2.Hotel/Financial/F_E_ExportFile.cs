using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_ExportFile : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _f_E_ExportID;
        public long? F_E_ExportID
        {
            get { return _f_E_ExportID; }
            set { _f_E_ExportID = value; }
        }

        private long? _f_ImportFileID;
        public long? F_ImportFileID
        {
            get { return _f_ImportFileID; }
            set { _f_ImportFileID = value; }
        }
        private long? _convert_FileTypeID;
        public long? Convert_FileTypeID
        {
            get { return _convert_FileTypeID; }
            set { _convert_FileTypeID = value; }
        }

        private long _m_CompanyDeliveryID;
        public long M_CompanyDeliveryID
        {
            get { return _m_CompanyDeliveryID; }
            set { _m_CompanyDeliveryID = value; }
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
        private int _exportStatus;
        public int ExportStatus
        {
            get { return _exportStatus; }
            set { _exportStatus = value; }
        }

        private string _exportType;
        public string ExportType
        {
            get { return _exportType; }
            set { _exportType = value; }
        }

        public override string Table { get { return "F_E_ExportFile"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_ExportFile_InsertOrUpdate"; } }
    }
    public enum F_E_ExportFileColumns
    {
        ID,
        F_ImportFileID,
        Convert_FileTypeID,
        M_CompanyDeliveryID,
        M_FileLocationID,
        FilePath,
        FileName,
        ExportStatus,
        ExportType,
        CreatedBy,
        CreatedDate,
        Updatedby,
        UpdatedDate,
        Status,
    }
    public enum F_E_ExportFileProcedure
    {
        p_F_E_ExportFile_GetFileForArchive
    }
    public class F_E_ExportFileList : List<F_E_ExportFile>
    {

    }
}