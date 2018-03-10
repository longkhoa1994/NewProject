using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_DTR_999 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _f_I_DTR_101ID;
        public long? F_I_DTR_101ID
        {
            get { return _f_I_DTR_101ID; }
            set { _f_I_DTR_101ID = value; }
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
        private int? _outputRecCt;
        public int? OutputRecCt
        {
            get { return _outputRecCt; }
            set { _outputRecCt = value; }
        }
        private int? _totNumDb;
        public int? TotNumDb
        {
            get { return _totNumDb; }
            set { _totNumDb = value; }
        }
        private decimal? _totDbAmt;
        public decimal? TotDbAmt
        {
            get { return _totDbAmt; }
            set { _totDbAmt = value; }
        }
        private int? _totNumCr;
        public int? TotNumCr
        {
            get { return _totNumCr; }
            set { _totNumCr = value; }
        }
        private decimal? _totCrAmt;
        public decimal? TotCrAmt
        {
            get { return _totCrAmt; }
            set { _totCrAmt = value; }
        }
        private int? _adjNoOfDb;
        public int? AdjNoOfDb
        {
            get { return _adjNoOfDb; }
            set { _adjNoOfDb = value; }
        }
        private decimal? _adjDbAmt;
        public decimal? AdjDbAmt
        {
            get { return _adjDbAmt; }
            set { _adjDbAmt = value; }
        }
        private int? _adjNoOfCr;
        public int? AdjNoOfCr
        {
            get { return _adjNoOfCr; }
            set { _adjNoOfCr = value; }
        }
        private decimal? _adjCrAmt;
        public decimal? AdjCrAmt
        {
            get { return _adjCrAmt; }
            set { _adjCrAmt = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_I_DTR_999"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_DTR_999_InsertOrUpdate"; } }
    }
    public enum F_I_DTR_999Columns
    {
        ID,
        F_I_DTR_101ID,
        RecordType,
        Zero,
        OutputRecCt,
        TotNumDb,
        TotDbAmt,
        TotNumCr,
        TotCrAmt,
        AdjNoOfDb,
        AdjDbAmt,
        AdjNoOfCr,
        AdjCrAmt,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_I_DTR_999Procedure
    {
        p_F_I_DTR_999_GetBy_F_I_DTR_101ID
    }
    public class F_I_DTR_999List : List<F_I_DTR_999>
    {

    }
}