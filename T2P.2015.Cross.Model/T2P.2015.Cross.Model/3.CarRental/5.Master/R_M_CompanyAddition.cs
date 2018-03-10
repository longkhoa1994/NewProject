using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_CompanyAddition : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _r_M_CompanyID;
        public long R_M_CompanyID
        {
            get { return _r_M_CompanyID; }
            set { _r_M_CompanyID = value; }
        }
        private long _r_M_PlatformID;
        public long R_M_PlatformID
        {
            get { return _r_M_PlatformID; }
            set { _r_M_PlatformID = value; }
        }
        public string CompanyName { get; set; }
        private string _customerNo;
        public string CustomerNo
        {
            get { return _customerNo; }
            set { _customerNo = value; }
        }
        private string _subID;
        public string SubID
        {
            get { return _subID; }
            set { _subID = value; }
        }
        public override string Table { get { return "R_M_CompanyAddition"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_CompanyAddition_InsertOrUpdate"; } }
    }
    public enum R_M_CompanyAdditionColumns
    {
        ID,
        R_M_CompanyID,
        R_M_PlatformID,
        CompanyName,
        CustomerNo,
        SubID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_CompanyAdditionProcedure
    {
        p_R_M_CompanyAddition_GetForValidation
    }
    public class R_M_CompanyAdditionList : List<R_M_CompanyAddition>
    {

    }
}