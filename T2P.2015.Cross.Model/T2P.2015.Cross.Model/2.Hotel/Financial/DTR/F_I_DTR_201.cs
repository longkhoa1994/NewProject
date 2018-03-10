using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_DTR_201 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _f_I_DTR_101ID;
        public long? F_I_DTR_101ID
        {
            get { return _f_I_DTR_101ID; }
            set { _f_I_DTR_101ID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _businessIca;
        public string BusinessIca
        {
            get { return _businessIca; }
            set { _businessIca = value; }
        }
        private string _clientId;
        public string ClientId
        {
            get { return _clientId; }
            set { _clientId = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        private string _bankName;
        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }
        private string _descripName;
        public string DescripName
        {
            get { return _descripName; }
            set { _descripName = value; }
        }
        private string _attenName;
        public string AttenName
        {
            get { return _attenName; }
            set { _attenName = value; }
        }
        private string _addrLine1;
        public string AddrLine1
        {
            get { return _addrLine1; }
            set { _addrLine1 = value; }
        }
        private string _addrLine2;
        public string AddrLine2
        {
            get { return _addrLine2; }
            set { _addrLine2 = value; }
        }
        private string _bhCity;
        public string BhCity
        {
            get { return _bhCity; }
            set { _bhCity = value; }
        }
        private string _bhState;
        public string BhState
        {
            get { return _bhState; }
            set { _bhState = value; }
        }
        private string _bhZip;
        public string BhZip
        {
            get { return _bhZip; }
            set { _bhZip = value; }
        }
        private string _filler2;
        public string Filler2
        {
            get { return _filler2; }
            set { _filler2 = value; }
        }
        public override string Table { get { return "F_I_DTR_201"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_DTR_201_InsertOrUpdate"; } }
    }
    public enum F_I_DTR_201Columns
    {
        ID,
        F_I_DTR_101ID,
        RecordType,
        BusinessIca,
        ClientId,
        Filler,
        BankName,
        DescripName,
        AttenName,
        AddrLine1,
        AddrLine2,
        BhCity,
        BhState,
        BhZip,
        Filler2,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_I_DTR_201Procedure
    {
        p_F_I_DTR_201_GetBy_F_I_DTR_101ID
    }
    public class F_I_DTR_201List : List<F_I_DTR_201>
    {

    }
}