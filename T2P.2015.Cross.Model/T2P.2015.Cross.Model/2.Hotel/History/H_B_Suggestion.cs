using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class H_B_Suggestion : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _h_M_HotelID;
        public long H_M_HotelID
        {
            get { return _h_M_HotelID; }
            set { _h_M_HotelID = value; }
        }
        private long _b_SuggestionID;
        public long B_SuggestionID
        {
            get { return _b_SuggestionID; }
            set { _b_SuggestionID = value; }
        }
        public override string Table { get { return "H_B_Suggestion"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_H_B_Suggestion_InsertOrUpdate"; } }
    }
    public enum H_B_SuggestionColumns
    {
        ID,
        H_M_HotelID,
        B_SuggestionID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum H_B_SuggestionProcedure
    {

    }
    public class H_B_SuggestionList : List<H_B_Suggestion>
    {

    }
}