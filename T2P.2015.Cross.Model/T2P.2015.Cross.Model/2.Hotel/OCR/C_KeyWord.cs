using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_KeyWord : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private string _expressionForm;
        public string ExpressionForm
        {
            get { return _expressionForm; }
            set { _expressionForm = value; }
        }
        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        private string _direction;
        public string Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
        public override string Table { get { return "C_KeyWord"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_KeyWord_InsertOrUpdate"; } }
    }
    public enum C_KeyWordColumns
    {
        ID,
        Value,
        ExpressionForm,
        Category,
        Direction,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum C_KeyWordProcedure
    {

    }
    public class C_KeyWordList : List<C_KeyWord>
    {

    }
}