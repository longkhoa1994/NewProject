using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_SippCode : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _sippCode;

        public string SippCode
        {
            get { return _sippCode; }
            set { _sippCode = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private string _transmission;

        public string Transmission
        {
            get { return _transmission; }
            set { _transmission = value; }
        }

        private string _fuel;

        public string Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }

        private string _airConditioning;

        public string AirConditioning
        {
            get { return _airConditioning; }
            set { _airConditioning = value; }
        }

        public override string Table { get { return "R_M_SippCode"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_SippCode_InsertOrUpdate"; } }
    }

    public enum R_M_SippCodeColumns
    {
        ID,
        SippCode,
        Description,
        Category,
        Type,
        Transmission,
        Fuel,
        AirConditioning,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_M_SippCodeProcedure
    {
        p_R_M_SippCode_Get_Id_By_Code,
        p_R_M_SippCode_Get_By_R_RG_RateGridID,
        p_R_M_SippCode_Get_By_ProviderAndCountry

    }

    public class R_M_SippCodeList : List<R_M_SippCode>
    {
    }
}