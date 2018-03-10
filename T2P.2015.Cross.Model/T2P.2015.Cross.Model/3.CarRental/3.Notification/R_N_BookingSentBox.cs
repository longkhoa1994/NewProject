using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_BookingSentBox : BaseModel
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

        private long _r_N_SentBoxID;

        public long R_N_SentBoxID
        {
            get { return _r_N_SentBoxID; }
            set { _r_N_SentBoxID = value; }
        }

        public override string Table { get { return "R_N_BookingSentBox"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_BookingSentBox_InsertOrUpdate"; } }
    }

    public enum R_N_BookingSentBoxColumns
    {
        ID,
        R_B_AccessID,
        R_N_SentBoxID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_N_BookingSentBoxProcedure
    {
        p_R_N_BookingSentBox_Get_By_BookingID_EmailID,
    }

    public class R_N_BookingSentBoxList : List<R_N_BookingSentBox>
    {
    }
}