using System;
using System.Collections.Generic;

namespace T2P._2015.Cross.Model
{
    [Serializable]
    public class M_BookingMapping : BaseModel
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private long? _m_HotelPlatformID;

        public long? M_HotelPlatformID
        {
            get { return _m_HotelPlatformID; }
            set { _m_HotelPlatformID = value; }
        }

        private string _bookingLevel;

        public string BookingLevel
        {
            get { return _bookingLevel; }
            set { _bookingLevel = value; }
        }

        private string _bookingField;

        public string BookingField
        {
            get { return _bookingField; }
            set { _bookingField = value; }
        }

        private string _requestField;

        public string RequestField
        {
            get { return _requestField; }
            set { _requestField = value; }
        }

        private string _requestFieldType;

        public string RequestFieldType
        {
            get { return _requestFieldType; }
            set { _requestFieldType = value; }
        }

        private string bookingPath;

        public string BookingPath
        {
            get { return bookingPath; }
            set { bookingPath = value; }
        }

        private string requestPath;

        public string RequestPath
        {
            get { return requestPath; }
            set { requestPath = value; }
        }

        public override string Table { get { return "M_BookingMapping"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_BookingMapping_InsertOrUpdate"; } }
    }

    public enum M_BookingMappingColumns
    {
        ID,
        M_HotelPlatformID,
        BookingLevel,
        BookingField,
        RequestField,
        RequestFieldType,
        CreatedBy,
        CreatedDate,
        UpdatedBy,
        UpdatedDate,
        Status,
    }

    public enum M_BookingMappingProcedure
    {
    }

    public class M_BookingMappingList : List<M_BookingMapping>
    {
    }
}