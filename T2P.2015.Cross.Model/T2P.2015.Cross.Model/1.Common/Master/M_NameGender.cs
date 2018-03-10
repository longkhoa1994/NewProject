using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_NameGender : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _gender;

        
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _firstName;

        
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        private string _sorting;

        
        public string Sorting
        {
            get { return _sorting; }
            set { _sorting = value; }
        }

        private string _country;

        
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public override string Table { get { return "M_NameGender"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_NameGender_InsertOrUpdate"; } }
    }

    public enum M_NameGenderColumns
    {
        ID,
        Gender,
        FirstName,
        Sorting,
        Country,
    }

    public enum M_NameGenderProcedure
    {
    }

    public class M_NameGenderList : List<M_NameGender>
    {
    }
}