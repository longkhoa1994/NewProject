using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CitySameName : BaseModel
    {
        private int _iD;
        public int ID
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
        private long _identifyKey;
        public long IdentifyKey
        {
            get { return _identifyKey; }
            set { _identifyKey = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "M_CitySameName"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CitySameName_InsertOrUpdate"; } }
    }
    public enum M_CitySameNameColumns
    {
        ID,
        CityName,
        IdentifyKey,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CitySameNameProcedure
    {

    }
    public class M_CitySameNameList : List<M_CitySameName>
    {

    }
}
