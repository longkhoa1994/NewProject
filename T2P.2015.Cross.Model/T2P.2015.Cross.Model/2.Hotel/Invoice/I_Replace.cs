using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Replace : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _oldID;

        public long OldID
        {
            get { return _oldID; }
            set { _oldID = value; }
        }

        private long _newID;

        public long NewID
        {
            get { return _newID; }
            set { _newID = value; }
        }

        private bool? _isUseOldData;

        public bool? IsUseOldData
        {
            get { return _isUseOldData; }
            set { _isUseOldData = value; }
        }

        public override string Table { get { return "I_Replace"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_I_Replace_InsertOrUpdate"; } }
    }

    public enum I_ReplaceColumns
    {
        ID,
        OldID,
        NewID,
        IsUseOldData,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum I_ReplaceProcedure
    {
        p_I_Replace_GetBy_I_ImageID,
        p_I_Replace_GetRecursive_ByNewID,
        p_I_Replace_GetBy_OldID,
        p_I_Replace_GetListForDeleting,
    }

    public class I_ReplaceList : List<I_Replace>
    {
    }
}