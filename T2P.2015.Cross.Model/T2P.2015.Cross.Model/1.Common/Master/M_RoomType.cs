using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_RoomType : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private int? _type;
        public int? Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public override string Table { get { return "M_RoomType"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_RoomType_InsertOrUpdate"; } }
    }

    public class P_RoomType : M_RoomType
    {
        private long _roomID;

        public long RoomID
        {
            get { return _roomID; }
            set { _roomID = value; }
        }

        private int _numberOfRoom;

        public int NumberOfRoom
        {
            get { return _numberOfRoom; }
            set { _numberOfRoom = value; }
        }

        private bool _isDelete;

        public bool IsDelete
        {
            get { return _isDelete; }
            set { _isDelete = value; }
        }
    }

    public enum M_RoomTypeColumns
    {
        ID,
        Name,
        Description,
        Type,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_RoomTypeProcedure
    {
        p_M_RoomType_GetList_ByM_HotelID
    }
    public class M_RoomTypeList : List<M_RoomType>
    {

    }
}