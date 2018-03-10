using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_UserHistory
    {
        private long _userID;

        public long UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        private string _controllerName;

        public string ControllerName
        {
            get { return _controllerName; }
            set { _controllerName = value; }
        }

        private string _actionName;

        public string ActionName
        {
            get { return _actionName; }
            set { _actionName = value; }
        }

        private string _ip;

        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private string _sessionID;

        public string SessionID
        {
            get { return _sessionID; }
            set { _sessionID = value; }
        }
    }
}
