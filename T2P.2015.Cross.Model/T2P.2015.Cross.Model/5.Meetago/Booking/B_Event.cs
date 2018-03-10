using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_Event : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long b_HeaderID;

        public long B_HeaderID
        {
            get { return b_HeaderID; }
            set { b_HeaderID = value; }
        }

        private string _eventNo;

        public string EventNo
        {
            get { return _eventNo; }
            set { _eventNo = value; }
        }

        private string _eventTitle;

        public string EventTitle
        {
            get { return _eventTitle; }
            set { _eventTitle = value; }
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

        public override string Table { get { return "B_Event"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_Event_InsertOrUpdate"; } }
    }

    public class Policies
    {
        public string terms { get; set; }
        public Cancel cancel { get; set; }

        public string deposit { get; set; }
        public string info { get; set; }

        public List<CancelSource> CancelSource { get; set; }
    }

    public class CancelSource
    {
        public string baseSource { get; set; }

        public string type { get; set; }
        public string days { get; set; }
        public string time { get; set; }
        public string percent { get; set; }
    }

    public class Cancel
    {
        public string preText { get; set; }

        public string cancel { get; set; }

        public string postText { get; set; }
    }

    public enum B_EventColumns
    {
        ID,
        EventTitle,
        StartDate,
        EndDate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_EventProcedure
    {
        p_B_EventBooking_GetSearch,
        p_B_Event_GetByEventNo,
        p_B_EventBooking_GetSearch_GetTotal,
        p_B_Event_GetByID,
        p_B_Event_GetInfomation,
        p_B_EventBooking_GetDetail,
        p_B_Event_ContractListing,
        p_B_EventBooking_GetDataContract_Package,
        p_B_EventBooking_GetDataContract_Room,
        p_B_EventBooking_GetDataInvoicePosition,
        p_B_EventBooking_GetDataInvoiceTax,
        p_B_EventBooking_GetDataContract,

        p_B_Event_GetBy_B_ContractID,
        p_B_EventBooking_GetDataContract_By_B_AcessID,
        p_MG_GetDashboardData,
        p_B_Event_GetTopBookingCities,
        p_B_Event_GetTopBookingCountries,
        p_B_Event_StatisticBookingByStatus,
        p_B_EventBooking_GetContract_Combine
    }

    public class B_EventList : List<B_Event>
    {
    }
}