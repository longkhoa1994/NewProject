using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_ArchiveRequestDetail : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _i_ArchiveRequestID;
        public long? I_ArchiveRequestID
        {
            get { return _i_ArchiveRequestID; }
            set { _i_ArchiveRequestID = value; }
        }
        private long? _i_ArchiveID;
        public long? I_ArchiveID
        {
            get { return _i_ArchiveID; }
            set { _i_ArchiveID = value; }
        }
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        private string _fileType;

        public string FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
        }
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        private DateTime _importDate;

        public DateTime ImportDate
        {
            get { return _importDate; }
            set { _importDate = value; }
        }

        private long? _f_ImportFileID;
        public long? F_ImportFileID
        {
            get { return _f_ImportFileID; }
            set { _f_ImportFileID = value; }
        }
        private bool _isFromAP;

        public bool IsFromAP
        {
            get { return _isFromAP; }
            set { _isFromAP = value; }
        }
        public override string Table { get { return "I_ArchiveRequestDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_ArchiveRequestDetail_InsertOrUpdate"; } }
    }
    public enum I_ArchiveRequestDetailColumns
    {
        ID,
        I_ArchiveRequestID,
        I_ArchiveID,
        FileName,
        FilePath,
        ImportDate,
        F_ImportFileID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_ArchiveRequestDetailProcedure
    {
        p_I_ArchiveRequestDetail_GetListForArchive
    }
    public class I_ArchiveRequestDetailList : List<I_ArchiveRequestDetail>
    {

    }
}