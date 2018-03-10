using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_AttachmentToImage : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _r_N_BillingEmailAttachmentID;

        public long? R_N_BillingEmailAttachmentID
        {
            get { return _r_N_BillingEmailAttachmentID; }
            set { _r_N_BillingEmailAttachmentID = value; }
        }

        private long? _r_I_ImageID;

        public long? R_I_ImageID
        {
            get { return _r_I_ImageID; }
            set { _r_I_ImageID = value; }
        }

        public override string Table { get { return "R_N_AttachmentToImage"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_AttachmentToImage_InsertOrUpdate"; } }
    }

    public enum R_N_AttachmentToImageColumns
    {
        ID,
        R_N_BillingEmailAttachmentID,
        R_I_ImageID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_N_AttachmentToImageProcedure
    {
        p_R_N_AttachmentToImage_Get_By_ImageID,
        p_R_N_AttachmentToImage_Get_By_EmailID,
    }

    public class R_N_AttachmentToImageList : List<R_N_AttachmentToImage>
    {
    }
}