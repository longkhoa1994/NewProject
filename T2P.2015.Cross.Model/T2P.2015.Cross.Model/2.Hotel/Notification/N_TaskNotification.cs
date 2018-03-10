using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_TaskNotification : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _n_NotificationID;
        public long? N_NotificationID
        {
            get { return _n_NotificationID; }
            set { _n_NotificationID = value; }
        }
        private long? _n_TaskID;
        public long? N_TaskID
        {
            get { return _n_TaskID; }
            set { _n_TaskID = value; }
        }

        private string _mailTable;

        public string MailTable
        {
            get { return _mailTable; }
            set { _mailTable = value; }
        }
        public override string Table { get { return "N_TaskNotification"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_TaskNotificaion_InsertOrUpdate"; } }
    }
}
