using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_Membership : BaseModel
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
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private int _passwordFailuresSinceLastSuccess;
        public int PasswordFailuresSinceLastSuccess
        {
            get { return _passwordFailuresSinceLastSuccess; }
            set { _passwordFailuresSinceLastSuccess = value; }
        }
        private bool _isBlocked;
        public bool IsBlocked
        {
            get { return _isBlocked; }
            set { _isBlocked = value; }
        }
        private string _comfirmationToken;
        public string ComfirmationToken
        {
            get { return _comfirmationToken; }
            set { _comfirmationToken = value; }
        }
        private bool? _isConfirmed;
        public bool? IsConfirmed
        {
            get { return _isConfirmed; }
            set { _isConfirmed = value; }
        }
        private DateTime? _lastPasswordFailureDate;
        public DateTime? LastPasswordFailureDate
        {
            get { return _lastPasswordFailureDate; }
            set { _lastPasswordFailureDate = value; }
        }
        private DateTime? _passwordChangedDate;
        public DateTime? PasswordChangedDate
        {
            get { return _passwordChangedDate; }
            set { _passwordChangedDate = value; }
        }
        private long? _m_HotelPlatformID;
        public long? M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }
        private long? _r_m_PlatformID;
        public long? R_M_PlatformID
        {
            get { return _r_m_PlatformID; }
            set { _r_m_PlatformID = value; }
        }
        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private long? _bookerID;
        public long? BookerID
        {
            get { return _bookerID; }
            set { _bookerID = value; }
        }
        private long? _m_TravellerID;
        public long? M_TravellerID
        {
            get { return _m_TravellerID; }
            set { _m_TravellerID = value; }
        }
        private long? _m_HotelID;
        public long? M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }
        private long? _m_ServiceCenterID;
        public long? M_ServiceCenterID
        {
            get { return _m_ServiceCenterID; }
            set { _m_ServiceCenterID = value; }
        }
        private DateTime? _lastestLogin;
        public DateTime? LastestLogin
        {
            get { return _lastestLogin; }
            set { _lastestLogin = value; }
        }
        private int? _isRecursive;
        public int? IsRecursive
        {
            get { return _isRecursive; }
            set { _isRecursive = value; }
        }
        private long? _a_OrganizationID;
        public long? A_OrganizationID
        {
            get { return _a_OrganizationID; }
            set { _a_OrganizationID = value; }
        }

        private bool? _isFirstLogin;

        public bool? IsFirstLogin
        {
            get { return _isFirstLogin; }
            set { _isFirstLogin = value; }
        }

        public override string Table { get { return "A_Membership"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_Membership_InsertOrUpdate"; } }
    }
    public enum A_MembershipColumns
    {
        ID,
        A_UserProfileID,
        Password,
        PasswordFailuresSinceLastSuccess,
        IsBlocked,
        ComfirmationToken,
        IsConfirmed,
        LastPasswordFailureDate,
        PasswordChangedDate,
        M_HotelPlatformID,
        R_M_PlatformID,
        M_CompanyID,
        BookerID,
        M_TravellerID,
        M_HotelID,
        M_ServiceCenterID,
        LastestLogin,
        IsRecursive,
        A_OrganizationID,
        IsFirstLogin,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum A_MembershipProcedure
    {
        p_A_Membership_Get_ByUserID,
        p_A_Membership_Update_Token,
        p_A_Membership_Get_ByUserProfileID,
        p_A_Membership_GetList_ByCompanyID,
        p_A_Membership_Get_ByA_UserProfileID,
        p_A_Membership_Get_By_UserName
    }
    public class A_MembershipList : List<A_Membership>
    {

    }
}