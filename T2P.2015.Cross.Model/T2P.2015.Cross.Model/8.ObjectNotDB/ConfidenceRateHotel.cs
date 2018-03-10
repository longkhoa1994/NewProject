using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class ConfidenceRateHotel
    {
        public M_Hotel rawHotel { get; set; }
        public M_Hotel posibleDuplicateHotel { get; set; }
        
        public double HotelNameRate { get; set; }
        public double AddressRate { get; set; }
        public double ZipCodeRate { get; set; }
        public double CityRate { get; set; }
        public double PhoneRate { get; set; }
        public double FaxRate { get; set; }
        public double EmailRate { get; set; }
        public double TotalRate { get; set; }
    }
}
