using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_DuplicatedHotel : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _originalID;
        public long OriginalID
        {
            get { return _originalID; }
            set { _originalID = value; }
        }
        private long _duplicatedID;
        public long DuplicatedID
        {
            get { return _duplicatedID; }
            set { _duplicatedID = value; }
        }
        public override string Table { get { return "M_DuplicatedHotel"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_DuplicatedHotel_InsertOrUpdate"; } }
    }
    public enum M_DuplicatedHotelColumns
    {
        ID,
        OriginalID,
        DuplicatedID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_DuplicatedHotelProcedure
    {

    }
    public class M_DuplicatedHotelList : List<M_DuplicatedHotel>
    {

    }
}