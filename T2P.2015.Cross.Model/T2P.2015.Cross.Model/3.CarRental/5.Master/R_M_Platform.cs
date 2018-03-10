using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_Platform : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        public long M_HotelPlatformID { get; set; }
        public string IP { get; set; }
        public string IISPath { get; set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _url;
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        private string _logo;
        public string Logo
        {
            get { return _logo; }
            set { _logo = value; }
        }
        private string _hotelLogo;
        public string HotelLogo
        {
            get { return _hotelLogo; }
            set { _hotelLogo = value; }
        }
        private string _airPlusLogo;
        public string AirPlusLogo
        {
            get { return _airPlusLogo; }
            set { _airPlusLogo = value; }
        }
        private string _t2pLogo;
        public string T2pLogo
        {
            get { return _t2pLogo; }
            set { _t2pLogo = value; }
        }
        public override string Table { get { return "R_M_Platform"; } } 
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_Platform_InsertOrUpdate"; } }
    }
    public enum R_M_PlatformColumns
    {
        ID,
        M_HotelPlatformID,
        Name,
        Url,
        Logo,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
   
    public enum R_M_PlatformProcedure
    {

    }
    public class R_M_PlatformList : List<R_M_Platform>
    {

    }
}