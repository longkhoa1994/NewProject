using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_IPLocation : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private float? _fromValue;

        
        public float? FromValue
        {
            get { return _fromValue; }
            set { _fromValue = value; }
        }

        private float? _toValue;

        
        public float? ToValue
        {
            get { return _toValue; }
            set { _toValue = value; }
        }

        private string _countryCode;

        
        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }

        private string _countryName;

        
        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }

        public override string Table { get { return "M_IPLocation"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_IPLocation_InsertOrUpdate"; } }
    }

    public enum M_IPLocationColumns
    {
        ID,
        FromValue,
        ToValue,
        CountryCode,
        CountryName,
    }

    public enum M_IPLocationProcedure
    {
        p_M_IPLocation_Get_ByIP
    }

    public class M_IPLocationList : List<M_IPLocation>
    {
    }
}