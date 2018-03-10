using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_I_Import : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _m_FileLocationID;

        public long? M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }

        public long? M_CarRentalProviderID { get; set; }

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
        public string Frequency { get; set; }

        private int _totalInvoice;

        public int TotalInvoice
        {
            get { return _totalInvoice; }
            set { _totalInvoice = value; }
        }

        private int _totalSuccess;

        public int TotalSuccess
        {
            get { return _totalSuccess; }
            set { _totalSuccess = value; }
        }

        private int _totalError;

        public int TotalError
        {
            get { return _totalError; }
            set { _totalError = value; }
        }

        private long _r_N_BillingEmailAttachmentID;

        public long R_N_BillingEmailAttachmentID
        {
            get { return _r_N_BillingEmailAttachmentID; }
            set { _r_N_BillingEmailAttachmentID = value; }
        }

        public List<R_P_Invoice_Capture> ListInvoiceCapture { get; set; } 
        public R_I_Import()
        {
            ListInvoiceCapture = new List<R_P_Invoice_Capture>();
        }
        public override string Table { get { return "R_I_Import"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_I_Import_InsertOrUpdate"; } }
    }

    public enum R_I_ImportColumns
    {
        ID,
        M_FileLocationID,
        M_CarRentalProviderID,
        FilePath,
        FileName,
        Frequency,
        TotalInvoice,
        TotalSuccess,
        TotalError,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_I_ImportProcedure
    {
        p_R_I_Import_GetSearch,
        p_R_I_Import_Invoice_GetDetail,
    }

    public class R_I_ImportList : List<R_I_Import>
    {
    }

    public class R_I_ImportExtend : R_I_Import
    {
        public string  ImportBy { get; set; }
        public long TotalRecords { get; set; }
    }


}