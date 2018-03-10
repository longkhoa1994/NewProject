using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_ArchiveImage : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _i_ArchiveID;
        public long? I_ArchiveID
        {
            get { return _i_ArchiveID; }
            set { _i_ArchiveID = value; }
        }
        private long? _i_ImageID;
        public long? I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }
        public override string Table { get { return "I_ArchiveImage"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_ArchiveImage_InsertOrUpdate"; } }
    }
    public enum I_ArchiveImageColumns
    {
        ID,
        I_ArchiveID,
        I_ImageID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_ArchiveImageProcedure
    {

    }
    public class I_ArchiveImageList : List<I_ArchiveImage>
    {

    }
}