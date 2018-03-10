using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ServiceSuggestion : BaseModel
    {
        private long _id;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private long _m_ServiceCodeID;
        public long M_ServiceCodeID
        {
            get { return _m_ServiceCodeID; }
            set { _m_ServiceCodeID = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string Table { get { return "M_ServiceSuggestion"; } }
        public override string PrimaryKey { get { return Id.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_ServiceSuggestion_InsertOrUpdate"; } }
    }
    public enum M_ServiceSuggestionColumns
    {
        Id,
        M_ServiceCodeID,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_ServiceSuggestionProcedure
    {
        p_M_ServiceSuggestion_Suggest
    }
    public class M_ServiceSuggestionList : List<M_ServiceSuggestion>
    {

    }
}