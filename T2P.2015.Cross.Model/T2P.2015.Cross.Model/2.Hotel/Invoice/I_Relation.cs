using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Relation : BaseModel
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
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public override string Table { get { return "I_Relation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_Relation_InsertOrUpdate"; } }
    }

     [Serializable]
    public class I_Relation_ForMatching : I_Relation
    {
        public string PDFLocalPath { get; set; }
        public string PDFIISPath { get; set; }

        public I_Relation_ForMatching()
        {
            PDFLocalPath = string.Empty;
            PDFIISPath = string.Empty;
        }
    }
    public enum I_RelationColumns
    {
        ID,
        OldID,
        NewID,
        Type,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_RelationProcedure
    {
        p_I_Relation_GetForVerificationInvoice,
        p_I_Relation_Get_By_ImageIDSpecialCaseFIN,
        p_I_Relation_GetByNewIDAndType,
        p_I_Relation_GetByOldIDAndType,
        p_P_Matching_GetI_RelationByReplacedImageID,
        p_I_Relation_GetListForDeleting,
        p_I_Relation_GetForCheckSpecialCaseFIN,
        p_I_Relation_GetList_ByB_AccessIDAndType,
        p_I_Relation_Check_AutoUseOldData_ByOldID,
        p_I_Relation_GetList_ByB_AccessID_DC0,
        p_I_Relation_CheckValidateSpecialCase
    }
    public class I_RelationList : List<I_Relation>
    {

    }
}