using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_F_Import : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _fileType;
        public string FileType
        {
            get { return _fileType; }
            set { _fileType = value; }
        }
        private string _fileName;
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        private string _companyIdentify;
        public string CompanyIdentify
        {
            get { return _companyIdentify; }
            set { _companyIdentify = value; }
        }
        private string _companyName;
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private int? _totalTransaction;
        public int? TotalTransaction
        {
            get { return _totalTransaction; }
            set { _totalTransaction = value; }
        }
        private int? _totalRentalCarTransaction;
        public int? TotalRentalCarTransaction
        {
            get { return _totalRentalCarTransaction; }
            set { _totalRentalCarTransaction = value; }
        }
        private decimal? _totalAmount;
        public decimal? TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
        private DateTime? importDate;

        public DateTime? ImportDate
        {
            get { return importDate; }
            set { importDate = value; }
        }
        public override string Table { get { return "R_F_Import"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_F_Import_InsertOrUpdate"; } }
    }
    public enum R_F_ImportColumns
    {
        ID,
        FileType,
        FileName,
        CompanyIdentify,
        CompanyName,
        TotalTransaction,
        TotalRentalCarTransaction,
        TotalAmount,
        ImportDate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_F_ImportProcedure
    {
        p_R_F_Import_GetByFileName
    }
    public class R_F_ImportList : List<R_F_Import>
    {

    }
}