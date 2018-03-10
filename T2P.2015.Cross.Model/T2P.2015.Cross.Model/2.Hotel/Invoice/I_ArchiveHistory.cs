using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_ArchiveHistory : BaseModel
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
        private string _downloadToken;
        public string DownloadToken
        {
            get { return _downloadToken; }
            set { _downloadToken = value; }
        }
        private string _action;
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
        public override string Table { get { return "I_ArchiveHistory"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_ArchiveHistory_InsertOrUpdate"; } }
    }
    public enum I_ArchiveHistoryColumns
    {
        ID,
        I_ArchiveID,
        DownloadToken,
        Action,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_ArchiveHistoryProcedure
    {

    }
    public class I_ArchiveHistoryList : List<I_ArchiveHistory>
    {

    }
}