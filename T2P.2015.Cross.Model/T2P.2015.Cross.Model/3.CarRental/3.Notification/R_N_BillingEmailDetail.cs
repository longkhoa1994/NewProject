using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_BillingEmailDetail : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _r_N_BillingEmailID;

        public long R_N_BillingEmailID
        {
            get { return _r_N_BillingEmailID; }
            set { _r_N_BillingEmailID = value; }
        }

        private string _body;

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        private string _bodyFilter;

        public string BodyFilter
        {
            get { return _bodyFilter; }
            set { _bodyFilter = value; }
        }

        public override string Table { get { return "R_N_BillingEmailDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_BillingEmailDetail_InsertOrUpdate"; } }
    }

    public enum R_N_BillingEmailDetailColumns
    {
        ID,
        R_N_BillingEmailID,
        Body,
        BodyFilter,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_N_BillingEmailDetailProcedure
    {
        p_R_N_BillingEmail_Get_Email_Detail_ForBillingEmail,
        p_R_N_BillingEmailDetail_Get_By_EmailID,
    }

    public class R_N_BillingEmailDetailList : List<R_N_BillingEmailDetail>
    {
    }
}