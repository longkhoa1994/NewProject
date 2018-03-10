using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    [Serializable]
    public class P_I_PositionMatching : BaseModel
    {

        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _i_PositionID;
        public long I_PositionID
        {
            get { return _i_PositionID; }
            set { _i_PositionID = value; }
        }

        private long _referID;
        public long ReferID
        {
            get { return _referID; }
            set { _referID = value; }
        }

        private int _serviceType;
        public int ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; }
        }

        public override string Table { get { return "P_I_PositionMatching"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_P_I_PositionMatching_InsertOrUpdate"; } }
    }

    public enum P_I_PositionMatchingColumns
    {
        ID,
        I_PositionID,
        ReferID,
        ServiceType,
        CreatedDate,
        CreatedBy,
        UpdatedDate,
        UpdatedBy,
        Status
    }

    public enum P_I_PositionMatchingProcedure
    {
        p_B_EventBooking_GetPositionMatching_By_I_DataID,
        p_B_EventBooking_GetPositionMatching_By_B_AccessID
    }

    public enum ServiceType
    {
        AdditionalService = 1,
        Package = 2,
        Room = 3
    }
}
