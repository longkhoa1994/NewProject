using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_NameGenderDigi : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _f1;

        
        public string F1
        {
            get { return _f1; }
            set { _f1 = value; }
        }

        private string _f2;

        
        public string F2
        {
            get { return _f2; }
            set { _f2 = value; }
        }

        public override string Table { get { return "M_NameGenderDigi"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_NameGenderDigi_InsertOrUpdate"; } }
    }

    public enum M_NameGenderDigiColumns
    {
        ID,
        F1,
        F2,
    }

    public enum M_NameGenderDigiProcedure
    {
    }

    public class M_NameGenderDigiList : List<M_NameGenderDigi>
    {
    }
}