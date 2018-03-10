using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.Process
{
    public class P_Translation
    {
        //private long _id;

        //public long ID
        //{
        //    get { return _id; }
        //    set { _id = value; }
        //}

        //private string _key;

        //public string Key
        //{
        //    get { return _key; }
        //    set { _key = value; }
        //}

        private string _labelType;

        public string LabelType
        {
            get { return _labelType; }
            set { _labelType = value; }
        }

        private long _englishID;

        public long EnglishID
        {
            get { return _englishID; }
            set { _englishID = value; }
        }

        private string _englishValue;

        public string EnglishValue
        {
            get { return _englishValue; }
            set { _englishValue = value; }
        }

        private long _translationID;

        public long TranslationID
        {
            get { return _translationID; }
            set { _translationID = value; }
        }

        private string _translationValue;

        public string TranslationValue
        {
            get { return _translationValue; }
            set { _translationValue = value; }
        }

        //private long _germanID;

        //public long GermanID
        //{
        //    get { return _germanID; }
        //    set { _germanID = value; }
        //}

        //private string _germanValue;

        //public string GermanValue
        //{
        //    get { return _germanValue; }
        //    set { _germanValue = value; }
        //}

        //private long _frenchID;

        //public long FrenchID
        //{
        //    get { return _frenchID; }
        //    set { _frenchID = value; }
        //}

        //private string _frenchValue;

        //public string FrenchValue
        //{
        //    get { return _frenchValue; }
        //    set { _frenchValue = value; }
        //}

        //private long _italianID;

        //public long ItalianID
        //{
        //    get { return _italianID; }
        //    set { _italianID = value; }
        //}

        //private string _italianValue;

        //public string ItalianValue
        //{
        //    get { return _italianValue; }
        //    set { _italianValue = value; }
        //}

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private DateTime _createdDate;

        public DateTime CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

    }

    public class P_Translation_Update
    {
        public long TotalRecords { get; set; }
        public long LanguageID { get; set; }
        public string FileLocal { get; set; }
        public List<P_Translation> ListTranslation { get; set; }

        public P_Translation_Update() 
        {
            ListTranslation = new List<P_Translation>();
        }
    }

    public enum P_TranslationProcedure
    { 
        p_M_Resource_GetList_ForTranslation
    }
}
