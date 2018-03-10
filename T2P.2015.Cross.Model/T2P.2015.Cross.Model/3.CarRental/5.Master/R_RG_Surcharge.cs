using System;
using System.Collections.Generic;
using T2P._2015.Cross.Enum.CarRental.Invoice;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_RG_Surcharge : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _r_RG_RateGridID;

        public long? R_RG_RateGridID
        {
            get { return _r_RG_RateGridID; }
            set { _r_RG_RateGridID = value; }
        }

        private long? _m_SurchargeID;

        public long? M_SurchargeID
        {
            get { return _m_SurchargeID; }
            set { _m_SurchargeID = value; }
        }

        private bool? _applicable;

        public bool? Applicable
        {
            get { return _applicable; }
            set { _applicable = value; }
        }

        private string _formularType;
        public string FormularType
        {
            get { return _formularType; }
            set { _formularType = value; }
        }

        private bool _changeToExtraCharge;

        public bool ChangeToExtraCharge
        {
            get { return _changeToExtraCharge; }
            set { _changeToExtraCharge = value; }
        }

        //private string _unit;
        //[NotInsert]
        //[NotUpdate]
        //public string Unit
        //{
        //    get { return _unit; }
        //    set { _unit = value; }
        //}

        //private float? _minUnit;
        //[NotInsert]
        //[NotUpdate]
        //public float? MinUnit
        //{
        //    get { return _minUnit; }
        //    set { _minUnit = value; }
        //}

        //private float? _maxUnit;
        //[NotInsert]
        //[NotUpdate]
        //public float? MaxUnit
        //{
        //    get { return _maxUnit; }
        //    set { _maxUnit = value; }
        //}

        //private float? _value;
        //[NotInsert]
        //[NotUpdate]
        //public float? Value
        //{
        //    get { return _value; }
        //    set { _value = value; }
        //}

        //private float? _unitPrice;

        //public float? UnitPrice
        //{
        //    get { return _unitPrice; }
        //    set { _unitPrice = value; }
        //}

        //private float? _comboPrice;

        //public float? ComboPrice
        //{
        //    get { return _comboPrice; }
        //    set { _comboPrice = value; }
        //}

        private string _validFrom;
        public string ValidFrom
        {
            get { return _validFrom; }
            set { _validFrom = value; }
        }
        private string _validTo;
        public string ValidTo
        {
            get { return _validTo; }
            set { _validTo = value; }
        }

        public override string Table { get { return "R_RG_Surcharge"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_RG_Surcharge_InsertOrUpdate"; } }
    }

    public enum R_RG_SurchargeColumns
    {
        ID,
        R_RG_RateGridID,
        M_SurchargeID,
        Applicable,
        Unit,
        MinUnit,
        MaxUnit,
        Value,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_RG_SurchargeProcedure
    {
        p_R_RG_Surcharge_GetBy_R_B_AccessID,
        p_R_RG_Surcharge_Get_By_RateGridId, 
        p_R_RG_Surcharge_Get_ApplicableSurcharge_By_RateGridId,
        p_R_RG_Surcharge_Get_By_CountryID
    }

    public class R_RG_SurchargeList : List<R_RG_Surcharge>
    {
    }
}