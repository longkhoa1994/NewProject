using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_TimeZone : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _cityName;

        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        private string m_CountryID;

        public string M_CountryID
        {
            get { return m_CountryID; }
            set { m_CountryID = value; }
        }

        private decimal _timezone;

        public decimal Timezone
        {
            get { return _timezone; }
            set { _timezone = value; }
        }

        public override string Table { get { return "M_TimeZone"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_TimeZone_InsertOrUpdate"; } }
    }

    public enum M_TimeZoneColumns
    {
        ID,
        CityName,
        M_CountryID,
        Timezone,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_TimeZoneProcedure
    {
        p_M_TimeZone_Get_ByM_TimeZone,
        p_M_TimeZone_GetListTimeZone,
        p_M_TimeZoneByCountryID,
        P_M_TimeZoneByCountryID
    }

    public class M_TimeZoneList : List<M_TimeZone>
    {
    }
}