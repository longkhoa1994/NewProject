using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Noun : BaseModel
    {
        private int _iD;
        public int ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _nounStr;
        public string NounStr
        {
            get { return _nounStr; }
            set { _nounStr = value; }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public override string Table { get { return "M_Noun"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Noun_InsertOrUpdate"; } }
    }
    public enum M_NounColumns
    {
        ID,
        NounStr,
        Description,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_NounProcedure
    {
        
    }
    public class M_NounList : List<M_Noun>
    {

    }
}
