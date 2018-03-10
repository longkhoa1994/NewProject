using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Enum;

namespace T2P._2015.Cross.Model._2.Hotel.Process
{
    public abstract class ProjectFactory
    {
        public abstract Mail CreateMail();
        public abstract ServiceDesk CreateServiceDesk();
        public abstract CorrectionGroup CreateCorrectionGroup();
        public abstract Chart CreateChart();
        public abstract string GetProjectName();
        public abstract string GetProjectCode();
    }
    public class OverviewModule
    {
        private bool hasModule = true;

        public bool HasModule
        {
            get { return hasModule; }
            set { hasModule = value; }
        }


        public virtual void SetHasModule(bool hasModule)
        {
            this.HasModule = hasModule;
        }
    }
    public abstract class Mail : OverviewModule
    {
        private string link;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }

        private int totalInformation;
        public int TotalInformation
        {
            get { return totalInformation; }
            set { totalInformation = value; }
        }

        private int totalOther;
        public int TotalOther
        {
            get { return totalOther; }
            set { totalOther = value; }
        }

        private int totalMatched;
        public int TotalMatched
        {
            get { return totalMatched; }
            set { totalMatched = value; }
        }

        private List<MailPlatfrom> platformsMail;

        public List<MailPlatfrom> PlatformsMail
        {
            get { return platformsMail; }
            set { platformsMail = value; }
        }

