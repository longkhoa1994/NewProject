using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_SBF_0_4287 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_E_SBF_0_0ID;
        public long F_E_SBF_0_0ID
        {
            get { return _f_E_SBF_0_0ID; }
            set { _f_E_SBF_0_0ID = value; }
        }
        private string _recordTypeID;
        public string RecordTypeID
        {
            get { return _recordTypeID; }
            set { _recordTypeID = value; }
        }
        private string _clientID;
        public string ClientID
        {
            get { return _clientID; }
            set { _clientID = value; }
        }
        private DateTime? _sysDate;
        public DateTime? SysDate
        {
            get { return _sysDate; }
            set { _sysDate = value; }
        }
        private string _cycleDay;
        public string CycleDay
        {
            get { return _cycleDay; }
            set { _cycleDay = value; }
        }
        private DateTime? _procDate;
        public DateTime? ProcDate
        {
            get { return _procDate; }
            set { _procDate = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_SBF_0_4287"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_SBF_0_4287_InsertOrUpdate"; } }
    }
    public enum F_E_SBF_0_4287Columns
    {
        ID,
        F_E_SBF_0_0ID,
        RecordTypeID,
        ClientID,
        SysDate,
        CycleDay,
        ProcDate,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_SBF_0_4287Procedure
    {
        p_F_E_SBF_0_4287_Get_By_F_ImportFileID,
    }
    public class F_E_SBF_0_4287List : List<F_E_SBF_0_4287>
    {

    }
}