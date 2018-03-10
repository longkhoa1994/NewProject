using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class R_M_ProviderProcess : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long  _m_CarRentalProviderID;
public long M_CarRentalProviderID
{
get{ return _m_CarRentalProviderID;}
set{_m_CarRentalProviderID = value;}
}
private string  _process;
public string Process
{
get{ return _process;}
set{_process = value;}
}
public override string Table { get { return "R_M_ProviderProcess"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_R_M_ProviderProcess_InsertOrUpdate"; } }
}
public enum R_M_ProviderProcessColumns
{
ID,
M_CarRentalProviderID,
Process,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum R_M_ProviderProcessProcedure
{

}
public class R_M_ProviderProcessList : List<R_M_ProviderProcess>
{

}
}