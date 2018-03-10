using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.BookingRaw
{
    public class B_Import_Raw
    {
        public Guid ID { get; set; }

        public int? M_HotelPlatformID { get; set; }

        public int? M_FileLocationID { get; set; }

        public string Message { get; set; }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        public string TransactionIdentifier { get; set; }

        public DateTime? TimeStamp { get; set; }

        public string Version { get; set; }

        public int? BookingCount { get; set; }

        public static string Table = "B_Import_Raw";
    }
}
