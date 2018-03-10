using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Room : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_ContractID;

        public long B_ContractID
        {
            get { return _b_ContractID; }
            set { _b_ContractID = value; }
        }

        private string _contigentID;

        public string ContigentID
        {
            get { return _contigentID; }
            set { _contigentID = value; }
        }

        private string _roomType;

        public string RoomType
        {
            get { return _roomType; }
            set { _roomType = value; }
        }

        private DateTime? _checkin;

        public DateTime? Checkin
        {
            get { return _checkin; }
            set { _checkin = value; }
        }

        private DateTime? _checkout;

        public DateTime? Checkout
        {
            get { return _checkout; }
            set { _checkout = value; }
        }

        private decimal? _pricePerStay;

        public decimal? PricePerStay
        {
            get { return _pricePerStay; }
            set { _pricePerStay = value; }
        }

        private decimal? _pricePerNight;

        public decimal? PricePerNight
        {
            get { return _pricePerNight; }
            set { _pricePerNight = value; }
        }

        private int? _quantityContract;

        public int? QuantityContract
        {
            get { return _quantityContract; }
            set { _quantityContract = value; }
        }

        private int? _quantityCurrent;

        public int? QuantityCurrent
        {
            get { return _quantityCurrent; }
            set { _quantityCurrent = value; }
        }

        private bool? _haveBreakfast;

        public bool? HaveBreakfast
        {
            get { return _haveBreakfast; }
            set { _haveBreakfast = value; }
        }

        public override string Table { get { return "B_Room"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_Room_InsertOrUpdate"; } }
    }

    public enum B_RoomColumns
    {
        ID,
        B_ContractID,
        ContigentID,
        RoomType,
        Checkin,
        Checkout,
        PricePerStay,
        PricePerNight,
        QuantityContract,
        QuantityCurrent,
        HaveBreakfast,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_RoomProcedure
    {
        p_B_Room_GetByBookingID,
        p_B_Room_GetByAccessID,
        p_B_Room_Get_By_B_ContractID
    }

    public class B_RoomList : List<B_Room>
    {
    }
}