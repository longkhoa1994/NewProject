using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_HotelChain : BaseModel
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

        private string _legalEntity;

        public string LegalEntity
        {
            get { return _legalEntity; }
            set { _legalEntity = value; }
        }

        private string _headQuater;

        public string HeadQuater
        {
            get { return _headQuater; }
            set { _headQuater = value; }
        }

        private long? _m_CountryID;

        public long? M_CountryID
        {
            get { return _m_CountryID; }
            set { _m_CountryID = value; }
        }

        private long? parentID;

        public long? ParentID
        {
            get { return parentID; }
            set { parentID = value; }
        }

        public override string Table { get { return "M_HotelChain"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelChain_InsertOrUpdate"; } }
    }
    public enum M_HotelChainColumns
    {
        ID,
        Name,
        LegalEntity,
        HeadQuater,
        M_CountryID,
        ParentID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_HotelChainProcedure
    {
        p_M_HotelChain_Get_Search,
        p_M_HotelChain_Keyword_GetByHotelChainID,
        p_M_HotelNew_Get_Search,
        p_M_HotelChain_Get_All,
        p_M_HotelChain_GetByID
    }
    public class M_HotelChainList : List<M_HotelChain>
    {

    }
}