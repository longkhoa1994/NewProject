using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyDBI : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_CompanyProcessID;
        public long? M_CompanyProcessID
        {
            get { return _m_CompanyProcessID; }
            set { _m_CompanyProcessID = value; }
        }
        private string _companyCode;
        public string CompanyCode
        {
            get { return _companyCode; }
            set { _companyCode = value; }
        }
        private string _employeeNo_PK;
        public string EmployeeNo_PK
        {
            get { return _employeeNo_PK; }
            set { _employeeNo_PK = value; }
        }
        private string _costCenter_KS;
        public string CostCenter_KS
        {
            get { return _costCenter_KS; }
            set { _costCenter_KS = value; }
        }
        private string _departmentNo_DS;
        public string DepartmentNo_DS
        {
            get { return _departmentNo_DS; }
            set { _departmentNo_DS = value; }
        }
        private string _accountingUnit_AE;
        public string AccountingUnit_AE
        {
            get { return _accountingUnit_AE; }
            set { _accountingUnit_AE = value; }
        }
        private string _internalAccount_IK;
        public string InternalAccount_IK
        {
            get { return _internalAccount_IK; }
            set { _internalAccount_IK = value; }
        }
        private DateTime? _processingDate_BD;
        public DateTime? ProcessingDate_BD
        {
            get { return _processingDate_BD; }
            set { _processingDate_BD = value; }
        }

        private string _customerName_BD;

        public string CustomerName_BD
        {
            get { return _customerName_BD; }
            set { _customerName_BD = value; }
        }


        private string _projectNo_PR;
        public string ProjectNo_PR
        {
            get { return _projectNo_PR; }
            set { _projectNo_PR = value; }
        }
        private string _orderNo_AU;
        public string OrderNo_AU
        {
            get { return _orderNo_AU; }
            set { _orderNo_AU = value; }
        }
        private string _actionNo_AK;
        public string ActionNo_AK
        {
            get { return _actionNo_AK; }
            set { _actionNo_AK = value; }
        }
        private string _finalDestination_RZ;
        public string FinalDestination_RZ
        {
            get { return _finalDestination_RZ; }
            set { _finalDestination_RZ = value; }
        }
        private string _serviceCodes;
        public string ServiceCodes
        {
            get { return _serviceCodes; }
            set { _serviceCodes = value; }
        }
        private string _dBI;
        public string DBI
        {
            get { return _dBI; }
            set { _dBI = value; }
        }

        private string _imageLayover;

        public string ImageLayover
        {
            get { return _imageLayover; }
            set { _imageLayover = value; }
        }


        private string _cANumber;
        public string CANumber
        {
            get { return _cANumber; }
            set { _cANumber = value; }
        }
        private string _expireDate;
        public string ExpireDate
        {
            get { return _expireDate; }
            set { _expireDate = value; }
        }

        private int _percent;

        public int Percent
        {
            get { return _percent; }
            set { _percent = value; }
        }

        private float? _tAF;
        public float? TAF
        {
            get { return _tAF; }
            set { _tAF = value; }
        }

        private string _currencyCode;
        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        private string _tAFType;
        public string TAFType
        {
            get { return _tAFType; }
            set { _tAFType = value; }
        }

        private long? m_CompanyID;
        public long? M_CompanyID
        {
            get { return m_CompanyID; }
            set { m_CompanyID = value; }
        }

        private int _maxTransaction;

        public int MaxTransaction
        {
            get { return _maxTransaction; }
            set { _maxTransaction = value; }
        }
        private long? _m_CurrencyID;

        public long? M_CurrencyID
        {
            get { return _m_CurrencyID; }
            set { _m_CurrencyID = value; }
        }

        private int? _costAcceptanceDate;
        public int? CostAcceptanceDate
        {
            get { return _costAcceptanceDate; }
            set { _costAcceptanceDate = value; }
        }

        public string BillingAccountID { get; set; }

        public bool? GenerateVCC { get; set; }

        public string PaymentInterface { get; set; }

        

        public override string Table { get { return "M_CompanyDBI"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyDBI_InsertOrUpdate"; } }
    }
    public enum M_CompanyDBIColumns
    {
        ID,
        M_CompanyProcessID,
        CompanyCode,
        EmployeeNo_PK,
        CostCenter_KS,
        DepartmentNo_DS,
        AccountingUnit_AE,
        InternalAccount_IK,
        ProcessingDate_BD,
        ProjectNo_PR,
        OrderNo_AU,
        ActionNo_AK,
        FinalDestination_RZ,
        ServiceCodes,
        DBI,
        CANumber,
        ExpireDate,
        CostAcceptanceDate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyDBIProcedure
    {
        p_M_CompanyDBIProcedure_GetBy_M_CompanyID,
        p_M_CompanyDBI_GetByM_CompanyID,
        p_M_CompanyDBI_GetByM_CompanyIDAndM_HotelPlatformID,
        p_M_CompanyDBI_Get_By_UserID,
        p_M_CompanyDBI_GetByB_AccessID
    }
    public class M_CompanyDBIList : List<M_CompanyDBI>
    {

    }
    public class M_CompanyDBISetting : M_CompanyDBI
    {
        public string ProcessName { get; set; }
        public string HotelPlatformName { get; set; }
        public long M_HotelPlatformID { get; set; }
        public long M_CompanyDBIID { get; set; }
        //public long M_CompanyID { get; set; }
        public bool IsPK { get; set; }
        public bool IsKS { get; set; }
        public bool IsDS { get; set; }
        public bool IsAE { get; set; }
        public bool IsAK { get; set; }
        public bool IsBD { get; set; }
        public bool IsPR { get; set; }
        public bool IsAU { get; set; }
        public bool IsRZ { get; set; }
        public bool IsIK { get; set; }
        public bool IsTravelerName { get; set; }
        public bool IsCA { get; set; }
        public bool IsExp { get; set; }
        public bool IsPK_Image { get; set; }
        public bool IsKS_Image { get; set; }
        public bool IsDS_Image { get; set; }
        public bool IsAE_Image { get; set; }
        public bool IsAK_Image { get; set; }
        public bool IsBD_Image { get; set; }
        public bool IsPR_Image { get; set; }
        public bool IsAU_Image { get; set; }
        public bool IsRZ_Image { get; set; }
        public bool IsIK_Image { get; set; }
        public bool IsCA_Image { get; set; }
        public bool IsExp_Image { get; set; }
    }
}