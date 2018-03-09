using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyPayment : BaseModel
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
        private long _m_PaymentProviderID;
        public long M_PaymentProviderID
        {
            get { return _m_PaymentProviderID; }
            set { _m_PaymentProviderID = value; }
        }
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private string _companyIdentify;
        public string CompanyIdentify
        {
            get { return _companyIdentify; }
            set { _companyIdentify = value; }
        }
        public string PaymentName { get; set; }
        public bool IsGenerateVCC { get; set; }
        public string BillingAccount { get; set; }
        public string PaymentInterface { get; set; }
        public override string Table { get { return "M_CompanyPayment"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyPayment_InsertOrUpdate"; } }
    }
    public enum M_CompanyPaymentColumns
    {
        ID,
        M_CompanyID,
        M_PaymentProviderID,
        CompanyName,
        CompanyIdentify,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyPaymentProcedure
    {
        p_M_CompanyPayment_GetBy_CompanyIdentify_M_PaymentProviderID,
        p_M_CompanyPayment_Get_B_AccessID_ByReservationNo,
        p_M_CompanyPayment_Get_By_M_CompanyID
    }
    public class M_CompanyPaymentList : List<M_CompanyPayment>
    {

    }
}