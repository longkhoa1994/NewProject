using System;

namespace T2P._2015.Cross.Model.Process
{
    public class DateRange
    {
        public DateTime? From { get; set; }

        public DateTime? To { get; set; }
    }

    public class Pagination
    {
        public int Page { get; set; }

        public int PageSize { get; set; }

        public long TotalRecord { get; set; }

        public string OrderBy { get; set; }

        public string OrderDirection { get; set; }

        public string RecordInfo { get; set; }

        public Pagination()
        {
            Page = 1;
            PageSize = 10;
            TotalRecord = 0;
            OrderBy = string.Empty;
            OrderDirection = "ASC";
            RecordInfo = string.Empty;
        }
    }
}