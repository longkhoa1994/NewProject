using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Contact : BaseModel
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

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private long _Createdby;

        public long CreatedBy
        {
            get { return _Createdby;}
            set { _Createdby = value; }
        }



        public override string Table { get { return "M_Contact"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_Contact_InsertOrUpdate"; } }
    }

    public enum M_ContactColumns
    {
        ID,
        Name,
        Email,       
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_ContactProcedure
    {
        
    }

    public class M_ContactList : List<M_Contact>
    {
    }
}