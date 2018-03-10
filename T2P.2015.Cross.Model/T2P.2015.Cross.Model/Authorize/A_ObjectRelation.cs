using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_ObjectRelation : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _parentObjectID;

        public long ParentObjectID
        {
            get { return _parentObjectID; }
            set { _parentObjectID = value; }
        }

        private long _childObjectID;

        public long ChildObjectID
        {
            get { return _childObjectID; }
            set { _childObjectID = value; }
        }

        public override string Table { get { return "A_ObjectRelation"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_A_ObjectRelation_InsertOrUpdate"; } }
    }

    public enum A_ObjectRelationColumns
    {
        ID,
        ParentObjectID,
        ChildObjectID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum A_ObjectRelationProcedure
    {
        p_A_ObjectRealtion_Get_ByUser
    }

    public class A_ObjectRelationList : List<A_ObjectRelation>
    {
    }
}