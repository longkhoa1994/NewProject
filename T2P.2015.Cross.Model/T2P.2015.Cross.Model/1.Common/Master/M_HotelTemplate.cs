using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelTemplate : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _hotelID;
        public long M_HotelID
        {
            get { return _hotelID; }
            set { _hotelID = value; }
        }
        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        private int _height;
        public int Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public override string Table { get { return "M_HotelTemplate"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelTemplate_InsertOrUpdate"; } }
    }
    public enum M_HotelTemplateColumns
    {
        ID,
        M_HotelID,
        Width,
        Height,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_HotelTemplateProcedure
    {
        p_M_HotelTemplate_GetByImageID,
        p_M_Hotel_GetListForCreateTemplate,
        p_M_HotelTemplate_GetByM_HotelID,
    }
    public class M_HotelTemplateList : List<M_HotelTemplate>
    {

    }
}