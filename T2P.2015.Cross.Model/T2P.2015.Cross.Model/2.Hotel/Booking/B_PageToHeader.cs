using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class B_PageToHeader : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long  _b_HeaderID;
public long B_HeaderID
{
get{ return _b_HeaderID;}
set{_b_HeaderID = value;}
}
private long  _n_AttachmentPageID;
public long N_AttachmentPageID
{
get{ return _n_AttachmentPageID;}
set{_n_AttachmentPageID = value;}
}
private int  _position;
public int Position
{
get{ return _position;}
set{_position = value;}
}
public override string Table { get { return "B_PageToHeader"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_B_PageToHeader_InsertOrUpdate"; } }
}
public enum B_PageToHeaderColumns
{
ID,
B_HeaderID,
N_AttachmentPageID,
Position,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum B_PageToHeaderProcedure
{

}
public class B_PageToHeaderList : List<B_PageToHeader>
{

}
}