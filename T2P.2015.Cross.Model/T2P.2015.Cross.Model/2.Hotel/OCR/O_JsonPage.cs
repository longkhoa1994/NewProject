using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class O_JsonPage : BaseModel
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
        private string _rawData;
        public string RawData
        {
            get { return _rawData; }
            set { _rawData = value; }
        }
        private string _hotelIds;
        public string HotelIds
        {
            get { return _hotelIds; }
            set { _hotelIds = value; }
        }

        public override string Table { get { return "O_JsonPage"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_JsonPage_InsertOrUpdate"; } }
    }
    public enum O_JsonPageColumns
    {
        ID,
        O_PageID,
        RawData,
        HotelIds,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum O_JsonPageProcedure
    {
        p_O_JsonPage_GetBy_O_PageID

    }
    public class O_JsonPageList : List<O_JsonPage>
    {

    }
}