using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_Forward : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
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

        private string _zipFilename;

        public string ZipFilename
        {
            get { return _zipFilename; }
            set { _zipFilename = value; }
        }

        private DateTime _forwardedDatetime;

        public DateTime ForwardedDatetime
        {
            get { return _forwardedDatetime; }
            set { _forwardedDatetime = value; }
        }

        private int _quantity;

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public override string Table { get { return "I_Forward"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_I_Forward_InsertOrUpdate"; } }
    }

    public enum I_ForwardColumns
    {
        ID,
        M_FileLocationID,
        FilePath,
        ZipFilename,
        ForwardedDatetime,
        Quantity,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum I_ForwardProcedure
    {
        p_I_Forward_GetListForDeleting,
        p_I_Forward_GetListIDForDeleting,
    }

    public class I_ForwardList : List<I_Forward>
    {
    }
}