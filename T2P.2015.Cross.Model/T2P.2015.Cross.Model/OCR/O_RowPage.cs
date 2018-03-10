using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class O_RowPage : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _o_PageID;
        public long O_PageID
        {
            get { return _o_PageID; }
            set { _o_PageID = value; }
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
        private string _processedData;

        public string ProcessedData
        {
            get { return _processedData; }
            set { _processedData = value; }
        }

        private string trimData;

        public string TrimData
        {
            get { return trimData; }
            set { trimData = value; }
        }

        public override string Table { get { return "O_RowPage"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_RowPage_InsertOrUpdate"; } }
    }
    public enum O_RowPageColumns
    {
        ID,
        O_PageID,
        Position,
        Confidence,
        RawData,
        CorrectData,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum O_RowPageProcedure
    {
        p_O_RowPage_Get_Page

    }
    public class O_RowPageList : List<O_RowPage>
    {

    }
}