using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class M_HotelChain_Keyword : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long  _m_HotelChainID;
public long M_HotelChainID
{
get{ return _m_HotelChainID;}
set{_m_HotelChainID = value;}
}
private string  _keyword;
public string Keyword
{
get{ return _keyword;}
set{_keyword = value;}
}
private bool?  _startwith;
public bool? Startwith
{
get{ return _startwith;}
set{_startwith = value;}
}
private bool?  _endwith;
public bool? Endwith
{
get{ return _endwith;}
set{_endwith = value;}
}
private bool?  _contain;
public bool? Contain
{
get{ return _contain;}
set{_contain = value;}
}
public override string Table { get { return "M_HotelChain_Keyword"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_M_HotelChain_Keyword_InsertOrUpdate"; } }
}
public enum M_HotelChain_KeywordColumns
{
ID,
M_HotelChainID,
Keyword,
Startwith,
Endwith,
Contain,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum M_HotelChain_KeywordProcedure
{

}
public class M_HotelChain_KeywordList : List<M_HotelChain_Keyword>
{

}
}