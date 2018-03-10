using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_NotificationTemplateAttachment : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_NotificationTemplateID;
        public long M_NotificationTemplateID
        {
            get { return _m_NotificationTemplateID; }
            set { _m_NotificationTemplateID = value; }
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
        public override string Table { get { return "M_NotificationTemplateAttachment"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_NotificationTemplateAttachment_InsertOrUpdate"; } }
    }
    public class M_NotificationTemplateAttachmentExtend : M_NotificationTemplateAttachment
    {
        private string _filenameIP;
        public string FilenameIP
        {
            get { return _filenameIP; }
            set { _filenameIP = value; }
        }
    }
    public enum M_NotificationTemplateAttachmentColumns
    {
        ID,
        M_NotificationTemplateID,
        M_FileLocationID,
        FileName,
        FilePath,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_NotificationTemplateAttachmentProcedure
    {
        p_M_NotificationTemplateAttachment_GetByM_NotificationTemplateID
    }
    public class M_NotificationTemplateAttachmentList : List<M_NotificationTemplateAttachment>
    {

    }
}