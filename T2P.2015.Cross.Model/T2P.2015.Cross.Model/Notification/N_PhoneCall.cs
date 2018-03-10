
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_PhoneCall : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? m_HotelID;

        public long? M_HotelID
        {
            get { return m_HotelID; }
            set { m_HotelID = value; }
        }

        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        private long? _n_TaskID;
        public long? N_TaskID
        {
            get { return _n_TaskID; }
            set { _n_TaskID = value; }
        }
        private string _from;
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        private string _to;
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        private string _recipient;
        public string Recipient
        {
            get { return _recipient; }
            set { _recipient = value; }
        }
        private int _duration;
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public override string Table { get { return "N_PhoneCall"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_PhoneCall_InsertOrUpdate"; } }
    }
    public enum N_PhoneCallColumns
    {
        ID,
        B_AccessID,
        N_TaskID,
        From,
        To,
        Recipient,
        Duration,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum N_PhoneCallProcedure
    {
        p_N_PhoneCall_Get_ByBooking_ForServiceDesk,
        p_N_PhoneCall_GetBy_Task,
        p_N_PhoneCall_Get_Search,
        p_N_PhoneCall_GetListForDeleting,
        p_N_PhoneCall_Get_SearchTodayByUserID
    }

    public class N_PhoneCallList : List<N_PhoneCall>
    {
    }
}
