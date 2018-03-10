using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._2.Hotel.Notification
{
    public class P_OverviewHRSServiceDeskCapture : BaseModel
    {
        public long ID { get; set; }
        public long UserID { get; set; }
        public long N_TaskID { get; set; }
        public string GroupName { get; set; }
        public string UserNameTask { get; set; }
        public string UserName { get; set; }
        public int Priority { get; set; }
        public long AssignedTo { get; set; }
        public long Overdue { get; set; }
        public string TaskType { get; set; }

        public override string Table { get { return "P_OverviewHRSServiceDeskCapture"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_P_OverviewHRSServiceDeskCapture_InsertOrUpdate"; } }
    }
    public enum P_OverviewHRSServiceDeskCaptureColumns
    {
        ID,
        Group,
        TaskType,
        Username,
        Priority1,
        Priority2,
        Priority3,
        Priority4,
        Priority5,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum P_OverviewHRSServiceDeskCaptureProcedure
    {
        p_P_GetDateServiceDesk_ByCreatedDate
    }
   
}
