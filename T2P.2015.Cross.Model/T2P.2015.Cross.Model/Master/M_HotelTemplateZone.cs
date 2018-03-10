using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelTemplateZone : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_HotelTemplateID;
        public long M_HotelTemplateID
        {
            get { return _m_HotelTemplateID; }
            set { _m_HotelTemplateID = value; }
        }
        private string _zoneName;
        public string ZoneName
        {
            get { return _zoneName; }
            set { _zoneName = value; }
        }
        private string _dataType;
        public string DataType
        {
            get { return _dataType; }
            set { _dataType = value; }
        }
        private string _format;
        public string Format
        {
            get { return _format; }
            set { _format = value; }
        }
        private int _x;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y;
        public int Y
        {
            get { return _y; }
            set { _y = value; }
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
        public override string Table { get { return "M_HotelTemplateZone"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelTemplateZone_InsertOrUpdate"; } }
    }
    public enum M_HotelTemplateZoneColumns
    {
        ID,
        M_HotelTemplateID,
        ZoneName,
        DataType,
        Format,
        X,
        Y,
        Width,
        Height,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_HotelTemplateZoneProcedure
    {
        p_M_HotelTemplateZone_GetByImageID,
        p_M_HotelTemplateZone_GetByM_HotelTemplateID,
    }
    public class M_HotelTemplateZoneList : List<M_HotelTemplateZone>
    {

    }
}