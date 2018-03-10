using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_SentBoxAttachment : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _n_SentBoxID;

        public long N_SentBoxID
        {
            get { return _n_SentBoxID; }
            set { _n_SentBoxID = value; }
        }

        private string _filename;

        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        private string _originalFilename;

        public string OriginalFilename
        {
            get { return _originalFilename; }
            set { _originalFilename = value; }
        }

        

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private long _m_FileLocationID;

        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }

        public override string Table { get { return "N_SentBoxAttachment"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_N_SentBoxAttachment_InsertOrUpdate"; } }
    }

    public class N_SentBoxAttachment_Extend : N_SentBoxAttachment
    {
        public string IISPath { get; set; }
        public string LocalPath { get; set; }

        public N_SentBoxAttachment_Extend()
        {
            IISPath = string.Empty;
            LocalPath = string.Empty;
        }
    }

    public enum N_SentBoxAttachmentColumns
    {
        ID,
        N_SentBoxID,
        Filename,
        FilePath,
        FilenameViewOnly,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum N_SentBoxAttachmentProcedure
    {
        p_N_SentBoxAttachment_GetByN_SentBoxID,
        p_N_SentBoxAttachment_GetBySentBoxID,
        p_N_SentBoxAttachment_GetListForDeleting,
    }

    public class N_SentBoxAttachmentList : List<N_SentBoxAttachment>
    {
    }
}