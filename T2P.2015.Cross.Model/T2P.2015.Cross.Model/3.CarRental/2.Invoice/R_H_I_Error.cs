using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class R_H_I_Error : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long?  _r_H_I_DataID;
public long? R_H_I_DataID
{
get{ return _r_H_I_DataID;}
set{_r_H_I_DataID = value;}
}
private long?  _r_I_ServiceID;
public long? R_I_ServiceID
{
get{ return _r_I_ServiceID;}
set{_r_I_ServiceID = value;}
}
private long?  _r_M_InvoiceErrorCodeID;
public long? R_M_InvoiceErrorCodeID
{
get{ return _r_M_InvoiceErrorCodeID;}
set{_r_M_InvoiceErrorCodeID = value;}
}
private string  _comment;
public string Comment
{
get{ return _comment;}
set{_comment = value;}
}
public override string Table { get { return "R_H_I_Error"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_R_H_I_Error_InsertOrUpdate"; } }
}
public enum R_H_I_ErrorColumns
{
ID,
R_H_I_DataID,
R_I_ServiceID,
R_M_InvoiceErrorCodeID,
Comment,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum R_H_I_ErrorProcedure
{

}
public class R_H_I_ErrorList : List<R_H_I_Error>
{

}
}