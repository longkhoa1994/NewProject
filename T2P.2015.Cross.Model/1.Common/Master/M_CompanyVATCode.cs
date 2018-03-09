using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyVATCode : BaseModel
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
        private long? _m_CountryID;
        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }
        private string _vATCode;
        public string VATCode
        {
            get { return _vATCode; }
            set { _vATCode = value; }
        }

        private bool _isUseInLetter;

        public bool IsUseInLetter
        {
            get { return _isUseInLetter; }
            set { _isUseInLetter = value; }
        }

        private bool? _isDefault;
        public bool? IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }

        public override string Table { get { return "M_CompanyVATCode"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyVATCode_InsertOrUpdate"; } }
    }
    public enum M_CompanyVATCodeColumns
    {
        ID,
        M_CompanyID,
        M_CountryID,
        VATCode,
        IsUseInLetter,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyVATCodeProcedure
    {
        p_M_CompanyVATCode_GetByB_AccessID,
        p_M_CompanyVATCode_GetBy_CompanyIDAndCountryID,
        P_P_CompanyVATCode_GetByCompany
    }
    public class M_CompanyVATCodeList : List<M_CompanyVATCode>
    {

    }
}
