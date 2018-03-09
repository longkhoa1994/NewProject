using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyAddition : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CompanyID;
        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private long _m_HotelPlatformID;
        public long M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private string _companyShortName;
        public string CompanyShortName
        {
            get { return _companyShortName; }
            set { _companyShortName = value; }
        }
        private string _customerNo;
        public string CustomerNo
        {
            get { return _customerNo; }
            set { _customerNo = value; }
        }
        private string _companyVATNumber;
        public string CompanyVATNumber
        {
            get { return _companyVATNumber; }
            set { _companyVATNumber = value; }
        }
        private string _subID;
        public string SubID
        {
            get { return _subID; }
            set { _subID = value; }
        }
        private string _companyTaxCode;
        public string CompanyTaxCode
        {
            get { return _companyTaxCode; }
            set { _companyTaxCode = value; }
        }
        private string _companyAddress;
        public string CompanyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }
        private string _companyEmail;
        public string CompanyEmail
        {
            get { return _companyEmail; }
            set { _companyEmail = value; }
        }
        private string _zIPCode;
        public string ZIPCode
        {
            get { return _zIPCode; }
            set { _zIPCode = value; }
        }
        private string _cityName;
        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }
        private long? _m_CountryID;
        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }
        private string _telephone;
        public string Telephone
        {
            get { return _telephone; }
            set { _telephone = value; }
        }
        private string _fax;
        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }
        private string _logo;
        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
        public override string Table { get { return "M_CompanyAddition"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyAddition_InsertOrUpdate"; } }
    }
    public enum M_CompanyAdditionColumns
    {
        ID,
        M_CompanyID,
        M_HotelPlatformID,
        CompanyName,
        CompanyShortName,
        CustomerNo,
        CompanyVATNumber,
        SubID,
        CompanyTaxCode,
        CompanyAddress,
        CompanyEmail,
        ZIPCode,
        CityName,
        M_CountryID,
        Telephone,
        Fax,
        Logo,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyAdditionProcedure
    {
        p_M_CompanyAddition_GetByCompany
    }
    public class M_CompanyAdditionList : List<M_CompanyAddition>
    {

    }
}