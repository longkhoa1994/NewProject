using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class R_I_DeliveryNotification : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private long  _r_M_NotificationTemplateID;
public long R_M_NotificationTemplateID
{
get{ return _r_M_NotificationTemplateID;}
set{_r_M_NotificationTemplateID = value;}
}
private long?  _r_M_FileLocationID;
public long? R_M_FileLocationID
{
get{ return _r_M_FileLocationID;}
set{_r_M_FileLocationID = value;}
}
private long?  _r_N_BillingEmailID;
public long? R_N_BillingEmailID
{
get{ return _r_N_BillingEmailID;}
set{_r_N_BillingEmailID = value;}
}
private string  _from;
public string From
{
get{ return _from;}
set{_from = value;}
}
private string  _to;
public string To
{
get{ return _to;}
set{_to = value;}
}
private string  _attachmentFileName;
public string AttachmentFileName
{
get{ return _attachmentFileName;}
set{_attachmentFileName = value;}
}
private string  _filePath;
public string FilePath
{
get{ return _filePath;}
set{_filePath = value;}
}
private string  _subject;
public string Subject
{
get{ return _subject;}
set{_subject = value;}
}
private string  _body;
public string Body
{
get{ return _body;}
set{_body = value;}
}
private string  _messageID;
public string MessageID
{
get{ return _messageID;}
set{_messageID = value;}
}
private string  _inReplyTo;
public string InReplyTo
{
get{ return _inReplyTo;}
set{_inReplyTo = value;}
}
private DateTime?  _sendDate;
public DateTime? SendDate
{
get{ return _sendDate;}
set{_sendDate = value;}
}
public override string Table { get { return "R_I_DeliveryNotification"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_R_I_DeliveryNotification_InsertOrUpdate"; } }
}
public enum R_I_DeliveryNotificationColumns
{
ID,
R_M_NotificationTemplateID,
R_M_FileLocationID,
R_N_BillingEmailID,
From,
To,
AttachmentFileName,
FilePath,
Subject,
Body,
MessageID,
InReplyTo,
SendDate,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum R_I_DeliveryNotificationProcedure
{

}
public class R_I_DeliveryNotificationList : List<R_I_DeliveryNotification>
{

}
}