using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class O_WordPage : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _o_RowPageID;
        public long O_RowPageID
        {
            get { return _o_RowPageID; }
            set { _o_RowPageID = value; }
        }
        private long? _o_PageSuggestionID;

       

        public long? O_PageSuggestionID
        {
            get { return _o_PageSuggestionID; }
            set { _o_PageSuggestionID = value; }
        }
        private long _position;

        public long Position
        {
            get { return _position; }
            set { _position = value; }
        }
        private float _confidence;
        public float Confidence
        {
            get { return _confidence; }
            set { _confidence = value; }
        }
        private int _xPos;
        public int XPos
        {
            get { return _xPos; }
            set { _xPos = value; }
        }
        private int _yPos;
        public int YPos
        {
            get { return _yPos; }
            set { _yPos = value; }
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
        private string _rawData;
        public string RawData
        {
            get { return _rawData; }
            set { _rawData = value; }
        }
        private string _correctData;
        public string CorrectData
        {
            get { return _correctData; }
            set { _correctData = value; }
        }
        public override string Table { get { return "O_WordPage"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_WordPage_InsertOrUpdate"; } }
    }
    public enum O_WordPageColumns
    {
        ID,
        O_RowPageID,
        O_PageSuggestionID,
        Confidence,
        XPos,
        YPos,
        Width,
        Height,
        RawData,
        CorrectData,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum O_WordPageProcedure
    {
        p_O_WordPage_Get_Row
    }
    public class O_WordPageList : List<O_WordPage>
    {

    }
}