using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_DTR_401 : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _F_E_DTR_201ID;
        public long? F_E_DTR_201ID
        {
            get { return _F_E_DTR_201ID; }
            set { _F_E_DTR_201ID = value; }
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
        private string _providerId3;
        public string ProviderId3
        {
            get { return _providerId3; }
            set { _providerId3 = value; }
        }
        private string _providerId2;
        public string ProviderId2
        {
            get { return _providerId2; }
            set { _providerId2 = value; }
        }
        private string _providerId1;
        public string ProviderId1
        {
            get { return _providerId1; }
            set { _providerId1 = value; }
        }
        private string _clientProductCode;
        public string ClientProductCode
        {
            get { return _clientProductCode; }
            set { _clientProductCode = value; }
        }
        private string _tbr;
        public string Tbr
        {
            get { return _tbr; }
            set { _tbr = value; }
        }
        private string _recLvlInd;
        public string RecLvlInd
        {
            get { return _recLvlInd; }
            set { _recLvlInd = value; }
        }
        private string _unitName;
        public string UnitName
        {
            get { return _unitName; }
            set { _unitName = value; }
        }
        private string _attentionName;
        public string AttentionName
        {
            get { return _attentionName; }
            set { _attentionName = value; }
        }
        private string _addressLine1;
        public string AddressLine1
        {
            get { return _addressLine1; }
            set { _addressLine1 = value; }
        }
        private string _addressLine2;
        public string AddressLine2
        {
            get { return _addressLine2; }
            set { _addressLine2 = value; }
        }
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        private string _stateCountry;
        public string StateCountry
        {
            get { return _stateCountry; }
            set { _stateCountry = value; }
        }
        private string _zip;
        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }
        private decimal? _totNumDb320;
        public decimal? TotNumDb320
        {
            get { return _totNumDb320; }
            set { _totNumDb320 = value; }
        }
        private decimal? _totDbAmt320;
        public decimal? TotDbAmt320
        {
            get { return _totDbAmt320; }
            set { _totDbAmt320 = value; }
        }
        private decimal? _totNumCr320;
        public decimal? TotNumCr320
        {
            get { return _totNumCr320; }
            set { _totNumCr320 = value; }
        }
        private decimal? _totCrAmt320;
        public decimal? TotCrAmt320
        {
            get { return _totCrAmt320; }
            set { _totCrAmt320 = value; }
        }
        private decimal? _budgetLimit;
        public decimal? BudgetLimit
        {
            get { return _budgetLimit; }
            set { _budgetLimit = value; }
        }
        private string _cycleDateInd;
        public string CycleDateInd
        {
            get { return _cycleDateInd; }
            set { _cycleDateInd = value; }
        }
        private decimal? _totNumDb402;
        public decimal? TotNumDb402
        {
            get { return _totNumDb402; }
            set { _totNumDb402 = value; }
        }
        private decimal? _totDbAmt402;
        public decimal? TotDbAmt402
        {
            get { return _totDbAmt402; }
            set { _totDbAmt402 = value; }
        }
        private decimal? _totNumCr402;
        public decimal? TotNumCr402
        {
            get { return _totNumCr402; }
            set { _totNumCr402 = value; }
        }
        private decimal? _totCrAmt402;
        public decimal? TotCrAmt402
        {
            get { return _totCrAmt402; }
            set { _totCrAmt402 = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }
        public override string Table { get { return "F_E_DTR_401"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_DTR_401_InsertOrUpdate"; } }
    }
    public enum F_E_DTR_401Columns
    {
        ID,
        F_E_DTR_201ID,
        RecordType,
        BusinessIca,
        ProviderId3,
        ProviderId2,
        ProviderId1,
        ClientProductCode,
        Tbr,
        RecLvlInd,
        UnitName,
        AttentionName,
        AddressLine1,
        AddressLine2,
        City,
        StateCountry,
        Zip,
        TotNumDb320,
        TotDbAmt320,
        TotNumCr320,
        TotCrAmt320,
        BudgetLimit,
        CycleDateInd,
        TotNumDb402,
        TotDbAmt402,
        TotNumCr402,
        TotCrAmt402,
        Filler,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum F_E_DTR_401Procedure
    {
        p_F_E_DTR_401_GetBy_F_E_DTR_201ID
    }
    public class F_E_DTR_401List : List<F_E_DTR_401>
    {

    }
}