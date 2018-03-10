using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyOffline : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private string companyCode;

        public string CompanyCode
        {
            get { return companyCode; }
            set { companyCode = value; }
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

        private string cANumber;

        public string CANumber
        {
            get { return cANumber; }
            set { cANumber = value; }
        }

        private string expireDate;

        public string ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }

        private int percent;

        public int Percent
        {
            get { return percent; }
            set { percent = value; }
        }

        public override string Table { get { return "M_CompanyOffline"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyOffline_InsertOrUpdate"; } }
    }
    public enum M_CompanyOfflineColumns
    {
        ID,
        M_CompanyID,
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
        Percent,
        CANumber,
        ExpireDate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyOfflineProcedure
    {
        p_M_CompanyOffline_GetBy_M_CompanyID
    }
    public class M_CompanyOfflineList : List<M_CompanyOffline>
    {

    }
}