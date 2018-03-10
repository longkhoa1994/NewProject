using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.History
{
    [Serializable]
    public class H_I_Data : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _i_DataID;
        public long I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
        }
        private long? _i_ImportID;
        public long? I_ImportID
        {
            get { return _i_ImportID; }
            set { _i_ImportID = value; }
        }
        private long _i_ImageID;
        public long I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }
        private string _invoiceNo;
        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }
        private DateTime? _invoiceDate;
        public DateTime? InvoiceDate
        {
            get { return _invoiceDate; }
            set { _invoiceDate = value; }
        }
        private decimal? _grossAmount;
        public decimal? GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }
        private decimal? _netAmount;
        public decimal? NetAmount
        {
            get { return _netAmount; }
            set { _netAmount = value; }
        }
        private string _currencyCode;
        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }
        private string _vATIdenNumber;
        public string VATIdenNumber
        {
            get { return _vATIdenNumber; }
            set { _vATIdenNumber = value; }
        }
        private string _tAXIdenNumber;
        public string TAXIdenNumber
        {
            get { return _tAXIdenNumber; }
            set { _tAXIdenNumber = value; }
        }
        private DateTime? _checkInDate;
        public DateTime? CheckInDate
        {
            get { return _checkInDate; }
            set { _checkInDate = value; }
        }
        private DateTime? _checkOutDate;
        public DateTime? CheckOutDate
        {
            get { return _checkOutDate; }
            set { _checkOutDate = value; }
        }
        private string _imageFileName;
        public string ImageFileName
        {
            get { return _imageFileName; }
            set { _imageFileName = value; }
        }
        private int? _readyVTI;
        public int? ReadyVTI
        {
            get { return _readyVTI; }
            set { _readyVTI = value; }
        }
        private string _hotelVATNumber;
        public string HotelVATNumber
        {
            get { return _hotelVATNumber; }
            set { _hotelVATNumber = value; }
        }
        private int? _isParking;
        public int? IsParking
        {
            get { return _isParking; }
            set { _isParking = value; }
        }

        private string comment;

        public string Comment
        {
            get { return comment; }
            set { comment = value; }
        }
        public override string Table { get { return "H_I_Data"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_H_I_Data_InsertOrUpdate"; } }
    }
    public enum H_I_DataColumns
    {
        ID,
        I_DataID,
        I_ImportID,
        I_ImageID,
        InvoiceNo,
        InvoiceDate,
        GrossAmount,
        NetAmount,
        CurrencyCode,
        VATIdenNumber,
        TAXIdenNumber,
        CheckInDate,
        CheckOutDate,
        ImageFileName,
        ReadyVTI,
        HotelVATNumber,
        IsParking,
        Comment,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum H_I_DataProcedure
    {
        p_H_I_Data_InsertOrUpdate,
        p_H_I_Data_GetBy_I_DataID,
        p_H_I_Data_GetListByListI_DataID,
        p_H_I_Data_GetListForDeleting,
    }
    public class H_I_DataList : List<H_I_Data>
    {

    }
}
