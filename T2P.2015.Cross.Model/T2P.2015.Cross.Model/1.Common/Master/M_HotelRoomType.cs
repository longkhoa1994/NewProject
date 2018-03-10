using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelRoomType : BaseModel
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
        private long _m_RoomTypeID;
        public long M_RoomTypeID
        {
            get { return _m_RoomTypeID; }
            set { _m_RoomTypeID = value; }
        }
        private int _numberOfRoom;
        public int NumberOfRoom
        {
            get { return _numberOfRoom; }
            set { _numberOfRoom = value; }
        }
        public override string Table { get { return "M_HotelRoomType"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelRoomType_InsertOrUpdate"; } }
    }
    public enum M_HotelRoomTypeColumns
    {
        ID,
        M_HotelID,
        M_RoomTypeID,
        NumberOfRoom,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_HotelRoomTypeProcedure
    {
        p_M_HotelRoomType_GetList_ByM_HotelID
    }
    public class M_HotelRoomTypeList : List<M_HotelRoomType>
    {

    }
}