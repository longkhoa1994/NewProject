using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_ImageDelivery : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _i_DeliveryNotificationID;

        public long I_DeliveryNotificationID
        {
            get { return _i_DeliveryNotificationID; }
            set { _i_DeliveryNotificationID = value; }
        }

        private long _i_ImageID;

        public long I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }

        public override string Table { get { return "I_ImageDelivery"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_I_ImageDelivery_InsertOrUpdate"; } }
    }

    public enum I_ImageDeliveryColumns
    {
        ID,
        I_DeliveryNotificationID,
        I_ImageID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum I_ImageDeliveryProcedure
    {
        p_I_ImageDelivery_GetListForDeleting,
        p_I_Image_GetListForDeliveryImage
    }

    public class I_ImageDeliveryList : List<I_ImageDelivery>
    {
    }
}