using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{

    [Serializable]
    public class M_HotelPlatform : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string sentToEmail;

        public string SentToEmail
        {
            get { return sentToEmail; }
            set { sentToEmail = value; }
        }

        private string _url;
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        private string _hotelLogo;
        public string HotelLogo
        {
            get { return _hotelLogo; }
            set { _hotelLogo = value; }
        }
        private string _ariPlusLogo;
        public string AriPlusLogo
        {
            get { return _ariPlusLogo; }
            set { _ariPlusLogo = value; }
        }
        private string _t2PLogo;
        public string T2PLogo
        {
            get { return _t2PLogo; }
            set { _t2PLogo = value; }
        }
        private string _defaultLogo;
        public string DefaultLogo
        {
            get { return _defaultLogo; }
            set { _defaultLogo = value; }
        }

        private string hotelPlatformType;

        public string HotelPlatformType
        {
            get { return hotelPlatformType; }
            set { hotelPlatformType = value; }
        }

        private int allValue;

        public int AllValue
        {
            get { return allValue; }
            set { allValue = value; }
        }

        public string LogoURL { get; set; }

        public override string Table { get { return "M_HotelPlatform"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelPlatform_InsertOrUpdate"; } }
    }
    public enum M_HotelPlatformColumns
    {
        ID,
        Name,
        Url,
        HotelLogo,
        AriPlusLogo,
        T2PLogo,
        DefaultLogo,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_HotelPlatformProcedure
    {
        p_M_HotelPlatform_GetByUser,
        p_M_HotelPlatform_GetByB_AccessID,
        p_M_HotelPlatform_GetBy_M_HotelID,
        p_M_HotelPlatform_GetBy_Name,
        p_M_HotelPlatform_GetList_By_AllValue, 
        p_M_HotelPlatform_GetPlatform_Avaiable_For_ImportBooking,
        p_M_HotelPlatform_CheckFullSmartBillings,
        p_M_HotelPlatform_GetListUsingSmartBillingEmail,

    }

    public class M_HotelPlatformList : List<M_HotelPlatform>
    {
    }
}