using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_AllowedServiceCodes : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _b_PosID;

        public long B_PosID
        {
            get { return _b_PosID; }
            set { _b_PosID = value; }
        }

        private string _serviceCodes;

        public string ServiceCodes
        {
            get { return _serviceCodes; }
            set { _serviceCodes = value; }
        }

        public override string Table { get { return "B_AllowedServiceCodes"; } }

        public override string PrimaryKey { get { return ID.ToString(); } }

        public override string InsertUpdateProcedure { get { return "p_B_AllowedServiceCodes_InsertOrUpdate"; } }
    }

    public enum B_AllowedServiceCodesColumns
    {
        ID,
        B_PosID,
        ServiceCodes,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_AllowedServiceCodesProcedure
    {
        p_B_AllowedServiceCodes_Get_By_B_PosID,
        p_B_AllowedServiceCodes_GetList_ByB_AccessID,
        p_B_AllowedServiceCodes_GetListForDeleting,
    }

    public class B_AllowedServiceCodesList : List<B_AllowedServiceCodes>
    {
    }
}