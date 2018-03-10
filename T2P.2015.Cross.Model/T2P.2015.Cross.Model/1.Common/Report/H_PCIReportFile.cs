using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class H_PCIReportFile : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_FileLocationID;
        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }
        private string _type;
        public string Type
        {
            get { return _type; }
            set { _type = value; }
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
        private int? _totalRegisteredHotel;
        public int? TotalRegisteredHotel
        {
            get { return _totalRegisteredHotel; }
            set { _totalRegisteredHotel = value; }
        }
        private int? _totalActiveHotel;
        public int? TotalActiveHotel
        {
            get { return _totalActiveHotel; }
            set { _totalActiveHotel = value; }
        }
        private int? _totalRegistrationEmail;
        public int? TotalRegistrationEmail
        {
            get { return _totalRegistrationEmail; }
            set { _totalRegistrationEmail = value; }
        }
        private int? _recentRegisteredHotel;
        public int? RecentRegisteredHotel
        {
            get { return _recentRegisteredHotel; }
            set { _recentRegisteredHotel = value; }
        }
        private int? _recentActiveHotel;
        public int? RecentActiveHotel
        {
            get { return _recentActiveHotel; }
            set { _recentActiveHotel = value; }
        }
        private int? _recentRegistrationEmail;
        public int? RecentRegistrationEmail
        {
            get { return _recentRegistrationEmail; }
            set { _recentRegistrationEmail = value; }
        }

        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }

        public override string Table { get { return "H_PCIReportFile"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_H_PCIReportFile_InsertOrUpdate"; } }
    }
    public enum H_PCIReportFileColumns
    {
        ID,
        M_FileLocationID,
        Type,
        FilePath,
        FileName,
        TotalRegisteredHotel,
        TotalActiveHotel,
        TotalRegistrationEmail,
        RecentRegisteredHotel,
        RecentActiveHotel,
        RecentRegistrationEmail,
        FromDate,
        ToDate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum H_PCIReportFileProcedure
    {
        p_H_PCIReportFile_GetDataForReport,
        p_H_PCIReportFile_GetListRecentPCIRegisteredHotel,
        p_H_PCIReportFileView_GetListFile,
        p_H_PCIReportFile_GetListRecentPCIRegisteredHotelView
    }
    public class H_PCIReportFileList : List<H_PCIReportFile>
    {

    }

    public class P_PCIPendingHotelReport
    {
        public int RowNum { get; set; }
        public string HotelName { get; set; }
        public string HotelNumber { get; set; }
        public string PCIAccount { get; set; }
        public string PCIStatus { get; set; }
        public string Email { get; set; }
        public int NumberOfRegistrationEmailSent { get; set; }
        public string FirstSentDate { get; set; }
        public string LastSentDate { get; set; }
        public int NumberOfCostAcceptanceSent { get; set; }
        public string ItelyaFax { get; set; }
        public string LastFaxSent { get; set; }
        public string SuccessfulSentToHotel { get; set; }
    }

    public enum P_PCIPendingHotelReportColumns
    {
        RowNum,
        HotelName,
        HotelNumber,
        PCIAccount,
        PCIStatus,
        Email,
        NumberOfRegistrationEmailSent,
        FirstSentDate,
        LastSentDate,
        NumberOfCostAcceptanceSent,
        SuccessfulSentToHotel
    }

    public class H_PCIReportFileView : H_PCIReportFile
    {
        public int RowNum { get; set; }
        public string DownloadPath { get; set; }
        public int TotalRecords { get; set; }
    }

    public class P_PCIPendingHotelReportView : P_PCIPendingHotelReport
    {
        public int TotalRecords { get; set; }
    }
    public class PCIReportDetailView : H_PCIReportFile
    {
        public List<P_PCIPendingHotelReportView> ListHotel { get; set; }
    }
}