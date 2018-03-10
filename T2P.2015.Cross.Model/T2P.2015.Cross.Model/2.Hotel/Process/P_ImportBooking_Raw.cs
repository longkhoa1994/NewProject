using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public class P_ImportBookingHeader_Raw
    {
        public Guid ImportID { get; set; }

        public M_HotelPlatform HotelPlatform { get; set; }

        public B_Header Header { get; set; }

        public DataTable ImportRaw { get; set; }

        public DataTable BookingRaw { get; set; }

        public DataTable BookingDetailRaw { get; set; }

        public DataTable HistoryRaw { get; set; }

        public DataTable DBIRaw { get; set; }

        public DataTable RateRaw { get; set; }

        public DataTable CompanyRaw { get; set; }

        public DataTable HotelRaw { get; set; }

        public DataTable HotelContactRaw { get; set; }

        public DataTable BookerRaw { get; set; }

        public DataTable TravelerRaw { get; set; }

        public DataTable PosRaw { get; set; }

        public DataTable AllowedServiceCodesRaw { get; set; }

        public DataTable KeyValuePairRaw { get; set; }

        public DataTable KeyValuePairDetailRaw { get; set; }

        public DataTable ErrorRaw { get; set; }
    }
}
