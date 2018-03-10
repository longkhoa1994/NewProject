using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class I_SuggestPosition : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _i_ImageID;
        public long? I_ImageID
        {
            get { return _i_ImageID; }
            set { _i_ImageID = value; }
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

        private int? _serviceQuantity;
        [Extract]
        public int? ServiceQuantity
        {
            get { return _serviceQuantity; }
            set { _serviceQuantity = value; }
        }

        private decimal? _serviceRate;
        [Extract]
        public decimal? ServiceRate
        {
            get { return _serviceRate; }
            set { _serviceRate = value; }
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

        private string _coordinates;
        public string Coordinates
        {
            get { return _coordinates; }
            set { _coordinates = value; }
        }

        public decimal? UnitPrice { get; set; }
        public override string Table { get { return "I_SuggestPosition"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_SuggestPosition_InsertOrUpdate"; } }
    }
    public enum I_SuggestPositionColumns
    {
        ID,
        I_ImageID,

        ServiceDate,
        ServiceCode,
        ServiceDescription,
        ServiceQuantity,
        ServiceRate,
        ServiceNet,
        ServiceTax,
        ServiceGross,
        ServiceCoordinates,

        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum I_SuggestPositionProcedure
    {
        p_I_SuggestPosition_GetBySuggestHeaderID,
    }
    public class I_SuggestPositionList : List<I_SuggestPosition>
    {

    }
}