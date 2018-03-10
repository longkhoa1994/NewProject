using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_HotelChain : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _b_BookingID;
        public long? B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
        }
        private string _chainName;
        public string ChainName
        {
            get { return _chainName; }
            set { _chainName = value; }
        }
        public override string Table { get { return "B_HotelChain"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_HotelChain_InsertOrUpdate"; } }
    }
    public enum B_HotelChainColumns
    {
        ID,
        B_BookingID,
        ChainName,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum B_HotelChainProcedure
    {
        p_B_HotelChain_Get_By_B_BookingID
    }
    public class B_HotelChainList : List<B_HotelChain>
    {

    }
}