using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_RG_RateGridTax : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _r_RG_RateGridID;
        public long R_RG_RateGridID
        {
            get { return _r_RG_RateGridID; }
            set { _r_RG_RateGridID = value; }
        }
        private float _vAT;
        public float VAT
        {
            get { return _vAT; }
            set { _vAT = value; }
        }
        public override string Table { get { return "R_RG_RateGridTax"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_RG_RateGridTax_InsertOrUpdate"; } }
    }
    public enum R_RG_RateGridTaxColumns
    {
        ID,
        R_RG_RateGridID,
        VAT,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_RG_RateGridTaxProcedure
    {

    }
    public class R_RG_RateGridTaxList : List<R_RG_RateGridTax>
    {

    }
}