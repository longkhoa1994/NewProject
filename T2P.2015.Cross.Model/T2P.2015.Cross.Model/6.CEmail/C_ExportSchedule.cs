using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class C_ExportSchedule : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _m_CompanyProcessID;
        public long M_CompanyProcessID
        {
            get { return _m_CompanyProcessID; }
            set { _m_CompanyProcessID = value; }
        }
        private string _deliveryFequency;
        public string DeliveryFequency
        {
            get { return _deliveryFequency; }
            set { _deliveryFequency = value; }
        }
        private string _deliveryDate;
        public string DeliveryDate
        {
            get { return _deliveryDate; }
            set { _deliveryDate = value; }
        }
        private string _deliveryTime;
        public string DeliveryTime
        {
            get { return _deliveryTime; }
            set { _deliveryTime = value; }
        }
        private string _deliveryType;
        public string DeliveryType
        {
            get { return _deliveryType; }
            set { _deliveryType = value; }
        }
        private float? _expireDate;
        public float? ExpireDate
        {
            get { return _expireDate; }
            set { _expireDate = value; }
        }
        public override string Table { get { return "C_ExportSchedule"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_C_ExportSchedule_InsertOrUpdate"; } }
    }
    public enum C_ExportScheduleColumns
    {
        ID,
        M_CompanyProcessID,
        DeliveryFequency,
        DeliveryDate,
        DeliveryTime,
        DeliveryType,
        ExpireDate,
        CreatedBy,
        CreatedDateTime,
        UpdatedBy,
        UpdatedDateTime,
        Status,
    }
    public enum C_ExportScheduleProcedure
    {
        p_C_ExportSchedule_GetDelivery
    }
    public class C_ExportScheduleList : List<C_ExportSchedule>
    {

    }
}