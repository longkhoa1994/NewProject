using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._4.Airbnb
{
    public class A_DBI : BaseModel
    {
        long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        long _m_CompanyID;

        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        string dBIName;

        public string DBIName
        {
            get { return dBIName; }
            set { dBIName = value; }
        }

        int required;

        public int Required
        {
            get { return required; }
            set { required = value; }
        }

        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public override string Table { get { return "A_DBI"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_I_DBIData_InsertOrUpdate"; } }

        
    }
    public enum A_DBIProcedure
    {
        p_B_Access_GetBy
    }
}
