using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_CompanyArchivedSetting
    {
        private long id;

        public long Id
        {
            get { return id; }
            set { id = value; }
        }
        private long _m_CompanyID;

        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
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
        private string companyNumber;

        public string CompanyNumber
        {
            get { return companyNumber; }
            set { companyNumber = value; }
        }
        private bool transactionFile;

        public bool TransactionFile
        {
            get { return transactionFile; }
            set { transactionFile = value; }
        }
        private bool invoiceImage;

        public bool InvoiceImage
        {
            get { return invoiceImage; }
            set { invoiceImage = value; }
        }
        private bool transactionPaper;

        public bool TransactionPaper
        {
            get { return transactionPaper; }
            set { transactionPaper = value; }
        }
        private long _m_PaymentProviderID;

        public long M_PaymentProviderID
        {
            get { return _m_PaymentProviderID; }
            set { _m_PaymentProviderID = value; }
        }
        private DateTime lastArchivedDate;

        public DateTime LastArchivedDate
        {
            get { return lastArchivedDate; }
            set { lastArchivedDate = value; }
        }
        private string uploadFrequency;

        public string UploadFrequency
        {
            get { return uploadFrequency; }
            set { uploadFrequency = value; }
        }
        private long _uploadPeriod;

        public long UploadPeriod
        {
            get { return _uploadPeriod; }
            set { _uploadPeriod = value; }
        }
        private string zipPassword;

        public string ZipPassword
        {
            get { return zipPassword; }
            set { zipPassword = value; }
        }
    }
}
