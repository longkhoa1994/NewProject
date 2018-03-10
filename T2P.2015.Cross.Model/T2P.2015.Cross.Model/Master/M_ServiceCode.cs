using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ServiceCode : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private string _description;

        
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string Table { get { return "M_ServiceCode"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_ServiceCode_InsertOrUpdate"; } }
    }

    public enum M_ServiceCodeColumns
    {
        ID,
        Code,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_ServiceCodeProcedure
    {
        p_M_ServiceCode_GetList_ByLanguageID,
        p_M_ServiceCode_GetByCountryAndTaxRate,
        p_M_ServiceCode_GetWithTaxRate,
        p_M_ServiceCode_Get_ByDescriptionAndHotel,
        p_M_ServiceCode_Get_ByDescription,
        p_M_Service_GetForCapture,
        p_M_ServiceCode_GetListWithTaxRateForCaptureByCountry,
    }

    public class M_ServiceCodeTax : M_ServiceCode
    {
        private decimal? _taxRate;

        public decimal? TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }
    }

    public class M_ServiceCodeList : List<M_ServiceCode>
    {
    }
}