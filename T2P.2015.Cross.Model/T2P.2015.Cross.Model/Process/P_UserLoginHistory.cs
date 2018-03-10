using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_UserLoginHistory
    {
        private long _userID;

        public long UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
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

        private string _roleName;

        public string RoleName
        {
            get { return _roleName; }
            set { _roleName = value; }
        }

        private long _numberOfSession;

        public long NumberOfSession
        {
            get { return _numberOfSession; }
            set { _numberOfSession = value; }
        }

        private DateTime _lastLogin;

        public DateTime LastLogin
        {
            get { return _lastLogin; }
            set { _lastLogin = value; }
        }

        private long _totalRecords;

        public long TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }
    }
}
