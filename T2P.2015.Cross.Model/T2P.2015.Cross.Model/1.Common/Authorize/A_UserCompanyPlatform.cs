using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_UserCompanyPlatform : BaseModel
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
        private long? _m_HotelPlatformID;
        public long? M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }

        private int _permission;

        public int Permission
        {
            get { return _permission; }
            set { _permission = value; }
        }
        public override string Table { get { return "A_UserCompanyPlatform"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_UserCompanyPlatform_InsertOrUpdate"; } }
    }
    public enum A_UserCompanyPlatformColumns
    {
        ID,
        A_UserProfileID,
        M_CompanyID,
        M_HotelPlatformID,
        Permission,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum A_UserCompanyPlatformProcedure
    {
        p_A_UserCompanyPlatform_GetListByUserProfileID,
        p_A_UserCompanyPlatform_CheckEdit_ByB_AccessID,
        p_A_UserCompanyPlatform_GetList_ByCompanyID_PlatformID,
        p_A_UserCompanyPlatform_GetList_ByListID,
    }
    public class A_UserCompanyPlatformList : List<A_UserCompanyPlatform>
    {

    }
}