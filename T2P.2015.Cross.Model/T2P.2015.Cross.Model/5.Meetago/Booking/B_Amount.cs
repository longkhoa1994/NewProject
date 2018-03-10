using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Amount : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _b_BookingID;

        public long? B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private float? _meeting;

        public float? Meeting
        {
            get { return _meeting; }
            set { _meeting = value; }
        }

        private float? _guestRoom;

        public float? GuestRoom
        {
            get { return _guestRoom; }
            set { _guestRoom = value; }
        }

        private float? _other;

        public float? Other
        {
            get { return _other; }
            set { _other = value; }
        }

        private float? _noShow;

        public float? NoShow
        {
            get { return _noShow; }
            set { _noShow = value; }
        }

        private float? _total;

        public float? Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public override string Table { get { return "B_Amount"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_Amount_InsertOrUpdate"; } }
    }

    public enum B_AmountColumns
    {
        ID,
        B_BookingID,
        Type,
        Meeting,
        GuestRoom,
        Other,
        NoShow,
        Total,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_AmountProcedure
    {
        p_B_Amount_Get_By_B_BookingID
    }

    public class B_AmountList : List<B_Amount>
    {
    }
}