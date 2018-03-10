using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class M_DuplicateHotelRule: BaseModel
    {
        public long ID { get; set; }
        public string RuleCode { get; set; }
        public string HotelPlatform { get; set; }
        public double HotelName { get; set; }
        public double Address { get; set; }
        public double ZipCode { get; set; }
        public double City { get; set; }
        public double Country { get; set; }
        public double Phone { get; set; }
        public double Fax { get; set; }
        public double Email { get; set; }
        public int HotelStatus { get; set; }
        public int? Order { get; set; }
        public int Status { get; set; }

        public override string Table { get { return "M_DuplicateHotelRule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
    }

    public enum RuleCode
    {
        Rule0,
        Rule1,
        Rule2,
        Rule3,
        Rule4,
        Rule5,
        Rule6,
        Rule7,
        Rule8
    }

}
