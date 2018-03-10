using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class M_ErrorCodeCategory : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
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
private string  _type;
public string Type
{
get{ return _type;}
set{_type = value;}
}
public override string Table { get { return "M_ErrorCodeCategory"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_M_ErrorCodeCategory_InsertOrUpdate"; } }
}
public enum M_ErrorCodeCategoryColumns
{
ID,
Name,
Description,
Type,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum M_ErrorCodeCategoryProcedure
{

}
public class M_ErrorCodeCategoryList : List<M_ErrorCodeCategory>
{

}
}