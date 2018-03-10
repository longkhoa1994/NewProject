using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class M_UserGuide : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long?  _a_ObjectFunctionID;
public long? A_ObjectFunctionID
{
get{ return _a_ObjectFunctionID;}
set{_a_ObjectFunctionID = value;}
}
private long?  _m_LanguageID;
public long? M_LanguageID
{
get{ return _m_LanguageID;}
set{_m_LanguageID = value;}
}
private long?  _m_FileLocationID;
public long? M_FileLocationID
{
get{ return _m_FileLocationID;}
set{_m_FileLocationID = value;}
}
private string  _filePath;
public string FilePath
{
get{ return _filePath;}
set{_filePath = value;}
}
private string  _fileName;
public string FileName
{
get{ return _fileName;}
set{_fileName = value;}
}
private int?  _position;
public int? Position
{
get{ return _position;}
set{_position = value;}
}
public override string Table { get { return "M_UserGuide"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_M_UserGuide_InsertOrUpdate"; } }
}
public enum M_UserGuideColumns
{
ID,
A_ObjectFunctionID,
M_LanguageID,
M_FileLocationID,
FilePath,
FileName,
Position,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum M_UserGuideProcedure
{
    p_M_UserGuide_Update,
    p_M_UserGuide_Get
}
public class M_UserGuideList : List<M_UserGuide>
{

}
}