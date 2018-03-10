using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_InformationAttachment : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _n_InformationID;
        public long N_InformationID
        {
            get { return _n_InformationID; }
            set { _n_InformationID = value; }
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
        public override string Table { get { return "N_InformationAttachment"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_InformationAttachment_InsertOrUpdate"; } }
    }
    public enum N_InformationAttachmentColumns
    {
        ID,
        N_InformationID,
        M_FileLocationID,
        FileName,
        FilePath,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum N_InformationAttachmentProcedure
    {
        p_N_InformationAttachment_GetListForDeleting,
    }
    public class N_InformationAttachmentList : List<N_InformationAttachment>
    {

    }
}