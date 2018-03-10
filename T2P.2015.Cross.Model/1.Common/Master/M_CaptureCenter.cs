using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CaptureCenter : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long m_HotelPlatformID;

        public long M_HotelPlatformID
        {
            get { return m_HotelPlatformID; }
            set { m_HotelPlatformID = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private string _linkServer;
        public string LinkServer
        {
            get { return _linkServer; }
            set { _linkServer = value; }
        }
        private string _port;
        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }
        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _forwardBookingFolder;
        public string ForwardBookingFolder
        {
            get { return _forwardBookingFolder; }
            set { _forwardBookingFolder = value; }
        }
        private string _forwardInvoiceFolder;
        public string ForwardInvoiceFolder
        {
            get { return _forwardInvoiceFolder; }
            set { _forwardInvoiceFolder = value; }
        }
        private string _importInvoiceFolder;
        public string ImportInvoiceFolder
        {
            get { return _importInvoiceFolder; }
            set { _importInvoiceFolder = value; }
        }
        private string _importInvoiceErrorFolder;
        public string ImportInvoiceErrorFolder
        {
            get { return _importInvoiceErrorFolder; }
            set { _importInvoiceErrorFolder = value; }
        }
        public override string Table { get { return "M_CaptureCenter"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CaptureCenter_InsertOrUpdate"; } }
    }
    public enum M_CaptureCenterColumns
    {
        ID,
        M_HotelPlatformID,
        Name,
        Type,
        LinkServer,
        Port,
        UserName,
        Password,
        ForwardBookingFolder,
        ForwardInvoiceFolder,
        ImportInvoiceFolder,
        ImportInvoiceErrorFolder,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CaptureCenterProcedure
    {
        p_M_CaptureCenter_GetByM_CompanyID,
        p_M_CaptureCenter_GetByHotelPlatformName,
    }
    public class M_CaptureCenterList : List<M_CaptureCenter>
    {

    }
}