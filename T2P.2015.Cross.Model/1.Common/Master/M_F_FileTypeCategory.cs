using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_F_FileTypeCategory : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_F_FileTypeID;
        public long M_F_FileTypeID
        {
            get { return _m_F_FileTypeID; }
            set { _m_F_FileTypeID = value; }
        }
        private string _category;
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        private string _keyWord;
        public string KeyWord
        {
            get { return _keyWord; }
            set { _keyWord = value; }
        }
        public override string Table { get { return "M_F_FileTypeCategory"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_F_FileTypeCategory_InsertOrUpdate"; } }
    }
    public enum M_F_FileTypeCategoryColumns
    {
        ID,
        M_F_FileTypeID,
        Category,
        KeyWord,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_F_FileTypeCategoryProcedure
    {
        p_M_F_FileTypeCategory_GetByFileTypeID
    }
    public class M_F_FileTypeCategoryList : List<M_F_FileTypeCategory>
    {

    }

    public enum FileTypeCategory
    {
        TravelExpense,
        CollectiveStatement
    }
}