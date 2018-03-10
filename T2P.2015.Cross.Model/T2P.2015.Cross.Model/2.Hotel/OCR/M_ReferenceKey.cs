using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ReferenceKey
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
    }
    public enum M_ReferenceKeyColumns
    {
        ID,
        Value,
        Type,
    }
    public enum M_ReferenceKeyProcedure
    {
        p_M_ReferenceKey_GetByType
    }
}