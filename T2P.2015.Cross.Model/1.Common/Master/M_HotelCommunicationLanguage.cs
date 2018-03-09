using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelCommunicationLanguage : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_HotelID;
        public long M_HotelID
        {
            get { return _m_HotelID; }
            set { _m_HotelID = value; }
        }
        private long _m_LanguageID;
        public long M_LanguageID
        {
            get { return _m_LanguageID; }
            set { _m_LanguageID = value; }
        }
        public override string Table { get { return "M_HotelCommunicationLanguage"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelCommunicationLanguage_InsertOrUpdate"; } }
    }
    public enum M_HotelCommunicationLanguageColumns
    {
        ID,
        M_HotelID,
        M_LanguageID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_HotelCommunicationLanguageProcedure
    {
        p_M_HotelCommunicationLanguage_GetList_ByM_HotelID
    }
    public class M_HotelCommunicationLanguageList : List<M_HotelCommunicationLanguage>
    {

    }
}