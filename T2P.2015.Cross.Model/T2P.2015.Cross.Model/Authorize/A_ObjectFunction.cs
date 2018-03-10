using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_ObjectFunction : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _a_ObjectID;

        public long A_ObjectID
        {
            get { return _a_ObjectID; }
            set { _a_ObjectID = value; }
        }

        private long _a_FunctionID;

        public long A_FunctionID
        {
            get { return _a_FunctionID; }
            set { _a_FunctionID = value; }
        }

        private int _type;

        public int Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override string Table { get { return "A_ObjectFunction"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_A_ObjectFunction_InsertOrUpdate"; } }
    }

    public enum A_ObjectFunctionColumns
    {
        ID,
        A_ObjectID,
        A_FunctionID,
        Type,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum A_ObjectFunctionProcedure
    {
        p_A_ObjectFunction_Get_ByUser,
        p_A_ObjectFunction_Get_ByRoleID
    }

    public class A_ObjectFunctionList : List<A_ObjectFunction>
    {

    }
}