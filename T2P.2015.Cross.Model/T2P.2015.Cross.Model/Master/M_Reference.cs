using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Reference : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _group;

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        private string _text;

        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private int _position;

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public override string Table { get { return "M_Reference"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_Reference_InsertOrUpdate"; } }
    }

    public enum M_ReferenceColumns
    {
        ID,
        Group,
        Text,
        Value,
        Position,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_ReferenceProcedure
    {
        p_M_Reference_Get_By_Group
    }

    public class M_ReferenceList : List<M_Reference>
    {
    }
    public enum ReferenceGroup
    {
        DateSearch,
        PossessiveAdj
    }
}