using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class R_I_ImageDelivery : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long  _r_I_DeliveryNotificationID;
public long R_I_DeliveryNotificationID
{
get{ return _r_I_DeliveryNotificationID;}
set{_r_I_DeliveryNotificationID = value;}
}
private long  _r_I_ImageID;
public long R_I_ImageID
{
get{ return _r_I_ImageID;}
set{_r_I_ImageID = value;}
}
public override string Table { get { return "R_I_ImageDelivery"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_R_I_ImageDelivery_InsertOrUpdate"; } }
}
public enum R_I_ImageDeliveryColumns
{
ID,
R_I_DeliveryNotificationID,
R_I_ImageID,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum R_I_ImageDeliveryProcedure
{
    p_R_I_Image_GetListForDeliveryImage
}
public class R_I_ImageDeliveryList : List<R_I_ImageDelivery>
{

}
}