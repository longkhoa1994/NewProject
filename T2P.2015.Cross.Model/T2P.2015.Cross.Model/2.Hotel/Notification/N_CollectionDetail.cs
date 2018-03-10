using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_CollectionDetail : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _n_CollectionID;
        public long N_CollectionID
        {
            get { return _n_CollectionID; }
            set { _n_CollectionID = value; }
        }
        private long _b_AccessID;
        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        public override string Table { get { return "N_CollectionDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_CollectionDetail_InsertOrUpdate"; } }
    }
    public enum N_CollectionDetailColumns
    {
        ID,
        N_CollectionID,
        B_AccessID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum N_CollectionDetailProcedure
    {

    }
    public class N_CollectionDetailList : List<N_CollectionDetail>
    {

    }
}