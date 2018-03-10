using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_SkipNotification : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _b_BookingID;
        public long? B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
        }
        private long? _f_TransactionID;
        public long? F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }
        private Guid? _groupID;
        public Guid? GroupID
        {
            get { return _groupID; }
            set { _groupID = value; }
        }
        public override string Table { get { return "N_SkipNotification"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_SkipNotification_InsertOrUpdate"; } }
    }
    public enum N_SkipNotificationColumns
    {
        ID,
        B_BookingID,
        F_TransactionID,
        GroupID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum N_SkipNotificationProcedure
    {
        p_N_SkipNotification_GetListForDeleting,
    }
    public class N_SkipNotificationList : List<N_SkipNotification>
    {

    }
}