using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_Surchage : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _surcharge;

        public string Surcharge
        {
            get { return _surcharge; }
            set { _surcharge = value; }
        }

        private string _serviceCode;

        public string ServiceCode
        {
            get { return _serviceCode; }
            set { _serviceCode = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string Table { get { return "R_M_Surchage"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_Surchage_InsertOrUpdate"; } }
    }

    public enum R_M_SurchageColumns
    {
        ID,
        Surcharge,
        ServiceCode,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_M_SurchageProcedure
    {
    }

    public class R_M_SurchageList : List<R_M_Surchage>
    {
    }
}