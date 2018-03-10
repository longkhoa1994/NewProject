using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_SBF_0_0000000 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_I_SBF_0_0ID;
        public long F_I_SBF_0_0ID
        {
            get { return _f_I_SBF_0_0ID; }
            set { _f_I_SBF_0_0ID = value; }
        }
        private string _hTZeros;
        public string HTZeros
        {
            get { return _hTZeros; }
            set { _hTZeros = value; }
        }
        private string _hTAlpha;
        public string HTAlpha
        {
            get { return _hTAlpha; }
            set { _hTAlpha = value; }
        }
        private string _trailerCount;
        public string TrailerCount
        {
            get { return _trailerCount; }
            set { _trailerCount = value; }
        }
        private float? _trailerTotalDebitAmt;
        public float? TrailerTotalDebitAmt
        {
            get { return _trailerTotalDebitAmt; }
            set { _trailerTotalDebitAmt = value; }
        }
        private float? _trailerTotalCreditAmt;
        public float? TrailerTotalCreditAmt
        {
            get { return _trailerTotalCreditAmt; }
            set { _trailerTotalCreditAmt = value; }
        }
        private float? _trailerTotalPaymentAmt;
        public float? TrailerTotalPaymentAmt
        {
            get { return _trailerTotalPaymentAmt; }
            set { _trailerTotalPaymentAmt = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_I_SBF_0_0000000"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_SBF_0_0000000_InsertOrUpdate"; } }
    }
    public enum F_I_SBF_0_0000000Columns
    {
        ID,
        F_I_SBF_0_0ID,
        HTZeros,
        HTAlpha,
        TrailerCount,
        TrailerTotalDebitAmt,
        TrailerTotalCreditAmt,
        TrailerTotalPaymentAmt,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_I_SBF_0_0000000Procedure
    {

    }
    public class F_I_SBF_0_0000000List : List<F_I_SBF_0_0000000>
    {

    }
}