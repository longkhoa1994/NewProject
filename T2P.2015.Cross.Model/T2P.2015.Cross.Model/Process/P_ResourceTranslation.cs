using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_ResourceTranslation
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _translationID;

        public long TranslationID
        {
            get { return _translationID; }
            set { _translationID = value; }
        }

        private string _language;

        public string Language
        {
            get { return _language; }
            set { _language = value; }
        }

        private string _translationValue;

        public string TranslationValue
        {
            get { return _translationValue; }
            set { _translationValue = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
    }

    public class P_ResourceTranslation_Result
    {
        private string _key;

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private long _englishID;

        public long EnglishID
        {
            get { return _englishID; }
            set { _englishID = value; }
        }

        private string _english;

        public string English
        {
            get { return _english; }
            set { _english = value; }
        }

        private long _germanID;

        public long GermanID
        {
            get { return _germanID; }
            set { _germanID = value; }
        }

        private string _german;

        public string German
        {
            get { return _german; }
            set { _german = value; }
        }

        private long _frenchID;

        public long FrenchID
        {
            get { return _frenchID; }
            set { _frenchID = value; }
        }

        private string _french;

        public string French
        {
            get { return _french; }
            set { _french = value; }
        }

        private long _italianID;

        public long ItalianID
        {
            get { return _italianID; }
            set { _italianID = value; }
        }

        private string _italian;

        public string Italian
        {
            get { return _italian; }
            set { _italian = value; }
        }

        public P_ResourceTranslation_Result()
        {
            Key = string.Empty;
            ID = 0;
            Description = string.Empty;
            EnglishID = 0;
            English = string.Empty;
            GermanID = 0;
            German = string.Empty;
            FrenchID = 0;
            French = string.Empty;
            ItalianID = 0;
            Italian = string.Empty;
        }
    }
}
