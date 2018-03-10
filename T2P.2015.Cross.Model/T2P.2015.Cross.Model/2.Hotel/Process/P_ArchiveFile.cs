using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_ArchiveFile : I_ArchiveRequestDetail
    {
        private string zipPassword;

        public string ZipPassword
        {
            get { return zipPassword; }
            set { zipPassword = value; }
        }
        private string fileLocation;

        public string FileLocation
        {
            get { return fileLocation; }
            set { fileLocation = value; }
        }
        private string platFormName;

        public string PlatFormName
        {
            get { return platFormName; }
            set { platFormName = value; }
        }
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        private DateTime fromDate;

        public DateTime FromDate
        {
            get { return fromDate; }
            set { fromDate = value; }
        }
        private DateTime toDate;

        public DateTime ToDate
        {
            get { return toDate; }
            set { toDate = value; }
        }
        private string archivingFrequency;

        public string ArchivingFrequency
        {
            get { return archivingFrequency; }
            set { archivingFrequency = value; }
        }
        private long archivingPeriod;

        public long ArchivingPeriod
        {
            get { return archivingPeriod; }
            set { archivingPeriod = value; }
        }
        private long _m_CompanyID;

        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private string companyCode;

        public string CompanyCode
        {
            get { return companyCode; }
            set { companyCode = value; }
        }
        private long _m_FileLocationID;

        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }
        private DateTime _importDate;

        public DateTime ImportDate
        {
            get { return _importDate; }
            set { _importDate = value; }
        }
        private int? _fileSize;

        public int? FileSize
        {
            get { return _fileSize; }
            set { _fileSize = value; }
        }
    }
}
