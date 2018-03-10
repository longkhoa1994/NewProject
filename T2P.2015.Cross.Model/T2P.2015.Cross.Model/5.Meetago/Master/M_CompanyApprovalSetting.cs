using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Master
{
    [Serializable]
    public class M_CompanyApprovalSetting : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CompanyID;
        public long M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }
        private bool _firstApproval;
        public bool FirstApproval
        {
            get { return _firstApproval; }
            set { _firstApproval = value; }
        }
        private bool _secondApproval;
        public bool SecondApproval
        {
            get { return _secondApproval; }
            set { _secondApproval = value; }
        }
        private bool _successfulInvoice;
        public bool SuccessfulInvoice
        {
            get { return _successfulInvoice; }
            set { _successfulInvoice = value; }
        }
        public override string Table { get { return "M_CompanyApprovalSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyApprovalSetting_InsertOrUpdate"; } }
    }
    public enum M_CompanyApprovalSettingColumns
    {
        ID,
        M_CompanyID,
        FirstApproval,
        SecondApproval,
        SuccessfulInvoice,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyApprovalSettingProcedure
    {
        p_M_CompanyApprovalSetting_GetByCompanyID
    }
    public class M_CompanyApprovalSettingList : List<M_CompanyApprovalSetting>
    {

    }
}
