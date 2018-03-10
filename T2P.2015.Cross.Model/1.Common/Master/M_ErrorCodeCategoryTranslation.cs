using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class M_ErrorCodeCategoryTranslation : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long  _m_ErrorCodeCategoryID;
public long M_ErrorCodeCategoryID
{
get{ return _m_ErrorCodeCategoryID;}
set{_m_ErrorCodeCategoryID = value;}
}
private long  _m_LanguageID;
public long M_LanguageID
{
get{ return _m_LanguageID;}
set{_m_LanguageID = value;}
}
private string  _name;
public string Name
{
get{ return _name;}
set{_name = value;}
}
private string  _description;
public string Description
{
get{ return _description;}
set{_description = value;}
}
public override string Table { get { return "M_ErrorCodeCategoryTranslation"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_M_ErrorCodeCategoryTranslation_InsertOrUpdate"; } }
}
public enum M_ErrorCodeCategoryTranslationColumns
{
ID,
M_ErrorCodeCategoryID,
M_LanguageID,
Name,
Description,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum M_ErrorCodeCategoryTranslationProcedure
{

}
public class M_ErrorCodeCategoryTranslationList : List<M_ErrorCodeCategoryTranslation>
{

}
}