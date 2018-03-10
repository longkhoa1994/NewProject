using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Language : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _languageCode;
        public string LanguageCode
        {
            get { return _languageCode; }
            set { _languageCode = value; }
        }
        private string _languageCode1;
        public string LanguageCode1
        {
            get { return _languageCode1; }
            set { _languageCode1 = value; }
        }
        private string _languageCode2;
        public string LanguageCode2
        {
            get { return _languageCode2; }
            set { _languageCode2 = value; }
        }
        private string _languageText;
        public string LanguageText
        {
            get { return _languageText; }
            set { _languageText = value; }
        }
        private string _dateFormat;
        public string DateFormat
        {
            get { return _dateFormat; }
            set { _dateFormat = value; }
        }
        private string _timeFormat;
        public string TimeFormat
        {
            get { return _timeFormat; }
            set { _timeFormat = value; }
        }
        public override string Table { get { return "M_Language"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Language_InsertOrUpdate"; } }
    }
    public enum M_LanguageColumns
    {
        ID,
        LanguageCode,
        LanguageCode1,
        LanguageCode2,
        LanguageText,
        DateFormat,
        TimeFormat,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_LanguageProcedure
    {
        p_M_Language_Get_ByLanguageCode,
    }

    public class M_LanguageList : List<M_Language>
    {
    }
}