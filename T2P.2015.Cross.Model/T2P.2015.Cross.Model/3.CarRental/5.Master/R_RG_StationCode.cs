using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_RG_StationCode : BaseModel
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
        private long _m_CompanyID;

        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private string _stationCode;
        public string StationCode
        {
            get { return _stationCode; }
            set { _stationCode = value; }
        }
        private decimal? _colFee;
        public decimal? ColFee
        {
            get { return _colFee; }
            set { _colFee = value; }
        }
        public override string Table { get { return "R_RG_StationCode"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_RG_StationCode_InsertOrUpdate"; } }
    }
    public enum R_RG_StationCodeColumns
    {
        ID,
        R_RG_RateGridID,
        M_CompanyID,
        StationCode,
        ColFee,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_RG_StationCodeProcedure
    {
        p_R_RG_StationCode_InsertOrUpdate,
        p_R_RG_StationCode_GetByRateGridID
    }
    public class R_RG_StationCodeList : List<R_RG_StationCode>
    {

    }
    public class StationCodeModel : R_RG_StationCode
    {
        public string CompanyName { get; set; }
    }
    public class StationCodeViewModel
    {
        public List<StationCodeModel> ListStationCode { get; set; }
        public List<string> ListCurrentStationCode { get; set; }
    }
}