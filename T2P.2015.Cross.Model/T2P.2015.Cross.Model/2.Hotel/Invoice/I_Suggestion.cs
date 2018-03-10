using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public partial class I_Suggestion : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        
        private long? _i_ImageID;
        public long? I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }

        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private string bookingNo;
        public string BookingNo
        {
            get { return bookingNo; }
            set { bookingNo = value; }
        }

        private long? _m_HotelID;
        public long? M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }

        private string hotelName;
        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private string hotelAddress;
        public string HotelAddress
        {
            get { return hotelAddress; }
            set { hotelAddress = value; }
        }

        private string hotelZipCode;
        public string HotelZipCode
        {
            get { return hotelZipCode; }
            set { hotelZipCode = value; }
        }

        private string hotelCity;
        public string HotelCity
        {
            get { return hotelCity; }
            set { hotelCity = value; }
        }

        private string hotelVAT;
        public string HotelVAT
        {
            get { return hotelVAT; }
            set { hotelVAT = value; }
        }

        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private string companyName;
        public string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }
        }

        private string companyAddress;
        public string CompanyAddress
        {
            get { return companyAddress; }
            set { companyAddress = value; }
        }

        private string companyZipCode;
        public string CompanyZipCode
        {
            get { return companyZipCode; }
            set { companyZipCode = value; }
        }

        private string companyCity;
        public string CompanyCity
        {
            get { return companyCity; }
            set { companyCity = value; }
        }

        private string _traveler;
        public string Traveler
        {
            get { return _traveler; }
            set { _traveler = value; }
        }

        private DateTime? _checkin;
        public DateTime? Checkin
        {
            get { return _checkin; }
            set { _checkin = value; }
        }

        private DateTime? _checkout;
        public DateTime? Checkout
        {
            get { return _checkout; }
            set { _checkout = value; }
        }
        private string _action;
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
        private int _priority;
        public int Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        private int suggestionCode;
        public int SuggestionCode
        {
            get { return suggestionCode; }
            set { suggestionCode = value; }
        }

        private string companyCountry;
        [NotInsert]
        [NotUpdate]
        public string CompanyCountry
        {
            get { return companyCountry; }
            set { companyCountry = value; }
        }

        private string companyCountryCode;
        [NotInsert]
        [NotUpdate]
        public string CompanyCountryCode
        {
            get { return companyCountryCode; }
            set { companyCountryCode = value; }
        }

        private string companyVAT;
        [NotInsert]
        [NotUpdate]
        public string CompanyVAT
        {
            get { return companyVAT; }
            set { companyVAT = value; }
        }        

        private string hotelCountry;
        [NotInsert]
        [NotUpdate]
        public string HotelCountry
        {
            get { return hotelCountry; }
            set { hotelCountry = value; }
        }

        private string hotelCountryCode;
        [NotInsert]
        [NotUpdate]
        public string HotelCountryCode
        {
            get { return hotelCountryCode; }
            set { hotelCountryCode = value; }
        }        

        //private DateTime checkin;
        //[NotInsert]
        //[NotUpdate]
        //public DateTime BCheckin
        //{
        //    get { return checkin; }
        //    set { checkin = value; }
        //}

        //private DateTime checkout;
        //[NotInsert]
        //[NotUpdate]
        //public DateTime BCheckout
        //{
        //    get { return checkout; }
        //    set { checkout = value; }
        //}

        private long _hotelCountryID;
        [NotInsert]
        [NotUpdate]
        public long HotelCountryID
        {
            get { return _hotelCountryID; }
            set { _hotelCountryID = value; }
        }

        public override string Table { get { return "I_Suggestion"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_Suggestion_InsertOrUpdate"; } }
    }
    public enum I_SuggestionColumns
    {
        ID,
        I_ImageID,
        B_AccessID,

        M_HotelID,
        HotelName,
        M_CompanyID,
        CompanyName,
        Traveler,
        CheckIn,
        CheckOut,
        Action,
        Priority,

        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_SuggestionProcedure
    {
        p_I_Suggestion_GetListIDForDeleting,
        p_I_Suggestion_GetByImageID,
        p_I_Suggestion_GetForCapture,
        p_I_Suggestion_GetList_ByM_HotelID,
        p_I_Suggestion_GetList_ByListHotelID,
        p_I_Suggestion_Get_Matched_Items_By_B_AccessID,
        p_M_Currency_GetbyHotelID    
    
    }
    public class I_SuggestionList : List<I_Suggestion>
    {

    }
}