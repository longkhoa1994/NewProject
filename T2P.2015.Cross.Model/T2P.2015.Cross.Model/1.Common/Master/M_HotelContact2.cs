using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class M_HotelContact2 : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long  _m_Hotel2ID;
public long M_Hotel2ID
{
    get { return _m_Hotel2ID; }
    set { _m_Hotel2ID = value; }
}
private string  _salutation;
public string Salutation
{
get{ return _salutation;}
set{_salutation = value;}
}
private string  _firstName;
public string FirstName
{
get{ return _firstName;}
set{_firstName = value;}
}
private string  _lastName;
public string LastName
{
get{ return _lastName;}
set{_lastName = value;}
}
private string  _phoneNumber;
public string PhoneNumber
{
get{ return _phoneNumber;}
set{_phoneNumber = value;}
}
private string  _cellPhone;
public string CellPhone
{
get{ return _cellPhone;}
set{_cellPhone = value;}
}
private string  _extensionNumber;
public string ExtensionNumber
{
get{ return _extensionNumber;}
set{_extensionNumber = value;}
}
private string  _position;
public string Position
{
get{ return _position;}
set{_position = value;}
}
private string  _skype;
public string Skype
{
get{ return _skype;}
set{_skype = value;}
}
private string  _fax;
public string Fax
{
get{ return _fax;}
set{_fax = value;}
}
private string  _comment;
public string Comment
{
get{ return _comment;}
set{_comment = value;}
}
private string  _email;
public string Email
{
get{ return _email;}
set{_email = value;}
}
private bool  _isDefault;
public bool IsDefault
{
get{ return _isDefault;}
set{_isDefault = value;}
}
public override string Table { get { return "M_HotelContact2"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_M_HotelContact2_InsertOrUpdate"; } }
}
public enum M_HotelContact2Columns
{
ID,
M_Hotel2ID,
Salutation,
FirstName,
LastName,
PhoneNumber,
CellPhone,
ExtensionNumber,
Position,
Skype,
Fax,
Comment,
Email,
IsDefault,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum M_HotelContact2Procedure
{

}
public class M_HotelContact2List : List<M_HotelContact2>
{

}
}