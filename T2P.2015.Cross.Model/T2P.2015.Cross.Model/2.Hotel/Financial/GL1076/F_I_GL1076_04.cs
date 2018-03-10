using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_GL1076_04 : BaseModel
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

        private long _f_I_GL1076_01ID;

        public long F_I_GL1076_01ID
        {
            get { return _f_I_GL1076_01ID; }
            set { _f_I_GL1076_01ID = value; }
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
        private string _userDefined1;
        public string UserDefined1
        {
            get { return _userDefined1; }
            set { _userDefined1 = value; }
        }
        private string _userDefined2;
        public string UserDefined2
        {
            get { return _userDefined2; }
            set { _userDefined2 = value; }
        }
        private string _userDefined3;
        public string UserDefined3
        {
            get { return _userDefined3; }
            set { _userDefined3 = value; }
        }
        private string _userDefined4;
        public string UserDefined4
        {
            get { return _userDefined4; }
            set { _userDefined4 = value; }
        }
        private string _userDefined5;
        public string UserDefined5
        {
            get { return _userDefined5; }
            set { _userDefined5 = value; }
        }
        private string _userDefined6;
        public string UserDefined6
        {
            get { return _userDefined6; }
            set { _userDefined6 = value; }
        }
        private string _userDefined7;
        public string UserDefined7
        {
            get { return _userDefined7; }
            set { _userDefined7 = value; }
        }
        private string _userDefined8;
        public string UserDefined8
        {
            get { return _userDefined8; }
            set { _userDefined8 = value; }
        }
        private string _userDefined9;
        public string UserDefined9
        {
            get { return _userDefined9; }
            set { _userDefined9 = value; }
        }
        private string _userDefined10;
        public string UserDefined10
        {
            get { return _userDefined10; }
            set { _userDefined10 = value; }
        }
        private string _userDefined11;
        public string UserDefined11
        {
            get { return _userDefined11; }
            set { _userDefined11 = value; }
        }
        private string _userDefined12;
        public string UserDefined12
        {
            get { return _userDefined12; }
            set { _userDefined12 = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }

        public override string Table { get { return "F_I_GL1076_04"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_GL1076_04_InsertOrUpdate"; } }
    }
    public enum F_I_GL1076_04Columns
    {
        ID,
        RecordType,
        F_I_GL1076_01ID,
        vPaymentTokenAccountNumber,
        PreAuthorizationUniqueID,
        TransactionSequenceNumber,
        BusinessProcessDate,
        BatchNumber,
        UserDefined1,
        UserDefined2,
        UserDefined3,
        UserDefined4,
        UserDefined5,
        UserDefined6,
        UserDefined7,
        UserDefined8,
        UserDefined9,
        UserDefined10,
        UserDefined11,
        UserDefined12,
        Filler,
        CreatedDate,
        CreatedBy,
        UpdatedDate,
        Updatedby,
        Status,
    }
    public enum F_I_GL1076_04Procedure
    {
        p_F_I_GL1076_04_Get_By_F_I_GL_1076_01ID,
        p_F_I_GL1076_04_Get_By_F_TransactionID
    }
    public class F_I_GL1076_04List : List<F_I_GL1076_04>
    {

    }
}