using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_Comment : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _r_B_AccessID;

        public long? R_B_AccessID
        {
            get { return _r_B_AccessID; }
            set { _r_B_AccessID = value; }
        }

        private long? _r_I_ImageID;

        public long? R_I_ImageID
        {
            get { return _r_I_ImageID; }
            set { _r_I_ImageID = value; }
        }

        private long? _r_F_TransactionID;

        public long? R_F_TransactionID
        {
            get { return _r_F_TransactionID; }
            set { _r_F_TransactionID = value; }
        }

        private long? _n_TaskID;

        public long? N_TaskID
        {
            get { return _n_TaskID; }
            set { _n_TaskID = value; }
        }

        private long? _r_I_PositionID;

        public long? R_I_PositionID
        {
            get { return _r_I_PositionID; }
            set { _r_I_PositionID = value; }
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

        public override string Table { get { return "R_N_Comment"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_Comment_InsertOrUpdate"; } }
    }

    public enum R_N_CommentColumns
    {
        ID,
        R_B_AccessID,
        R_I_ImageID,
        R_F_TransactionID,
        N_TaskID,
        R_I_PositionID,
        M_CodeID,
        Action,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_N_CommentProcedure
    {
        p_R_N_Comment_ForParking,
        p_R_N_Comment_Get_By_FinID,
        p_R_N_Comment_Get_By_ImageID,
        p_R_N_Comment_Get_By_R_N_BillingEmailID,
    }

    public class R_N_CommentList : List<R_N_Comment>
    {
    }
}