using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class M_RateGrid_Raw : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private string  _provider;
public string Provider
{
get{ return _provider;}
set{_provider = value;}
}
private string  _country;
public string Country
{
get{ return _country;}
set{_country = value;}
}
private string  _carGroup;
public string CarGroup
{
get{ return _carGroup;}
set{_carGroup = value;}
}
private string  _fleet;
public string Fleet
{
get{ return _fleet;}
set{_fleet = value;}
}
private string  _fleetType;
public string FleetType
{
get{ return _fleetType;}
set{_fleetType = value;}
}
private string  _sIPP;
public string SIPP
{
get{ return _sIPP;}
set{_sIPP = value;}
}
private string  _vehicleType;
public string VehicleType
{
get{ return _vehicleType;}
set{_vehicleType = value;}
}
private string  _currency;
public string Currency
{
get{ return _currency;}
set{_currency = value;}
}
private string  _unit;
public string Unit
{
get{ return _unit;}
set{_unit = value;}
}
private string  _minUnit;
public string MinUnit
{
get{ return _minUnit;}
set{_minUnit = value;}
}
private string  _maxUnit;
public string MaxUnit
{
get{ return _maxUnit;}
set{_maxUnit = value;}
}
private string  _unitPrice;
public string UnitPrice
{
get{ return _unitPrice;}
set{_unitPrice = value;}
}
public override string Table { get { return "M_RateGrid_Raw"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_M_RateGrid_Raw_InsertOrUpdate"; } }
}
public enum M_RateGrid_RawColumns
{
ID,
Provider,
Country,
CarGroup,
Fleet,
FleetType,
SIPP,
VehicleType,
Currency,
Unit,
MinUnit,
MaxUnit,
UnitPrice,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum M_RateGrid_RawProcedure
{

}
public class M_RateGrid_RawList : List<M_RateGrid_Raw>
{

}
}