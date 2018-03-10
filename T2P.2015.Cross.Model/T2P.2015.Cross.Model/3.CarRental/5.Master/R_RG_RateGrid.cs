using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_RG_RateGrid : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_CarRentalProviderID;

        public long M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
        }

        private long? _m_CountryID;

        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }

        private long? _m_StateID;

        public long? M_StateID
        {
            get { return _m_StateID; }
            set { _m_StateID = value; }
        }
        private long? _m_CompanyID;

        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private long? _R_M_PlatformID;

        public long? R_M_PlatformID
        {
            get { return _R_M_PlatformID; }
            set { _R_M_PlatformID = value; }
        }
        private string _currency;

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        private DateTime? _validFrom;

        public DateTime? ValidFrom
        {
            get { return _validFrom; }
            set { _validFrom = value; }
        }

        private DateTime? _validTo;

        public DateTime? ValidTo
        {
            get { return _validTo; }
            set { _validTo = value; }
        }

        private float? vAT;

        public float? VAT
        {
            get { return vAT; }
            set { vAT = value; }
        }

        private bool? _useLocation;

        public bool? UseLocation
        {
            get { return _useLocation; }
            set { _useLocation = value; }
        }

        public override string Table { get { return "R_RG_RateGrid"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_RG_RateGrid_InsertOrUpdate"; } }
    }

    public class View_R_RG_RateGridList
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_CarRentalProviderID;

        public long M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
        }

        private string _carRentalProviderName;

        public string CarRentalProviderName
        {
            get { return _carRentalProviderName; }
            set { _carRentalProviderName = value; }
        }

        private long? _m_CountryID;

        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }

        private string _countryName;

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }

        private long? _m_CompanyID;

        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private long _R_M_PlatformID;

        public long R_M_PlatformID
        {
            get { return _R_M_PlatformID; }
            set { _R_M_PlatformID = value; }
        }
        private string _R_M_PlatformName;

        public string R_M_PlatformName
        {
            get { return _R_M_PlatformName; }
            set { _R_M_PlatformName = value; }
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

        private DateTime _updatedDate;

        public DateTime UpdatedDate
        {
            get { return _updatedDate; }
            set { _updatedDate = value; }
        }

        private string _updatedBy;

        public string UpdatedBy
        {
            get { return _updatedBy; }
            set { _updatedBy = value; }
        }

        private int _totalRecords;

        public int TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }
    }

    public class View_RateGrid_CommonData
    {
        public List<M_CarRentalProvider> ListProvider;
        public List<M_Country> ListCountry;
        public List<M_Company> ListCompany;
        public List<R_M_Platform> ListPlatform;

        public View_RateGrid_CommonData()
        {
            ListProvider = new List<M_CarRentalProvider>();
            ListCountry = new List<M_Country>();
            ListCompany = new List<M_Company>();
            ListPlatform = new List<R_M_Platform>();
        }
    }
    public enum R_RG_RateGridColumns
    {
        ID,
        M_CarRentalProviderID,
        M_CountryID,
        M_StateID,
        Currency,
        ValidFrom,
        ValidTo,
        VAT,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_RG_RateGridProcedure
    {
        p_R_RG_RateGrid_GetBy_R_B_AccessID,
        p_R_RG_RateGrid_Get_By_R_I_ImageID,
        p_R_RG_RateGrid_GetForInvoice,
        p_R_RG_RateGrid_GetBy_SearchForm,
        p_R_RG_RateGrid_GetByCondition,
        p_R_RG_RateGrid_GetByProvider_Country,
    }

    public class R_RG_RateGridList : List<R_RG_RateGrid>
    {
    }


    #region Rental Car Area

    public class RategridView
    {
        public RateGridViewModel ViewModel;

        public int numberOfColumns = 0;
        public int numberOfPerhourColumns = 0;
        public int numberOfPerdayColumns = 0;
        public int numberOfPackageColumns = 0;
        public int numberOfPerweekColumns = 0;
        public int numberOfPermonthColumns = 0;

        public List<string> PerHourColumnsList;
        public List<string> PerDayColumnsList;
        public List<string> PerWeekColumnsList;
        public List<string> PerMonthColumnsList;

        public List<string> Per2DayColumnsList;
        public List<string> Per3DayColumnsList;
        public List<string> Per4DayColumnsList;
        public List<string> Per5DayColumnsList;
        public List<string> Per6DayColumnsList;
        public List<string> Per7DayColumnsList;

        public RategridView()
        {
            ViewModel = new RateGridViewModel();
            PerDayColumnsList = new List<string>();
            PerWeekColumnsList = new List<string>();
            PerMonthColumnsList = new List<string>();

            Per2DayColumnsList = new List<string>();
            Per3DayColumnsList = new List<string>();
            Per4DayColumnsList = new List<string>();
            Per5DayColumnsList = new List<string>();
            Per6DayColumnsList = new List<string>();
            Per7DayColumnsList = new List<string>();
        }
    }
    public class RateGridViewModel
    {
        public R_RG_RateGrid RateGrid;
        public List<RategridDetailViewModel> RategridDetailsList;
        public List<SurchargeViewModel> SurchargesList;
        public List<Dynamic> LocationList;

        public RateGridViewModel()
        {
            RateGrid = new R_RG_RateGrid();
            RategridDetailsList = new List<RategridDetailViewModel>();
            SurchargesList = new List<SurchargeViewModel>();
            LocationList = new List<Dynamic>();
        }
    }
    public class RategridDetailViewModel
    {
        public int Index;
        public string CarGroup;
        public string Fleet;
        public string SIPPCode;
        public string SIPP;
        public string VehicleType;
        public string AdditionalKm;
        public bool hasAdditionalKm;

        public List<decimal?> PerHour;
        public List<decimal?> PerDay;
        public List<decimal?> PerWeek;
        public List<decimal?> PerMonth;


        public List<decimal?> Per2Day;
        public List<decimal?> Per3Day;
        public List<decimal?> Per4Day;
        public List<decimal?> Per5Day;
        public List<decimal?> Per6Day;
        public List<decimal?> Per7Day;

        public RategridDetailViewModel()
        {
            PerHour = new List<decimal?>();
            PerDay = new List<decimal?>();
            PerWeek = new List<decimal?>();
            PerMonth = new List<decimal?>();

            Per2Day = new List<decimal?>();
            Per3Day = new List<decimal?>();
            Per4Day = new List<decimal?>();
            Per5Day = new List<decimal?>();
            Per6Day = new List<decimal?>();
            Per7Day = new List<decimal?>();
        }
    }

    [Serializable]
    public class SurchargeViewModel
    {
        private int index;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }


        private string serviceCode;
        public string ServiceCode
        {
            get { return serviceCode; }
            set { serviceCode = value; }
        }

        private string surcharge;
        public string Surcharge
        {
            get { return surcharge; }
            set { surcharge = value; }
        }

        private string unit;
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        private decimal? min;
        public decimal? Min
        {
            get { return min; }
            set { min = value; }
        }

        private string minUnit;
        public string MinUnit
        {
            get { return minUnit; }
            set { minUnit = value; }
        }

        private decimal? max;
        public decimal? Max
        {
            get { return max; }
            set { max = value; }
        }

        private string maxUnit;
        public string MaxUnit
        {
            get { return maxUnit; }
            set { maxUnit = value; }
        }

        private decimal? price;
        public decimal? Price
        {
            get { return price; }
            set { price = value; }
        }

        private string priceText;
        public string PriceText
        {
            get { return priceText; }
            set { priceText = value; }
        }

        private string condition;
        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }

        private string comment;
        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }

        private string valid;
        public string Valid
        {
            get { return valid; }
            set { valid = value; }
        }

        private string formularType;
        public string FormularType
        {
            get { return formularType; }
            set { formularType = value; }
        }

        private string priceString;
        public string PriceString
        {
            get { return priceString; }
            set { priceString = value; }
        }

        private long surchargeID;
        public long SurchargeID
        {
            get { return surchargeID; }
            set { surchargeID = value; }
        }

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string currency;
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        private DateTime updatedDate;
        public DateTime UpdatedDate
        {
            get { return updatedDate; }
            set { updatedDate = value; }
        }
    }
    public enum SurchargeViewModelProcedure
    {
        p_R_SurchargeViewModel_GetBy_RateGridId
    }

    #endregion


    #region Master Area

    public class MRategridViewModel : R_RG_RateGrid
    {
        private string _providerName;
        public string ProviderName
        {
            get { return _providerName; }
            set { _providerName = value; }
        }

        private string _countryCode;
        public string CountryCode
        {
            get { return _countryCode; }
            set { _countryCode = value; }
        }
    }

    public class MRateGridDetailViewModel : R_RG_RateGridDetail
    {

    }

    public class MSurchargeViewModel : R_RG_Surcharge
    {

    }

    public class MRategridDetailViewModel
    {
        public MRategridViewModel RategridHeader;
        public List<MRateGridDetailViewModel> RategridDetails;
        public List<MSurchargeViewModel> Surcharges;

        public MRategridDetailViewModel()
        {
            RategridDetails = new List<MRateGridDetailViewModel>();
            Surcharges = new List<MSurchargeViewModel>();
        }
    }

    #endregion

}