using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_CompanyProcessSetting : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _m_CompanyProcessID;
        public long? M_CompanyProcessID
        {
            get { return _m_CompanyProcessID; }
            set { _m_CompanyProcessID = value; }
        }
        private string _attribute;
        public string Attribute
        {
            get { return _attribute; }
            set { _attribute = value; }
        }
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "M_CompanyProcessSetting"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_CompanyProcessSetting_InsertOrUpdate"; } }
    }
    public enum M_CompanyProcessSettingColumns
    {
        ID,
        M_CompanyProcessID,
        Attribute,
        Value,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_CompanyProcessSettingProcedure
    {
        p_M_CompanyProcessSetting_GetList_ByCompanyProcess,
        p_M_CompanyProcessSetting_Get_By_CompanyID,
        p_M_CompanyProcessSetting_Get_By_CompanyID_Atribute,
        p_M_CompanyProcessSetting_GetBy_CompanyId_ProcessId_HotelPlatformId_Attribute,
    }
    public class M_CompanyProcessSettingList : List<M_CompanyProcessSetting>
    {

    }
}