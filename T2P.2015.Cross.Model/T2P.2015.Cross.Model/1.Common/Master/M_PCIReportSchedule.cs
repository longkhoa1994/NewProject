using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_PCIReportSchedule : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _frequency;
        public string Frequency
        {
            get { return _frequency; }
            set { _frequency = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _emailCC;
        public string EmailCC
        {
            get { return _emailCC; }
            set { _emailCC = value; }
        }
        public DateTime LastExportDate { get; set; }
        public DateTime NextExportDate { get; set; }
        public override string Table { get { return "M_PCIReportSchedule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_PCIReportSchedule_InsertOrUpdate"; } }
    }
    public enum M_PCIReportScheduleColumns
    {
        ID,
        Frequency,
        Email,
        EmailCC,
        LastExportDate,
        NextExportDate,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_PCIReportScheduleProcedure
    {
        p_M_PCIReportSchedule_GetSchedule,
        p_M_PCIReportSchedule_GetByType
    }
    public class M_PCIReportScheduleList : List<M_PCIReportSchedule>
    {

    }

    public enum FrequencyEnum
    {
        Weekly,
        Monthly
    }
}