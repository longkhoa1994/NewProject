using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyTamaraSetting : BaseModel
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
        public long M_CurrencyID { get; set; }
        private string _merchantName;
        public string MerchantName
        {
            get { return _merchantName; }
            set { _merchantName = value; }
        }
        private float? _amount;
        public float? Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        private float? _taxRate;
        public float? TaxRate
        {
            get { return _taxRate; }
            set { _taxRate = value; }
        }
        public override string Table { get { return "M_CompanyTamaraSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyTamaraSetting_InsertOrUpdate"; } }
    }
    public enum M_CompanyTamaraSettingColumns
    {
        ID,
        M_CompanyID,
        MerchantName,
        Amount,
        TaxRate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyTamaraSettingProcedure
    {

    }
    public class M_CompanyTamaraSettingList : List<M_CompanyTamaraSetting>
    {

    }
}