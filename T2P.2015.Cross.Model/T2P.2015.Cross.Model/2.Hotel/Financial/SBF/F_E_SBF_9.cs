using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_SBF_9 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_E_SBF_0_4287ID;
        public long F_E_SBF_0_4287ID
        {
            get { return _f_E_SBF_0_4287ID; }
            set { _f_E_SBF_0_4287ID = value; }
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
        private DateTime? _procDate;
        public DateTime? ProcDate
        {
            get { return _procDate; }
            set { _procDate = value; }
        }
        private string _numOfAccts;
        public string NumOfAccts
        {
            get { return _numOfAccts; }
            set { _numOfAccts = value; }
        }
        private string _numOfTrans;
        public string NumOfTrans
        {
            get { return _numOfTrans; }
            set { _numOfTrans = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_SBF_9"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_SBF_9_InsertOrUpdate"; } }
    }
    public enum F_E_SBF_9Columns
    {
        ID,
        F_E_SBF_0_4287ID,
        RecordTypeID,
        ProviderID3,
        ProviderID2,
        ProviderID1,
        ProcDate,
        NumOfAccts,
        NumOfTrans,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_SBF_9Procedure
    {
        p_F_E_SBF_9_Get_By_F_ImportFileID,
    }
    public class F_E_SBF_9List : List<F_E_SBF_9>
    {

    }
}