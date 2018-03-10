using System;
using System.Collections.Generic;
using T2P._2015.Cross.Model;

namespace T2P._2015.Model
{
    [Serializable]
    public class B_Comment : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        private long? _i_ImageID;
        public long? I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }
        private long? _f_TransactionID;
        public long? F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }
        private long? _n_TaskID;
        public long? N_TaskID
        {
            get { return _n_TaskID; }
            set { _n_TaskID = value; }
        }

        private long? _m_CodeID;

        public long? M_CodeID
        {
            get { return _m_CodeID; }
            set { _m_CodeID = value; }
        }

        private string _action;
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
        private string _comment;
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }
        public override string Table { get { return "B_Comment"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_Comment_InsertOrUpdate"; } }
    }
    public class B_CommentExtend: B_Comment
    {
        public string Code { get; set; }
    }
    public enum B_CommentColumns
    {
        ID,
        B_AccessID,
        I_ImageID,
        F_TransactionID,
        N_TaskID,
        M_CodeID,
        Action,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum B_CommentProcedure
    {
        p_B_Comment_GetList_CheckingStatus,
        p_B_Comment_GetByCheckingStatus,
        p_B_Comment_GetListForDeleting,
        p_B_Comment_GetByAction,
        p_B_Comment_GetByActionExtend,
        p_B_Comment_GetBy_StopCode,
        p_B_Comment_GetBy_CheckStopBooking,
        p_B_Comment_GetByB_AccessID_StopCode,
        p_B_Comment_GetByI_ImageID_After2Rejection,
        p_B_Comment_CheckBookingStop_SelfPayment,
    }

    public class B_CommentList : List<B_Comment>
    {
    }   
}