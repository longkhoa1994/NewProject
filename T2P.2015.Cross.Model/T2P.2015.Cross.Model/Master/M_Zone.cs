using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class M_Zone : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long  _m_TemplateID;
public long M_TemplateID
{
get{ return _m_TemplateID;}
set{_m_TemplateID = value;}
}
private string  _zoneName;
public string ZoneName
{
get{ return _zoneName;}
set{_zoneName = value;}
}
private string  _dataType;
public string DataType
{
get{ return _dataType;}
set{_dataType = value;}
}
private string  _format;
public string Format
{
get{ return _format;}
set{_format = value;}
}
private int  _x;
public int X
{
get{ return _x;}
set{_x = value;}
}
private int  _y;
public int Y
{
get{ return _y;}
set{_y = value;}
}
private int  _witdh;
public int Witdh
{
get{ return _witdh;}
set{_witdh = value;}
}
private int  _height;
public int Height
{
get{ return _height;}
set{_height = value;}
}
public override string Table { get { return "M_Zone"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_M_Zone_InsertOrUpdate"; } }
}
public enum M_ZoneColumns
{
ID,
M_TemplateID,
ZoneName,
DataType,
Format,
X,
Y,
Witdh,
Height,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum M_ZoneProcedure
{

}
public class M_ZoneList : List<M_Zone>
{

}
}