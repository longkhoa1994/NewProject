using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
    public class M_ServiceCodeKeyword : BaseModel
        {
            private long  _iD;
            public long ID
            {
                get{ return _iD;}
                set{_iD = value;}
            }
            private string  _keyword;
            public string Keyword
            {
            get{ return _keyword;}
            set{_keyword = value;}
            }
            private long  _m_ServiceCodeID;
            public long M_ServiceCodeID
            {
            get{ return _m_ServiceCodeID;}
            set{_m_ServiceCodeID = value;}
            }
            public override string Table { get { return "M_ServiceCodeKeyword"; } }
            public override string PrimaryKey { get { return ID.ToString(); } }
            public override string InsertUpdateProcedure { get { return "p_M_ServiceCodeKeyword_InsertOrUpdate"; } }
        }
    public class M_ServiceCodeKeywordExtend:M_ServiceCode
    {
        private string _serviceCode;

        public string ServiceCode
        {
            get { return _serviceCode; }
            set { _serviceCode = value; }
        }

    }
    public enum M_ServiceCodeKeywordColumns
        {
        ID,
        Keyword,
        M_ServiceCodeID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
        }
    public enum M_ServiceCodeKeywordProcedure
    {
        p_M_ServiceCodeKeyword_Get_By_Keyword,
        p_M_ServiceCodeKeyword_GetBy_Desc
    }
    public class M_ServiceCodeKeywordList : List<M_ServiceCodeKeyword>
    {

    }
    }