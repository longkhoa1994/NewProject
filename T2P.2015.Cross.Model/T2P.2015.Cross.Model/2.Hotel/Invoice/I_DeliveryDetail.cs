using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_DeliveryDetail : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _i_DeliveryID;
        public long I_DeliveryID
        {
            get { return _i_DeliveryID; }
            set { _i_DeliveryID = value; }
        }
        private long _i_DataID;
        public long I_DataID
        {
            get { return _i_DataID; }
            set { _i_DataID = value; }
        }
        public override string Table { get { return "I_DeliveryDetail"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_DeliveryDetail_InsertOrUpdate"; } }
    }
    public enum I_DeliveryDetailColumns
    {
        ID,
        I_DeliveryID,
        I_DataID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_DeliveryDetailProcedure
    {
        p_I_DeliveryDetail_GetByI_DataID,
        p_I_DeliveryDetail_GetListForDeleting,
    }

    public class I_DeliveryDetailList : List<I_DeliveryDetail>
    {
    }
}