using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class R_F_Relation : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private string  _documentNo;
public string DocumentNo
{
get{ return _documentNo;}
set{_documentNo = value;}
}
private long  _sourceTransactionID;
public long SourceTransactionID
{
get{ return _sourceTransactionID;}
set{_sourceTransactionID = value;}
}
private string  _typeS;
public string TypeS
{
get{ return _typeS;}
set{_typeS = value;}
}
private long  _desTransactionID;
public long DesTransactionID
{
get{ return _desTransactionID;}
set{_desTransactionID = value;}
}
private string  _typeD;
public string TypeD
{
get{ return _typeD;}
set{_typeD = value;}
}
private int  _type;
public int Type
{
get{ return _type;}
set{_type = value;}
}
public override string Table { get { return "R_F_Relation"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_R_F_Relation_InsertOrUpdate"; } }
}
public enum R_F_RelationColumns
{
ID,
DocumentNo,
SourceTransactionID,
TypeS,
DesTransactionID,
TypeD,
Type,
CreatedBy,
CreatedDate,
UpdatedBy,
UpdatedDate,
Status,
}
public enum R_F_RelationProcedure
{
    p_R_F_Relation_GetBy_TransactionID
}
public class R_F_RelationList : List<R_F_Relation>
{

}
}