using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_SBF_0_0 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_ImportFileID;
        public long F_ImportFileID
        {
            get { return _f_ImportFileID; }
            set { _f_ImportFileID = value; }
        }
        private string _recordTypeID;
        public string RecordTypeID
        {
            get { return _recordTypeID; }
            set { _recordTypeID = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        private string _headerID;
        public string HeaderID
        {
            get { return _headerID; }
            set { _headerID = value; }
        }
        private DateTime? _procDate;
        public DateTime? ProcDate
        {
            get { return _procDate; }
            set { _procDate = value; }
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
        public override string Table { get { return "F_E_SBF_0_0"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_SBF_0_0_InsertOrUpdate"; } }
    }
    public enum F_E_SBF_0_0Columns
    {
        ID,
        F_ImportFileID,
        RecordTypeID,
        Filler,
        HeaderID,
        ProcDate,
        Filler2,
        Filler3,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_SBF_0_0Procedure
    {
        p_F_E_SBF_0_0_Get_By_F_ImportFileID,
    }
    public class F_E_SBF_0_0List : List<F_E_SBF_0_0>
    {

    }
}