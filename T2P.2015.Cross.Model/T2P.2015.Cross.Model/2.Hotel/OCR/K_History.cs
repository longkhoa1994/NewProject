using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class K_History : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _k_DataID;
        public long K_DataID
        {
            get { return _k_DataID; }
            set { _k_DataID = value; }
        }
        private string _oCRText;
        public string OCRText
        {
            get { return _oCRText; }
            set { _oCRText = value; }
        }
        private int? _x;
        public int? X
        {
            get { return _x; }
            set { _x = value; }
        }
        private int? _y;
        public int? Y
        {
            get { return _y; }
            set { _y = value; }
        }
        private int? _width;
        public int? Width
        {
            get { return _width; }
            set { _width = value; }
        }
        private int? _height;
        public int? Height
        {
            get { return _height; }
            set { _height = value; }
        }
        private decimal? _threshold;
        public decimal? Threshold
        {
            get { return _threshold; }
            set { _threshold = value; }
        }
        public override string Table { get { return "K_History"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_K_History_InsertOrUpdate"; } }
    }
    public enum K_HistoryColumns
    {
        ID,
        K_DataID,
        OCRText,
        X,
        Y,
        Width,
        Height,
        Threshold,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum K_HistoryProcedure
    {

    }
    public class K_HistoryList : List<K_History>
    {

    }
}