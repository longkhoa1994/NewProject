using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_I_GL1076_FH : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _f_ImportFileID;
        public long F_ImportFileID
        {
            get { return _f_ImportFileID; }
            set { _f_ImportFileID = value; }
        }
        private string _recordType;
        public string RecordType
        {
            get { return _recordType; }
            set { _recordType = value; }
        }
        private string _globalClientOriginIdentifier;
        public string GlobalClientOriginIdentifier
        {
            get { return _globalClientOriginIdentifier; }
            set { _globalClientOriginIdentifier = value; }
        }
        private string _globalClientName;
        public string GlobalClientName
        {
            get { return _globalClientName; }
            set { _globalClientName = value; }
        }
        private string _recipientNumber;
        public string RecipientNumber
        {
            get { return _recipientNumber; }
            set { _recipientNumber = value; }
        }
        private string _reportName;
        public string ReportName
        {
            get { return _reportName; }
            set { _reportName = value; }
        }
        private string _reportVersionNumber;
        public string ReportVersionNumber
        {
            get { return _reportVersionNumber; }
            set { _reportVersionNumber = value; }
        }
        private DateTime? _reportVersionDate;
        public DateTime? ReportVersionDate
        {
            get { return _reportVersionDate; }
            set { _reportVersionDate = value; }
        }
        private DateTime? _fileCreationDateTime;
        public DateTime? FileCreationDateTime
        {
            get { return _fileCreationDateTime; }
            set { _fileCreationDateTime = value; }
        }
        private DateTime? _processDate;
        public DateTime? ProcessDate
        {
            get { return _processDate; }
            set { _processDate = value; }
        }
        private string _fileVersionNumber;
        public string FileVersionNumber
        {
            get { return _fileVersionNumber; }
            set { _fileVersionNumber = value; }
        }
        private string _messageText;
        public string MessageText
        {
            get { return _messageText; }
            set { _messageText = value; }
        }
        private string _numberofGlobalClientOriginIdentifiers;
        public string NumberofGlobalClientOriginIdentifiers
        {
            get { return _numberofGlobalClientOriginIdentifiers; }
            set { _numberofGlobalClientOriginIdentifiers = value; }
        }
        private DateTime? _runDateTimeStamp;
        public DateTime? RunDateTimeStamp
        {
            get { return _runDateTimeStamp; }
            set { _runDateTimeStamp = value; }
        }
        private string _filler;
        public string Filler
        {
            get { return _filler; }
            set { _filler = value; }
        }

        public override string Table { get { return "F_I_GL1076_FH"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_I_GL1076_FH_InsertOrUpdate"; } }
    }
    public enum F_I_GL1076_FHColumns
    {
        ID,
        F_ImportFileID,
        RecordType,
        GlobalClientOriginIdentifier,
        GlobalClientName,
        RecipientNumber,
        ReportName,
        ReportVersionNumber,
        ReportVersionDate,
        FileCreationDateTime,
        ProcessDate,
        FileVersionNumber,
        MessageText,
        NumberofGlobalClientOriginIdentifiers,
        RunDateTimeStamp,
        Filler,
        CreatedDate,
        CreatedBy,
        UpdatedDate,
        Updatedby,
        Status,
    }
    public enum F_I_GL1076_FHProcedure
    {
        p_F_I_GL1076_FH_Get_By_F_ImportFileID
    }
    public class F_I_GL1076_FHList : List<F_I_GL1076_FH>
    {

    }
}