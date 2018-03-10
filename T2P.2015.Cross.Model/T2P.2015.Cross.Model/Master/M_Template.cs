using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Template : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _hotelID;
        public long HotelID
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
        public override string Table { get { return "M_Template"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Template_InsertOrUpdate"; } }
    }
    public enum M_TemplateColumns
    {
        ID,
        HotelID,
        Width,
        Height,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_TemplateProcedure
    {

    }
    public class M_TemplateList : List<M_Template>
    {

    }
}