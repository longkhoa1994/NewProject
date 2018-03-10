using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    public class B_DBI_Raw
    {
        public int ID { get; set; }

        public Guid ImportID { get; set; }

        public string BookingProcessNo { get; set; }

        public string BookingNo { get; set; }

        public string ActionNo_AK { get; set; }

        public string EmployeeNo_PK { get; set; }

        public string FinalDestination_RZ { get; set; }

        public string OrderNo_AU { get; set; }

        public string DepartmentNo_DS { get; set; }

        public string AccountingUnit_AE { get; set; }

        public string CostCenter_KS { get; set; }

        public string ProcessingDate_BD { get; set; }

        public string ProjectNo_PR { get; set; }

        public string InternalAccount_IK { get; set; }

        public static string Table = "B_DBI_Raw";
    }
}
