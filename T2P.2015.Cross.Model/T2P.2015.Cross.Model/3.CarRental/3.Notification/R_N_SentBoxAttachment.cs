using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_SentBoxAttachment : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _r_N_SentBoxID;

        public long R_N_SentBoxID
        {
            get { return _r_N_SentBoxID; }
            set { _r_N_SentBoxID = value; }
        }

        private long? _r_M_FileLocationID;

        public long? R_M_FileLocationID
        {
            get { return _r_M_FileLocationID; }
            set { _r_M_FileLocationID = value; }
        }

        

        private string _filename;

        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        private string _originalFilename;

        public string OriginalFilename
        {
            get { return _originalFilename; }
            set { _originalFilename = value; }
        }

        public override string Table { get { return "R_N_SentBoxAttachment"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_SentBoxAttachment_InsertOrUpdate"; } }
    }

    public enum R_N_SentBoxAttachmentColumns
    {
        ID,
        R_N_SentBoxID,
        M_FileLocationID,
        Filename,
        FilePath,
        OriginalFilename,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public class R_N_SentBoxAttachment_Extend : R_N_SentBoxAttachment
    {
        public string IISPath { get; set; }
        public string LocalPath { get; set; }

        public R_N_SentBoxAttachment_Extend()
        {
            IISPath = string.Empty;
            LocalPath = string.Empty;
        }
    }



    public enum R_N_SentBoxAttachmentProcedure
    {
        p_R_N_SentBoxAttachment_GetBySentBoxID
    }

    public class R_N_SentBoxAttachmentList : List<R_N_SentBoxAttachment>
    {
    }
}