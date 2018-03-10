using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class F_E_ExportFileHistory : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _f_E_ExportFileID;
        public long F_E_ExportFileID
        {
            get { return _f_E_ExportFileID; }
            set { _f_E_ExportFileID = value; }
        }
        private string _reservationNo;
        public string ReservationNo
        {
            get { return _reservationNo; }
            set { _reservationNo = value; }
        }
        private decimal _grossAmount;
        public decimal GrossAmount
        {
            get { return _grossAmount; }
            set { _grossAmount = value; }
        }

        private string _currencyCode;

        public string CurrencyCode
        {
            get { return _currencyCode; }
            set { _currencyCode = value; }
        }
        private string _hotelName;
        public string HotelName
        {
            get { return _hotelName; }
            set { _hotelName = value; }
        }
        private string _financialStatus;
        public string FinancialStatus
        {
            get { return _financialStatus; }
            set { _financialStatus = value; }
        }
        private long _updatedby;
        public long Updatedby
        {
            get { return _updatedby; }
            set { _updatedby = value; }
        }
        public override string Table { get { return "F_E_ExportFileHistory"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_F_E_ExportFileHistory_InsertOrUpdate"; } }
    }
    public enum F_E_ExportFileHistoryColumns
    {
        ID,
        F_E_ExportFileID,
        ReservationNo,
        GrossAmount,
        HotelName,
        FinancialStatus,
        CreatedBy,
        CreatedDate,
        Updatedby,
        UpdatedDate,
        Status,
    }
    public enum F_E_ExportFileHistoryProcedure
    {

    }
    public class F_E_ExportFileHistoryList : List<F_E_ExportFileHistory>
    {

    }
}