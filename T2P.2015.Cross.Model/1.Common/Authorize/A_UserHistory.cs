using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_UserHistory : BaseModel
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
        private string _action;
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
        private DateTime _timeStamp;
        public DateTime TimeStamp
        {
            get { return _timeStamp; }
            set { _timeStamp = value; }
        }
        private string _sessionID;
        public string SessionID
        {
            get { return _sessionID; }
            set { _sessionID = value; }
        }
        private string _iP;
        public string IP
        {
            get { return _iP; }
            set { _iP = value; }
        }
        public override string Table { get { return "A_UserHistory"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_UserHistory_InsertOrUpdate"; } }
    }
    public enum A_UserHistoryColumns
    {
        ID,
        A_UserProfileID,
        Action,
        TimeStamp,
        SessionID,
        IP,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum A_UserHistoryProcedure
    {
        p_A_UserHistory_GetLastData_ByUserID
    }
    public class A_UserHistoryList : List<A_UserHistory>
    {

    }
}