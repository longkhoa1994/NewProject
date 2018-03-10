using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Notification
{
    public class P_OverviewHRSServiceDeskOverdueCapture : BaseModel
    {
        public long ID { get; set; }
        public string RangeCode {get;set;}
        public string Total { get; set; }
        public string Username { get; set; }
        public string TimeCall { get; set; }
        public override string Table { get { return "P_OverviewHRSServiceDeskOverdueCapture"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_P_OverviewHRSServiceDeskOverdueCapture_InsertOrUpdate"; } }
    }
    public enum P_OverviewHRSServiceDeskOverdueCaptureColumns
    {
        ID,
        RangeCode,
        RangeText,
        TotalOverdue,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum P_OverviewHRSServiceDeskOverdueCaptureProcedure
    {
        p_P_GetDataOverviewHRSBy_CreatedDate
    }
}
