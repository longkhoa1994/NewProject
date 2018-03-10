using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_TransactionAdditionAPC : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_TransactionID;
        public long F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }
        private string _dBI_PK;
        public string DBI_PK
        {
            get { return _dBI_PK; }
            set { _dBI_PK = value; }
        }
        private string _dBI_KS;
        public string DBI_KS
        {
            get { return _dBI_KS; }
            set { _dBI_KS = value; }
        }
        private string _dBI_DS;
        public string DBI_DS
        {
            get { return _dBI_DS; }
            set { _dBI_DS = value; }
        }
        private string _dBI_AE;
        public string DBI_AE
        {
            get { return _dBI_AE; }
            set { _dBI_AE = value; }
        }
        private string _dBI_IK;
        public string DBI_IK
        {
            get { return _dBI_IK; }
            set { _dBI_IK = value; }
        }
        private string _dBI_BD;
        public string DBI_BD
        {
            get { return _dBI_BD; }
            set { _dBI_BD = value; }
        }
        private string _dBI_PR;
        public string DBI_PR
        {
            get { return _dBI_PR; }
            set { _dBI_PR = value; }
        }
        private string _dBI_AU;
        public string DBI_AU
        {
            get { return _dBI_AU; }
            set { _dBI_AU = value; }
        }
        private string _dBI_AK;
        public string DBI_AK
        {
            get { return _dBI_AK; }
            set { _dBI_AK = value; }
        }
        private string _dBI_RZ;
        public string DBI_RZ
        {
            get { return _dBI_RZ; }
            set { _dBI_RZ = value; }
        }
        public override string Table { get { return "F_TransactionAdditionAPC"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_TransactionAdditionAPC_InsertOrUpdate"; } }
    }
    public enum F_TransactionAdditionAPCColumns
    {
        ID,
        F_TransactionID,
        DBI_PK,
        DBI_KS,
        DBI_DS,
        DBI_AE,
        DBI_IK,
        DBI_BD,
        DBI_PR,
        DBI_AU,
        DBI_AK,
        DBI_RZ,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_TransactionAdditionAPCProcedure
    {
        p_F_TransactionAdditionAPC_GetListForDeleting,
    }
    public class F_TransactionAdditionAPCList : List<F_TransactionAdditionAPC>
    {

    }
}
