using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_AttachmentPage : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _n_BillingAttachmentID;

        public long N_BillingEmailAttachmentID
        {
            get { return _n_BillingAttachmentID; }
            set { _n_BillingAttachmentID = value; }
        }

        private long _m_FileLocationID;

        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }

        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }


        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        private string _fileNamePDF;

        public string FileNamePDF
        {
            get { return _fileNamePDF; }
            set { _fileNamePDF = value; }
        }
        private float _rotate;
        public float Rotate
        {
            get { return _rotate; }
            set { _rotate = value; }
        }
        private int _page;
        public int Page
        {
            get { return _page; }
            set { _page = value; }
        }
        private string _cIGStatus;
        public string CIGStatus
        {
            get { return _cIGStatus; }
            set { _cIGStatus = value; }
        }

        private string _cIGBookingNo;
        public string CIGBookingNo
        {
            get { return _cIGBookingNo; }
            set { _cIGBookingNo = value; }
        }

        private long _cIGGroupID;
        public long CIGGroupID
        {
            get { return _cIGGroupID; }
            set { _cIGGroupID = value; }
        }

        public override string Table { get { return "N_AttachmentPage"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_N_AttachmentPage_InsertOrUpdate"; } }


    }

    public class N_AttachmentPage_ForMatching : N_AttachmentPage
    {
        private string _IISPath;
        public string IISPath
        {
            get { return _IISPath; }
            set { _IISPath = value; }
        }

        private string _localPath;
        public string LocalPath
        {
            get { return _localPath; }
            set { _localPath = value; }
        }

    }

    public enum N_AttachmentPageColumns
    {
        ID,
        N_BillingEmailAttachmentID,
        M_FileLocationID,
        Filename,
        FilePath,
        FileNamePDF,
        Rotate,
        Page,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum N_AttachmentPageProcedure
    {
        p_N_AttachmentPage_GetByI_ImageID,
        p_N_AttachmentPage_Get_ByImage,
        p_N_AttachmentPage_GetByBillingEmail,
        p_N_AttachmentPage_Get_ByI_ImageID,
        p_N_AttachmentPage_GetListForDeleting,
        p_N_AttachmentPage_GetListForArchiving_Deleting,
        p_N_AttachmentPage_GetListFileForDeleting,
    }

    public class N_AttachmentPageList : List<N_AttachmentPageList>
    {
    }


    public class N_AttachmentPage_CreatePDF
    {
        public long N_AttachmentPageID { get; set; }       
        public int Rotate { get; set; }
    }

    public class N_AttachmentPage_OCR : N_AttachmentPage
    {
        private string _IISPath;
        public string IISPath
        {
            get { return _IISPath; }
            set { _IISPath = value; }
        }

        private string _ip;
        public string IP
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private long _position;

        public long Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
