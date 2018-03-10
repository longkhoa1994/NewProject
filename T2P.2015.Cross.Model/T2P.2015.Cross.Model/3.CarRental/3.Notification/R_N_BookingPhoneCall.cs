using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class R_N_BookingPhoneCall : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long  _r_B_AccessID;
public long R_B_AccessID
{
get{ return _r_B_AccessID;}
set{_r_B_AccessID = value;}
}
private long  _r_N_PhoneCallID;
public long R_N_PhoneCallID
{
get{ return _r_N_PhoneCallID;}
set{_r_N_PhoneCallID = value;}
}
private long?  _r_N_TaskID;
public long? R_N_TaskID
{
get{ return _r_N_TaskID;}
set{_r_N_TaskID = value;}
}
private string  _comment;
public string Comment
{
get{ return _comment;}
set{_comment = value;}
}
public override string Table { get { return "R_N_BookingPhoneCall"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_R_N_BookingPhoneCall_InsertOrUpdate"; } }
}
public enum R_N_BookingPhoneCallColumns
{
ID,
R_B_AccessID,
R_N_PhoneCallID,
R_N_TaskID,
Comment,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum R_N_BookingPhoneCallProcedure
{

}
public class R_N_BookingPhoneCallList : List<R_N_BookingPhoneCall>
{

}
}