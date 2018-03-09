using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_Function : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _functionName;

        public string FunctionName
        {
            get { return _functionName; }
            set { _functionName = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override string Table { get { return "A_Function"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_A_Function_InsertOrUpdate"; } }
    }

    public enum A_FunctionColumns
    {
        ID,
        FunctionName,
        Type,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum A_FunctionProcedure
    {
    }

    public class A_FunctionList : List<A_Function>
    {
    }
}