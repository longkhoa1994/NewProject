using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ProcessSchedule : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_ProcessStepID;
        public long M_ProcessStepID
        {
            get { return _m_ProcessStepID; }
            set { _m_ProcessStepID = value; }
        }
        private string _frequency;
        public string Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }
        private string _period;
        public string Period
        {
            get { return _period; }
            set { _period = value; }
        }
        private string _executionDate;
        public string ExecutionDate
        {
            get { return _executionDate; }
            set { _executionDate = value; }
        }
        private string _executionTime;
        public string ExecutionTime
        {
            get { return _executionTime; }
            set { _executionTime = value; }
        }
        private int _usedTimeZone;
        public int UsedTimeZone
        {
            get { return _usedTimeZone; }
            set { _usedTimeZone = value; }
        }
        public override string Table { get { return "M_ProcessSchedule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_ProcessSchedule_InsertOrUpdate"; } }
    }
    public enum M_ProcessScheduleColumns
    {
        ID,
        M_ProcessStepID,
        Frequency,
        Period,
        ExecutionDate,
        ExecutionTime,
        UsedTimeZone,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_ProcessScheduleProcedure
    {
        p_M_ProcessGeneralSetting_GetByProcessStepID
    }

    public class M_ProcessScheduleList : List<M_ProcessSchedule>
    {
    }
}