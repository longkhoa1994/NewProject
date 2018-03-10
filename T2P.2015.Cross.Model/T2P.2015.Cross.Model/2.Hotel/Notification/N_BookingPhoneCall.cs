using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_BookingPhoneCall : BaseModel
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
        private long _n_PhoneCallID;
        public long N_PhoneCallID
        {
            get { return _n_PhoneCallID; }
            set { _n_PhoneCallID = value; }
        }
        private long? _n_TaskID;
        public long? N_TaskID
        {
            get { return _n_TaskID; }
            set { _n_TaskID = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public override string Table { get { return "N_BookingPhoneCall"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_BookingPhoneCall_InsertOrUpdate"; } }
    }
    public enum N_BookingPhoneCallColumns
    {
        ID,
        B_AccessID,
        N_PhoneCallID,
        N_TaskID,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum N_BookingPhoneCallProcedure
    {
        p_N_BookingPhoneCall_GetByPhoneCallID
    }
    public class N_BookingPhoneCallList : List<N_BookingPhoneCall>
    {

    }
}