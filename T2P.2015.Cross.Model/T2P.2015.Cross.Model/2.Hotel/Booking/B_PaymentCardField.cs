using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_PaymentCardField : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _b_PaymentCardID;
        public long B_PaymentCardID
        {
            get { return _b_PaymentCardID; }
            set { _b_PaymentCardID = value; }
        }
        private string _code;
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public override string Table { get { return "B_PaymentCardField"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_PaymentCardField_InsertOrUpdate"; } }
    }
    public enum B_PaymentCardFieldColumns
    {
        ID,
        B_PaymentCardID,
        Code,
        Value,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum B_PaymentCardFieldProcedure
    {

    }
    public class B_PaymentCardFieldList : List<B_PaymentCardField>
    {

    }
}