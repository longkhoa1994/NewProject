using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class R_N_Task : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _r_B_AccessID;

        public long? R_B_AccessID
        {
            get { return _r_B_AccessID; }
            set { _r_B_AccessID = value; }
        }

        private long? _r_I_ImageID;

        public long? R_I_ImageID
        {
            get { return _r_I_ImageID; }
            set { _r_I_ImageID = value; }
        }

        private long? _r_F_TransactionID;

        public long? R_F_TransactionID
        {
            get { return _r_F_TransactionID; }
            set { _r_F_TransactionID = value; }
        }

        private long? _r_N_TaskID;

        public long? R_N_TaskID
        {
            get { return _r_N_TaskID; }
            set { _r_N_TaskID = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _contactTo;

        public string ContactTo
        {
            get { return _contactTo; }
            set { _contactTo = value; }
        }

        private string _contactWay;

        public string ContactWay
        {
            get { return _contactWay; }
            set { _contactWay = value; }
        }

        private long? _assignedTo;

        public long? AssignedTo
        {
            get { return _assignedTo; }
            set { _assignedTo = value; }
        }

        private DateTime? _date;

        public DateTime? Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private string _priority;

        public string Priority
        {
            get { return _priority; }
            set { _priority = value; }
        }

        private bool? _isDone;

        public bool? IsDone
        {
            get { return _isDone; }
            set { _isDone = value; }
        }

        private bool? _invoiceExpected;

        public bool? InvoiceExpected
        {
            get { return _invoiceExpected; }
            set { _invoiceExpected = value; }
        }

        private long? _doneBy;

        public long? DoneBy
        {
            get { return _doneBy; }
            set { _doneBy = value; }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override string Table { get { return "R_N_Task"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_R_N_Task_InsertOrUpdate"; } }
    }

    public enum R_N_TaskColumns
    {
        ID,
        R_B_AccessID,
        R_I_ImageID,
        R_F_TransactionID,
        R_N_TaskID,
        Name,
        ContactTo,
        ContactWay,
        AssignedTo,
        Date,
        Description,
        Priority,
        IsDone,
        InvoiceExpected,
        DoneBy,
        Type,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum R_N_TaskProcedure
    {
        p_R_N_Task_GetList_ByListType,
        p_R_N_Task_GetForClose,
        p_R_N_Task_GetForCloseGetByImageId,
        p_R_N_Task_GetByBookingID,
        p_R_N_Task_GetBy_R_I_ImageID_And_Type,
        p_R_I_Image_GetList_ForDeleteTaskNoFIN,
        //p_R_I_Image_GetList_NoTransactionAfterReceivedDate3Days,
        p_R_I_Image_GetList_NoTransactionAfterReceivedDate10Days,
        p_R_N_Task_GetBy_R_F_TransactionID_And_Type,
        p_R_B_Access_Get_Items_For_TaskNoInvAndFin,
        p_R_I_Image_GetList_ForDeleteTaskNoINVAndFIN,
        p_R_N_Task_GetListNotEditByUser,
        p_R_B_Access_Get_Items_For_TaskInvAndNoFin,
        p_R_N_Task_HasCredit_And_NewDebitInvoice_For_DoneTask,
    }

    public class R_N_TaskList : List<R_N_Task>
    {
    }
}