using System;
using System.Collections.Generic;
using T2P._2015.Cross.Model;

namespace T2P._2015.Model
{
    [Serializable]
    public class N_Task : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long? _b_AccessID;
        public long? B_AccessID
        {
            get { return _b_AccessID; }
            set { _b_AccessID = value; }
        }
        private long? _i_ImageID;
        public long? I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
        }
        private long? _f_TransactionID;
        public long? F_TransactionID
        {
            get { return _f_TransactionID; }
            set { _f_TransactionID = value; }
        }
        private long? _n_TaskID;
        public long? N_TaskID
        {
            get { return _n_TaskID; }
            set { _n_TaskID = value; }
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
        public override string Table { get { return "N_Task"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_N_Task_InsertOrUpdate"; } }
    }
    public enum N_TaskColumns
    {
        ID,
        B_AccessID,
        I_ImageID,
        F_TransactionID,
        N_TaskID,
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
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum N_TaskProcedure
    {
        p_N_Task_GetByB_AccessID,
        p_N_Task_Get_ByID,
        p_N_Task_GetList_ForFinishTask,
        p_N_Task_GetByB_AccessID_FinID,
        p_N_Task_GetListForDeleting,
        p_N_Task_GetList_ByType,
        p_N_Task_GetList_ByListType,
        p_N_Task_GetList_By_B_AccessID_ListF_TransactionID,
        p_N_Task_GetList_By_B_AccessID_ListF_TransactionID_ForReactivate
    }

    public class N_TaskList : List<N_Task>
    {
    }
}