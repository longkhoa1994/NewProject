using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class H_M_Hotel : BaseModel
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
        private string _hotelNo;
        public string HotelNo
        {
            get { return _hotelNo; }
            set { _hotelNo = value; }
        }
        private string _hotelVATNumber;
        public string HotelVATNumber
        {
            get { return _hotelVATNumber; }
            set { _hotelVATNumber = value; }
        }
        public override string Table { get { return "H_M_Hotel"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_H_M_Hotel_InsertOrUpdate"; } }
    }
    public enum H_M_HotelColumns
    {
        ID,
        M_HotelID,
        HotelNo,
        HotelVATNumber,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum H_M_HotelProcedure
    {

    }
    public class H_M_HotelList : List<H_M_Hotel>
    {

    }
}