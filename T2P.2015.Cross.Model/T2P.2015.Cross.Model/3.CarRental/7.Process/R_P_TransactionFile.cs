using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class R_P_TransactionFile : R_F_Import
    {
        private int _totalEriched;

        public int TotalEriched
        {
            get { return _totalEriched; }
            set { _totalEriched = value; }
        }

        private int _totalProcessing;

        public int TotalProcessing
        {
            get { return _totalProcessing; }
            set { _totalProcessing = value; }
        }

        private string _fileStatus;

        public string FileStatus
        {
            get { return _fileStatus; }
            set { _fileStatus = value; }
        }

        private int _totalRecords;

        public int TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }


        private string _amount;

        public string Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        
    }

    public class R_P_Transaction : R_F_Transaction
    {

        private string _finStatus;

        public string FinStatus
        {
            get { return _finStatus; }
            set { _finStatus = value; }
        }

        private string _fileName;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private int _totalRecords;

        public int TotalRecords
        {
            get { return _totalRecords; }
            set { _totalRecords = value; }
        }

        private string _errorName;

        public string ErrorName
        {
            get { return _errorName; }
            set { _errorName = value; }
        }

        private string _errorDescription;

        public string ErrorDescription
        {
            get { return _errorDescription; }
            set { _errorDescription = value; }
        }

    }

    public enum R_P_TransactionFileProcedure
    {
        p_R_F_Import_GetByCondition,
        p_R_F_Transaction_GetByCondition
    }

}
