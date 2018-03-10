using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Booking
{
    [Serializable]
    public class B_AdditionalService : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long _B_ContractID;
        public long B_ContractID
        {
            get { return _B_ContractID; }
            set { _B_ContractID = value; }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        private string _serviceCode;
        public string ServiceCode
        {
            get { return _serviceCode; }
            set { _serviceCode = value; }
        }

        private string _serviceName;
        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }

        private int? _quantity;
        public int? Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        private decimal? _unitPrice;
        public decimal? UnitPrice
        {
            get { return _unitPrice; }
            set { _unitPrice = value; }
        }

        private decimal? _total;

        public decimal? Total
        {
            get { return _total; }
            set { _total = value; }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string _type;

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public override string Table { get { return "B_AdditionalService"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_B_AdditionalService_InsertOrUpdate"; } }

    }

    public enum B_AdditionalServiceColumns
    {
        ID,
        B_ContractID,
        Date,
        ServiceCode,
        ServiceName,
        Quantity,
        UnitPrice,
        Description,
        Total,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum B_AdditionalServiceProcedure
    {
        p_B_AdditionalService_GetByAccessID,
        p_B_AdditionalService_GetList_ByContractID
    }
}
