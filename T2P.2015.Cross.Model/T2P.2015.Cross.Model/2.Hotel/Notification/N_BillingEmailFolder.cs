using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_BillingEmailFolder : BaseModel
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

        [NotInsert]
        [NotUpdate]
        public long TotalEmail { get; set; }

        public override string Table { get { return "N_BillingEmailFolder"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_BillingEmailFolder_InsertOrUpdate"; } }
    }
    public enum N_BillingEmailFolderColumns
    {
        ID,
        Name,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum N_BillingEmailFolderProcedure
    {
        p_N_N_BillingEmailFolder_GetAll,

    }
    public class N_BillingEmailFolderList : List<N_BillingEmailFolder>
    {

    }
}