using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class N_BillingEmailDetail : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _n_BillingEmailID;

        public long N_BillingEmailID
        {
            get { return _n_BillingEmailID; }
            set { _n_BillingEmailID = value; }
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

        public override string Table { get { return "N_BillingEmailDetail"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_N_BillingEmailDetail_InsertOrUpdate"; } }
    }

    public class N_BillingEmailDetail_Extend : N_BillingEmailDetail
    {
        public N_BillingEmail_ForBillingEmailDetail N_BillingEmail { get; set; }      
        public N_Remind Remind { get; set; }
        public List<N_Collection> ListN_Collection { get; set; }
        public List<N_Rejection_Extend> ListN_Rejection { get; set; }
        public List<N_Information> ListN_Information { get; set; }
        public List<N_SentBox_Extend> ListN_SentBox { get; set; }
        public List<A_UserTemplate> ListA_UserTemplate { get; set; }     
        public N_BillingEmailDetail_Extend()
        {
            N_BillingEmail = null;                 
            Remind = null;
            ListN_Collection = new List<N_Collection>();
            ListN_Rejection = new List<N_Rejection_Extend>();
            ListN_Information = new List<N_Information>();
            ListN_SentBox = new List<N_SentBox_Extend>();
            ListA_UserTemplate = new List<A_UserTemplate>();
        }
    }

    

    public enum N_BillingEmailDetailColumns
    {
        ID,
        N_BillingEmailID,
        Body,
        BodyFilter,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum N_BillingEmailDetailProcedure
    {
        p_N_Email_GetBy_ID,
        p_N_BillingEmailDetail_GetListForDeleting,
        p_N_BillingEmailDetail_GetListForArchiving_Deleting,
        p_N_BillingEmailDetail_GetByN_BillingEmailID,
        p_N_BillingEmailDetail_Check_Update_Email_Hotel,
    }

    public class N_BillingEmailDetailList : List<N_BillingEmailDetail>
    {
    }
}