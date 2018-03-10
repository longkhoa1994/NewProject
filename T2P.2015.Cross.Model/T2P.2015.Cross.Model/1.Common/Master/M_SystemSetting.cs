using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_SystemSetting : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
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

        public override string Table { get { return "M_SystemSetting"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_SystemSetting_InsertOrUpdate"; } }
    }

    public enum M_SystemSettingColumns
    {
        ID,
        Attribute,
        Value,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_SystemSettingProcedure
    {
        p_M_SystemSetting_Get_ByAttribute
    }

    public class M_SystemSettingList : List<M_SystemSetting>
    {
    }

    public class M_Configuration
    {
 
    }
}