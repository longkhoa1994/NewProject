using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class M_RateGridCondition_Raw : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private string  _country;
public string Country
{
get{ return _country;}
set{_country = value;}
}
private string  _condition;
public string Condition
{
get{ return _condition;}
set{_condition = value;}
}
private string  _value;
public string Value
{
get{ return _value;}
set{_value = value;}
}
public override string Table { get { return "M_RateGridCondition_Raw"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_M_RateGridCondition_Raw_InsertOrUpdate"; } }
}
public enum M_RateGridCondition_RawColumns
{
ID,
Country,
Condition,
Value,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum M_RateGridCondition_RawProcedure
{

}
public class M_RateGridCondition_RawList : List<M_RateGridCondition_Raw>
{

}
}