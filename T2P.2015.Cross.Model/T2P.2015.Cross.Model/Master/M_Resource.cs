using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Resource : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _resourceSet;
        public string ResourceSet
        {
            get { return _resourceSet; }
            set { _resourceSet = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _key;
        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private string _group;
        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "M_Resource"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Resource_InsertOrUpdate"; } }
    }
    public enum M_ResourceColumns
    {
        ID,
        ResourceSet,
        Type,
        Key,
        Value,
        Group,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
        Description,
    }
    public enum M_ResourceProcedure
    {

    }
    public class M_ResourceList : List<M_Resource>
    {

    }
}