using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Contract
{
    [Serializable]
    public class B_CancellationPolicy : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _B_ContractID;

        public long B_ContractID
        {
            get { return _B_ContractID; }
            set { _B_ContractID = value; }
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
        public string Deposit { get; set; }
        public string Info { get; set; }
        public string CancelPreText { get; set; }
        public string CancelPostText { get; set; }

        public override string Table { get { return "B_CancellationPolicy"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_CancellationPolicy_InsertOrUpdate"; } }
    }

    public enum B_CancellationPolicyColumns
    {
        ID,
        B_ContractID,
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

    public enum B_CancellationPolicyProcedure
    {
        p_B_CancellationPolicy_ViewModel_GetBy_ContractId,
        p_B_CancellationPolicy_GetList_ByContractID,
        p_B_CancellationPolicyStatus_ByContractID_AndCompanyID
    }

    public class CancellationPolicyVM : B_CancellationPolicy
    {
        public int? RemainingDay;
        public int? GetRemainingDay2(DateTime cancelDate)
        {
            if (!string.IsNullOrWhiteSpace(TimeUnit) && TimeUnit.ToLower().Trim() == "Date".ToLower() && Date.HasValue)
                return Convert.ToInt32((this.Date.Value - cancelDate).TotalDays);
            return 0;
        }
    }

    public class vm_B_CancellationPolicy_M_CompanyCountrySetting
    {
        public bool HasSpecialCancellationPolicy { get; set; }
        public List<B_CancellationPolicy> ListCancellationPolicy { get; set; }
    }

    public class B_CancellationPolicyStatus
    {
        public bool Status { get; set; }
    }
}