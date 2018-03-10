using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_GL1076_00 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _f_I_GL1076_FHID;

        public long F_I_GL1076_FHID
        {
            get { return _f_I_GL1076_FHID; }
            set { _f_I_GL1076_FHID = value; }
        }

        private long _f_HeaderID;
        public long F_HeaderID
        {
            get { return _f_HeaderID; }
            set { _f_HeaderID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _marketCode;
        public string MarketCode
        {
            get { return _marketCode; }
            set { _marketCode = value; }
        }
        private string _clientID;
        public string ClientID
        {
            get { return _clientID; }
            set { _clientID = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        private string _iSONumericCountryCode;
        public string ISONumericCountryCode
        {
            get { return _iSONumericCountryCode; }
            set { _iSONumericCountryCode = value; }
        }
        private string _iDCIECIndicator;
        public string IDCIECIndicator
        {
            get { return _iDCIECIndicator; }
            set { _iDCIECIndicator = value; }
        }
        private string _clientOrganizationName;
        public string ClientOrganizationName
        {
            get { return _clientOrganizationName; }
            set { _clientOrganizationName = value; }
        }
        private DateTime? _processDate;
        public DateTime? ProcessDate
        {
            get { return _processDate; }
            set { _processDate = value; }
        }
        private string _messageText;
        public string MessageText
        {
            get { return _messageText; }
            set { _messageText = value; }
        }
        private string _totalTransactionCount;
        public string TotalTransactionCount
        {
            get { return _totalTransactionCount; }
            set { _totalTransactionCount = value; }
        }
        private string _filler2;
        public string Filler2
        {
            get { return _filler2; }
            set { _filler2 = value; }
        }
        private string _filler3;
        public string Filler3
        {
            get { return _filler3; }
            set { _filler3 = value; }
        }

        public override string Table { get { return "F_I_GL1076_00"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_GL1076_00_InsertOrUpdate"; } }
    }
    public enum F_I_GL1076_00Columns
    {
        ID,
        F_I_GL1076_FHID,
        F_HeaderID,
        RecordType,
        MarketCode,
        ClientID,
        Filler,
        ISONumericCountryCode,
        IDCIECIndicator,
        ClientOrganizationName,
        ProcessDate,
        MessageText,
        TotalTransactionCount,
        Filler2,
        Filler3,
        CreatedDate,
        CreatedBy,
        UpdatedDate,
        Updatedby,
        Status,
    }
    public enum F_I_GL1076_00Procedure
    {
        p_F_I_GL1076_00_Get_By_F_ImportFileID,
        p_F_I_GL1076_00_Get_By_F_HeaderID,
        p_F_I_GL1076_00_Get_By_F_TransactionID
    }
    public class F_I_GL1076_00List : List<F_I_GL1076_00>
    {

    }
}