using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_CommentDetail : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _b_CommentID;
        public long B_CommentID
        {
            get { return _b_CommentID; }
            set { _b_CommentID = value; }
        }
        private long? _f_TransactionID;
        public long? F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }
        public override string Table { get { return "B_CommentDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_CommentDetail_InsertOrUpdate"; } }
    }
    public enum B_CommentDetailColumns
    {
        ID,
        B_CommentID,
        F_TransactionID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum B_CommentDetailProcedure
    {

    }
    public class B_CommentDetailList : List<B_CommentDetail>
    {

    }
}