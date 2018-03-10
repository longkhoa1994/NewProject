using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_BookingBillingEmail : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _r_B_AccessID;

        public long R_B_AccessID
        {
            get { return _r_B_AccessID; }
            set { _r_B_AccessID = value; }
        }

        private long _r_N_BillingEmailID;

        public long R_N_BillingEmailID
        {
            get { return _r_N_BillingEmailID; }
            set { _r_N_BillingEmailID = value; }
        }

        public override string Table { get { return "R_N_BookingBillingEmail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_BookingBillingEmail_InsertOrUpdate"; } }
    }

    public enum R_N_BookingBillingEmailColumns
    {
        ID,
        R_B_AccessID,
        R_N_BillingEmailID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_N_BookingBillingEmailProcedure
    {
        p_R_N_BookingBillingEmail_Get_Booking_Email_ForBillingEmail,
        p_R_N_BookingBillingEmail_Get_By_BookingID_EmailID,
    }

    public class R_N_BookingBillingEmailList : List<R_N_BookingBillingEmail>
    {
    }
}