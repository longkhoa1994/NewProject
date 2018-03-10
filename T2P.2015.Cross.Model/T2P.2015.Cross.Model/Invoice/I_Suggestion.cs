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
        private long? _m_HotelID;
        public long? M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }
        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
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
        M_CompanyID,
        Traveler,
        Checkin,
        Checkout,
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
    }
    public class I_SuggestionList : List<I_Suggestion>
    {

    }
}