using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Suggestion:BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _b_AccessID;

        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        private long _n_BillingEmailID;

        public long N_BillingEmailID
        {
            get { return _n_BillingEmailID; }
            set { _n_BillingEmailID = value; }
        }

        private long? _m_HotelID;

        public long? M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }


        private long? _m_TravellerID;

        public long? M_TravellerID
        {
            get { return _m_TravellerID; }
            set { _m_TravellerID = value; }
        }


        private long? _m_CompanyID;

        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        
        
        private string _hotelName;

        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }
        private string _travellerName;

        public string TravellerName
        {
            get { return _travellerName; }
            set { _travellerName = value; }
        }

        private string _companyName;

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }
        private int _isMatched;

        public int IsMatched
        {
            get { return _isMatched; }
            set { _isMatched = value; }
        }

        public override string Table { get { return "B_Sugestion"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_Suggestion_InsertOrUpdate"; } }
    }
    public enum B_SuggestionColumns
    {
        ID,
        B_AccessID,
        N_BillingEmailID,
        M_HotelContactID,
        M_TravellerID,
        HotelName,
        TravellerName,
        IsMatched,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_SuggestionProcedure
    {
        p_B_Suggestion_InsertOrUpdate,
        p_B_Suggestion_GetInformation,
        p_B_Suggestion_ByN_BillingEmailID,
        p_B_Suggestion_ByN_BillingEmailID_New,
        p_B_Suggestion_Get_ByI_ImageID,
        p_B_Suggestion_GetListForDeleting,
    }
}
