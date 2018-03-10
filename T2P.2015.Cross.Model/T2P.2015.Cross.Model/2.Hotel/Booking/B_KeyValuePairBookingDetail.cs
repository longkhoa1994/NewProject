using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_KeyValuePairBookingDetail : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_BookingDetailID;

        public long B_BookingDetailID
        {
            get { return _b_BookingDetailID; }
            set { _b_BookingDetailID = value; }
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

        public override string Table { get { return "B_KeyValuePairBookingDetail"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_KeyValuePairBookingDetail_InsertOrUpdate"; } }
    }

    public enum B_KeyValuePairBookingDetailColumns
    {
        ID,
        B_BookingDetailID,
        Key,
        Value,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_KeyValuePairBookingDetailProcedure
    {
        p_B_KeyValuePairBookingDetail_Get_By_B_BookingDetailID,
        p_B_KeyValuePairBookingDetail_GetListForDeleting,
    }

    public class B_KeyValuePairBookingDetailList : List<B_KeyValuePairBookingDetail>
    {
    }
}