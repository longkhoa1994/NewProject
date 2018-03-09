using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CancellationPolicy : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _M_CompanyID;

        public long M_CompanyID
        {
            get { return _M_CompanyID; }
            set { _M_CompanyID = value; }
        }

        private int? _roomMin;

        public int? RoomMin
        {
            get { return _roomMin; }
            set { _roomMin = value; }
        }

        private int? _roomMax;

        public int? RoomMax
        {
            get { return _roomMax; }
            set { _roomMax = value; }
        }

        private int? _time;

        public int? Time
        {
            get { return _time; }
            set { _time = value; }
        }

        private DateTime? _date;

        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _timeUnit;

        public string TimeUnit
        {
            get { return _timeUnit; }
            set { _timeUnit = value; }
        }

        private decimal? _freeCharge;

        public decimal? FreeCharge
        {
            get { return _freeCharge; }
            set { _freeCharge = value; }
        }

        private string _freeChargeUnit;

        public string FreeChargeUnit
        {
            get { return _freeChargeUnit; }
            set { _freeChargeUnit = value; }
        }

        public string Terms { get; set; }
        public string Cancel { get; set; }
        public string CancelPreText { get; set; }
        public string CancelPostText { get; set; }
        public string Deposit { get; set; }
        public string Info { get; set; }

        public override string Table { get { return "M_CancellationPolicy"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CancellationPolicy_InsertOrUpdate"; } }
    }

    public enum M_CancellationPolicyColumns
    {
        ID,
        M_CompanyID,
        RoomMin,
        RoomMax,
        Time,
        Date,
        TimeUnit,
        FreeCharge,
        FreeChargeUnit,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_CancellationPolicyProcedure
    {
        P_M_CancellationPolicy_GetByCompany,
        p_B_CancellationPolicy_ViewModel_GetBy_CompanyID,
        p_B_CancellationPolicy_GetList_ByCompanyID,
        p_M_CancellationPolicy_GetByCompany_OrByContract
    }
}