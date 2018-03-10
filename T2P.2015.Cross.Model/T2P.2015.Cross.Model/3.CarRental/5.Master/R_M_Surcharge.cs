using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_Surcharge : BaseModel
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

        private bool _changeToExtraCharge;

        public bool ChangeToExtraCharge
        {
            get { return _changeToExtraCharge; }
            set { _changeToExtraCharge = value; }
        }

        public override string Table { get { return "R_M_Surcharge"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_Surcharge_InsertOrUpdate"; } }
    }

    public enum R_M_SurchargeColumns
    {
        ID,
        Surcharge,
        ServiceCode,
        Description,
        ChangeToExtraCharge,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_M_SurchargeProcedure
    {
        p_R_M_Surcharge_GetBy_ServiceCode,
        p_R_M_Surcharge_Get_By_R_RG_RateGridID
    }

    public class R_M_SurchargeList : List<R_M_Surcharge>
    {
    }
}