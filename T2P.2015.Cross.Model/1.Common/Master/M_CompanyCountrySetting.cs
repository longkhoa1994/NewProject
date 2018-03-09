using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class M_CompanyCountrySetting : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long  _m_CompanyID;
public long M_CompanyID
{
get{ return _m_CompanyID;}
set{_m_CompanyID = value;}
}
private long  _m_CountryID;
public long M_CountryID
{
get{ return _m_CountryID;}
set{_m_CountryID = value;}
}
private string  _setting;
public string Setting
{
get{ return _setting;}
set{_setting = value;}
}
public override string Table { get { return "M_CompanyCountrySetting"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_M_CompanyCountrySetting_InsertOrUpdate"; } }
}
public enum M_CompanyCountrySettingColumns
{
ID,
M_CompanyID,
M_CountryID,
Setting,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum M_CompanyCountrySettingProcedure
{

}
public class M_CompanyCountrySettingList : List<M_CompanyCountrySetting>
{

}

public enum M_CompanyCountrySettingType
{
    CANCELLATION_POLICY
}
}