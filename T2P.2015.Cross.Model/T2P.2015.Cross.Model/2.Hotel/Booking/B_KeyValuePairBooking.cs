using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_KeyValuePairBooking : BaseModel
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

        private string _key;

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public override string Table { get { return "B_KeyValuePairBooking"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_KeyValuePairBooking_InsertOrUpdate"; } }
    }

    public enum B_KeyValuePairBookingColumns
    {
        ID,
        B_BookingID,
        Key,
        Value,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_KeyValuePairBookingProcedure
    {
        p_B_KeyValuePairBooking_GetListForDeleting,
    }

    public class B_KeyValuePairBookingList : List<B_KeyValuePairBooking>
    {
    }
}