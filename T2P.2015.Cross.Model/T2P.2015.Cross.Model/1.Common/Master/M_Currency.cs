using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Currency : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _currencyCode;

        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }

        private string _iSO4217Code;

        
        public string ISO4217Code
        {
            get { return _iSO4217Code; }
            set { _iSO4217Code = value; }
        }

        private int _status;

        public int status
        {
            get { return _status; }
            set { _status = value; }
        }

        public override string Table { get { return "M_Currency"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_Currency_InsertOrUpdate"; } }
    }

    public enum M_CurrencyColumns
    {
        ID,
        CurrencyCode,
        ISO4217Code,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        status,
    }

    public enum M_CurrencyProcedure
    {
        p_M_Currency_GetByCurrencyCode,
        p_M_Currency_GetByCurrencyNumber,
        p_M_Currency_DistinctWithCompanyCurrencyBySetup,
        p_M_Currency_Get_Company_Currency_By_B_AccessID,
        p_M_Currency_Get_Country_Currency_By_B_AccessID,
        p_M_Currency_GetByCurrencyCode2
    }

    public class M_CurrencyList : List<M_Currency>
    {
    }
}