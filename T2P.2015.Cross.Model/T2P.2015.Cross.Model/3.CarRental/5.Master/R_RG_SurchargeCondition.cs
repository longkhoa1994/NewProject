using System;
using System.Collections.Generic;
using T2P._2015.Cross.Enum.CarRental.Invoice;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_RG_SurchargeCondition : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _r_RG_SurchargeID;
        public long R_RG_SurchargeID
        {
            get { return _r_RG_SurchargeID; }
            set { _r_RG_SurchargeID = value; }
        }

        private string _unit;
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        private decimal? _min;
        public decimal? Min
        {
            get { return _min; }
            set { _min = value; }
        }

        private string _minUnit;
        public string MinUnit
        {
            get { return _minUnit; }
            set { _minUnit = value; }
        }

        private decimal? _max;
        public decimal? Max
        {
            get { return _max; }
            set { _max = value; }
        }

        private string _maxUnit;
        public string MaxUnit
        {
            get { return _maxUnit; }
            set { _maxUnit = value; }
        }

        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _priceType;
        public string PriceType
        {
            get { return _priceType; }
            set { _priceType = value; }
        }
        private decimal? _minPriceValue;
        public decimal? MinPriceValue
        {
            get { return _minPriceValue; }
            set { _minPriceValue = value; }
        }
        private string _minPriceUnit;
        public string MinPriceUnit
        {
            get { return _minPriceUnit; }
            set { _minPriceUnit = value; }
        }
        private decimal? _maxPriceValue;
        public decimal? MaxPriceValue
        {
            get { return _maxPriceValue; }
            set { _maxPriceValue = value; }
        }
        private string _maxPriceUnit;
        public string MaxPriceUnit
        {
            get { return _maxPriceUnit; }
            set { _maxPriceUnit = value; }
        }

        private string _comment;

        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public override string Table { get { return "R_RG_SurchargeCondition"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_RG_SurchargeCondition_InsertOrUpdate"; } }
                                                                     
    }

    public enum R_RG_SurchargeConditionColumns
    {
        ID,
        R_RG_SurchargeID,
        Unit,
        Min,
        MinUnit,
        Max,
        MaxUnit,
        Price,
        PriceType,
        MinPriceValue,
        MinPriceUnit, 
        MaxPriceValue,
        MaxPriceUnit,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status
    }

    public enum R_RG_SurchargeConditionProcedure
    {
        p_R_RG_SurchargeCondition_GetBy_RG_SurchargeId,
        p_R_SurchargeCondition_GetBy_SurchargeId
    }

    public class R_RG_SurchargeConditionList : List<R_RG_SurchargeCondition>
    {
    }

    
    [Serializable]
    public class R_RG_SurchargeConditionExtra : R_RG_SurchargeCondition
    {
        private long _M_SurchargeID;
        public long M_SurchargeID
        {
            get { return _M_SurchargeID; }
            set { _M_SurchargeID = value; }
        }
    }
    public enum R_RG_SurchargeConditionExtraProcedure
    {
        p_R_RG_SurchargeConditionExtra_GetBy_R_RG_RateGridID
    }
}