using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_BillingEmailAddition : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _n_BillingEmailID;
        public long N_BillingEmailID
        {
            get { return _n_BillingEmailID; }
            set { _n_BillingEmailID = value; }
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
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        public string FileNameBodyText { get; set; }
        public override string Table { get { return "N_BillingEmailAddition"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_BillingEmailAddition_InsertOrUpdate"; } }
    }
    public enum N_BillingEmailAdditionColumns
    {
        ID,
        N_BillingEmailID,
        M_FileLocationID,
        FilePath,
        FileName,
        FileNameBodyText,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum N_BillingEmailAdditionProcedure
    {
        p_N_BillingEmailAddition_GetListForDeleting,
    }
    public class N_BillingEmailAdditionList : List<N_BillingEmailAddition>
    {

    }
}