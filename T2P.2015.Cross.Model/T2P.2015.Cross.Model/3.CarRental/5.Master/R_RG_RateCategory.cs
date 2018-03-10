using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_RG_RateCategory : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _category;

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private string _code;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string Table { get { return "R_RG_RateCategory"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_RG_RateCategory_InsertOrUpdate"; } }
    }

    public enum R_RG_RateCategoryColumns
    {
        ID,
        Category,
        Code,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_RG_RateCategoryProcedure
    {
    }

    public class R_RG_RateCategoryList : List<R_RG_RateCategory>
    {
    }
}