using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_BookingSentBox : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_AccessID;

        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private long _n_SentBoxID;

        public long N_SentBoxID
        {
            get { return _n_SentBoxID; }
            set { _n_SentBoxID = value; }
        }

        public override string Table { get { return "N_BookingSentBox"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_N_BookingSentBox_InsertOrUpdate"; } }
    }

    public class N_BookingSentBox_Extend : N_BookingSentBox
    {      
        public string BookingNo {get; set;}       

        public N_BookingSentBox_Extend()
        {
            BookingNo = string.Empty;
        }

        private long _m_HotelID;

        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }

    }

    public enum N_BookingSentBoxColumns
    {
        ID,
        B_AccessID,
        N_SentBoxID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum N_BookingSentBoxProcedure
    {
        p_N_BookingSentBox_GetByN_SentBoxID,
        p_N_BookingSentBox_GetListForDeleting,
    }

    public class N_BookingSentBoxList : List<N_BookingSentBox>
    {
    }
}