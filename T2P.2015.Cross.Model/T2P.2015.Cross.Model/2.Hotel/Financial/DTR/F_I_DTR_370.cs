using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_DTR_370 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _f_I_DTR_320ID;
        public long? F_I_DTR_320ID
        {
            get { return _f_I_DTR_320ID; }
            set { _f_I_DTR_320ID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _businessIca;
        public string BusinessIca
        {
            get { return _businessIca; }
            set { _businessIca = value; }
        }
        private string _providerId3;
        public string ProviderId3
        {
            get { return _providerId3; }
            set { _providerId3 = value; }
        }
        private string _providerId2;
        public string ProviderId2
        {
            get { return _providerId2; }
            set { _providerId2 = value; }
        }
        private string _providerId1;
        public string ProviderId1
        {
            get { return _providerId1; }
            set { _providerId1 = value; }
        }
        private string _clientProductCode;
        public string ClientProductCode
        {
            get { return _clientProductCode; }
            set { _clientProductCode = value; }
        }
        private string _tbr;
        public string Tbr
        {
            get { return _tbr; }
            set { _tbr = value; }
        }
        private string _acctNo;
        public string AcctNo
        {
            get { return _acctNo; }
            set { _acctNo = value; }
        }
        private string _aquirRefNum;
        public string AquirRefNum
        {
            get { return _aquirRefNum; }
            set { _aquirRefNum = value; }
        }
        private decimal? _addendumSeqNo;
        public decimal? AddendumSeqNo
        {
            get { return _addendumSeqNo; }
            set { _addendumSeqNo = value; }
        }
        private DateTime? _arrivalDate;
        public DateTime? ArrivalDate
        {
            get { return _arrivalDate; }
            set { _arrivalDate = value; }
        }
        private DateTime? _departDate;
        public DateTime? DepartDate
        {
            get { return _departDate; }
            set { _departDate = value; }
        }
        private string _folioNum;
        public string FolioNum
        {
            get { return _folioNum; }
            set { _folioNum = value; }
        }
        private string _propertyTeleNum;
        public string PropertyTeleNum
        {
            get { return _propertyTeleNum; }
            set { _propertyTeleNum = value; }
        }
        private string _custServiceNum;
        public string CustServiceNum
        {
            get { return _custServiceNum; }
            set { _custServiceNum = value; }
        }
        private decimal? _roomRate;
        public decimal? RoomRate
        {
            get { return _roomRate; }
            set { _roomRate = value; }
        }
        private decimal? _roomTax;
        public decimal? RoomTax
        {
            get { return _roomTax; }
            set { _roomTax = value; }
        }
        private string _programCd;
        public string ProgramCd
        {
            get { return _programCd; }
            set { _programCd = value; }
        }
        private decimal? _amtOfCall;
        public decimal? AmtOfCall
        {
            get { return _amtOfCall; }
            set { _amtOfCall = value; }
        }
        private decimal? _restaurantRmServ;
        public decimal? RestaurantRmServ
        {
            get { return _restaurantRmServ; }
            set { _restaurantRmServ = value; }
        }
        private decimal? _barMiniBarCharge;
        public decimal? BarMiniBarCharge
        {
            get { return _barMiniBarCharge; }
            set { _barMiniBarCharge = value; }
        }
        private decimal? _giftShopCharges;
        public decimal? GiftShopCharges
        {
            get { return _giftShopCharges; }
            set { _giftShopCharges = value; }
        }
        private decimal? _laundDryCleanChg;
        public decimal? LaundDryCleanChg
        {
            get { return _laundDryCleanChg; }
            set { _laundDryCleanChg = value; }
        }
        private string _otherServCd;
        public string OtherServCd
        {
            get { return _otherServCd; }
            set { _otherServCd = value; }
        }
        private decimal? _otherServCharges;
        public decimal? OtherServCharges
        {
            get { return _otherServCharges; }
            set { _otherServCharges = value; }
        }
        private string _billAdjustIndic;
        public string BillAdjustIndic
        {
            get { return _billAdjustIndic; }
            set { _billAdjustIndic = value; }
        }
        private decimal? _billAdjustAmt;
        public decimal? BillAdjustAmt
        {
            get { return _billAdjustAmt; }
            set { _billAdjustAmt = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_I_DTR_370"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_DTR_370_InsertOrUpdate"; } }
    }
    public enum F_I_DTR_370Columns
    {
        ID,
        F_I_DTR_320ID,
        RecordType,
        BusinessIca,
        ProviderId3,
        ProviderId2,
        ProviderId1,
        ClientProductCode,
        Tbr,
        AcctNo,
        AquirRefNum,
        AddendumSeqNo,
        ArrivalDate,
        DepartDate,
        FolioNum,
        PropertyTeleNum,
        CustServiceNum,
        RoomRate,
        RoomTax,
        ProgramCd,
        AmtOfCall,
        RestaurantRmServ,
        BarMiniBarCharge,
        GiftShopCharges,
        LaundDryCleanChg,
        OtherServCd,
        OtherServCharges,
        BillAdjustIndic,
        BillAdjustAmt,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_I_DTR_370Procedure
    {
        p_F_I_DTR_370_GetBy_F_I_DTR_320ID
    }
    public class F_I_DTR_370List : List<F_I_DTR_370>
    {

    }
}