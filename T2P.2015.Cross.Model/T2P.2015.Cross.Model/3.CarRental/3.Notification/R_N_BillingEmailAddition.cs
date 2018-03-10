using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_BillingEmailAddition : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _r_N_BillingEmailID;
        public long R_N_BillingEmailID
        {
            get { return _r_N_BillingEmailID; }
            set { _r_N_BillingEmailID = value; }
        }
        private long _r_M_FileLocationID;
        public long R_M_FileLocationID
        {
            get { return _r_M_FileLocationID; }
            set { _r_M_FileLocationID = value; }
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
        public override string Table { get { return "R_N_BillingEmailAddition"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_BillingEmailAddition_InsertOrUpdate"; } }
    }
    public enum R_N_BillingEmailAdditionColumns
    {
        ID,
        R_N_BillingEmailID,
        R_M_FileLocationID,
        FilePath,
        FileName,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_N_BillingEmailAdditionProcedure
    {
        p_R_N_BillingEmailAddition_Get_By_EmailID,

    }
    public class R_N_BillingEmailAdditionList : List<R_N_BillingEmailAddition>
    {

    }
}