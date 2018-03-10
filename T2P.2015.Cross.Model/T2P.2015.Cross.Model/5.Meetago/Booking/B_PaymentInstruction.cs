using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class B_PaymentInstruction : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _b_BookingID;

        public long? B_BookingID
        {
            get { return _b_BookingID; }
            set { _b_BookingID = value; }
        }

        private int? _meetingPackage;

        public int? MeetingPackage
        {
            get { return _meetingPackage; }
            set { _meetingPackage = value; }
        }

        private int? _additonalService;

        public int? AdditonalService
        {
            get { return _additonalService; }
            set { _additonalService = value; }
        }

        private int? _room;

        public int? Room
        {
            get { return _room; }
            set { _room = value; }
        }

        public override string Table { get { return "B_PaymentInstruction"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_PaymentInstruction_InsertOrUpdate"; } }
    }

    public enum B_PaymentInstructionColumns
    {
        ID,
        B_BookingID,
        MeetingPackage,
        AdditonalService,
        Room,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_PaymentInstructionProcedure
    {
    }

    public class B_PaymentInstructionList : List<B_PaymentInstruction>
    {
    }
}