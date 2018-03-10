using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class D_StatisticData : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private DateTime _deletionDate;
        public DateTime DeletionDate
        {
            get { return _deletionDate; }
            set { _deletionDate = value; }
        }
        private int _numberOfBooking;
        public int NumberOfBooking
        {
            get { return _numberOfBooking; }
            set { _numberOfBooking = value; }
        }
        private int _numberOfInvoice;
        public int NumberOfInvoice
        {
            get { return _numberOfInvoice; }
            set { _numberOfInvoice = value; }
        }
        private int _numberOfTransaction;
        public int NumberOfTransaction
        {
            get { return _numberOfTransaction; }
            set { _numberOfTransaction = value; }
        }
        public override string Table { get { return "D_StatisticData"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_D_StatisticData_InsertOrUpdate"; } }
    }
    public enum D_StatisticDataColumns
    {
        ID,
        DeletionDate,
        NumberOfBooking,
        NumberOfInvoice,
        NumberOfTransaction,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum D_StatisticDataProcedure
    {

    }
    public class D_StatisticDataList : List<D_StatisticData>
    {

    }
}