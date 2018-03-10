using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_GL1076_05 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private long _f_E_GL1076_01ID;

        public long F_E_GL1076_01ID
        {
            get { return _f_E_GL1076_01ID; }
            set { _f_E_GL1076_01ID = value; }
        }

        private string _vPaymentTokenAccountNumber;
        public string vPaymentTokenAccountNumber
        {
            get { return _vPaymentTokenAccountNumber; }
            set { _vPaymentTokenAccountNumber = value; }
        }
        private string _preAuthorizationUniqueID;
        public string PreAuthorizationUniqueID
        {
            get { return _preAuthorizationUniqueID; }
            set { _preAuthorizationUniqueID = value; }
        }
        private string _transactionSequenceNumber;
        public string TransactionSequenceNumber
        {
            get { return _transactionSequenceNumber; }
            set { _transactionSequenceNumber = value; }
        }
        private DateTime? _businessProcessDate;
        public DateTime? BusinessProcessDate
        {
            get { return _businessProcessDate; }
            set { _businessProcessDate = value; }
        }
        private string _batchNumber;
        public string BatchNumber
        {
            get { return _batchNumber; }
            set { _batchNumber = value; }
        }
        private string _accounting1;
        public string Accounting1
        {
            get { return _accounting1; }
            set { _accounting1 = value; }
        }
        private string _accounting2;
        public string Accounting2
        {
            get { return _accounting2; }
            set { _accounting2 = value; }
        }
        private string _accounting3;
        public string Accounting3
        {
            get { return _accounting3; }
            set { _accounting3 = value; }
        }
        private string _accounting4;
        public string Accounting4
        {
            get { return _accounting4; }
            set { _accounting4 = value; }
        }
        private string _accounting5;
        public string Accounting5
        {
            get { return _accounting5; }
            set { _accounting5 = value; }
        }
        private string _accounting6;
        public string Accounting6
        {
            get { return _accounting6; }
            set { _accounting6 = value; }
        }
        private string _accounting7;
        public string Accounting7
        {
            get { return _accounting7; }
            set { _accounting7 = value; }
        }
        private string _accounting8;
        public string Accounting8
        {
            get { return _accounting8; }
            set { _accounting8 = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }

        public override string Table { get { return "F_E_GL1076_05"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_GL1076_05_InsertOrUpdate"; } }
    }
    public enum F_E_GL1076_05Columns
    {
        ID,
        RecordType,
        F_E_GL1076_01ID,
        vPaymentTokenAccountNumber,
        PreAuthorizationUniqueID,
        TransactionSequenceNumber,
        BusinessProcessDate,
        BatchNumber,
        Accounting1,
        Accounting2,
        Accounting3,
        Accounting4,
        Accounting5,
        Accounting6,
        Accounting7,
        Accounting8,
        Filler,
        CreatedDate,
        CreatedBy,
        UpdatedDate,
        Updatedby,
        Status,
    }
    public enum F_E_GL1076_05Procedure
    {
        p_F_E_GL1076_05_Get_By_F_E_GL_1076_01ID,
    }
    public class F_E_GL1076_05List : List<F_E_GL1076_05>
    {

    }
}