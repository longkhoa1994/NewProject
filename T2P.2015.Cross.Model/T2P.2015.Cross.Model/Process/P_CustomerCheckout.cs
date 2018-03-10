using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_CustomerCheckout
    {
        public DateTime FromDate;
        public DateTime ToDate;
        public List<P_CustomerCheckout_Data> ListData_Receive;
        public List<P_CustomerCheckout_Data> ListData_Checkout;
        public List<P_CustomerCheckout_Data> ListData_Invoice;

        public P_CustomerCheckout() 
        {
            FromDate = new DateTime();
            ToDate = new DateTime();
            ListData_Receive = new List<P_CustomerCheckout_Data>();
            ListData_Checkout = new List<P_CustomerCheckout_Data>();
            ListData_Invoice = new List<P_CustomerCheckout_Data>();
        }
    }

    public class P_CustomerCheckout_Data
    {
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        private long _parentCompanyID;

        public long ParentCompanyID
        {
            get { return _parentCompanyID; }
            set { _parentCompanyID = value; }
        }

        private string _parentCompanyName;

        public string ParentCompanyName
        {
            get { return _parentCompanyName; }
            set { _parentCompanyName = value; }
        }

        private string _companyShortName;

        public string CompanyShortName
        {
            get { return _companyShortName; }
            set { _companyShortName = value; }
        }

        private int _number;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public P_CustomerCheckout_Data()
        {
            Type = string.Empty;
            ParentCompanyID = 0;
            ParentCompanyName = string.Empty;
            CompanyShortName = string.Empty;
            Number = 0;
        }
    }

    public enum P_CustomerCheckoutProcedure
    {
        p_P_CustomerCheckout_GetData,
    }
}
