using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2P._2015.Cross.Model._5.Meetago.Process
{
    public class P_DashboardStatistic
    {
        public P_DashboardHeader Header { get; set; }
        public List<P_DashboardCities> Cities { get; set; }
        public List<P_DashboardCountries> Countries { get; set; }
        public List<P_DashboardMeetingStatus> MeetingStatus { get; set; }
    }

    public class P_DashboardHeader
    {
        public int WaitForApproval { get; set; }
        public int EndingToday { get; set; }
        public int CurrentlyRunning { get; set; }
        public int InProcessing { get; set; }
    }

    public class P_DashboardCities
    {
        public string CityName { get; set; }
        public string TotalBooking { get; set; }
    }
    public class P_DashboardMeetingStatus
    {
        public string BookingStatus { get; set; }
        public string TotalBooking { get; set; }
    }
    public class P_DashboardCountries
    {
        public string CountryName { get; set; }
        public string TotalBooking { get; set; }
    }
}
