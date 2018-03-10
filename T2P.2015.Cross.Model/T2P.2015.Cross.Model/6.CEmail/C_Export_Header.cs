using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_Export_Header : BaseModel
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
        private DateTime? _exportDate;
        public DateTime? ExportDate
        {
            get { return _exportDate; }
            set { _exportDate = value; }
        }
        public override string Table { get { return "C_Export_Header"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_Export_Header_InsertOrUpdate"; } }
    }
    public enum C_Export_HeaderColumns
    {
        ID,
        C_HeaderID,
        ExportDate,
        CreatedBy,
        CreatedDateTime,
        UpdatedBy,
        UpdatedDateTime,
        Status,
    }
    public enum C_Export_HeaderProcedure
    {

    }
    public class C_Export_HeaderList : List<C_Export_Header>
    {

    }
}