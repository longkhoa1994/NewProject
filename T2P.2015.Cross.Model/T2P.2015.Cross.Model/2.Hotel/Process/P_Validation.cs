using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
     [Serializable]
    public class P_Validation : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _i_DataID;
        public long I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
        }
        private long? _f_TransactionID;
        public long? F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }
        private int _result;

        public int Result
        {
            get { return _result; }
            set { _result = value; }
        }
        public override string Table { get { return "P_Validation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_P_Validation_InsertOrUpdate"; } }
    }
    public enum P_ValidationColumns
    {
        ID,
        I_DataID,
        F_TransactionID,
        Result,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum P_ValidationProcedure
    {
        p_P_Validation_GetBy_I_DataID,
        p_P_Validation_GetListByListI_DataID,
        p_P_Validation_GetBy_I_ImageID,
        p_P_Validation_GetBy_F_TransactionID,
        p_P_Validation_Get_ForTAccount,
        p_P_Validation_GetSkip_ForTAccount,
        p_P_Validation_GetListForDeleting,
        p_P_Validation_GetList_ByAccessID,
        p_P_Validation_GetList_ByListFinID,
        p_P_Validation_GetLastListByListI_DataID,
        p_P_Validation_NotMatchFINByB_AccessID,
        p_P_Validation_MatchFINByB_AccessID,
        p_P_Validation_GetList_ByListImageID,
        p_P_Validation_Check_Matching_Or_Skip
    }
    public class P_ValidationList : List<P_Validation>
    {

    }
}
