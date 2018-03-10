using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_ForwardLine : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_BookingID;

        public long B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
        }

        private long _b_ForwardID;

        public long B_ForwardID
        {
            get { return _b_ForwardID; }
            set { _b_ForwardID = value; }
        }

        public override string Table { get { return "B_ForwardLine"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_ForwardLine_InsertOrUpdate"; } }
    }

    public enum B_ForwardLineColumns
    {
        ID,
        B_BookingID,
        B_ForwardID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_ForwardLineProcedure
    {
    }

    public class B_ForwardLineList : List<B_ForwardLine>
    {
    }
}