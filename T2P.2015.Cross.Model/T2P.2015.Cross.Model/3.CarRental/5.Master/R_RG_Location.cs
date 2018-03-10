using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_RG_Location : BaseModel
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

        private string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        private int _groupLocation;

        public int GroupLocation
        {
            get { return _groupLocation; }
            set { _groupLocation = value; }
        }

        private int? _minDay;

        public int? MinDay
        {
            get { return _minDay; }
            set { _minDay = value; }
        }

        private int? _maxDay;

        public int? MaxDay
        {
            get { return _maxDay; }
            set { _maxDay = value; }
        }

        private decimal? _rate;

        public decimal? Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        private string _validFrom;

        public string ValidFrom
        {
            get { return _validFrom; }
            set { _validFrom = value; }
        }

        private string _validTo;

        public string ValidTo
        {
            get { return _validTo; }
            set { _validTo = value; }
        }

        private string _unit;

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }



        public override string Table { get { return "R_RG_Location"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_RG_Location_InsertOrUpdate"; } }
    }

    public enum R_RG_LocationColumns
    {
        ID,
        R_RG_RateGridID,
        Location,
        GroupLocation,
        MinDay,
        MaxDay,
        Rate,
        ValidFrom,
        ValidTo,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_RG_LocationProcedure
    {
        p_R_RG_LocationByRateGridID,
        p_R_RG_LocationByCondition
    }

    public class R_RG_LocationList : List<R_RG_RateGrid>
    {
    }

}