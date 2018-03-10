using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_ProcessGeneralSetting : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_ProcessStepID;

        public long M_ProcessStepID
        {
            get { return _m_ProcessStepID; }
            set { _m_ProcessStepID = value; }
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

        public override string Table { get { return "M_ProcessGeneralSetting"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_ProcessGeneralSetting_InsertOrUpdate"; } }
    }

    public enum M_ProcessGeneralSettingColumns
    {
        ID,
        M_ProcessStepID,
        Attribute,
        Value,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_ProcessGeneralSettingProcedure
    {
        p_M_ProcessGeneralSetting_GetByProcessStepID,
        p_M_ProcessGeneralSetting_GetByProcessID
    }

    public class M_ProcessGeneralSettingList : List<M_ProcessGeneralSetting>
    {
    }
}