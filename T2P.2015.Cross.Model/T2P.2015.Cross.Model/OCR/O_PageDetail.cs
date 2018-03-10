using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class O_PageDetail : BaseModel
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
        private string zoneName;

        public string ZoneName
        {
            get { return zoneName; }
            set { zoneName = value; }
        }

        private string zoneType;

        public string ZoneType
        {
            get { return zoneType; }
            set { zoneType = value; }
        }

        private string zoneFormat;

        public string ZoneFormat
        {
            get { return zoneFormat; }
            set { zoneFormat = value; }
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
        public override string Table { get { return "O_PageDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_PageDetail_InsertOrUpdate"; } }
    }
    public enum O_PageDetailColumns
    {
        ID,
        O_PageID,
        ZoneName,
        ZoneType,
        ZoneFormat,
        RawData,
        CorrectData,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum O_PageDetailProcedure
    {
        p_RD_PageDetail_GetRawData_ById
    }
    public class O_PageDetailList : List<O_PageDetail>
    {

    }
}