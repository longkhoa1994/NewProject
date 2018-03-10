using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._3.CarRental._3.Notification
{
    [Serializable]
    public class R_N_Approval : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        public long R_I_DataID { get; set; }

        private string _tokenString;
        public string TokenString
        {
            get { return _tokenString; }
            set { _tokenString = value; }
        }

        private string _from;
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        private string _to;
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }

        private DateTime _sendDate;
        public DateTime SendDate
        {
            get { return _sendDate; }
            set { _sendDate = value; }
        }
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        private string _body;
        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        private int? _isSuccess;
        public int? IsSuccess
        {
            get { return _isSuccess; }
            set { _isSuccess = value; }
        }
        private bool? _isLocked;
        public bool? IsLocked
        {
            get { return _isLocked; }
            set { _isLocked = value; }
        }

        public override string Table { get { return "R_N_Approval"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_Approval_InsertOrUpdate"; } }
    }
    public enum N_ApprovalColumns
    {
        ID,
        R_I_DataID,
        TokenString,
        From,
        To,
        SendDate,
        Subject,
        Body,
        IsSuccess,
        IsLocked,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status
    }
    public enum R_N_ApprovalProcedure
    {
        p_R_N_Approval_GetByToken,
        p_R_N_Approval_GetByRIDataID
    }
    public class R_N_ApprovalList : List<N_Approval>
    {

    }
}
