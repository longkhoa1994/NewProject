using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class P_ProcessDuration : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _n_BillingEmailID;

        public long? N_BillingEmailID
        {
            get { return _n_BillingEmailID; }
            set { _n_BillingEmailID = value; }
        }

        private long? _i_ImageID;

        public long? I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }

        private string _action;

        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }

        private DateTime? _from;

        public DateTime? From
        {
            get { return _from; }
            set { _from = value; }
        }

        private DateTime? _to;

        public DateTime? To
        {
            get { return _to; }
            set { _to = value; }
        }

        private float? _duration;

        public float? Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }

        public override string Table { get { return "P_ProcessDuration"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_P_ProcessDuration_InsertOrUpdate"; } }
    }

    public enum P_ProcessDurationColumns
    {
        ID,
        N_BillingEmailID,
        I_ImageID,
        Action,
        From,
        To,
        Duration,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum P_ProcessDurationProcedure
    {
        p_P_ProcessDuration_GetByForUpdate,
    }

    public class P_ProcessDurationList : List<P_ProcessDuration>
    {
    }
}