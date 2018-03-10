using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.View
{
    public class V_Pagination
    {

        private int _page;

        public int Page
        {
            get { return _page; }
            set { _page = value; }
        }

        private int _pageSize;

        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }

        private string _orderBy;

        public string OrderBy
        {
            get { return _orderBy; }
            set { _orderBy = value; }
        }

        private string _orderDirection;

        public string OrderDirection
        {
            get { return _orderDirection; }
            set { _orderDirection = value; }
        }

        private string _recordInfo;

        public string RecordInfo
        {
            get { return _recordInfo; }
            set { _recordInfo = value; }
        }

        private long _totalRecord;

        public long TotalRecord
        {
            get { return _totalRecord; }
            set { _totalRecord = value; }
        }

        public V_Pagination()
        {
            Page = 1;
            PageSize = 10;
            TotalRecord = 0;
            OrderBy = string.Empty;
            OrderDirection = "ASC";
            RecordInfo = string.Empty;
        }
    }

    public class V_Pagination_ForMatching : V_Pagination
    {
        private int _pageMatched;

        public int PageMatched
        {
            get { return _pageMatched; }
            set { _pageMatched = value; }
        }

        private int _pageSizeMatched;

        public int PageSizeMatched
        {
            get { return _pageSizeMatched; }
            set { _pageSizeMatched = value; }
        }

        private string _orderByMatched;

        public string OrderByMatched
        {
            get { return _orderByMatched; }
            set { _orderByMatched = value; }
        }

        private string _orderDirectionMatched;

        public string OrderDirectionMatched
        {
            get { return _orderDirectionMatched; }
            set { _orderDirectionMatched = value; }
        }

        public V_Pagination_ForMatching()
        {
            PageMatched = 1;
            PageSizeMatched = 10;
            OrderByMatched = string.Empty;
            OrderDirectionMatched = "ASC";

        }
    }
    public class V_ArchiveInvoicePagination : V_Pagination
    {
        public string CompanyName { get; set; }
        public string DownloadedBy { get; set; }
        public bool? IsDownloaded { get; set; }
        public string FileName { get; set; }
        public DateTime? CreatedDateFrom { get; set; }
        public DateTime? CreatedDateTo { get; set; }
        public DateTime? InvoiceDateFrom { get; set; }
        public DateTime? InvoiceDateTo { get; set; }
        public DateTime? CheckoutDateFrom { get; set; }
        public DateTime? CheckoutDateTo { get; set; }
        public string BookingNo { get; set; }
        public string InvoiceNo { get; set; }
        public int Type { get; set; }
        public bool? IsExpired { get; set; }
        public long? CompanyID { get; set; }
        public int PlatformType { get; set; }
        public List<string> ListCompanyCode { get; set; }
        public bool IsFromAP { get; set; }
    }

    public class V_Pagination_ForDownloadCenter_FileDetail : V_Pagination
    {
        public long FileID { get; set; }
        public long[] ListFileIDs { get; set; }
        public bool IsFileType { get; set; }
        public int PlatformType { get; set; }
    }
}
