using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_PhoneCall : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_CarRentalProviderID;
        public long? M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
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
        public override string Table { get { return "R_N_PhoneCall"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_PhoneCall_InsertOrUpdate"; } }
    }
    public enum R_N_PhoneCallColumns
    {
        ID,
        M_CarRentalProviderID,
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
    public enum R_N_PhoneCallProcedure
    {
        p_R_N_PhoneCall_GetBy_Task
    }
    public class R_N_PhoneCallList : List<R_N_PhoneCall>
    {

    }
}