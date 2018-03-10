using System;
using System.Collections.Generic;
using T2P._2015.Cross.Enum.CarRental.Invoice;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_ReferenceKey : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _keys;
        public string Keys
        {
            get { return _keys; }
            set { _keys = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _carProviderId;
        public int CarProviderId
        {
            get { return _carProviderId; }
            set { _carProviderId = value; }
        }


        public override string Table { get { return "R_M_ReferenceKey"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
    }

    public enum R_M_ReferenceKeyColumns
    {
        ID,
        Name,
        Keys,
        Description,
        CarProviderId
    }

    public enum R_M_ReferenceKeyProcedure
    {
        p_R_M_ReferenceKey_GetAll,
        p_R_M_ReferenceKey_GetBy_KeyName,
        p_R_M_ReferenceKey_GetBy_CarProviderId
    }

    public class R_M_ReferenceKeyList : List<R_M_ReferenceKey>
    {
    }

    public class KeyField
    {
        public int NumberOfField;
        public string Value;


        public KeyField()
        {
            NumberOfField = 0;
            Value = string.Empty;
        }
    }
}