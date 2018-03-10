using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_F_Reflection : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        private long _fieldID;
        public long FieldID
        {
            get { return _fieldID; }
            set { _fieldID = value; }
        }
        private long? _inputFieldID;
        public long? InputFieldID
        {
            get { return _inputFieldID; }
            set { _inputFieldID = value; }
        }
        private int _typeValue;
        public int TypeValue
        {
            get { return _typeValue; }
            set { _typeValue = value; }
        }
        private string _value;
        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        private string _bookingPath;
        public string BookingPath
        {
            get { return _bookingPath; }
            set { _bookingPath = value; }
        }

        private long? _m_CompanyID;
        public long? M_CompanyID
        {
            get { return _m_CompanyID; }
            set { _m_CompanyID = value; }
        }

        private string _transactionTypePath;
        public string TransactionTypePath
        {
            get { return _transactionTypePath; }
            set { _transactionTypePath = value; }
        }

        private string _transactionTypeCode;
        public string TransactionTypeCode
        {
            get { return _transactionTypeCode; }
            set { _transactionTypeCode = value; }
        }

        private string _additionalInputFieldID;
        public string AdditionalInputFieldID
        {
            get { return _additionalInputFieldID; }
            set { _additionalInputFieldID = value; }
        }


        public override string Table { get { return "M_F_Reflection"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_F_Reflection_InsertOrUpdate"; } }
    }
    public enum M_F_ReflectionColumns
    {
        ID,
        FieldID,
        InputFieldID,
        TypeValue,
        Value,
        BookingPath,
        M_CompanyID,
        TransactionTypePath,
        TransactionTypeCode,
        AdditionalInputFieldID,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }
    public enum M_F_ReflectionProcedure
    {
        p_M_F_Reflection_GetListByType
    }
    public class M_F_ReflectionList : List<M_F_Reflection>
    {

    }

    public enum TypeValue
    {
        InputField = 1,
        Booking = 2,
        FixedValue = 3,
        MustCalculated = 4
    }
}