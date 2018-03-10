using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_I_Service : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _r_I_DataID;

        public long? R_I_DataID
        {
            get { return _r_I_DataID; }
            set { _r_I_DataID = value; }
        }

        private long? _r_M_SurchargeID;

        public long? R_M_SurchargeID
        {
            get { return _r_M_SurchargeID; }
            set { _r_M_SurchargeID = value; }
        }

        private string _serviceName;
        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }

        private string _serviceCode;
        public string ServiceCode
        {
            get { return _serviceCode; }
            set { _serviceCode = value; }
        }

        private decimal? _quantity;

        public decimal? Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private decimal? _unitPrice;

        public decimal? UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        private string _unit;
        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }

        private decimal? _netAmount;

        public decimal? NetAmount
        {
            get { return _netAmount; }
            set { _netAmount = value; }
        }

        private decimal? _taxRate;

        public decimal? TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }

        private decimal? _taxAmount;

        public decimal? TaxAmount
        {
            get { return _taxAmount; }
            set { _taxAmount = value; }
        }

        private decimal? _grossAmount;

        public decimal? GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        private bool? _isError;

        public bool? IsError
        {
            get { return _isError; }
            set { _isError = value; }
        }

        private bool _isHighlight;

        public bool IsHighlight
        {
            get { return _isHighlight; }
            set { _isHighlight = value; }
        }


        private string _serviceKeyword;

        public string ServiceKeyword
        {
            get { return _serviceKeyword; }
            set { _serviceKeyword = value; }
        }

        private bool _isManual;

        public bool IsManual
        {
            get { return _isManual; }
            set { _isManual = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "R_I_Service"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_I_Service_InsertOrUpdate"; } }
    }

    public enum R_I_ServiceColumns
    {
        ID,
        R_I_DataID,
        ServiceName,
        Quantity,
        UnitPrice,
        NetAmount,
        TaxRate,
        TaxAmount,
        GrossAmount,
        IsError,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_I_ServiceProcedure
    {
        p_R_I_Service_GetBy_R_I_DataID,
        p_R_I_Service_Get_By_R_I_DataID,
        p_R_I_Service_Get_List_Error_For_Claim_Email,
        p_R_I_Service_GetByDataID_ForCorrection,
        p_R_I_Service_Get_By_R_I_DataID_ForCheckOutMail,
        p_R_I_Service_GetByListR_I_DataID,
        p_R_I_Service_GetByDataID_ForApproval
    }

    public class R_I_ServiceList : List<R_I_Service>
    {
    }

    public class R_I_Service_ForCheckOut : R_I_Service
    {
        string claim;

        public string Claim
        {
            get { return claim; }
            set { claim = value; }
        }

        string errorCode;

        public string ErrorCode
        {
            get { return errorCode; }
            set { errorCode = value; }
        }

        string errorText;

        public string ErrorText
        {
            get { return errorText; }
            set { errorText = value; }
        }
    }
}