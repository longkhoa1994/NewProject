using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class O_Page : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _I_ImageID;
        public long I_ImageID
        {
            get { return _I_ImageID; }
            set { _I_ImageID = value; }
        }

        private decimal oCRDuration;

        public decimal OCRDuration
        {
            get { return oCRDuration; }
            set { oCRDuration = value; }
        }

        private decimal xmlDuration;

        public decimal XmlDuration
        {
            get { return xmlDuration; }
            set { xmlDuration = value; }
        }

        private decimal suggestDuration;

        public decimal SuggestDuration
        {
            get { return suggestDuration; }
            set { suggestDuration = value; }
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
        private int rotate;

        public int Rotate
        {
            get { return rotate; }
            set { rotate = value; }
        }

        private int ocrStatus;

        public int OCRStatus
        {
            get { return ocrStatus; }
            set { ocrStatus = value; }
        }

        public override string Table { get { return "O_Page"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_Page_InsertOrUpdate"; } }
    }
    public enum O_PageColumns
    {
        ID,
        I_ImageID,
        OCRDuration,
        SuggestDuration,
        Width,
        Height,
        Rotate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum O_PageProcedure
    {
        p_O_Page_Get_ByImage,
        p_O_Page_GetBy_OCRStatus,
        p_O_Page_GetBy_ImageId
    }
    public class O_PageList : List<O_Page>
    {

    }
}