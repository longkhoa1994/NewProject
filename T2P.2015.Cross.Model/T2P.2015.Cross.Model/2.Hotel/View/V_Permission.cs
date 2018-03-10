using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model.View
{
    public class V_Permission
    {
        private long _userID;

        public long UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        List<long> _companyPermission;

        public List<long> CompanyPermission
        {
            get { return _companyPermission; }
            set { _companyPermission = value; }
        }

        long _travelerPermission;

        public long TravelerPermission
        {
            get { return _travelerPermission; }
            set { _travelerPermission = value; }
        }

        long _bookerPermission;

        public long BookerPermission
        {
            get { return _bookerPermission; }
            set { _bookerPermission = value; }
        }

        private long _hotelPermission;

        public long HotelPermission
        {
            get { return _hotelPermission; }
            set { _hotelPermission = value; }
        }

        private long _hotelPlatformID;

        public long HotelPlatformID
        {
            get { return _hotelPlatformID; }
            set { _hotelPlatformID = value; }
        }

        private List<long> _listHotelPlatform;

        public List<long> ListHotelPlatform
        {
            get { return _listHotelPlatform; }
            set { _listHotelPlatform = value; }
        }   
    }
}
