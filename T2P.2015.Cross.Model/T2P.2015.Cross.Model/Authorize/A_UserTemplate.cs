using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class A_UserTemplate : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _a_UserTemplateID;
        [NotInsert]
        [NotUpdate]
        public long A_UserTemplateID
        {
            get { return _a_UserTemplateID; }
            set { _a_UserTemplateID = value; }
        }

        private long _a_UserProfileID;
        public long A_UserProfileID
        {
            get { return _a_UserProfileID; }
            set { _a_UserProfileID = value; }
        }
        private long _m_LanguageID;
        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private string _subject;
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        private string _body;
        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }
        public override string Table { get { return "A_UserTemplate"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_A_UserTemplate_InsertOrUpdate"; } }
    }    

    public enum A_UserTemplateColumns
    {
        ID,
        A_UserProfileID,
        M_LanguageID,
        Subject,
        Body,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum A_UserTemplateProcedure
    {
        p_A_UserTemplateProcedure_GetByUser,
        p_A_UserTemplate_Get
      
    }
    public class A_UserTemplateList : List<A_UserTemplate>
    {

    }
}