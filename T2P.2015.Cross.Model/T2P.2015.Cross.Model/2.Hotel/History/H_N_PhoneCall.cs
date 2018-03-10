using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class H_N_PhoneCall : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _h_M_HotelID;
        public long H_M_HotelID
        {
            get { return _h_M_HotelID; }
            set { _h_M_HotelID = value; }
        }
        private long _n_PhoneCallID;
        public long N_PhoneCallID
        {
            get { return _n_PhoneCallID; }
            set { _n_PhoneCallID = value; }
        }
        public override string Table { get { return "H_N_PhoneCall"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_H_N_PhoneCall_InsertOrUpdate"; } }
    }
    public enum H_N_PhoneCallColumns
    {
        ID,
        H_M_HotelID,
        N_PhoneCallID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum H_N_PhoneCallProcedure
    {

    }
    public class H_N_PhoneCallList : List<H_N_PhoneCall>
    {

    }
}