using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_Group : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private long? _parentID;

        public long? ParentID
        {
            get { return _parentID; }
            set { _parentID = value; }
        }

        private string _Type;

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }

        private string _ReferenceInfo;

        public string ReferenceInfo
        {
            get { return _ReferenceInfo; }
            set { _ReferenceInfo = value; }
        }

        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value; }
        }

        public override string Table { get { return "A_Group"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_Group_InsertOrUpdate"; } }
    }

    public class A_GroupExtend : A_Group
    {
        private long _m_LanguageID;
        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
    }

    public enum A_GroupProcedure
    {
        p_A_Group_Get_ByUserID,
        p_A_GroupGetErrorCodes
    }

    public class A_GroupList : List<A_Group>
    {
    }
}
