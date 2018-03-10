using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model._5.Meetago.Contract
{
    [Serializable]
    public class B_ContractFile : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _b_ContractID;
        public long? B_ContractID
        {
            get { return _b_ContractID; }
            set { _b_ContractID = value; }
        }
        private long _m_FileLocationID;
        public long M_FileLocationID
        {
            get { return _m_FileLocationID; }
            set { _m_FileLocationID = value; }
        }
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        private string _pDFFileName;
        public string PDFFileName
        {
            get { return _pDFFileName; }
            set { _pDFFileName = value; }
        }
        private string _uploadFileName;
        public string UploadFileName
        {
            get { return _uploadFileName; }
            set { _uploadFileName = value; }
        }
        private string _fileStatus;
        public string FileStatus
        {
            get { return _fileStatus; }
            set { _fileStatus = value; }
        }
        private string _checkingStatus;
        public string CheckingStatus
        {
            get { return _checkingStatus; }
            set { _checkingStatus = value; }
        }
        private bool? _isCoppied;
        public bool? IsCoppied
        {
            get { return _isCoppied; }
            set { _isCoppied = value; }
        }
        private bool? _isAdditionalContract;
        public bool? IsAdditionalContract
        {
            get { return _isAdditionalContract; }
            set { _isAdditionalContract = value; }
        }
        private DateTime _receivedDate;
        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }

        private bool? _isLocked;
        public bool? IsLocked
        {
            get { return _isLocked; }
            set { _isLocked = value; }
        }

        public override string Table { get { return "B_ContractFile"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_ContractFile_InsertOrUpdate"; } }
    }
    public enum B_ContractFileColumns
    {
        ID,
        B_ContractID,
        M_FileLocationID,
        FilePath,
        PDFFileName,
        FileStatus,
        CheckingStatus,
        IsCoppied,
        IsAdditionalContract,
        Status,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        ReceivedDate,
    }
    public enum B_ContractFileProcedure
    {
        p_B_ContractFile_CheckFileExists,
        p_B_ContractFile_CheckIfContractMatchBooking,
        p_B_ContractFile_GetHistoryUpload,
        p_B_ContractFile_GetHistoryUpload_Count,
        p_P_Contract_GetData_ForCapture,
        p_B_ContractFile_GetListLocked_ByUserID,
        p_B_ContractFile_SelectFileToDelete,
        p_B_ContractFile_Get_by_B_ContractID
    }

   
    public class B_ContractFileList : List<B_ContractFile>
    {

    }
}