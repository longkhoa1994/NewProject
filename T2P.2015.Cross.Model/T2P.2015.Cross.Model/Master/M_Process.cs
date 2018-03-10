using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_Process : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private string _processName;
        public string ProcessName
        {
            get { return _processName; }
            set { _processName = value; }
        }

        private string _processName2;

        public string ProcessName2
        {
            get { return _processName2; }
            set { _processName2 = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string _payment;
        public string Payment
        {
            get { return _payment; }
            set { _payment = value; }
        }
        private int? _position;
        public int? Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public override string Table { get { return "M_Process"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_Process_InsertOrUpdate"; } }
    }
    public enum M_ProcessColumns
    {
        ID,
        ProcessName,
        Description,
        Payment,
        Position,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_ProcessProcedure
    {
        p_M_Process_Get_ByBookingAccess,
        p_M_Process_GetByCompanyID,
        P_M_Process_ByHotelPlaformID
    }

    public class M_ProcessList : List<M_Process>
    {
    }
}