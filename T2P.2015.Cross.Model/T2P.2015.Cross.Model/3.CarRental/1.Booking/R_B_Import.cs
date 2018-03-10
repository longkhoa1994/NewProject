using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class R_B_Import : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
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
private int?  _totalBooking;
public int? TotalBooking
{
get{ return _totalBooking;}
set{_totalBooking = value;}
}
private int?  _totalSuccess;
public int? TotalSuccess
{
get{ return _totalSuccess;}
set{_totalSuccess = value;}
}
private int?  _totalError;
public int? TotalError
{
get{ return _totalError;}
set{_totalError = value;}
}
public override string Table { get { return "R_B_Import"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_R_B_Import_InsertOrUpdate"; } }
}
public enum R_B_ImportColumns
{
ID,
M_FileLocationID,
FilePath,
FileName,
TotalBooking,
TotalSuccess,
TotalError,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum R_B_ImportProcedure
{

}
public class R_B_ImportList : List<R_B_Import>
{

}
}