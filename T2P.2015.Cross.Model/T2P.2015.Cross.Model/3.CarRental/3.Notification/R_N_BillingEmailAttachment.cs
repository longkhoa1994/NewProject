using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_BillingEmailAttachment : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _r_N_BillingEmailID;

        public long R_N_BillingEmailID
        {
            get { return _r_N_BillingEmailID; }
            set { _r_N_BillingEmailID = value; }
        }

        private long _r_M_FileLocationID;

        public long R_M_FileLocationID
        {
            get { return _r_M_FileLocationID; }
            set { _r_M_FileLocationID = value; }
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

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public string Description { get; set; }

        public string RawFile { get; set; }
        public R_I_Import Import { get; set; }
        public override string Table { get { return "R_N_BillingEmailAttachment"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_BillingEmailAttachment_InsertOrUpdate"; } }
    }

    public enum R_N_BillingEmailAttachmentColumns
    {
        ID,
        R_N_BillingEmailID,
        M_FileLocationID,
        OriginalFilename,
        Filename,
        FilePath,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_N_BillingEmailAttachmentProcedure
    {
        p_R_N_BillingEmailAttachment_Get_ByEmail,
        p_R_N_BillingEmailAttachment_Get_List_ForBillingEmail,
        p_R_N_BillingEmailAttachment_Get_By_EmailID,
    }

    public class R_N_BillingEmailAttachmentList : List<R_N_BillingEmailAttachment>
    {
    }
}