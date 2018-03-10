using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_SBF_1 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? f_HeaderID;
        public long F_I_SBF_0_4287ID { get; set; }

        public long? F_HeaderID
        {
            get { return f_HeaderID; }
            set { f_HeaderID = value; }
        }

        private string _recordTypeID;
        public string RecordTypeID
        {
            get { return _recordTypeID; }
            set { _recordTypeID = value; }
        }
        private string _providerID3;
        public string ProviderID3
        {
            get { return _providerID3; }
            set { _providerID3 = value; }
        }
        private string _providerID2;
        public string ProviderID2
        {
            get { return _providerID2; }
            set { _providerID2 = value; }
        }
        private string _providerID1;
        public string ProviderID1
        {
            get { return _providerID1; }
            set { _providerID1 = value; }
        }
        private string _clientProductCode;
        public string ClientProductCode
        {
            get { return _clientProductCode; }
            set { _clientProductCode = value; }
        }
        private string _compNum;
        public string CompNum
        {
            get { return _compNum; }
            set { _compNum = value; }
        }
        private DateTime? _procDate;
        public DateTime? ProcDate
        {
            get { return _procDate; }
            set { _procDate = value; }
        }
        private string _corpAcctNum;
        public string CorpAcctNum
        {
            get { return _corpAcctNum; }
            set { _corpAcctNum = value; }
        }
        private string _billingTyp;
        public string BillingTyp
        {
            get { return _billingTyp; }
            set { _billingTyp = value; }
        }
        private string _cycleDay;
        public string CycleDay
        {
            get { return _cycleDay; }
            set { _cycleDay = value; }
        }
        private string _freqInd;
        public string FreqInd
        {
            get { return _freqInd; }
            set { _freqInd = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_I_SBF_1"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_SBF_1_InsertOrUpdate"; } }
    }
    public enum F_I_SBF_1Columns
    {
        ID,
        F_I_SBF_0_4287ID,
        F_HeaderID,
        RecordTypeID,
        ProviderID3,
        ProviderID2,
        ProviderID1,
        ClientProductCode,
        CompNum,
        ProcDate,
        CorpAcctNum,
        BillingTyp,
        CycleDay,
        FreqInd,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_I_SBF_1Procedure
    {
        p_F_I_SBF_1_GetBy_CompanyNumber_ProcessedDate
    }
    public class F_I_SBF_1List : List<F_I_SBF_1>
    {

    }
}