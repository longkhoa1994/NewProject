using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_CompanyProviderSetting : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _r_M_CompanyID;
        public long? R_M_CompanyID
        {
            get { return _r_M_CompanyID; }
            set { _r_M_CompanyID = value; }
        }
        private long? _m_CarRentalProviderID;
        public long? M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
        }

        public long? M_PaymentProviderID { get; set; }

        private string _emailApproval;

        public string EmailApproval
        {
            get { return _emailApproval; }
            set { _emailApproval = value; }
        }
       
        private string _emailClaim;
        public string EmailClaim
        {
            get { return _emailClaim; }
            set { _emailClaim = value; }
        }
       
        private string _emailCollectionPDF;
        public string EmailCollectionPDF
        {
            get { return _emailCollectionPDF; }
            set { _emailCollectionPDF = value; }
        }

        private string _emailCollectionData;
        public string EmailCollectionData
        {
            get { return _emailCollectionData; }
            set { _emailCollectionData = value; }
        }
        private string _emailEscalation;

        public string EmailEscalation
        {
            get { return _emailEscalation; }
            set { _emailEscalation = value; }
        }

        private string _process;
        public string Process
        {
            get { return _process; }
            set { _process = value; }
        }

        public override string Table { get { return "R_M_CompanyProviderSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_CompanyProviderSetting_InsertOrUpdate"; } }
    }

    public enum R_M_CompanyProviderSettingColumns
    {
        ID,
        R_M_CompanyID,
        M_CarRentalProviderID,
        EmailClaim,
        EmailCollectionPDF,
        EmailCollectionData,
        Process,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_CompanyProviderSettingProcedure
    {
        p_R_M_CompanyProviderSetting_GetBy_CompanyID,
        p_R_M_CompanyProviderSetting_ForCheckProcess
    }
    public class RR_M_CompanyProviderSettingList : List<R_M_CompanyProviderSetting>
    {

    }

    public class R_M_CompanyProviderSettingExtend : M_Company
    {
        public long M_CompanyID { get; set; }
        public string Process { get; set; }
    }
}