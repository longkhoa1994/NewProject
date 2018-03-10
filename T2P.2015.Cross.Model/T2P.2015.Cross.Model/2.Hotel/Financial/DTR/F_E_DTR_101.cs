using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_101 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _f_ImportFileID;
        public long? F_ImportFileID
        {
            get { return _f_ImportFileID; }
            set { _f_ImportFileID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _zero;
        public string Zero
        {
            get { return _zero; }
            set { _zero = value; }
        }
        private string _processorName;
        public string ProcessorName
        {
            get { return _processorName; }
            set { _processorName = value; }
        }
        private DateTime? _headDate;
        public DateTime? HeadDate
        {
            get { return _headDate; }
            set { _headDate = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        private string _pgmVersionNum;
        public string PgmVersionNum
        {
            get { return _pgmVersionNum; }
            set { _pgmVersionNum = value; }
        }
        public override string Table { get { return "F_E_DTR_101"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_101_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_101Columns
    {
        ID,
        F_ImportFileID,
        RecordType,
        Zero,
        ProcessorName,
        HeadDate,
        Filler,
        PgmVersionNum,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_101Procedure
    {
        p_F_E_DTR_101_GetBy_F_ImportFileID
    }
    public class F_E_DTR_101List : List<F_E_DTR_101>
    {

    }
}