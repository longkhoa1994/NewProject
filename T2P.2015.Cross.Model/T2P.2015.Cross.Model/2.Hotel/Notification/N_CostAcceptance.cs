using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_CostAcceptance : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _b_AccessID;
        public long B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        private long _m_FileLocationID;
        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }
        private long? _m_NotificationTemplateID;
        public long? M_NotificationTemplateID
        {
            get { return _m_NotificationTemplateID; }
            set { _m_NotificationTemplateID = value; }
        }
        private long _m_HotelPlatformSettingID;

        public long M_HotelPlatformSettingID
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
        private string _faxID;
        public string FaxID
        {
            get { return _faxID; }
            set { _faxID = value; }
        }

        private string _faxResult;

        public string FaxResult
        {
            get { return _faxResult; }
            set { _faxResult = value; }
        }

        private string _faxStatus;
        public string FaxStatus
        {
            get { return _faxStatus; }
            set { _faxStatus = value; }
        }
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        private int _retry;
        public int Retry
        {
            get { return _retry; }
            set { _retry = value; }
        }
        private string _body;

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        private string footer;

        public string Footer
        {
            get { return footer; }
            set { footer = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private decimal _rate;

        public decimal Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        public string PCIToken { get; set; }
        public bool GenerateVCC { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public long M_HotelPlatformID { get; set; }
        public override string Table { get { return "N_CostAcceptance"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_CostAcceptance_InsertOrUpdate"; } }
    }
    public enum N_CostAcceptanceColumns
    {
        ID,
        B_AccessID,
        M_FileLocationID,
        M_NotificationTemplateID,
        M_HotelPlatformSettingID,
        Type,
        From,
        To,
        SendDate,
        FaxID,
        FaxResult,
        FaxStatus,
        FilePath,
        FileName,
        Retry,
        Rate,
        PCIToken,
        GenerateVCC,
        ValidFrom,
        ValidTo,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum N_CostAcceptanceProcedure
    {
        p_N_CostAcceptance_GetForCheck,
        p_N_CostAcceptance_GetLastByBAccessID,
        p_N_CostAcceptance_Get_ForDelete,
        p_N_CostAcceptance_GetForSendIng,
        p_N_CostAcceptance_GetForSendIngPCI,
        p_N_CostAcceptance_GetByBookingID_ForDeactivate,
        p_N_CostAcceptanceMeetago_GetByBookingId,
        p_N_CostAcceptance_GetByBAccessID,
        p_N_CostAcceptance_DeleteCostAcceptance,
        p_N_CostAcceptance_GetCancellation,
        p_N_CostAcceptance_GetDataForCancellation,
        p_N_CostAcceptance_GetBy_B_AccessID_AllStatus,
        p_N_CostAcceptance_GetFor_MG_CreateCollectionInvoice,
        p_N_CostAcceptance_GetListSendToItelya
    }
    public class N_CostAcceptanceList : List<N_CostAcceptance>
    {

    }

    public class P_CostAcceptance : N_CostAcceptance
    {
        private string _faxUserName;

        public string FaxUserName
        {
            get { return _faxUserName; }
            set { _faxUserName = value; }
        }

        private string _faxPassword;

        public string FaxPassword
        {
            get { return _faxPassword; }
            set { _faxPassword = value; }
        }

        private string _faxNumber;

        public string FaxNumber
        {
            get { return _faxNumber; }
            set { _faxNumber = value; }
        }

        private string _iP;

        public string IP
        {
            get { return _iP; }
            set { _iP = value; }
        }

        private string _mailServer;

        public string MailServer
        {
            get { return _mailServer; }
            set { _mailServer = value; }
        }

        private string _mailUsername;

        public string MailUsername
        {
            get { return _mailUsername; }
            set { _mailUsername = value; }
        }

        private string _mailPassword;

        public string MailPassword
        {
            get { return _mailPassword; }
            set { _mailPassword = value; }
        }

        private long m_HotelID;

        public long M_HotelID
        {
            get { return m_HotelID; }
            set { m_HotelID = value; }
        }

        private string fax;

        public string Fax
        {
            get { return fax; }
            set { fax = value; }
        }

        public string TokenStringPCI { get; set; }

        public string HotelEmail { get; set; }

        public string PCI_AccountName { get; set; }
        public bool PCI_Allowed { get; set; }
        public string PCI_AccountStatus { get; set; }
        public DateTime? PCI_ExpriredRegistrationDate { get; set; }
        public string BookingStatus { get; set; }
        public bool FaxNotAvailable { get; set; }
        public DateTime? CheckinDate { get; set; }

        public HotelPCIValues GetPCIValues()
        {
            return new HotelPCIValues
            {
                AccountName = this.PCI_AccountName,
                IsAllowed = this.PCI_Allowed,
                AccountStatus = this.PCI_AccountStatus,
                ExpriredRegistrationDate = this.PCI_ExpriredRegistrationDate
            };
        }
    }
}