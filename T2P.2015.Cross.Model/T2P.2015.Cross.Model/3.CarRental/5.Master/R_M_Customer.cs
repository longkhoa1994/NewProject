using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_Customer : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _providerID;
        public long ProviderID
        {
            get { return _providerID; }
            set { _providerID = value; }
        }
        private long _companyID;
        public long CompanyID
        {
            get { return _companyID; }
            set { _companyID = value; }
        }
        private string _customerNumber;
        public string CustomerNumber
        {
            get { return _customerNumber; }
            set { _customerNumber = value; }
        }
        public string LogoURL { get; set; }
        public string CustomerName { get; set; }

        public string CompanyAddress { get; set; }

        public string ZIPCode { get; set; }

        public string CityName { get; set; }

        public string CountryName { get; set; }

        public override string Table { get { return "R_M_Customer"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_Customer_InsertOrUpdate"; } }
    }
    public enum R_M_CustomerColumns
    {
        ID,
        ProviderID,
        CompanyID,
        CustomerNumber,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_CustomerProcedure
    {
        p_R_M_Customer_GetByImageID,
        p_R_M_Customer_GetInformation
    }
    public class R_M_CustomerList : List<R_M_Customer>
    {

    }
}