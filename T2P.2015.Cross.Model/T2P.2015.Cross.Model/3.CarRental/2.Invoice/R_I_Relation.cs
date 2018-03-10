using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_I_Relation : BaseModel
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
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public override string Table { get { return "R_I_Relation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_I_Relation_InsertOrUpdate"; } }
    }
    public enum R_I_RelationColumns
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
    public enum R_I_RelationProcedure
    {
        p_R_I_Relation_GetByNewID,
        p_R_I_Relation_GetByOldID,
        p_R_I_Relation_GetByImageID
    }
    public class R_I_RelationList : List<R_I_Relation>
    {

    }
}