using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_UserCompany : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _a_UserProfileID;
        public long A_UserProfileID
        {
            get { return _a_UserProfileID; }
            set { _a_UserProfileID = value; }
        }
        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        public override string Table { get { return "A_UserCompany"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_UserCompany_InsertOrUpdate"; } }
    }
    public enum A_UserCompanyColumns
    {
        ID,
        A_UserProfileID,
        M_CompanyID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum A_UserCompanyProcedure
    {
        p_A_UserCompany_GetListByUserProfileID,
        p_A_UserCompany_Classify,
        p_A_UserCompany_InsertList
    }
    public class A_UserCompanyList : List<A_UserCompany>
    {

    }
}