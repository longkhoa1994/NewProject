using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_DBI : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _b_BookingDetailID;

        public long? B_BookingDetailID
        {
            get { return _b_BookingDetailID; }
            set { _b_BookingDetailID = value; }
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

        private DateTime? _costAcceptanceDate;

        public DateTime? CostAcceptanceDate
        {
            get { return _costAcceptanceDate; }
            set { _costAcceptanceDate = value; }
        }

        private string panNo;

        public string PANNo
        {
            get { return panNo; }
            set { panNo = value; }
        }

        private string tokenReferenceID;

        public string TokenReferenceID
        {
            get { return tokenReferenceID; }
            set { tokenReferenceID = value; }
        }
        public string TokenStringPCI { get; set; }

        private string _tokenStringPCIStatus;

        public string TokenStringPCIStatus
        {
            get { return _tokenStringPCIStatus; }
            set { _tokenStringPCIStatus = value; }
        }
        private bool _isUpdated;

        public bool IsUpdated
        {
            get { return _isUpdated; }
            set { _isUpdated = value; }
        }

        public long TravelerIndex { get; set; }
        public override string Table { get { return "B_DBI"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_DBI_InsertOrUpdate"; } }
    }

    public enum B_DBIColumns
    {
        ID,
        B_BookingDetailID,
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
        TokenStringPCI,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_DBIProcedure
    {
        p_B_DBI_Get_ByImageID,
        p_B_DBI_GetListSuggestion_ByCompanyID,
        p_B_DBI_Get_By_B_BookingDetailID,
        p_B_DBI_GetDBIsTraveler,
        p_B_DBI_Get_By_B_AccessID,
        p_B_DBI_GetForUpdateCostAcceptanceDBI,
        p_B_DBIExtension_GetByBAccessID,
        p_B_DBI_GetForEmptyTamaraFile
    }

    public class B_DBIList : List<B_DBI>
    {
    }

    public class P_DBI_OL_Traveler
    {
        public string DBI_PK { get; set; }
        public string DBI_DS { get; set; }
        public string DBI_KS { get; set; }
        public DateTime? DBI_BD { get; set; }
        public string DBI_AE { get; set; }
        public string DBI_PR { get; set; }
        public string DBI_AU { get; set; }
        public string DBI_RZ { get; set; }
        public string DBI_IK { get; set; }
        public int TravelerNo { get; set; }
    }
}