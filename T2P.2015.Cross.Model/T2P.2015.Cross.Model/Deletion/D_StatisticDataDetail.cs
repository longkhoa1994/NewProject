using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class D_StatisticDataDetail : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _d_StatisticDataID;
        public long D_StatisticDataID
        {
            get { return _d_StatisticDataID; }
            set { _d_StatisticDataID = value; }
        }
        private long _b_AccessID;
        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        public override string Table { get { return "D_StatisticDataDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_D_StatisticDataDetail_InsertOrUpdate"; } }
    }
    public enum D_StatisticDataDetailColumns
    {
        ID,
        D_StatisticDataID,
        B_AccessID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum D_StatisticDataDetailProcedure
    {
        p_D_StatisticDataDetail_InsertDataForDeleting,
    }
    public class D_StatisticDataDetailList : List<D_StatisticDataDetail>
    {

    }
}