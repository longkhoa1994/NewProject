using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_City : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _cityCode;

        public string CityCode
        {
            get { return _cityCode; }
            set { _cityCode = value; }
        }

        private string _cityName;

        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        private long? _m_CountryID;

        
        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }

        public override string Table { get { return "M_City"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_City_InsertOrUpdate"; } }
    }

    public enum M_CityColumns
    {
        ID,
        CityCode,
        CityName,
        M_CountryID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_CityProcedure
    {
        p_M_City_Get_ByCityName,
    }

    public class M_CityList : List<M_City>
    {
    }
}