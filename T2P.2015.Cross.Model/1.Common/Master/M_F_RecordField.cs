using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_F_RecordField : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_F_FileRecordID;
        public long M_F_FileRecordID
        {
            get { return _m_F_FileRecordID; }
            set { _m_F_FileRecordID = value; }
        }
        private string _referenceColumn;
        public string ReferenceColumn
        {
            get { return _referenceColumn; }
            set { _referenceColumn = value; }
        }
        private string _fieldName;
        public string FieldName
        {
            get { return _fieldName; }
            set { _fieldName = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private int _pos;
        public int Pos
        {
            get { return _pos; }
            set { _pos = value; }
        }
        private int _length;
        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }
        private string _format;
        public string Format
        {
            get { return _format; }
            set { _format = value; }
        }
        private string _formatString;
        public string FormatString
        {
            get { return _formatString; }
            set { _formatString = value; }
        }
        private string _sICCode;
        public string SICCode
        {
            get { return _sICCode; }
            set { _sICCode = value; }
        }
        private int? _mOF;
        public int? MOF
        {
            get { return _mOF; }
            set { _mOF = value; }
        }
        public override string Table { get { return "M_F_RecordField"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_F_RecordField_InsertOrUpdate"; } }
    }
    public enum M_RecordFieldColumns
    {
        ID,
        M_FileRecordID,
        ReferenceColumn,
        FieldName,
        Description,
        Pos,
        Length,
        Format,
        FormatString,
        MOF,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_F_RecordFieldProcedure
    {
        p_M_F_RecordField_GetList_ByFileType,
        p_M_F_RecordField_GetByRecordCode
    }
    public class M_F_RecordFieldList : List<M_F_RecordField>
    {

    }
}