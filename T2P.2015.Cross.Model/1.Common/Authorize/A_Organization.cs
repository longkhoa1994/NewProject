using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_Organization : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "A_Organization"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_Organization_InsertOrUpdate"; } }
    }
    public enum A_OrganizationColumns
    {
        ID,
        Name,
        Category,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum A_OrganizationProcedure
    {

    }
    public class A_OrganizationList : List<A_Organization>
    {

    }
}