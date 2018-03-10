using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_UserCompanyProviderPlatform : BaseModel
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
        private long _m_CompanyID;
        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private long _m_CarRentalProviderID;
        public long M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
        }

        private long _r_M_PlatformID;

        public long R_M_PlatformID
        {
            get { return _r_M_PlatformID; }
            set { _r_M_PlatformID = value; }
        }
        private int? _permission;
        public int? Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }
        public override string Table { get { return "A_UserCompanyProviderPlatform"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_UserCompanyProviderPlatform_InsertOrUpdate"; } }
    }
    
    public class UserCompanyProviderPlatformSet
    {
        public long A_UserProfileID { get; set; }
        public long M_CompanyID { get; set; }
        public long R_M_PlatformID { get; set; }
    }

    public enum A_UserCompanyProviderPlatformColumns
    {
        ID,
        A_UserProfileID,
        M_CompanyID,
        M_CarRentalProviderID,
        M_HotelPlatformID,
        Permission,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum A_UserCompanyProviderPlatformProcedure
    {
        p_A_UserCompanyProviderPlatform_Get_List_By_UserID,
        p_A_UserCompanyProviderPlatform_UpdatePermission,
        p_A_UserCompanyProviderPlatform_GetByUserProfileID
    }
    public class A_UserCompanyProviderPlatformList : List<A_UserCompanyProviderPlatform>
    {

    }
}