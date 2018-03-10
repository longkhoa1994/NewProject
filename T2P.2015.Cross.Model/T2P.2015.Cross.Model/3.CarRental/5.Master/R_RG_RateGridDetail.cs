using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_RG_RateGridDetail : BaseModel
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

        private long? _r_RG_RateCategoryID;

        public long? R_RG_RateCategoryID
        {
            get { return _r_RG_RateCategoryID; }
            set { _r_RG_RateCategoryID = value; }
        }

        private long? r_M_SippCodeID;

        public long? R_M_SippCodeID
        {
            get { return r_M_SippCodeID; }
            set { r_M_SippCodeID = value; }
        }
        private long? r_M_CarGroupID;

        public long? R_M_CarGroupID
        {
            get { return r_M_CarGroupID; }
            set { r_M_CarGroupID = value; }
        }

        private string _name;
        [NotInsert]
        [NotUpdate]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string _group;

        public string Group
        {
            get { return _group; }
            set { _group = value; }
        }

        private string _carGroup;

        public string CarGroup
        {
            get { return _carGroup; }
            set { _carGroup = value; }
        }

        private string _fleet;

        public string Fleet
        {
            get { return _fleet; }
            set { _fleet = value; }
        }

        private string _fleetType;

        public string FleetType
        {
            get { return _fleetType; }
            set { _fleetType = value; }
        }

        private string _sIPP;

        public string SIPP
        {
            get { return _sIPP; }
            set { _sIPP = value; }
        }

       
        private string _vehicleType;

        public string VehicleType
        {
            get { return _vehicleType; }
            set { _vehicleType = value; }
        }

        private string _unit;

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        private string _timeUnit;

        public string TimeUnit
        {
            get { return _timeUnit; }
            set { _timeUnit = value; }
        }

        private int? _dayPerTimeUnit;

        public int? DayPerTimeUnit
        {
            get { return _dayPerTimeUnit; }
            set { _dayPerTimeUnit = value; }
        }

        private int? _minDay;

        public int? MinDay
        {
            get { return _minDay; }
            set { _minDay = value; }
        }

        private int? _maxDay;

        public int? MaxDay
        {
            get { return _maxDay; }
            set { _maxDay = value; }
        }

        private decimal? _rate;

        public decimal? Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        private decimal? _taxRate;

        public decimal? TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }

        private long? maxKm;

        public long? MaxKm
        {
            get { return maxKm; }
            set { maxKm = value; }
        }

        private decimal? additionalFee;

        public decimal? AdditionalFee
        {
            get { return additionalFee; }
            set { additionalFee = value; }
        }

        public string Type { get; set; }

        public override string Table { get { return "R_RG_RateGridDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_RG_RateGridDetail_InsertOrUpdate"; } }
    }

    public class View_RateGridDetail_CommonData
    {
        private string _providerName;

        public string ProviderName
        {
            get { return _providerName; }
            set { _providerName = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _countryCode;

        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }

        private string _header;

        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }

        private DateTime _validFrom;

        public DateTime ValidFrom
        {
            get { return _validFrom; }
            set { _validFrom = value; }
        }

        private DateTime _validTo;

        public DateTime ValidTo
        {
            get { return _validTo; }
            set { _validTo = value; }
        }

        public List<R_M_SippCode> ListSippCode;
        public List<R_M_CarGroup> ListCarGroup;
        public List<View_RateGridDetail_Header> ListHeader;
        public List<R_M_Surcharge> ListMasterSurcharge;

        public View_RateGridDetail_CommonData()
        {
            ListSippCode = new List<R_M_SippCode>();
            ListCarGroup = new List<R_M_CarGroup>();
            ListHeader = new List<View_RateGridDetail_Header>();
            ListMasterSurcharge = new List<R_M_Surcharge>();
        }

    }
    public class View_RateGridDetail_Header
    {
        private string _header;

        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }
        private string _unit;

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }
    }
    public class View_R_RG_RateGridDetail
    {
        public List<R_RG_RateGridDetail> ListRateGridDetail;

        public View_R_RG_RateGridDetail()
        {
            ListRateGridDetail = new List<R_RG_RateGridDetail>();
        }
    }
    public enum R_RG_RateGridDetailColumns
    {
        ID,
        R_RG_RateGridID,
        R_RG_RateCategoryID,
        R_M_SippCodeID,
        R_M_CarGroupID,
        Type,
        Name,
        Description,
        Group,
        CarGroup,
        Fleet,
        FleetType,
        SIPP,
        VehicleType,
        Unit,
        TimeUnit,
        DayPerTimeUnit,
        MinDay,
        MaxDay,
        Rate,
        TaxRate,
        MaxKm,
        AdditionalFee,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status
    }

    public enum R_RG_RateGridDetailProcedure
    {
        p_R_RG_RateGridDetail_GetBy_R_B_AccessID,
        p_R_RG_RateGridDetail_GetBy_RateGridId,
        p_R_RG_RateGrid_GetHeader_ByRateGridID,
        p_R_RG_RateGridDetail_GetByRateGridID,
        p_R_RG_RateGridDetail_GetBy_RateGridID_Type
    }

    public class R_RG_RateGridDetailList : List<R_RG_RateGridDetail>
    {
       
    }

    public enum R_RG_RateGridDetailType
    {
        [Display(Name = "Online Rate")]
        OnlineRate,
        [Display(Name = "Offline Rate")]
        OfflineRate
    }
}