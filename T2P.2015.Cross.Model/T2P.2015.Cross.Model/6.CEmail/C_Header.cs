using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_Header : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private DateTime? _importDate;
        public DateTime? ImportDate
        {
            get { return _importDate; }
            set { _importDate = value; }
        }
        private int _exportStatus;
        public int ExportStatus
        {
            get { return _exportStatus; }
            set { _exportStatus = value; }
        }
        public override string Table { get { return "C_Header"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_Header_InsertOrUpdate"; } }
    }
    public enum C_HeaderColumns
    {
        ID,
        ImportDate,
        ExportStatus,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum C_HeaderProcedure
    {
        p_C_CSV_GetChange,
        p_C_Header_Get_ForDelivery,
        p_C_Header_Get_ByDate
    }
    public class C_HeaderList : List<C_Header>
    {

    }
    public enum ExportStatus
    {
        Stored = 0,
        Success = 1,
        Fail = 2,
        FailImage = 4,
        FailCSV = 5
        
    }
}