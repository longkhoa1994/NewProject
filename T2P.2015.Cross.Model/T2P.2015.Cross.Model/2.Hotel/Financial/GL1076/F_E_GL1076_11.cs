using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model 
{
[Serializable]
public class F_E_GL1076_11 : BaseModel
{
private long  _iD;
public long ID
{
get{ return _iD;}
set{_iD = value;}
}
private string  _recordType;
public string RecordType
{
get{ return _recordType;}
set{_recordType = value;}
}
private long _f_E_GL1076_01ID;

public long F_E_GL1076_01ID
{
    get { return _f_E_GL1076_01ID; }
    set { _f_E_GL1076_01ID = value; }
}

private string  _lIDTransactionID;
public string LIDTransactionID
{
get{ return _lIDTransactionID;}
set{_lIDTransactionID = value;}
}
private string  _filler;
public string Filler
{
get{ return _filler;}
set{_filler = value;}
}
private int?  _lIDLineID;
public int? LIDLineID
{
get{ return _lIDLineID;}
set{_lIDLineID = value;}
}
private int?  _lineIdentifier;
public int? LineIdentifier
{
get{ return _lineIdentifier;}
set{_lineIdentifier = value;}
}
private string  _totalTaxableAmountSignIndicator;
public string TotalTaxableAmountSignIndicator
{
get{ return _totalTaxableAmountSignIndicator;}
set{_totalTaxableAmountSignIndicator = value;}
}
private decimal?  _totalTaxableAmount;
public decimal? TotalTaxableAmount
{
get{ return _totalTaxableAmount;}
set{_totalTaxableAmount = value;}
}
private string  _totalTaxSignIndicator;
public string TotalTaxSignIndicator
{
get{ return _totalTaxSignIndicator;}
set{_totalTaxSignIndicator = value;}
}
private decimal?  _totalTaxAmount;
public decimal? TotalTaxAmount
{
get{ return _totalTaxAmount;}
set{_totalTaxAmount = value;}
}
private decimal?  _totalTaxRate;
public decimal? TotalTaxRate
{
get{ return _totalTaxRate;}
set{_totalTaxRate = value;}
}
private string  _totalTaxExemptCode;
public string TotalTaxExemptCode
{
get{ return _totalTaxExemptCode;}
set{_totalTaxExemptCode = value;}
}
private string  _valueAddedTaxSignIndicator;
public string ValueAddedTaxSignIndicator
{
get{ return _valueAddedTaxSignIndicator;}
set{_valueAddedTaxSignIndicator = value;}
}
private decimal?  _valueAddedTaxAmount;
public decimal? ValueAddedTaxAmount
{
get{ return _valueAddedTaxAmount;}
set{_valueAddedTaxAmount = value;}
}
private string  _valueAddedTaxRate;
public string ValueAddedTaxRate
{
get{ return _valueAddedTaxRate;}
set{_valueAddedTaxRate = value;}
}
private string  _valueAddedTaxExemptCode;
public string ValueAddedTaxExemptCode
{
get{ return _valueAddedTaxExemptCode;}
set{_valueAddedTaxExemptCode = value;}
}
private string  _goodsandServicesTaxSignIndicator;
public string GoodsandServicesTaxSignIndicator
{
get{ return _goodsandServicesTaxSignIndicator;}
set{_goodsandServicesTaxSignIndicator = value;}
}
private decimal?  _goodsandServicesTaxAmount;
public decimal? GoodsandServicesTaxAmount
{
get{ return _goodsandServicesTaxAmount;}
set{_goodsandServicesTaxAmount = value;}
}
private decimal?  _goodsandServicesTaxRate;
public decimal? GoodsandServicesTaxRate
{
get{ return _goodsandServicesTaxRate;}
set{_goodsandServicesTaxRate = value;}
}
private string  _goodsandServicesTaxExemptCode;
public string GoodsandServicesTaxExemptCode
{
get{ return _goodsandServicesTaxExemptCode;}
set{_goodsandServicesTaxExemptCode = value;}
}
private string  _provincialSalesTaxSignIndicator;
public string ProvincialSalesTaxSignIndicator
{
get{ return _provincialSalesTaxSignIndicator;}
set{_provincialSalesTaxSignIndicator = value;}
}
private decimal?  _provincialSalesTaxAmount;
public decimal? ProvincialSalesTaxAmount
{
get{ return _provincialSalesTaxAmount;}
set{_provincialSalesTaxAmount = value;}
}
private decimal?  _provincialSalesTaxRate;
public decimal? ProvincialSalesTaxRate
{
get{ return _provincialSalesTaxRate;}
set{_provincialSalesTaxRate = value;}
}
private string  _provincialSalesTaxExemptCode;
public string ProvincialSalesTaxExemptCode
{
get{ return _provincialSalesTaxExemptCode;}
set{_provincialSalesTaxExemptCode = value;}
}
private string  _quebecSalesTaxSignIndicator;
public string QuebecSalesTaxSignIndicator
{
get{ return _quebecSalesTaxSignIndicator;}
set{_quebecSalesTaxSignIndicator = value;}
}
private decimal?  _quebecSalesTaxAmount;
public decimal? QuebecSalesTaxAmount
{
get{ return _quebecSalesTaxAmount;}
set{_quebecSalesTaxAmount = value;}
}
private decimal?  _quebecSalesTaxRate;
public decimal? QuebecSalesTaxRate
{
get{ return _quebecSalesTaxRate;}
set{_quebecSalesTaxRate = value;}
}
private string  _quebecSalesTaxExemptCode;
public string QuebecSalesTaxExemptCode
{
get{ return _quebecSalesTaxExemptCode;}
set{_quebecSalesTaxExemptCode = value;}
}
private string  _harmonisedSalesTaxSignIndicator;
public string HarmonisedSalesTaxSignIndicator
{
get{ return _harmonisedSalesTaxSignIndicator;}
set{_harmonisedSalesTaxSignIndicator = value;}
}
private decimal?  _harmonisedSalesTaxAmount;
public decimal? HarmonisedSalesTaxAmount
{
get{ return _harmonisedSalesTaxAmount;}
set{_harmonisedSalesTaxAmount = value;}
}
private decimal?  _harmonisedSalesTaxRate;
public decimal? HarmonisedSalesTaxRate
{
get{ return _harmonisedSalesTaxRate;}
set{_harmonisedSalesTaxRate = value;}
}
private string  _harmonisedSalesTaxExemptCode;
public string HarmonisedSalesTaxExemptCode
{
get{ return _harmonisedSalesTaxExemptCode;}
set{_harmonisedSalesTaxExemptCode = value;}
}
private string  _tax1TaxableAmountSignIndicator;
public string Tax1TaxableAmountSignIndicator
{
get{ return _tax1TaxableAmountSignIndicator;}
set{_tax1TaxableAmountSignIndicator = value;}
}
private decimal?  _tax1TaxableAmount;
public decimal? Tax1TaxableAmount
{
get{ return _tax1TaxableAmount;}
set{_tax1TaxableAmount = value;}
}
private string  _tax1SignIndicator;
public string Tax1SignIndicator
{
get{ return _tax1SignIndicator;}
set{_tax1SignIndicator = value;}
}
private decimal?  _tax1TaxAmount;
public decimal? Tax1TaxAmount
{
get{ return _tax1TaxAmount;}
set{_tax1TaxAmount = value;}
}
private decimal?  _tax1TaxRate;
public decimal? Tax1TaxRate
{
get{ return _tax1TaxRate;}
set{_tax1TaxRate = value;}
}
private string  _tax1TaxExemptCode;
public string Tax1TaxExemptCode
{
get{ return _tax1TaxExemptCode;}
set{_tax1TaxExemptCode = value;}
}
private string  _tax2TaxableAmountSignIndicator;
public string Tax2TaxableAmountSignIndicator
{
get{ return _tax2TaxableAmountSignIndicator;}
set{_tax2TaxableAmountSignIndicator = value;}
}
private decimal?  _tax2TaxableAmount;
public decimal? Tax2TaxableAmount
{
get{ return _tax2TaxableAmount;}
set{_tax2TaxableAmount = value;}
}
private string  _tax2TaxSignIndicator;
public string Tax2TaxSignIndicator
{
get{ return _tax2TaxSignIndicator;}
set{_tax2TaxSignIndicator = value;}
}
private decimal?  _tax2TaxAmount;
public decimal? Tax2TaxAmount
{
get{ return _tax2TaxAmount;}
set{_tax2TaxAmount = value;}
}
private decimal?  _tax2TaxRate;
public decimal? Tax2TaxRate
{
get{ return _tax2TaxRate;}
set{_tax2TaxRate = value;}
}
private string  _tax2TaxExemptCode;
public string Tax2TaxExemptCode
{
get{ return _tax2TaxExemptCode;}
set{_tax2TaxExemptCode = value;}
}
private string  _tax3TaxableAmountSignIndicator;
public string Tax3TaxableAmountSignIndicator
{
get{ return _tax3TaxableAmountSignIndicator;}
set{_tax3TaxableAmountSignIndicator = value;}
}
private decimal?  _tax3TaxableAmount;
public decimal? Tax3TaxableAmount
{
get{ return _tax3TaxableAmount;}
set{_tax3TaxableAmount = value;}
}
private string  _tax3TaxSignIndicator;
public string Tax3TaxSignIndicator
{
get{ return _tax3TaxSignIndicator;}
set{_tax3TaxSignIndicator = value;}
}
private decimal?  _tax3TaxAmount;
public decimal? Tax3TaxAmount
{
get{ return _tax3TaxAmount;}
set{_tax3TaxAmount = value;}
}
private decimal?  _tax3TaxRate;
public decimal? Tax3TaxRate
{
get{ return _tax3TaxRate;}
set{_tax3TaxRate = value;}
}
private string  _tax3TaxExemptCode;
public string Tax3TaxExemptCode
{
get{ return _tax3TaxExemptCode;}
set{_tax3TaxExemptCode = value;}
}
private string  _tax4TaxableAmountSignIndicator;
public string Tax4TaxableAmountSignIndicator
{
get{ return _tax4TaxableAmountSignIndicator;}
set{_tax4TaxableAmountSignIndicator = value;}
}
private decimal?  _tax4TaxableAmount;
public decimal? Tax4TaxableAmount
{
get{ return _tax4TaxableAmount;}
set{_tax4TaxableAmount = value;}
}
private string  _tax4TaxSignIndicator;
public string Tax4TaxSignIndicator
{
get{ return _tax4TaxSignIndicator;}
set{_tax4TaxSignIndicator = value;}
}
private decimal?  _tax4TaxAmount;
public decimal? Tax4TaxAmount
{
get{ return _tax4TaxAmount;}
set{_tax4TaxAmount = value;}
}
private decimal?  _tax4TaxRate;
public decimal? Tax4TaxRate
{
get{ return _tax4TaxRate;}
set{_tax4TaxRate = value;}
}
private string  _tax4TaxExemptCode;
public string Tax4TaxExemptCode
{
get{ return _tax4TaxExemptCode;}
set{_tax4TaxExemptCode = value;}
}
private string  _filler2;
public string Filler2
{
get{ return _filler2;}
set{_filler2 = value;}
}
private long  _updatedby;
public long Updatedby
{
get{ return _updatedby;}
set{_updatedby = value;}
}
public override string Table { get { return "F_E_GL1076_11"; } }
public override string PrimaryKey { get { return ID.ToString(); } }
public override string InsertUpdateProcedure { get { return "p_F_E_GL1076_11_InsertOrUpdate"; } }
}
public enum F_E_GL1076_11Columns
{
ID,
RecordType,
F_E_GL1076_01ID,
LIDTransactionID,
Filler,
LIDLineID,
LineIdentifier,
TotalTaxableAmountSignIndicator,
TotalTaxableAmount,
TotalTaxSignIndicator,
TotalTaxAmount,
TotalTaxRate,
TotalTaxExemptCode,
ValueAddedTaxSignIndicator,
ValueAddedTaxAmount,
ValueAddedTaxRate,
ValueAddedTaxExemptCode,
GoodsandServicesTaxSignIndicator,
GoodsandServicesTaxAmount,
GoodsandServicesTaxRate,
GoodsandServicesTaxExemptCode,
ProvincialSalesTaxSignIndicator,
ProvincialSalesTaxAmount,
ProvincialSalesTaxRate,
ProvincialSalesTaxExemptCode,
QuebecSalesTaxSignIndicator,
QuebecSalesTaxAmount,
QuebecSalesTaxRate,
QuebecSalesTaxExemptCode,
HarmonisedSalesTaxSignIndicator,
HarmonisedSalesTaxAmount,
HarmonisedSalesTaxRate,
HarmonisedSalesTaxExemptCode,
Tax1TaxableAmountSignIndicator,
Tax1TaxableAmount,
Tax1SignIndicator,
Tax1TaxAmount,
Tax1TaxRate,
Tax1TaxExemptCode,
Tax2TaxableAmountSignIndicator,
Tax2TaxableAmount,
Tax2TaxSignIndicator,
Tax2TaxAmount,
Tax2TaxRate,
Tax2TaxExemptCode,
Tax3TaxableAmountSignIndicator,
Tax3TaxableAmount,
Tax3TaxSignIndicator,
Tax3TaxAmount,
Tax3TaxRate,
Tax3TaxExemptCode,
Tax4TaxableAmountSignIndicator,
Tax4TaxableAmount,
Tax4TaxSignIndicator,
Tax4TaxAmount,
Tax4TaxRate,
Tax4TaxExemptCode,
Filler2,
CreatedDate,
CreatedBy,
UpdatedDate,
Updatedby,
Status,
}
public enum F_E_GL1076_11Procedure
{
    p_F_E_GL1076_11_Get_By_F_E_GL_1076_01ID,
}
public class F_E_GL1076_11List : List<F_E_GL1076_11>
{

}
}