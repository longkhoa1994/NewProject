using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class O_SuggestPosition : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _o_SuggestHeaderID;

        public long? O_SuggestHeaderID
        {
            get { return _o_SuggestHeaderID; }
            set { _o_SuggestHeaderID = value; }
        }

        private DateTime? _serviceDate;
        [Extract]
        public DateTime? ServiceDate
        {
            get { return _serviceDate; }
            set { _serviceDate = value; }
        }

        private string _serviceCode;

        public string ServiceCode
        {
            get { return _serviceCode; }
            set { _serviceCode = value; }
        }

        private string _serviceDescription;
        [Extract]
        public string ServiceDescription
        {
            get { return _serviceDescription; }
            set { _serviceDescription = value; }
        }

        private decimal? _serviceRate;
        [Extract]
        public decimal? ServiceRate
        {
            get { return _serviceRate; }
            set { _serviceRate = value; }
        }

        private decimal? _serviceQuantity;
        [Extract]
        public decimal? ServiceQuantity
        {
            get { return _serviceQuantity; }
            set { _serviceQuantity = value; }
        }

        private decimal? _serviceNet;
        [Extract]
        public decimal? ServiceNet
        {
            get { return _serviceNet; }
            set { _serviceNet = value; }
        }

        private decimal? _serviceTax;
        [Extract]
        public decimal? ServiceTax
        {
            get { return _serviceTax; }
            set { _serviceTax = value; }
        }

        private decimal? _serviceGross;
        [Extract]
        public decimal? ServiceGross
        {
            get { return _serviceGross; }
            set { _serviceGross = value; }
        }

        public override string Table { get { return "O_SuggestPosition"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_O_SuggestPosition_InsertOrUpdate"; } }
    }

    public enum O_SuggestPositionColumns
    {
        ID,
        O_SuggestHeaderID,

        ServiceDate,
        ServiceCode,
        ServiceDescription,
        ServiceQuantity,
        ServiceRate,
        ServiceNet,
        ServiceTax,
        ServiceGross,

        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum O_SuggestPositionProcedure
    {
    }

    public class O_SuggestPositionList : List<O_SuggestPosition>
    {
    }
}