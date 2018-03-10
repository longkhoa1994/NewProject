using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._1.Common.Master
{
    [Serializable]
    public class M_HotelNotDuplicate : BaseModel
    {
        private long _iD;
        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private bool? _isHotelName;

        public bool? IsHotelName
        {
            get { return _isHotelName; }
            set { _isHotelName = value; }
        }

        private bool? _isHotelNo;

        public bool? IsHotelNo
        {
            get { return _isHotelNo; }
            set { _isHotelNo = value; }
        }

        private bool? _isHotelAddress;

        public bool? IsHotelAddress
        {
            get { return _isHotelAddress; }
            set { _isHotelAddress = value; }
        }

        private bool? _isZipCode;

        public bool? IsZipCode
        {
            get { return _isZipCode; }
            set { _isZipCode = value; }
        }

        private bool? _isCityName;

        public bool? IsCityName
        {
            get { return _isCityName; }
            set { _isCityName = value; }
        }

        private bool? _isCountryCode;

        public bool? IsCountryCode
        {
            get { return _isCountryCode; }
            set { _isCountryCode = value; }
        }

        private bool? _isPhone;

        public bool? IsPhone
        {
            get { return _isPhone; }
            set { _isPhone = value; }
        }

        private bool? _isFax;

        public bool? IsFax
        {
            get { return _isFax; }
            set { _isFax = value; }
        }

        private bool? _isEmail;

        public bool? IsEmail
        {
            get { return _isEmail; }
            set { _isEmail = value; }
        }

        private string _value;

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }


        public override string Table { get { return "M_HotelNotDuplicate"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_M_HotelNotDuplicate_InsertOrUpdate"; } }
    }

    public enum M_HotelNotDuplicateProcedure
    {
        p_M_HotelNotDuplicate_Get_For_NotDuplicate
    }
}
