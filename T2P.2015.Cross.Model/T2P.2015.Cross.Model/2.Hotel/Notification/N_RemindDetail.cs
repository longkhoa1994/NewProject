using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_RemindDetail : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _n_RemindID;
        public long N_RemindID
        {
            get { return _n_RemindID; }
            set { _n_RemindID = value; }
        }
        private long _b_AccessID;
        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        public override string Table { get { return "N_RemindDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_RemindDetail_InsertOrUpdate"; } }
    }
    public enum N_RemindDetailColumns
    {
        ID,
        N_RemindID,
        B_AccessID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum N_RemindDetailProcedure
    {

    }
    public class N_RemindDetailList : List<N_RemindDetail>
    {

    }
}