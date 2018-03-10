using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_F_FileRecord : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_F_FileTypeID;
        public long M_F_FileTypeID
        {
            get { return _m_F_FileTypeID; }
            set { _m_F_FileTypeID = value; }
        }
        private string _recordCode;
        public string RecordCode
        {
            get { return _recordCode; }
            set { _recordCode = value; }
        }
        private string _recordName;
        public string RecordName
        {
            get { return _recordName; }
            set { _recordName = value; }
        }
        private int? _length;
        public int? Length
        {
            get { return _length; }
            set { _length = value; }
        }

        private bool? _isOptional;
        public bool? IsOptional
        {
            get { return _isOptional; }
            set { _isOptional = value; }
        }

        private string _objectName;
        public string ObjectName
        {
            get { return _objectName; }
            set { _objectName = value; }
        }

        private long? _parentRecordID;
        public long? ParentRecordID
        {
            get { return _parentRecordID; }
            set { _parentRecordID = value; }
        }

        private string _pathExport;
        public string PathExport
        {
            get { return _pathExport; }
            set { _pathExport = value; }
        }
        public override string Table { get { return "M_F_FileRecord"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_F_FileRecord_InsertOrUpdate"; } }
    }
    public enum M_F_FileRecordColumns
    {
        ID,
        M_FileTypeID,
        RecordCode,
        RecordName,
        Length,
        IsOptional,
        ObjectName,
        ParentRecordID,
        PathExport,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_F_FileRecordProcedure
    {
        p_M_F_FileRecord_GetList_ByFileType,
        p_M_F_FileRecord_GetList_By_M_F_FileTypeID,
        p_M_F_FileRecord_GetByFileType_And_RecordCode
    }
    public class M_F_FileRecordList : List<M_F_FileRecord>
    {

    }
}