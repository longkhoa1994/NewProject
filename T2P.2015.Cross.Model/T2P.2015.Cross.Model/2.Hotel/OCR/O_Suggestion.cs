using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class O_Suggestion : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        
        private long? _o_PageID;
        public long? O_PageID
        {
            get { return _o_PageID; }
            set { _o_PageID = value; }
        }

        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }

        private long? _m_HotelID;
        public long? M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }

        private string _hotelName;
        [Extract]
        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }

        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private string _companyName;
        [Extract]
        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        private string _traveler;
        [Extract]
        public string Traveler
        {
            get { return _traveler; }
            set { _traveler = value; }
        }

        private string action;

        public string Action
        {
            get { return action; }
            set { action = value; }
        }

        private int numberofInvoice;

        public int NumberofInvoice
        {
            get { return numberofInvoice; }
            set { numberofInvoice = value; }
        }

        private DateTime? checkin;

        [Extract]
        public DateTime? Checkin
        {
            get { return checkin; }
            set { checkin = value; }
        }

        private DateTime? checkout;

        [Extract]
        public DateTime? Checkout
        {
            get { return checkout; }
            set { checkout = value; }
        }

        private string resNo;

        [Extract]
        public string ResNo
        {
            get { return resNo; }
            set { resNo = value; }
        }

        private decimal oCRDuration;

        public decimal OCRDuration
        {
            get { return oCRDuration; }
            set { oCRDuration = value; }
        }

        private decimal suggestDuration;

        public decimal SuggestDuration
        {
            get { return suggestDuration; }
            set { suggestDuration = value; }
        }

        private int hasDate;

        public int HasDate
        {
            get { return hasDate; }
            set { hasDate = value; }
        }

        private int priority;

        public int Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        private int rotate;

        public int Rotate
        {
            get { return rotate; }
            set { rotate = value; }
        }

        public override string Table { get { return "O_Suggestion"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_Suggestion_InsertOrUpdate"; } }

    }
    public enum O_SuggestionColumns
    {
        ID,
        O_PageID,
        B_AccessID,
        M_HotelID,
        M_CompanyID,
        Traveler,
        Priority,
        Rotate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum O_SuggestionProcedure
    {

    }
    public class O_SuggestionList : List<O_Suggestion>
    {

    }
}