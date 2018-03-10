using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class H_M_HotelContact : BaseModel
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
        private long _m_HotelContactID;
        public long M_HotelContactID
        {
            get { return _m_HotelContactID; }
            set { _m_HotelContactID = value; }
        }
        public override string Table { get { return "H_M_HotelContact"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_H_M_HotelContact_InsertOrUpdate"; } }
    }
    public enum H_M_HotelContactColumns
    {
        ID,
        H_M_HotelID,
        M_HotelContactID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum H_M_HotelContactProcedure
    {

    }
    public class H_M_HotelContactList : List<H_M_HotelContact>
    {

    }
}