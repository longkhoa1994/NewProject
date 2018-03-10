using System;
using System.Collections.Generic;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_PageToImage : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _i_ImageID;

        public long I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }

        private long _n_AttachmentPageID;

        public long N_AttachmentPageID
        {
            get { return _n_AttachmentPageID; }
            set { _n_AttachmentPageID = value; }
        }

        private int _position;

        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public override string Table { get { return "I_PageToImage"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_I_PageToImage_InsertOrUpdate"; } }
    }

    public class P_PageToImage 
    {
        public List<I_PageToImage> ListInsert { get; set; }
        public List<I_PageToImage> ListDelete { get; set; }

        public P_PageToImage()
        {
            ListInsert = new List<I_PageToImage>();
            ListDelete = new List<I_PageToImage>();
        }
    }

    public enum I_PageToImageColumns
    {
        ID,
        I_ImageID,
        N_AttachmentPageID,
        Position,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum I_PageToImageProcedure
    {
        p_I_PageToImage_GetByI_ImageID,
        p_I_PageToImage_GetListByListImageID,
        p_I_PageToImage_GetListForDeleting,
        p_I_PageToImage_GetListForArchiving_Deleting,
    }

    public class I_PageToImageList : List<I_PageToImageList>
    {
    }
}
