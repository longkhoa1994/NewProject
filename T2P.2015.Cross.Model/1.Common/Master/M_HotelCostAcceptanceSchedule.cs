using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelCostAcceptanceSchedule : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_HotelID;
        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }
        private long _dayBefore;
        public long DayBefore
        {
            get { return _dayBefore; }
            set { _dayBefore = value; }
        }
        private string _timeSending;
        public string TimeSending
        {
            get { return _timeSending; }
            set { _timeSending = value; }
        }
        public override string Table { get { return "M_HotelCostAcceptanceSchedule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelCostAcceptanceSchedule_InsertOrUpdate"; } }
    }
    public enum M_HotelCostAcceptanceScheduleColumns
    {
        ID,
        M_HotelID,
        DayBefore,
        TimeSending,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_HotelCostAcceptanceScheduleProcedure
    {

    }
    public class M_HotelCostAcceptanceScheduleList : List<M_HotelCostAcceptanceSchedule>
    {

    }

    public class P_HotelSchedule : M_HotelCostAcceptanceSchedule
    {  
        private bool _isOn;
        public bool IsOn
        {
            get { return _isOn; }
            set { _isOn = value; }
        }

        private string _hour;
        public string Hour
        {
            get { return _hour; }
            set { _hour = value; }
        }

        private string _minute;
        public string Minute
        {
            get { return _minute; }
            set { _minute = value; }
        }

        private string _name;
        public string Name
        {
            get { return "Schedule Cost Acceptance"; }
        }

    }
}