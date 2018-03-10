using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_FileType
    {
        public M_F_FileType FileType;
        public List<P_FileRecord> LstFileRecord;
        public List<P_FileRecord> LstFileRecordEdit;
        public List<ValuesType> LstValuesType;
        public P_FileType()
        {
            LstFileRecord = new List<P_FileRecord>();
            LstFileRecordEdit = new List<P_FileRecord>();
            LstValuesType = new List<ValuesType>();
        }
    }

    public class P_FileRecord
    {
        public M_F_FileRecord FileRecord;
        public List<P_RecordField> LstRecordField;

        public P_FileRecord()
        {
            LstRecordField = new List<P_RecordField>();
        }
    }

    public class P_RecordField
    {
        public P_RecordFieldRow FieldReflection;
        public M_F_RecordField Field;
        public M_F_Reflection Reflection;
    }

    public class P_RecordFieldRow
    {
        public long RecordFieldID { get; set; }
        public long FileRecordID { get; set; }
        public string ReferenceColumn { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public long Pos { get; set; }
        public long Length { get; set; }
        public string Format { get; set; }
        public string FormatString { get; set; }
        public bool IsOptional { get; set; }
        public long? MOF { get; set; }
        public long ReflectionID { get; set; }
        public long FieldID { get; set; }
        public long? InputFieldID { get; set; }
        public int TypeValue { get; set; }
        public string Value { get; set; }
        public long M_CompanyID { get; set; }
        public string TypeValuesText { get; set; }
        
    }

    public class ValuesType
    {
        public long ID{ get; set; }
        public string TypeName{ get; set; }
        public List<string> LstTypeChild { get; set; }
        
    }

}
