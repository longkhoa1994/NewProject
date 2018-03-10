using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_BIReport_Item : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _c_BIReport_HeaderID;
        public long C_BIReport_HeaderID
        {
            get { return _c_BIReport_HeaderID; }
            set { _c_BIReport_HeaderID = value; }
        }
        private DateTime? _startDate;
        public DateTime? StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        private DateTime? _endDate;
        public DateTime? EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        private string _bookingNo;
        public string BookingNo
        {
            get { return _bookingNo; }
            set { _bookingNo = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public override string Table { get { return "C_BIReport_Item"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_BIReport_Item_InsertOrUpdate"; } }
    }
    public enum C_BIReport_ItemColumns
    {
        ID,
        C_BIReport_HeaderID,
        StartDate,
        EndDate,
        BookingNo,
        Email,
        CreatedBy,
        CreatedDateTime,
        UpdatedBy,
        UpdatedDateTime,
        Status,
    }
    public enum C_BIReport_ItemProcedure
    {
        GetBIItemsMatched
    }
    public class C_BIReport_ItemList : List<C_BIReport_Item>
    {

    }
}