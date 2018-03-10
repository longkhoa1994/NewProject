using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class N_Error : BaseModel
    {
        long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _i_DataID;

        public long? I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
        }

        private long? _m_HotelPlatformID;

        public long? M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }

        private long? _m_NotificationTemplateID;

        public long? M_NotificationTemplateID
        {
            get { return _m_NotificationTemplateID; }
            set { _m_NotificationTemplateID = value; }
        }

        private long? _m_HotelPlatformSettingID;

        public long? M_HotelPlatformSettingID
        {
            get { return _m_HotelPlatformSettingID; }
            set { _m_HotelPlatformSettingID = value; }
        }

        private string _from;
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }

        string _to;
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }

        DateTime _sendDate;
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

        string _bodyText;
        public string BodyText
        {
            get { return _bodyText; }
            set { _bodyText = value; }
        }

        string _body;
        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }


        string _faxID;
        public string FaxID
        {
            get { return _faxID; }
            set { _faxID = value; }
        }

        string _faxResult;
        public string FaxResult
        {
            get { return _faxResult; }
            set { _faxResult = value; }
        }

        private int? _retry;
        public int? Retry
        {
            get { return _retry; }
            set { _retry = value; }
        }

        int? emailResult;
        public int? EmailResult
        {
            get { return emailResult; }
            set { emailResult = value; }
        }

        private string _messageID;
        public string MessageID
        {
            get { return _messageID; }
            set { _messageID = value; }
        }

        string _mailTable;
        public string MailTable
        {
            get { return _mailTable; }
            set { _mailTable = value; }
        }

        private List<long> _b_AccessIDs;

        public List<long> B_AccessIDs
        {
            get { return _b_AccessIDs; }
            set { _b_AccessIDs = value; }
        }

        private int? _isSuccess;
        public int? IsSuccess
        {
            get { return _isSuccess; }
            set { _isSuccess = value; }
        }
        


    }
    
    public enum MailTable 
    {
        N_Collection,
        N_Rejection,
        N_Remind,
        N_SentBox
    }

    public enum N_ErrorProcedure
    {
        p_N_Error_GetByEmailError,
        p_N_Error_GetForCheckingFax,
        p_N_Error_GetB_AccessID,
        p_N_Error_GetByEmailError2,
        p_N_Error_GetBySentBoxError,
        p_N_Error_GetBySentBoxError2,
        p_N_Error_GetB_AccessIDInformation,
        p_N_Error_GetEmailError_InReplyToExists
    }
}
