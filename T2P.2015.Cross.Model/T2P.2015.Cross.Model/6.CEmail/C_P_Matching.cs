using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_P_Matching : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _c_CSV_ItemID;
        public long C_CSV_ItemID
        {
            get { return _c_CSV_ItemID; }
            set { _c_CSV_ItemID = value; }
        }
        private long _c_BIReport_ItemID;
        public long C_BIReport_ItemID
        {
            get { return _c_BIReport_ItemID; }
            set { _c_BIReport_ItemID = value; }
        }
        public override string Table { get { return "C_P_Matching"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_P_Matching_InsertOrUpdate"; } }
    }
    public enum C_P_MatchingColumns
    {
        ID,
        C_CSV_ItemID,
        C_BIReport_ItemID,
        CreatedBy,
        CreatedDateTime,
        UpdatedBy,
        UpdatedDateTime,
        Status,
    }
    public enum C_P_MatchingProcedure
    {

    }
    public class C_P_MatchingList : List<C_P_Matching>
    {

    }
}