using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_SuggestError : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _i_SuggestHeaderID;
        public long I_SuggestHeaderID
        {
            get { return _i_SuggestHeaderID; }
            set { _i_SuggestHeaderID = value; }
        }
        private long _m_InvoiceErrorCodeID;
        public long M_InvoiceErrorCodeID
        {
            get { return _m_InvoiceErrorCodeID; }
            set { _m_InvoiceErrorCodeID = value; }
        }
        public override string Table { get { return "I_SuggestError"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_SuggestError_InsertOrUpdate"; } }
    }
    public enum I_SuggestErrorColumns
    {
        ID,
        I_SuggestHeaderID,
        M_InvoiceErrorCodeID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_SuggestErrorProcedure
    {
        p_I_SuggestError_GetBySuggestHeaderID
    }
    public class I_SuggestErrorList : List<I_SuggestError>
    {

    }
}