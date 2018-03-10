using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_M_CarGroupSippCode : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CarRentalProviderID;
        public long M_CarRentalProviderID
        {
            get { return _m_CarRentalProviderID; }
            set { _m_CarRentalProviderID = value; }
        }
        private long _m_CountryID;
        public long M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }
        private long _r_M_CarGroupID;
        public long R_M_CarGroupID
        {
            get { return _r_M_CarGroupID; }
            set { _r_M_CarGroupID = value; }
        }
        private long _r_M_SippCodeID;
        public long R_M_SippCodeID
        {
            get { return _r_M_SippCodeID; }
            set { _r_M_SippCodeID = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "R_M_CarGroupSippCode"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_M_CarGroupSippCode_InsertOrUpdate"; } }
    }
    public enum R_M_CarGroupSippCodeColumns
    {
        ID,
        M_CarRentalProviderID,
        M_CountryID,
        R_M_CarGroupID,
        R_M_SippCodeID,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum R_M_CarGroupSippCodeProcedure
    {
        p_R_M_CarGroupSippCode_Get_By_CarProviderID,
        p_R_M_CarGroupSippCode_Get_By_Code
    }
    public class R_M_CarGroupSippCodeList : List<R_M_CarGroupSippCode>
    {

    }
}