using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_Object : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _a_MenuID;

        public long? A_MenuID
        {
            get { return _a_MenuID; }
            set { _a_MenuID = value; }
        }

        private string _objectName;

        public string ObjectName
        {
            get { return _objectName; }
            set { _objectName = value; }
        }

        private string controllerName;

        public string ControllerName
        {
            get { return controllerName; }
            set { controllerName = value; }
        }

        private string actionName;

        public string ActionName
        {
            get { return actionName; }
            set { actionName = value; }
        }

        private string _description;

        
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public override string Table { get { return "A_Object"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_A_Object_InsertOrUpdate"; } }
    }

    public enum A_ObjectColumns
    {
        ID,
        A_MenuID,
        ObjectName,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum A_ObjectProcedure
    {
    }

    public class A_ObjectList : List<A_Object>
    {
    }
}