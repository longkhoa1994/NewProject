using System;

namespace T2P._2015.Cross.Model._1.Common.Master
{
    [Serializable]
    public class M_HotelPlatformServiceSchedule : BaseModel
    {
        public long ID { get; set; }
        public long M_HotelPlatformServiceSettingID { get; set; }
        public long? M_NotificationTemplateID { get; set; }
        public string DeliveryFequency { get; set; }
        public string DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }
        public string DeliveryType { get; set; }
        public float? ExpireDate { get; set; }
        public string FilenameFormat { get; set; }

        public override string Table { get { return "M_HotelPlatformServiceSchedule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelPlatformServiceSchedule_InsertOrUpdate"; } }
    }

    public enum M_HotelPlatformServiceScheduleColumns
    {
        ID,
        M_HotelPlatformServiceSettingID,
        M_NotificationTemplateID,
        DeliveryFequency,
        DeliveryDate,
        DeliveryTime,
        DeliveryType,
        ExpireDate,
        FilenameFormat,
        CreatedBy,
        CreatedDateTime,
        UpdatedBy,
        UpdatedDateTime,
        Status,
    }

    public enum M_HotelPlatformServiceScheduleProcedure
    {
        p_CFM_GetTimeExport_FileCSV,
        p_M_HotelPlatformServiceSchedule_Get_ByName
    }
}