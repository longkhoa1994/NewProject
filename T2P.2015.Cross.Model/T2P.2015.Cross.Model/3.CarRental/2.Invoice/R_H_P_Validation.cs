using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class R_H_P_Validation : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long?  _r_F_TransactionID;
public long? R_F_TransactionID
{
get{ return _r_F_TransactionID;}
set{_r_F_TransactionID = value;}
}
private long?  _r_H_I_DataID;
public long? R_H_I_DataID
{
get{ return _r_H_I_DataID;}
set{_r_H_I_DataID = value;}
}
private int?  _result;
public int? Result
{
get{ return _result;}
set{_result = value;}
}
public override string Table { get { return "R_H_P_Validation"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_R_H_P_Validation_InsertOrUpdate"; } }
}
public enum R_H_P_ValidationColumns
{
ID,
R_F_TransactionID,
R_H_I_DataID,
Result,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum R_H_P_ValidationProcedure
{

}
public class R_H_P_ValidationList : List<R_H_P_Validation>
{

}
}