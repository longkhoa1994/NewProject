using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_I_Report : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _r_M_CompanyID;
        public long? R_M_CompanyID
        {
            get { return _r_M_CompanyID; }
            set { _r_M_CompanyID = value; }
        }
        private long? _r_M_FileLocationID;
        public long? R_M_FileLocationID
        {
            get { return _r_M_FileLocationID; }
            set { _r_M_FileLocationID = value; }
        }
        private long? _m_CarRentalProviderID;
        public long? M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
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
        private long? _r_N_SentBoxAttachmentID;
        public long? R_N_SentBoxAttachmentID
        {
            get { return _r_N_SentBoxAttachmentID; }
            set { _r_N_SentBoxAttachmentID = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public override string Table { get { return "R_I_Report"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_I_Report_InsertOrUpdate"; } }
    }
    public enum R_I_ReportColumns
    {
        ID,
        R_M_CompanyID,
        R_M_FileLocationID,
        M_CarRentalProviderID,
        FilePath,
        FileName,
        R_N_SentBoxAttachmentID,
        Type,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_I_ReportProcedure
    {
        p_R_I_Report_Monthly_Last_GetBy_CompanyID
    }

    public enum R_I_ReportType
    {
        WEEKLY_CLAIM,
        MONTHLY_INVOICE
    }
    public class R_I_ReportList : List<R_I_Report>
    {

    }
}