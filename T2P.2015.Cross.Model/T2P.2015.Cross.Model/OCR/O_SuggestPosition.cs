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

        public string ServiceDescription
        {
            get { return _serviceDescription; }
            set { _serviceDescription = value; }
        }

        private float? _net;

        public float? Net
        {
            get { return _net; }
            set { _net = value; }
        }

        private float? _rate;

        public float? Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        private float? _tax;

        public float? Tax
        {
            get { return _tax; }
            set { _tax = value; }
        }

        private float? _gross;

        public float? Gross
        {
            get { return _gross; }
            set { _gross = value; }
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
        Net,
        Rate,
        Tax,
        Gross,
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