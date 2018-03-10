using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._1.Common.Master
{
    [Serializable]
    public class M_CompanyCheckOutMail_NonContract : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private string _startingText;
        public string StartingText
        {
            get { return _startingText; }
            set { _startingText = value; }
        }
        private string _receiverSetting;
        public string ReceiverSetting
        {
            get { return _receiverSetting; }
            set { _receiverSetting = value; }
        }
        private string _emailReceiving;
        public string EmailReceiving
        {
            get { return _emailReceiving; }
            set { _emailReceiving = value; }
        }
        private string _emailCC;
        public string EmailCC
        {
            get { return _emailCC; }
            set { _emailCC = value; }
        }
        private bool? _sendAttachment;
        public bool? SendAttachment
        {
            get { return _sendAttachment; }
            set { _sendAttachment = value; }
        }
        private bool? _isDaimlerBooking;
        public bool? IsDaimlerBooking
        {
            get { return _isDaimlerBooking; }
            set { _isDaimlerBooking = value; }
        }
        private string _headerContentSetting;
        public string HeaderContentSetting
        {
            get { return _headerContentSetting; }
            set { _headerContentSetting = value; }
        }
        public override string Table { get { return "M_CompanyCheckOutMail_NonContract"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyCheckOutMail_NonContract_InsertOrUpdate"; } }
    }

    public class M_CompanyCheckOutMail_NonContract_Addition : M_CompanyCheckOutMail_NonContract
    {
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _subID;
        public string SubID
        {
            get { return _subID; }
            set { _subID = value; }
        }

        private bool _isSetting;
        public bool IsSetting
        {
            get { return _isSetting; }
            set { _isSetting = value; }
        }
    }
    public enum M_CompanyCheckOutMail_NonContractColumns
    {
        ID,
        M_CompanyID,
        StartingText,
        ReceiverSetting,
        EmailReceiving,
        EmailCC,
        SendAttachment,
        IsDaimlerBooking,
        HeaderContentSetting,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyCheckOutMail_NonContractProcedure
    {
        p_M_CompanyCheckOutMail_NonContract_GetBy_M_CompanyID,
        p_M_Company_GetList_CompanyCheckOutMail,
        p_M_Company_GetList_CompanyNonContractSetting,
        p_M_CompanyCheckOutMail_NonContract_GetContract_Setting
    }
    public class M_CompanyCheckOutMail_NonContractList : List<M_CompanyCheckOutMail_NonContract>
    {

    }
}
