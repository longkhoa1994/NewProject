using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_BillingEmailAttachment : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _n_BillingEmailID;

        public long N_BillingEmailID
        {
            get { return _n_BillingEmailID; }
            set { _n_BillingEmailID = value; }
        }

        private long _m_FileLocationID;

        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }

        private string _originalFilename;

        public string OriginalFilename
        {
            get { return _originalFilename; }
            set { _originalFilename = value; }
        }

        private string _filename;

        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        private string _PDFFilename;

        public string PDFFilename
        {
            get { return _PDFFilename; }
            set { _PDFFilename = value; }
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public override string Table { get { return "N_BillingEmailAttachment"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_N_BillingEmailAttachment_InsertOrUpdate"; } }
    }

    public class N_BillingEmailAttachment_Extend : N_BillingEmailAttachment
    {
        public string IISPath { get; set; }
        public string LocalPath { get; set; }

        public N_BillingEmailAttachment_Extend()
        {
            IISPath = string.Empty;
            LocalPath = string.Empty;
        }
    }
    public class P_BillingEmailAttachment
    {
        N_BillingEmailAttachment n_BillingEmailAttachment;

        public N_BillingEmailAttachment N_BillingEmailAttachment
        {
            get { return n_BillingEmailAttachment; }
            set { n_BillingEmailAttachment = value; }
        }
        List<N_AttachmentPage> listN_AttachmentPage;

        public List<N_AttachmentPage> ListN_AttachmentPage
        {
            get { return listN_AttachmentPage; }
            set { listN_AttachmentPage = value; }
        }

        public P_BillingEmailAttachment()
        {
            N_BillingEmailAttachment = new N_BillingEmailAttachment();
            ListN_AttachmentPage = new List<N_AttachmentPage>();
        }

    }
    public enum N_BillingEmailAttachmentColumns
    {
        ID,
        N_BillingEmailID,
        M_FileLocationID,
        OriginalFilename,
        Filename,
        PDFFilename,
        FilePath,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum N_BillingEmailAttachmentProcedure
    {
        p_N_BillingEmailAttachment_Get_ByEmail,
        p_N_BillingEmailAttachment_GetByN_BillingEmailID,
        p_N_BillingEmailAttachment_GetByReplacedImageID_ForMatching,
        p_N_BillingEmailAttachment_GetListForDeleting,
        p_N_BillingEmailAttachment_GetListFileForDeleting,
    }

    public class N_BillingEmailAttachmentList : List<N_BillingEmailAttachment>
    {
    }
}