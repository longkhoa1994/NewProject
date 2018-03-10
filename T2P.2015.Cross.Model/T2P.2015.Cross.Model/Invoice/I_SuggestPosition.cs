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
        private long? _i_SuggestHeaderID;
        public long? I_SuggestHeaderID
        {
            get { return _i_SuggestHeaderID; }
            set { _i_SuggestHeaderID = value; }
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
        public override string Table { get { return "I_SuggestPosition"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_I_SuggestPosition_InsertOrUpdate"; } }
    }
    public enum I_SuggestPositionColumns
    {
        ID,
        I_SuggestHeaderID,
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
    public enum I_SuggestPositionProcedure
    {
        p_I_SuggestPosition_GetBySuggestHeaderID,
    }
    public class I_SuggestPositionList : List<I_SuggestPosition>
    {

    }
}