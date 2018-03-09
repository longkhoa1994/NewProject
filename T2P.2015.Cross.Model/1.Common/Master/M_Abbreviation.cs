using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Abbreviation : BaseModel
    {
        private int _iD;
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _abbreviationStr;
        public string AbbreviationStr
        {
            get { return _abbreviationStr; }
            set { _abbreviationStr = value; }
        }
        private string _standFor;
        public string StandFor
        {
            get { return _standFor; }
            set { _standFor = value; }
        }

        private string _useFor;
        public string UseFor
        {
            get { return _useFor; }
            set { _useFor = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "M_Abbreviation"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Abbreviation_InsertOrUpdate"; } }
    }
    public enum M_AbbreviationColumns
    {
        ID,
        AbbreviationStr,
        StandFor,
        UseFor, // 0 it mean for all, 1 for hotelname, 2 for hotel address
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_AbbreviationProcedure
    {

    }
    public class M_AbbreviationList : List<M_Abbreviation>
    {

    }
}