        public abstract void SetMailsSummary();
    }
    public abstract class ServiceDesk : OverviewModule
    {
        private string link;

        public string Link
        {
            get { return link; }
            set { link = value; }
        }

        private List<ServiceDeskUser> serviceDesksUser;

        public List<ServiceDeskUser> ServiceDesksUser
        {
            get { return serviceDesksUser; }
            set { serviceDesksUser = value; }
        }

        public abstract void SetServiceDeskUserSummary();
    }
    public abstract class Correction : OverviewModule
    {
        private string correctionLink;

        public string CorrectionLink
        {
            get { return correctionLink; }
            set { correctionLink = value; }
        }
        public int TotalPreProcessing { get; set; }
        public int TotalMatching { get; set; }
        public long TotalUnmatchable { get; set; }
        public int TotalProcessing { get; set; }
        public int TotalDelay { get; set; }
        public long TotalCorrection { get; set; }
        public long TotalDuplicate { get; set; }
        public abstract void SetCorrection();
    }
    public abstract class CorrectionGroup : OverviewModule
    {
        private string correctionLink;

        public string CorrectionLink
        {
            get { return correctionLink; }
            set { correctionLink = value; }
        }

        private int totalError;
        public int TotalError
        {
            get { return totalError; }
            set { totalError = value; }
        }

        private int numberOfItelya;
        public int NumberOfItelya
        {
            get { return numberOfItelya; }
            set { numberOfItelya = value; }
        }

        private int numberOfVN;
        public int NumberOfVN
        {
            get { return numberOfVN; }
            set { numberOfVN = value; }
        }

        private int numberOfSupervisor;
        public int NumberOfSupervisor
        {
            get { return numberOfSupervisor; }
            set { numberOfSupervisor = value; }
        }

        private int numberOfReviewDuplicate;
        public int NumberOfReviewDuplicate
        {
            get { return numberOfReviewDuplicate; }
            set { numberOfReviewDuplicate = value; }
        }

        public abstract void SetCorrectionGroup();
    }
    public abstract class Chart
    {
        public long TotalPreProcessing { get; set; }
        public long TotalMatching { get; set; }
        public long TotalUnmatchable { get; set; }
        public long TotalUnclassified { get; set; }
        public int TotalProcessing { get; set; }
        public int TotalDelay { get; set; }
        public long TotalCorrection { get; set; }
        public long TotalDuplicate { get; set; }
        public long TotalFinal { get; set; }
        public abstract void SetChart();
    }


    #region Data Resource Database
    public class D_Mail : MailPlatfrom
    {
        public string HotelPlatformType { get; set; }
    }
    public class D_ServiceDesk : OPriority
    {
        public string HotelPlatformType { get; set; }

        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string groupName;

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

    }

    public class D_Correction
    {
        public string HotelPlatformType { get; set; }
        public int TotalPreProcessing { get; set; }
        public int TotalMatching { get; set; }
        public int TotalUnmatchable { get; set; }
        public int TotalUnclassified { get; set; }
        public int TotalDelay { get; set; }
        public int TotalProcessing { get; set; }
        public int TotalCorrection { get; set; }
        public int TotalDuplicate { get; set; }
        public int TotalFinal { get; set; }

    }
    public class D_CorrectionGroup
    {
        public string HotelPlatformType { get; set; }
        public int IsParking { get; set; }
        public int IsVNGroup { get; set; }
    }
    public class D_Data
    {
        private List<D_Mail> mailData;

        public List<D_Mail> MailData
        {
            get { return mailData; }
            set { mailData = value; }
        }

        private List<D_ServiceDesk> serviceDeskData;

        public List<D_ServiceDesk> ServiceDeskData
        {
            get { return serviceDeskData; }
            set { serviceDeskData = value; }
        }
        public List<D_CorrectionGroup> CorrectionGroup { get; set; }

        private List<D_Correction> correctionData;
        public List<D_Correction> CorrectionData
        {
            get { return correctionData; }
            set { correctionData = value; }
        }
    }
    public enum D_DataProcedure
    {
        p_N_Overview_GetMailData,
        p_N_Overview_GetServiceDesk,
        p_N_Overview_GetChartData,
        p_N_OverviewCorrections
    }
    #endregion

    #region Class Item
    public class MailPlatfrom
    {
        private string bookingPlatformName;

        public string BookingPlatformName
        {
            get { return bookingPlatformName; }
            set { bookingPlatformName = value; }
        }

        private int m_HotelPlatformSettingID;

        public int M_HotelPlatformSettingID
        {
            get { return m_HotelPlatformSettingID; }
            set { m_HotelPlatformSettingID = value; }
        }

        private int totalInformation;

        public int TotalInformation
        {
            get { return totalInformation; }
            set { totalInformation = value; }
        }

        private int totalOther;

        public int TotalOther
        {
            get { return totalOther; }
            set { totalOther = value; }
        }

        private int totalMatched;

        public int TotalMatched
        {
            get { return totalMatched; }
            set { totalMatched = value; }
        }
    }
    public class ServiceDeskUser
    {
        private long _iD;

        public long ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        private string groupName;

        public string GroupName
        {
            get { return groupName; }
            set { groupName = value; }
        }

        private ICollection<OPriority> priorities;

        public ICollection<OPriority> Priorities
        {
            get { return priorities; }
            set { priorities = value; }
        }

        public ServiceDeskUser()
        {
            Priorities = new List<OPriority>();
        }
    }
    public class OPriority
    {
        private int priorityLevel;

        public int PriorityLevel
        {
            get { return priorityLevel; }
            set { priorityLevel = value; }
        }

        private int totalTask;

        public int TotalTask
        {
            get { return totalTask; }
            set { totalTask = value; }
        }

        bool anyOverdue;

        public bool AnyOverdue
        {
            get { return anyOverdue; }
            set { anyOverdue = value; }
        }
    }

    #endregion

    #region Implement Item
    //Default Implement
    public class DefaultCorrectionGroup : CorrectionGroup
    {
        public DefaultCorrectionGroup()
        {
            base.SetHasModule(false);
        }

        public override void SetCorrectionGroup()
        {
        }
    }

    //Hotel Implement
    public class HotelMail : Mail
    {
        List<D_Mail> _data;
        public HotelMail(List<D_Mail> data)
        {
            _data = data;
        }

        public override void SetMailsSummary()
        {
            Link = "Notification/BillingEmail";

            PlatformsMail = new List<MailPlatfrom>();

            IEnumerable<D_Mail> hotelMailData = _data.Where(x => x.HotelPlatformType == "Hotel");

            TotalInformation = hotelMailData.Sum(x => x.TotalInformation);
            TotalOther = hotelMailData.Sum(x => x.TotalOther);

            foreach (var item in hotelMailData)
            {
                item.TotalMatched = -1;

                if (item.BookingPlatformName == HotelPlatformName.HRS.ToString())
                {
                    item.BookingPlatformName = item.BookingPlatformName + "/HDE";
                    D_Mail HDEMailData = hotelMailData.Where(x => x.BookingPlatformName == HotelPlatformName.HDE.ToString()).FirstOrDefault();
                    if (HDEMailData != null)
                    {
                        item.TotalInformation += HDEMailData.TotalInformation;
                        item.TotalOther += HDEMailData.TotalOther;
                    }
                }

                if (item.BookingPlatformName != HotelPlatformName.HDE.ToString())
                {
                    PlatformsMail.Add((MailPlatfrom)item);
                }
            }
        }
    }
    public class HotelServiceDesk : ServiceDesk
    {
        List<D_ServiceDesk> _data;
        public HotelServiceDesk(List<D_ServiceDesk> data)
        {
            _data = data;
        }

        public override void SetServiceDeskUserSummary()
        {
            Link = "Notification/ServiceDesk";

            ServiceDesksUser = new List<ServiceDeskUser>();
            IEnumerable<D_ServiceDesk> hotelServiceDeskData = _data.Where(x => x.HotelPlatformType == "Hotel");

            //string currentUserName = string.Empty;
            ServiceDeskUser currentUser = null;

            foreach (var item in hotelServiceDeskData)
            {
                if (currentUser == null || currentUser.ID != item.ID)
                {
                    currentUser = new ServiceDeskUser();
                    currentUser.ID = item.ID;
                    currentUser.GroupName = item.GroupName;
                    ServiceDesksUser.Add(currentUser);
                }

                currentUser.Priorities.Add((OPriority)item);
            }
        }
    }
    public class HotelChart : Chart
    {
        private List<D_Correction> _correctionData;
        private List<D_CorrectionGroup> _correctionGroup;
        public HotelChart(List<D_Correction> correctionData, List<D_CorrectionGroup> correctionGroup)
        {
            _correctionData = correctionData;
            _correctionGroup = correctionGroup;
        }
        public override void SetChart()
        {
            D_Correction hotelCorrectionData = _correctionData.Where(x => x.HotelPlatformType == "Hotel").FirstOrDefault();
            int totalCorrection = _correctionGroup.Where(x => x.HotelPlatformType == "Hotel").Count();

            TotalPreProcessing = hotelCorrectionData.TotalPreProcessing;
            TotalMatching = hotelCorrectionData.TotalMatching;
            TotalUnmatchable = hotelCorrectionData.TotalUnmatchable;
            TotalUnclassified = hotelCorrectionData.TotalUnclassified;
            TotalDelay = hotelCorrectionData.TotalDelay;
            TotalProcessing = hotelCorrectionData.TotalProcessing;
            TotalCorrection = totalCorrection;
            TotalDuplicate = hotelCorrectionData.TotalDuplicate;
            TotalFinal = hotelCorrectionData.TotalFinal;
        }
    }
    public class HotelCorrection : Correction
    {
        private List<D_Correction> _correctionData;
        private List<D_CorrectionGroup> _correctionGroup;
        public HotelCorrection(List<D_Correction> correctionData, List<D_CorrectionGroup> correctionGroup)
        {
            _correctionData = correctionData;
            _correctionGroup = correctionGroup;
        }
        public override void SetCorrection()
        {
            D_Correction hotelCorrectionData = _correctionData.Where(x => x.HotelPlatformType == "Hotel").FirstOrDefault();
            int totalCorrection = _correctionGroup.Where(x => x.HotelPlatformType == "Hotel" && x.IsParking != 2).Count();

            TotalUnmatchable = hotelCorrectionData.TotalUnmatchable;
            TotalCorrection = totalCorrection;
            TotalDuplicate = hotelCorrectionData.TotalDuplicate;
        }
    }
    public class HotelCorrectionGroup : CorrectionGroup
    {
        List<D_CorrectionGroup> _data;
        public HotelCorrectionGroup(List<D_CorrectionGroup> data)
        {
            _data = data;
        }

        public HotelCorrectionGroup()
        {

        }
        public override void SetCorrectionGroup()
        {
            List<D_CorrectionGroup> correctionsData = _data.Where(x => x.HotelPlatformType == "Hotel").ToList();

            CorrectionLink = "Invoice/Correction";

            NumberOfItelya = correctionsData.Where(x => x.IsParking != 2 && x.IsVNGroup == 0).Count();
            NumberOfVN = correctionsData.Where(x => x.IsParking != 2 && x.IsVNGroup != 0).Count();
            NumberOfSupervisor = correctionsData.Where(x => x.IsParking == 2).Count();
            TotalError = NumberOfItelya + NumberOfVN + NumberOfSupervisor;
        }
    }
    public class HotelProjectFactory : ProjectFactory
    {
        private D_Data _data;
        public HotelProjectFactory(D_Data data)
        {
            _data = data;
        }
        public override Mail CreateMail()
        {
            HotelMail hotelMail = new HotelMail(_data.MailData);
            hotelMail.SetMailsSummary();
            return hotelMail;
        }

        public override ServiceDesk CreateServiceDesk()
        {
            HotelServiceDesk serviceDesk = new HotelServiceDesk(_data.ServiceDeskData);
            serviceDesk.SetServiceDeskUserSummary();

            return serviceDesk;
        }

        public override Chart CreateChart()
        {
            HotelChart item = new HotelChart(_data.CorrectionData, _data.CorrectionGroup);
            item.SetChart();
            return item;
        }

        public override CorrectionGroup CreateCorrectionGroup()
        {
            HotelCorrectionGroup data = new HotelCorrectionGroup(_data.CorrectionGroup);
            data.SetCorrectionGroup();

            return data;
        }

        public override string GetProjectCode()
        {
            return "Hotel";
        }

        public override string GetProjectName()
        {
            return "HOTEL";
        }
    }

    //Car Implement
    public class CarMail : Mail
    {
        List<D_Mail> _data;
        public CarMail(List<D_Mail> data)
        {
            _data = data;
        }

        public override void SetMailsSummary()
        {
            Link = "RentalCar/BillingEmail";

            PlatformsMail = new List<MailPlatfrom>();
            D_Mail hotelMailData = _data.Where(x => x.HotelPlatformType == "Car").FirstOrDefault();


            TotalMatched = hotelMailData.TotalMatched;
            TotalInformation = hotelMailData.TotalInformation;

            PlatformsMail.Add(new MailPlatfrom { BookingPlatformName = HotelPlatformName.BCD.ToString(), M_HotelPlatformSettingID = hotelMailData.M_HotelPlatformSettingID, TotalInformation = hotelMailData.TotalInformation, TotalMatched = hotelMailData.TotalMatched });
        }
    }
    public class CarServiceDesk : ServiceDesk
    {
        List<D_ServiceDesk> _data;
        public CarServiceDesk(List<D_ServiceDesk> data)
        {
            _data = data;
        }

        public override void SetServiceDeskUserSummary()
        {
            Link = "RentalCar/ServiceDesk";

            ServiceDesksUser = new List<ServiceDeskUser>();
            IEnumerable<D_ServiceDesk> hotelServiceDeskData = _data.Where(x => x.HotelPlatformType == "Rental Car");

            //string currentUserName = string.Empty;
            ServiceDeskUser currentUser = null;

            foreach (var item in hotelServiceDeskData)
            {
                if (currentUser == null || currentUser.ID != item.ID)
                {
                    currentUser = new ServiceDeskUser();
                    currentUser.ID = item.ID;
                    currentUser.GroupName = item.GroupName;
                    ServiceDesksUser.Add(currentUser);
                }

                currentUser.Priorities.Add((OPriority)item);
            }
        }
    }
    public class CarCorrection : Correction
    {
        private List<D_Correction> _data;
        public CarCorrection(List<D_Correction> data)
        {
            _data = data;
        }
        public override void SetCorrection()
        {
            D_Correction carChartData = _data.Where(x => x.HotelPlatformType == "Car").FirstOrDefault();
            TotalUnmatchable = carChartData.TotalUnmatchable;
            TotalCorrection = carChartData.TotalCorrection;
            TotalDuplicate = -1;
        }
    }
    public class CarCorrectionGroup : CorrectionGroup
    {
        private List<D_Correction> _data;
        public CarCorrectionGroup(List<D_Correction> data)
        {
            _data = data;
        }
        public override void SetCorrectionGroup()
        {
            CorrectionLink = "RentalCar/Correction";
            D_Correction carChartData = _data.Where(x => x.HotelPlatformType == "Car").FirstOrDefault();
            TotalError = carChartData.TotalCorrection;
            NumberOfItelya = carChartData.TotalCorrection;
        }
    }
    public class CarChart : Chart
    {
        private List<D_Correction> _data;
        public CarChart(List<D_Correction> data)
        {
            _data = data;
        }
        public override void SetChart()
        {
            D_Correction carChartData = _data.Where(x => x.HotelPlatformType == "Car").FirstOrDefault();
            TotalUnmatchable = carChartData.TotalUnmatchable;
            TotalCorrection = carChartData.TotalCorrection;
            TotalProcessing = carChartData.TotalProcessing;
        }
    }

    public class CarProjectFactory : ProjectFactory
    {
        private D_Data _data;
        public CarProjectFactory(D_Data data)
        {
            _data = data;
        }
        public override Mail CreateMail()
        {
            CarMail carMail = new CarMail(_data.MailData);
            carMail.SetMailsSummary();
            return carMail;
        }
        public override ServiceDesk CreateServiceDesk()
        {
            CarServiceDesk serviceDesk = new CarServiceDesk(_data.ServiceDeskData);
            serviceDesk.SetServiceDeskUserSummary();

            return serviceDesk;
        }
        public override CorrectionGroup CreateCorrectionGroup()
        {
            CorrectionGroup carCorrection = new CarCorrectionGroup(_data.CorrectionData);
            carCorrection.SetCorrectionGroup();

            return carCorrection;
        }
        public override Chart CreateChart()
        {
            Chart item = new CarChart(_data.CorrectionData);
            item.SetChart();
            return item;
        }
        public override string GetProjectCode()
        {
            return "Car";
        }
        public override string GetProjectName()
        {
            return "RENTAL CAR";
        }
    }

    //Meeting Implement
    public class MeetingMail : Mail
    {
        List<D_Mail> _data;
        public MeetingMail(List<D_Mail> data)
        {
            _data = data;
        }

        public override void SetMailsSummary()
        {
            Link = "Notification/BillingEmail";

            PlatformsMail = new List<MailPlatfrom>();

            IEnumerable<D_Mail> hotelMailData = _data.Where(x => x.HotelPlatformType == "Meeting");

            TotalInformation = hotelMailData.Sum(x => x.TotalInformation);
            TotalOther = hotelMailData.Sum(x => x.TotalOther);

            foreach (var item in hotelMailData)
            {
                item.TotalMatched = -1;
                PlatformsMail.Add((MailPlatfrom)item);
            }
        }
    }
    public class MeetingServiceDesk : ServiceDesk
    {
        List<D_ServiceDesk> _data;
        public MeetingServiceDesk(List<D_ServiceDesk> data)
        {
            _data = data;
        }

        public override void SetServiceDeskUserSummary()
        {
            Link = "Notification/ServiceDesk";

            ServiceDesksUser = new List<ServiceDeskUser>();
            IEnumerable<D_ServiceDesk> hotelServiceDeskData = _data.Where(x => x.HotelPlatformType == "Meeting");

            //string currentUserName = string.Empty;
            ServiceDeskUser currentUser = null;

            foreach (var item in hotelServiceDeskData)
            {
                if (currentUser == null || currentUser.ID != item.ID)
                {
                    currentUser = new ServiceDeskUser();
                    currentUser.ID = item.ID;
                    currentUser.GroupName = item.GroupName;
                    ServiceDesksUser.Add(currentUser);
                }

                currentUser.Priorities.Add((OPriority)item);
            }
        }
    }
    public class MeetingCorection : Correction
    {
        private List<D_Correction> _data;
        private List<D_CorrectionGroup> _correctionData;
        public MeetingCorection(List<D_Correction> data, List<D_CorrectionGroup> correctionData)
        {
            _data = data;
            _correctionData = correctionData;
        }
        public override void SetCorrection()
        {
            D_Correction chartData = _data.Where(x => x.HotelPlatformType == "Meeting").FirstOrDefault();
            int totalCorrection = _correctionData.Where(x => x.HotelPlatformType == "Meeting").Count();

            TotalUnmatchable = chartData.TotalUnmatchable;
            TotalCorrection = totalCorrection;
            TotalDuplicate = -1;
        }
    }
    public class MeetingCorectionGroup : CorrectionGroup
    {
        private List<D_Correction> _data;
        private List<D_CorrectionGroup> _correctionGroup;

        public MeetingCorectionGroup(List<D_Correction> data, List<D_CorrectionGroup> correctionGroup)
        {
            _data = data;
            _correctionGroup = correctionGroup;
        }

        public MeetingCorectionGroup()
        {

        }
        public override void SetCorrectionGroup()
        {
            CorrectionLink = "Invoice/Correction";
            D_Correction correctionData = _data.Where(x => x.HotelPlatformType == "Meeting").FirstOrDefault();
            List<D_CorrectionGroup> correctionsGroup = _correctionGroup.Where(x => x.HotelPlatformType == "Meeting").ToList();

            NumberOfItelya = correctionsGroup.Count;
            NumberOfSupervisor = correctionData.TotalUnmatchable;
            TotalError = NumberOfItelya + NumberOfSupervisor;
        }
    }
    public class MeetingChart : Chart
    {
        private List<D_Correction> _data;
        private List<D_CorrectionGroup> _correctionData;
        public MeetingChart(List<D_Correction> data, List<D_CorrectionGroup> correctionData)
        {
            _data = data;
            _correctionData = correctionData;
        }
        public override void SetChart()
        {
            D_Correction chartData = _data.Where(x => x.HotelPlatformType == "Meeting").FirstOrDefault();
            int totalCorrection = _correctionData.Where(x => x.HotelPlatformType == "Meeting").Count();

            TotalMatching = chartData.TotalMatching;
            TotalUnmatchable = chartData.TotalUnmatchable;
            TotalProcessing = chartData.TotalProcessing;
            TotalCorrection = totalCorrection;

        }
    }

    public class MeetingProjectFactory : ProjectFactory
    {
        private D_Data _data;
        public MeetingProjectFactory(D_Data data)
        {
            _data = data;
        }
        public override Mail CreateMail()
        {
            MeetingMail meetingMail = new MeetingMail(_data.MailData);
            meetingMail.SetMailsSummary();
            return meetingMail;
        }
        public override ServiceDesk CreateServiceDesk()
        {
            MeetingServiceDesk serviceDesk = new MeetingServiceDesk(_data.ServiceDeskData);
            serviceDesk.SetServiceDeskUserSummary();

            return serviceDesk;
        }
        public override Chart CreateChart()
        {
            Chart meetingCorection = new MeetingChart(_data.CorrectionData, _data.CorrectionGroup);
            meetingCorection.SetChart();

            return meetingCorection;
        }
        public override CorrectionGroup CreateCorrectionGroup()
        {
            MeetingCorectionGroup meetingCorectionGroup = new MeetingCorectionGroup(_data.CorrectionData, _data.CorrectionGroup);
            meetingCorectionGroup.SetCorrectionGroup();

            return meetingCorectionGroup;
        }
        public override string GetProjectCode()
        {
            return "Meeting";
        }
        public override string GetProjectName()
        {
            return "MEETING & GROUP";
        }
    }
    #endregion
    public class P_ProjectOverview
    {
        private Mail _mail;
        public Mail Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }

        private ServiceDesk _serviceDesk;
        public ServiceDesk ServiceDesk
        {
            get { return _serviceDesk; }
            set { _serviceDesk = value; }
        }

        private CorrectionGroup _correctionGroup;
        public CorrectionGroup CorrectionGroup
        {
            get { return _correctionGroup; }
            set { _correctionGroup = value; }
        }

        private Chart _chart;
        public Chart Chart
        {
            get { return _chart; }
            set { _chart = value; }
        }

        private string _code;
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public P_ProjectOverview(ProjectFactory factory)
        {
            Mail = factory.CreateMail();
            ServiceDesk = factory.CreateServiceDesk();
            Chart = factory.CreateChart();
            CorrectionGroup = factory.CreateCorrectionGroup();
            Code = factory.GetProjectCode();
            Name = factory.GetProjectName();
        }
    }


    public class CallLogOverview 
    {
        public string UserNameCallLog { get; set; }
        public string TimeAvg { get; set; }
        public long NumberCallLogOrUserID { get; set; }
    }
    public class HRS_NumberCall : CallLogOverview
    {
        public string NumberCallLog { get; set; }
        public HRS_NumberCall()
        {
            NumberCallLog = "000";
        }
    }

    public class HRS_DataOverview
    {
        public string TotalUnmatchable { get; set; }
        public HRS_NumberCall NumberCallLog { get; set; }
        public List<CallLogOverview> ListCallLogDetail { get; set; }
        public List<HRS_GroupOverview> ListHRS_GroupOverview { get; set; }
        public HRS_DataOverview()
        {
            TotalUnmatchable = "000";
            NumberCallLog = new HRS_NumberCall();
            ListCallLogDetail = new List<CallLogOverview>();
            ListHRS_GroupOverview = new List<HRS_GroupOverview>();
        }
    }

    public class HRS_GroupOverview
    {
        public List<HRS_TypeOverview> listTypeOverview { get; set; }
        public int Type { get; set; }
        public HRS_GroupOverview()
        {
            listTypeOverview = new List<HRS_TypeOverview>();
        }
    }

    public class HRS_TypeOverview
    {
        public List<HRS_UserGroup> List_HRS_UserGroup { get; set; }
        public string TaskType { get; set; }
        public HRS_Overdue Overdure { get; set; }
        public HRS_TypeOverview()
        {
            List_HRS_UserGroup = new List<HRS_UserGroup>();
            Overdure = new HRS_Overdue();
        }
    }
    public class HRS_UserGroup 
    {
        public long UserID { get; set; }
        public string NumberTask { get; set; }
        public string UserName { get; set; }
        public int Priority_1 { get; set; }
        public int Priority_2 { get; set; }
        public int Priority_3 { get; set; }
        public int Priority_4 { get; set; }
        public int Priority_5 { get; set; }
        public HRS_UserGroup()
        {
            Priority_1 = 0;
            Priority_2 = 0;
            Priority_3 = 0;
            Priority_4 = 0;
            Priority_5 = 0;
            NumberTask = "000";
        }

    }
    public class Data_HRS
    {
        public long N_TaskID { get; set; }
        public string GroupName { get; set; }
        public string UserNameTask { get; set; }
        public string UserName { get; set; }
        public int Priority { get; set; }
        public long AssignedTo { get; set; }
        public long Overdue { get; set; }
        public string TaskType { get; set; }
        public long UserID { get; set; }
        public int NumberTask { get; set; }
        
    }
    public class HRS_Overdue
    {
        public string TaskType { get; set; }
        public string Overdue_0 { get; set; }
        public string Overdue_2 { get; set; }
        public string Overdue_7 { get; set; }
        public HRS_Overdue()
        {
            Overdue_0 = "000";
            Overdue_2 = "000";
            Overdue_7 = "000";
        }
      
    }

    public class S_Overdue : BaseModel
    {
        public long ID { get; set; }
        public string TaskType { get; set; }
        public string GroupName { get; set; }
        public string Overdue_0 { get; set; }
        public string Overdue_2 { get; set; }
        public string Overdue_7 { get; set; }
        public override string Table { get { return "S_Overdue"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_S_Overdue_InsertOrUpdate"; } }

    }
    public class S_InforGroup : BaseModel
    {
        public long ID { get; set; }
        public long UserID { get; set; }
        public string GroupName { get; set; }
        public string TaskType { get; set; }
        public string UserName { get; set; }
        public string NumberTaskAndCall { get; set; }
        public string TimeCallForUser { get; set; }
        public string Type { get; set; }
        public override string Table { get { return "S_InforGroup"; } }
        public override string PrimaryKey { get { return ID.ToString(); } }
        public override string InsertUpdateProcedure { get { return "p_S_InforGroup_InsertOrUpdate"; } }
    }
    public enum HRS_Overview_Group
    {
        HRSGroup = 1,
        HRSExternal = 2,
        ItelyaGroup = 3,
    }
    public enum HRS_Overview_TaskType
    {
        FollowUp,
        Collection,
        Rejection,
    }

    public enum HRS_CallCenter_Overview
    {
        p_N_Overview_HRS_CallLog,
        p_P_Overview_HRSExternal_AvgCallLogAllUser,

        p_N_Overview_GetNumber_Unmatchable,
        p_N_Overview_HRS_GetServiceDesk,

        p_N_Overview_HRS_GetServiceDesk_Collection_Rejection,

        p_S_Overdue_GetDataOverdue_ByCreatedDate,
        p_S_InforGroup_GetDataOverdue_ByCreatedDate,
        
        p_S_InforGroup_GetDataCallLogHistory,
        p_S_InforGroup_GetDataHRSSeviceHistory,
        p_S_InforGroup_GetDataItelyaHistory,
        p_S_InforGroup_GetDataHRSExternalHistory,
        p_S_InforGroup_GetDataCallLogAllUserHistory

        , p_N_Overview_HRS_NumberCall,

        p_N_Overview_HRS_GetUserProfile_ByIsUserOverviewHRS
        
    }

}
