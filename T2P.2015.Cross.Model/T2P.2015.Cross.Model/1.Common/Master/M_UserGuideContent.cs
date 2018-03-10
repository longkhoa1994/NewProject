using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class M_UserGuideContent : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long?  _m_UserGuideID;
public long? M_UserGuideID
{
get{ return _m_UserGuideID;}
set{_m_UserGuideID = value;}
}
private string  _hTMLText;
public string HTMLText
{
get{ return _hTMLText;}
set{_hTMLText = value;}
}
public override string Table { get { return "M_UserGuideContent"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_M_UserGuideContent_InsertOrUpdate"; } }
}
public enum M_UserGuideContentColumns
{
ID,
M_UserGuideID,
HTMLText,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum M_UserGuideContentProcedure
{
    p_M_UserGuideContent_GetByObjFunctionID
}
public class M_UserGuideContentList : List<M_UserGuideContent>
{

}
}