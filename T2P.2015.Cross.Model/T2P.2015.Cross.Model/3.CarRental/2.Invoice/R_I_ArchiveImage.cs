using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class R_I_ArchiveImage : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long?  _i_ArchiveID;
public long? I_ArchiveID
{
get{ return _i_ArchiveID;}
set{_i_ArchiveID = value;}
}
private long?  _r_I_ImageID;
public long? R_I_ImageID
{
get{ return _r_I_ImageID;}
set{_r_I_ImageID = value;}
}
public override string Table { get { return "R_I_ArchiveImage"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_R_I_ArchiveImage_InsertOrUpdate"; } }
}
public enum R_I_ArchiveImageColumns
{
ID,
I_ArchiveID,
R_I_ImageID,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum R_I_ArchiveImageProcedure
{

}
public class R_I_ArchiveImageList : List<R_I_ArchiveImage>
{

}
}