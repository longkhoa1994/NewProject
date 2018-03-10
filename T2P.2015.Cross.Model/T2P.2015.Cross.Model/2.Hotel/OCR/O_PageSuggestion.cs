using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class O_PageSuggestion : BaseModel
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
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
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
        public override string Table { get { return "O_PageSuggestion"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_PageSuggestion_InsertOrUpdate"; } }
    }
    public enum O_PageSuggestionColumns
    {
        ID,
        I_ImageID,
        Type,
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
    public enum O_PageSuggestionProcedure
    {

    }
    public class O_PageSuggestionList : List<O_PageSuggestion>
    {

    }
}