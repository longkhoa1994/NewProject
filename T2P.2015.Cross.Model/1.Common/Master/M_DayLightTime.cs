using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_DayLightTime : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _region;

        public string Region
        {
            get { return _region; }
            set { _region = value; }
        }

        private string _country;

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        private DateTime _startDate;

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        private DateTime _endDate;

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        private string _year;

        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public override string Table { get { return "M_DayLightTime"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_DayLightTime_InsertOrUpdate"; } }
    }

    public enum M_DayLightTimeColumns
    {
        ID,
        Region,
        Country,
        StartDate,
        EndDate,
        Year,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_DayLightTimeProcedure
    {
    }

    public class M_DayLightTimeList : List<M_DayLightTime>
    {
    }
}