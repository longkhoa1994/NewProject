using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanySameInfomation : BaseModel
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
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private string _companyAddress;
        public string CompanyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }
        private string _cityName;
        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }
        public override string Table { get { return "M_CompanySameInfomation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanySameInfomation_InsertOrUpdate"; } }
    }
    public enum M_CompanySameInfomationColumns
    {
        ID,
        M_CompanyID,
        CompanyName,
        CompanyAddress,
        CityName,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanySameInfomationProcedure
    {
        p_M_CompanySameInfomation_GetListByCompany,
    }
    public class M_CompanySameInfomationList : List<M_CompanySameInfomation>
    {

    }
}