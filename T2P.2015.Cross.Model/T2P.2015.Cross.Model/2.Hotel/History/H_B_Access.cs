using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class H_B_Access : BaseModel
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
        private long _b_AccessID;
        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        public override string Table { get { return "H_B_Access"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_H_B_Access_InsertOrUpdate"; } }
    }
    public enum H_B_AccessColumns
    {
        ID,
        H_M_HotelID,
        B_AccessID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum H_B_AccessProcedure
    {

    }
    public class H_B_AccessList : List<H_B_Access>
    {

    }
}