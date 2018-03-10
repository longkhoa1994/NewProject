using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_DBIData : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _i_DataID;
        public long I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
        }
        private string _aE;
        public string AE
        {
            get { return _aE; }
            set { _aE = value; }
        }
        private string _aK;
        public string AK
        {
            get { return _aK; }
            set { _aK = value; }
        }
        private string _aU;
        public string AU
        {
            get { return _aU; }
            set { _aU = value; }
        }
        private string _bD;
        public string BD
        {
            get { return _bD; }
            set { _bD = value; }
        }
        private string _dS;
        public string DS
        {
            get { return _dS; }
            set { _dS = value; }
        }
        private string _iK;
        public string IK
        {
            get { return _iK; }
            set { _iK = value; }
        }
        private string _kS;
        public string KS
        {
            get { return _kS; }
            set { _kS = value; }
        }
        private string _pK;
        public string PK
        {
            get { return _pK; }
            set { _pK = value; }
        }
        private string _pR;
        public string PR
        {
            get { return _pR; }
            set { _pR = value; }
        }
        private string _rZ;
        public string RZ
        {
            get { return _rZ; }
            set { _rZ = value; }
        }
        public override string Table { get { return "I_DBIData"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_DBIData_InsertOrUpdate"; } }
    }
    public enum I_DBIDataColumns
    {
        ID,
        I_DataID,
        AE,
        AK,
        AU,
        BD,
        DS,
        IK,
        KS,
        PK,
        PR,
        RZ,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_DBIDataProcedure
    {
        p_I_DBIData_Get_By_I_ImageID
    }
    public class I_DBIDataList : List<I_DBIData>
    {

    }
}