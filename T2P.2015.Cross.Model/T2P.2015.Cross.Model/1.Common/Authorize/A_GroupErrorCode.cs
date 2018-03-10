using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_GroupErrorCode : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _a_GroupID;
        public long A_GroupID
        {
            get { return _a_GroupID; }
            set { _a_GroupID = value; }
        }
        private long _m_InvoiceErrorCodeID;
        public long M_InvoiceErrorCodeID
        {
            get { return _m_InvoiceErrorCodeID; }
            set { _m_InvoiceErrorCodeID = value; }
        }
        public override string Table { get { return "A_GroupErrorCode"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_GroupErrorCode_InsertOrUpdate"; } }
    }
    public enum A_GroupErrorCodeColumns
    {
        ID,
        A_GroupID,
        M_InvoiceErrorCodeID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum A_GroupErrorCodeProcedure
    {
        p_A_GroupErrorCode_DeleteBy_A_GroupID
    }
    public class A_GroupErrorCodeList : List<A_GroupErrorCode>
    {

    }
}