using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Company : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_BookingID;

        public long B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _companyShortName;

        public string CompanyShortName
        {
            get { return _companyShortName; }
            set { _companyShortName = value; }
        }

        private string _companyAddress;

        
        public string CompanyAddress
        {
            get { return _companyAddress; }
            set { _companyAddress = value; }
        }

        private string _customerNo;

        public string CustomerNo
        {
            get { return _customerNo; }
            set { _customerNo = value; }
        }

        public override string Table { get { return "B_Company"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Company_InsertOrUpdate"; } }
    }

    public enum B_CompanyColumns
    {
        ID,
        B_BookingID,
        CompanyName,
        CompanyShortName,
        CompanyAddress,
        CustomerNo,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_CompanyProcedure
    {
        p_B_Company_Get_by_B_BookingID,
        p_B_Company_GetListForDeleting,
    }

    public class B_CompanyList : List<B_Company>
    {
    }
}