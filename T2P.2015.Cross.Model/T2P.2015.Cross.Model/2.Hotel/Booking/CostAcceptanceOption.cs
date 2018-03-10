using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Enum;

namespace T2P._2015.Cross.Model._2.Hotel.Booking
{
    public class CostAcceptanceOption
    {
        public string Email { get; set; }
        public string Fax { get; set; }
        public long M_NotificationTemplateID { get; set; }
        public ProtocolType Type { get; set; }
        public string TokenStringPCI { get; set; }
    }
}
