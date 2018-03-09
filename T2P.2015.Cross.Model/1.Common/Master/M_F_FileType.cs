using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_F_FileType : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_PaymentProviderID;
        public long? M_PaymentProviderID
        {
            get { return _m_PaymentProviderID; }
            set { _m_PaymentProviderID = value; }
        }
        private string _fileType;
        public string FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
        }
        private string _importFolder;
        public string ImportFolder
        {
            get { return _importFolder; }
            set { _importFolder = value; }
        }
        private string _exportFolder;
        public string ExportFolder
        {
            get { return _exportFolder; }
            set { _exportFolder = value; }
        }
        private string _extention;
        public string Extention
        {
            get { return _extention; }
            set { _extention = value; }
        }

        private string _transactionPath;
        public string TransactionPath
        {
            get { return _transactionPath; }
            set { _transactionPath = value; }
        }

        public override string Table { get { return "M_F_FileType"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_F_FileType_InsertOrUpdate"; } }
    }
    public enum M_F_FileTypeColumns
    {
        ID,
        M_PaymentProviderID,
        FileType,
        ImportFolder,
        ExportFolder,
        Extention,
        TransactionPath,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_F_FileTypeProcedure
    {
        p_M_F_FileType_GetList_ByPaymentProviderName,
        p_M_F_FileType_GetListFileType_ToSetRelation,
        p_M_F_FileType_GetByTypeName
    }
    public class M_F_FileTypeList : List<M_F_FileType>
    {

    }
}