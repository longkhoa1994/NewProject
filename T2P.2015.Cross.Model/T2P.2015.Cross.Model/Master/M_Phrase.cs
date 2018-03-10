using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Phrase : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _m_LanguageID;

        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }

        private string _phraseCode;

        public string PhraseCode
        {
            get { return _phraseCode; }
            set { _phraseCode = value; }
        }

        private string _phraseText;

        public string PhraseText
        {
            get { return _phraseText; }
            set { _phraseText = value; }
        }

        public override string Table { get { return "M_Phrase"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_M_Phrase_InsertOrUpdate"; } }
    }

    public enum M_PhraseColumns
    {
        ID,
        M_LanguageID,
        PhraseCode,
        PhraseText,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_PhraseProcedure
    {
    }

    public class M_PhraseList : List<M_Phrase>
    {
    }
}