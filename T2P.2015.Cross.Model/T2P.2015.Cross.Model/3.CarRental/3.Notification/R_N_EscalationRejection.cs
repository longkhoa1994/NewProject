using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_EscalationRejection : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _r_N_RejectionID;
        public long R_N_RejectionID
        {
            get { return _r_N_RejectionID; }
            set { _r_N_RejectionID = value; }
        }

        private long _r_N_EscalationID;
        public long R_N_EscalationID
        {
            get { return _r_N_EscalationID; }
            set { _r_N_EscalationID = value; }
        }

        public override string Table { get { return "R_N_EscalationRejection"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_EscalationRejection_InsertOrUpdate"; } }
    }
    public enum R_N_EscalationRejectionColumns
    {
        ID,
        R_N_RejectionID,
        R_N_EscalationID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_N_EscalationRejectionProcedure
    {

    }
    public class R_N_EscalationRejectionList : List<R_N_EscalationRejection>
    {

    }
}