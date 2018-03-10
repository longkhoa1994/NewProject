using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_InformationDetail : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _n_InformationID;
        public long N_InformationID
        {
            get { return _n_InformationID; }
            set { _n_InformationID = value; }
        }
        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private long? _f_TransactionID;

        public long? F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }

        public override string Table { get { return "N_InformationDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_InformationDetail_InsertOrUpdate"; } }
    }
    public enum N_InformationDetailColumns
    {
        ID,
        N_InformationID,
        B_AccessID,
        F_TransactionID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum N_InformationDetailProcedure
    {
        p_N_InformationDetail_GetListForDeleting,
        p_N_InformationDetail_InsertDataForDeleting,
    }
    public class N_InformationDetailList : List<N_InformationDetail>
    {

    }
}
