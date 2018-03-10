using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_CompanySetting : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _r_M_CompanyID;
        public long R_M_CompanyID
        {
            get { return _r_M_CompanyID; }
            set { _r_M_CompanyID = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _frequency;
        public string Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }
        private string _time;
        public string Time
        {
            get { return _time; }
            set { _time = value; }
        }
        private string _date;
        public string Date
        {
            get { return _date; }
            set { _date = value; }
        }
        private string _attribute;
        public string Attribute
        {
            get { return _attribute; }
            set { _attribute = value; }
        }
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _emailCC;
        public string EmailCC
        {
            get { return _emailCC; }
            set { _emailCC = value; }
        }
        public override string Table { get { return "R_M_CompanySetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_CompanySetting_InsertOrUpdate"; } }
    }
    public enum R_M_CompanySettingColumns
    {
        ID,
        R_M_CompanyID,
        Type,
        Frequency,
        Time,
        Date,
        Attribute,
        Value,
        Email,
        EmailCC,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_CompanySettingProcedure
    {
        p_R_M_CompanySetting_GetBy_CompanyID_Type,
        p_R_M_CompanySetting_GetParent
    }
    public class R_M_CompanySettingList : List<R_M_CompanySetting>
    {

    }

    public enum R_M_CompanySettingFrequency
    {
        Week,
        Month
    }

    public enum R_M_CompanySettingType
    {
        ClaimReport,
        InvoiceReport,
        CheckoutMail
    }
}