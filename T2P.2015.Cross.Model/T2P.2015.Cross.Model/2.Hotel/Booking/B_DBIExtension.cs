using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Booking
{
    public class B_DBIExtension : B_DBI
    {
        public long M_HotelPlatformID { get; set; }
        public string BookingNo { get; set; }
        public string PartnerId { get; set; }
        public string TravellerName { get; set; }
        public long B_AccessID { get; set; }
        public string BosId { get; set; }
        public string CountryCode { get; set; }

        public bool IsPK { get; set; }
        public bool IsKS { get; set; }
        public bool IsDS { get; set; }
        public bool IsAE { get; set; }
        public bool IsAK { get; set; }
        public bool IsBD { get; set; }
        public bool IsPR { get; set; }
        public bool IsAU { get; set; }
        public bool IsRZ { get; set; }
        public bool IsIK { get; set; }
        public string Name_CostCenter_KS { get; set; }
        public string Name_EmployeeNo_PK { get; set; }
        public string Name_DepartmentNo_DS { get; set; }
        public string Name_AccountingUnit_AE { get; set; }
        public string Name_InternalAccount_IK { get; set; }
        public string Name_CustomerName_BD { get; set; }
        public string Name_ProjectNo_PR { get; set; }
        public string Name_OrderNo_AU { get; set; }
        public string Name_ActionNo_AK { get; set; }
        public string Name_FinalDestination_RZ { get; set; }
    }
}
