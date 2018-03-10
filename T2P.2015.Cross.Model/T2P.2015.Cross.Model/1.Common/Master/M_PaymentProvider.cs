using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_PaymentProvider : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _providerName;
        public string ProviderName
        {
            get { return _providerName; }
            set { _providerName = value; }
        }
        public override string Table { get { return "M_PaymentProvider"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_PaymentProvider_InsertOrUpdate"; } }
    }
    public enum M_PaymentProviderColumns
    {
        ID,
        ProviderName,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_PaymentProviderProcedure
    {
        p_M_PaymentProvider_GetByProviderName
    }
    public class M_PaymentProviderList : List<M_PaymentProvider>
    {

    }
}