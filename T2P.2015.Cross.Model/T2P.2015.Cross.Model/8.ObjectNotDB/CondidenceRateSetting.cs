using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    public class ConfidenceRateSetting
    {
        public double HotelNameWeightRate { get; set; }
        public double AddressWeightRate { get; set; }
        public double ZipCodeWeightRate { get; set; }
        public double CityWeightRate { get; set; }
        public double PhoneWeightRate { get; set; }
        public double FaxWeightRate { get; set; }
        public double EmailWeightRate { get; set; }
    }

    public enum M_Hotel_ConfidenceRateSetting_Column
    {
        HotelName_WeightRate,
        Address_WeightRate,
        ZipCode_WeightRate,
        City_WeightRate,
        Phone_WeightRate,
        Fax_WeightRate,
        Email_WeightRate
    }

    [Serializable]
    public class M_Hotel_ConfidenceRateSetting: BaseModel
    {
        public long ID { get; set; }
        public string Key { get; set; }
        public double Value { get; set; }       
        public override string Table { get { return "M_Hotel_ConfidenceRateSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
    }
}
