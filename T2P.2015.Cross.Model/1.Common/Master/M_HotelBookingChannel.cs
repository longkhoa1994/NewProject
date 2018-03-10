using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelBookingChannel : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_HotelID;
        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }
        private long _m_BookingChannelID;
        public long M_BookingChannelID
        {
            get { return _m_BookingChannelID; }
            set { _m_BookingChannelID = value; }
        }
        public override string Table { get { return "M_HotelBookingChannel"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelBookingChannel_InsertOrUpdate"; } }
    }
    public enum M_HotelBookingChannelColumns
    {
        ID,
        M_HotelID,
        M_BookingChannelID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_HotelBookingChannelProcedure
    {
        p_M_HotelBookingChannel_GetList_ByM_HotelID
    }
    public class M_HotelBookingChannelList : List<M_HotelBookingChannel>
    {

    }
}