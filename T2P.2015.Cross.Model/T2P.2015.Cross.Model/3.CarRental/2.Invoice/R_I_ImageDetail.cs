using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_I_ImageDetail : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _r_I_ImageID;

        public long R_I_ImageID
        {
            get { return _r_I_ImageID; }
            set { _r_I_ImageID = value; }
        }

        private string _rawData;

        public string RawData
        {
            get { return _rawData; }
            set { _rawData = value; }
        }

        public override string Table { get { return "R_I_ImageDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_I_ImageDetail_InsertOrUpdate"; } }
    }

    public enum R_I_ImageDetailColumns
    {
        ID,
        R_I_ImageID,
        RawData,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_I_ImageDetailProcedure
    {
    }

    public class R_I_ImageDetailList : List<R_I_ImageDetail>
    {
    }
}