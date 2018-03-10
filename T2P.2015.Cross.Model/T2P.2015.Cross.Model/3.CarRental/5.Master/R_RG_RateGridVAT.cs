using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_RG_RateGridVAT : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _r_RG_RateGridID;
        public long? R_RG_RateGridID
        {
            get { return _r_RG_RateGridID; }
            set { _r_RG_RateGridID = value; }
        }
        private decimal? _vAT;
        public decimal? VAT
        {
            get { return _vAT; }
            set { _vAT = value; }
        }

        private decimal? _min;

        public decimal? Min
        {
            get { return _min; }
            set { _min = value; }
        }

        private decimal? _max;

        public decimal? Max
        {
            get { return _max; }
            set { _max = value; }
        }

        public override string Table { get { return "R_RG_RateGridVAT"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_RG_RateGridVAT_InsertOrUpdate"; } }
    }
    public enum R_RG_RateGridVATColumns
    {
        ID,
        R_RG_RateGridID,
        VAT,
        Min,
        Max,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_RG_RateGridVATProcedure
    {
        p_RG_RateGridVAT_GetBy_RategridId
    }
    public class R_RG_RateGridVATList : List<R_RG_RateGridVAT>
    {

    }
}