using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class H_I_Suggestion : BaseModel
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
        private long _i_SuggestionID;
        public long I_SuggestionID
        {
            get { return _i_SuggestionID; }
            set { _i_SuggestionID = value; }
        }
        public override string Table { get { return "H_I_Suggestion"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_H_I_Suggestion_InsertOrUpdate"; } }
    }
    public enum H_I_SuggestionColumns
    {
        ID,
        H_M_HotelID,
        I_SuggestionID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum H_I_SuggestionProcedure
    {

    }
    public class H_I_SuggestionList : List<H_I_Suggestion>
    {

    }
}