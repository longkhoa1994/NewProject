using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_UserProfile : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private string _fullName;
        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        private bool? _gender;

        public bool? Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        private string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _department;
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "A_UserProfile"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_UserProfile_InsertOrUpdate"; } }
    }
    public enum A_UserProfileColumns
    {
        ID,
        UserName,
        FirstName,
        LastName,
        FullName,
        Gender,
        PhoneNumber,
        Email,
        Department,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public class P_UserProfile : A_UserProfile
    {
        private string _roleName;

        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        private string _fullName;

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }

        private string _partnerName;

        public string PartnerName
        {
            get { return _partnerName; }
            set { _partnerName = value; }
        }

        private long _totalRecords;

        public long TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }
    }


    public enum A_UserProfileProcedure
    {
        p_A_UserProfile_Get_ForLogin,
        p_A_UserProfile_GetAllServiceCenter,
        p_A_UserProfile_GetList,
        p_A_UserProfile_GetForDetailByUserId,
        p_A_UserProfile_GetList_ByRoleID,
        p_A_UserProfile_GetList_ByRoleID_ForPagination,
        p_A_UserProfile_GetAllServiceCenter_Preprocessing,
        p_A_UserProfile_Get_ForLogin_ByID,
        p_A_UserProfile_GetList_UserOnline,
        p_A_UserProfile_GetList_LoginHistory,
        p_A_UserProfile_GetList_ByHotelPlatformID,
        p_A_UserProfile_GetListHistory_ByUserID,
        p_A_UserProfile_CheckUserName,
        p_A_UserProfile_GetList_UserLimit,
        p_A_UserProfile_GetAllCaller,
        p_A_UserProfile_GetList_AllUserOnline,
        p_A_UserProfile_Search,
        p_A_UserProfile_GetForUpdatePermision,
        p_A_UserProfile_GetForDeletePermision,
        p_A_UserProfile_GetForUpdatePermission_APAccount,
        p_A_UserProfile_GetForSuggestion
    }

    public class A_UserProfileList : List<A_UserProfile>
    {
    }
}