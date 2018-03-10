using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyProcessDetail : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CompanyProcessID;
        public long M_CompanyProcessID
        {
            get { return _m_CompanyProcessID; }
            set { _m_CompanyProcessID = value; }
        }       
        private long _m_StepTypeID;
        public long M_StepTypeID
        {
            get { return _m_StepTypeID; }
            set { _m_StepTypeID = value; }
        }
        public override string Table { get { return "M_CompanyProcessDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyProcessDetail_InsertOrUpdate"; } }
    }
    public enum M_CompanyProcessDetailColumns
    {
        ID,
        M_CompanyProcessID,       
        M_StepTypeID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyProcessDetailProcedure
    {
        P_M_CompanyProcess_GetListByCompanyId,
        p_M_CompanyProcess_Get_By_StepCode,
        p_M_CompanyProcessDetail_GetList_ByCompanyID,
        p_M_CompanyProcessDetail_GetList_ByM_CompanyProcessID
        
    }
    public class M_CompanyProcessDetailList : List<M_CompanyProcessDetail>
    {

    }
}