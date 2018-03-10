using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_UserHotel : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _a_UserProfileID;
        public long A_UserProfileID
        {
            get { return _a_UserProfileID; }
            set { _a_UserProfileID = value; }
        }
        private long _m_HotelID;
        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }
        private int? _permission;
        public int? Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }
        public override string Table { get { return "A_UserHotel"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_UserHotel_InsertOrUpdate"; } }
    }
    public enum A_UserHotelColumns
    {
        ID,
        A_UserProfileID,
        M_HotelID,
        Permission,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum A_UserHotelProcedure
    {
        p_A_UserHotel_GetListByUserProfileID
    }
    public class A_UserHotelList : List<A_UserHotel>
    {

    }
}