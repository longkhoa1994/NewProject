using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_GL1076_FT : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _f_I_GL1076_FHID;

        public long F_I_GL1076_FHID
        {
            get { return _f_I_GL1076_FHID; }
            set { _f_I_GL1076_FHID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _totalRecordCount;
        public string TotalRecordCount
        {
            get { return _totalRecordCount; }
            set { _totalRecordCount = value; }
        }
        private string _globalClientOriginIdentifier;
        public string GlobalClientOriginIdentifier
        {
            get { return _globalClientOriginIdentifier; }
            set { _globalClientOriginIdentifier = value; }
        }
        private string _fileCreationDateTime;
        public string FileCreationDateTime
        {
            get { return _fileCreationDateTime; }
            set { _fileCreationDateTime = value; }
        }
        private DateTime? _processDate;
        public DateTime? ProcessDate
        {
            get { return _processDate; }
            set { _processDate = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }

        public override string Table { get { return "F_I_GL1076_FT"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_GL1076_FT_InsertOrUpdate"; } }
    }
    public enum F_I_GL1076_FTColumns
    {
        ID,
        F_I_GL1076_FHID,
        RecordType,
        TotalRecordCount,
        GlobalClientOriginIdentifier,
        FileCreationDateTime,
        ProcessDate,
        Filler,
        CreatedDate,
        CreatedBy,
        UpdatedDate,
        Updatedby,
        Status,
    }
    public enum F_I_GL1076_FTProcedure
    {
        p_F_I_GL1076_FT_Get_By_F_ImportFileID
    }
    public class F_I_GL1076_FTList : List<F_I_GL1076_FT>
    {

    }
}