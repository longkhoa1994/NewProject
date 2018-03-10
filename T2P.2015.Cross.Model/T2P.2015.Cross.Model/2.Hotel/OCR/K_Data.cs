using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class K_Data : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _keyword;
        public string Keyword
        {
            get { return _keyword; }
            set { _keyword = value; }
        }
        private string _mark;
        public string Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }
        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        private long? _m_LangugeID;
        public long? M_LangugeID
        {
            get { return _m_LangugeID; }
            set { _m_LangugeID = value; }
        }
        private string _direction;
        public string Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }
        private int? _noWords;
        public int? NoWords
        {
            get { return _noWords; }
            set { _noWords = value; }
        }
        public override string Table { get { return "K_Data"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_K_Data_InsertOrUpdate"; } }
    }
    public enum K_DataColumns
    {
        ID,
        Keyword,
        Mark,
        Category,
        M_LangugeID,
        Direction,
        NoWords,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum K_DataProcedure
    {

    }
    public class K_DataList : List<K_Data>
    {

    }
}