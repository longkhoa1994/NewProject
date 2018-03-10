using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Rate : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_BookingDetailID;

        public long B_BookingDetailID
        {
            get { return _b_BookingDetailID; }
            set { _b_BookingDetailID = value; }
        }

        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private string _currencyCode;

        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        private float _vatRate;

        public float VatRate
        {
            get { return _vatRate; }
            set { _vatRate = value; }
        }

        private int _rateTimeAmount;

        public int RateTimeAmount
        {
            get { return _rateTimeAmount; }
            set { _rateTimeAmount = value; }
        }

        private string _rateTimeUnit;

        public string RateTimeUnit
        {
            get { return _rateTimeUnit; }
            set { _rateTimeUnit = value; }
        }

        private string _roomCategory;

        public string RoomCategory
        {
            get { return _roomCategory; }
            set { _roomCategory = value; }
        }

        public override string Table { get { return "B_Rate"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Rate_InsertOrUpdate"; } }
    }

    public enum B_RateColumns
    {
        ID,
        B_BookingDetailID,
        Price,
        CurrencyCode,
        VatRate,
        RateTimeAmount,
        RateTimeUnit,
        RoomCategory,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_RateProcedure
    {
        p_B_Rate_Get_By_B_BookingDetailID,
        p_B_Rate_GetListForDeleting,
    }

    public class B_RateList : List<B_Rate>
    {
    }
}