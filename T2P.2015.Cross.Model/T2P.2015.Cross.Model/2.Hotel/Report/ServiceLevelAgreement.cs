using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T2P._2015.Cross.Model.Report;

namespace T2P._2015.Cross.Model
{
    #region V1
    public class ServiceLevelAgreement
    {
        public string FileZipOutPut { get; set; }
        public ServiceLevelAgreement_DeparturePeriod DeparturePeriod { get; set; }
        public ServiceLevelAgreement_StatusQuo StatusQuo { get; set; }
        public List<ServiceLevelAgreement_HotelCollaboration> ListHotelCollaboration { get; set; }
        public long TotalRecords { get; set; }
        public ServiceLevelAgreement()
        {
            TotalRecords = 0;
        }
    }

    public class ServiceLevelAgreement_DeparturePeriod
    {
        public long TotalBooking { get; set; }
        public long TotalReceivedInvoice { get; set; }
        public long TotalBookingReceivedInvoice { get; set; }
        public long TotalFisrtCollection { get; set; }
        public long TotalSecondCollection { get; set; }
        //public long TotalLastCallCollection { get; set; }
        public long TotalFisrtRejection { get; set; }
        public long TotalSecondRejection { get; set; }
        //public long TotalLastCallRejection { get; set; }
        public long TotalOfPhoneCall { get; set; }
        public long TotalOfInvoiceAfterCall { get; set; }
        public long TotalOfPhoneCallAfter3Days { get; set; }
        public ServiceLevelAgreement_DeparturePeriod()
        {
            TotalBooking = 0;
            TotalReceivedInvoice = 0;
            TotalBookingReceivedInvoice = 0;
            TotalFisrtCollection = 0;
            TotalSecondCollection = 0;
            //TotalLastCallCollection = 0;
            TotalFisrtRejection = 0;
            TotalSecondRejection = 0;
            //TotalLastCallRejection = 0;
            TotalOfPhoneCall = 0;
            TotalOfInvoiceAfterCall = 0;
            TotalOfPhoneCallAfter3Days = 0;
        }
    }

    public class ServiceLevelAgreement_StatusQuo
    {
        public long TotalBooking { get; set; }
        public long TotalOutstanding { get; set; }
        public long TotalBookingNotReceivedInvoice { get; set; }
        public long TotalFisrtCollection { get; set; }
        public long TotalSecondCollection { get; set; }
        //public long TotalLastCallCollection { get; set; }
        public long TotalFisrtRejection { get; set; }
        public long TotalSecondRejection { get; set; }
        //public long TotalLastCallRejection { get; set; }
        public long TotalOfPhoneCall { get; set; }
        public long TotalOfPhoneCallAfter3Days { get; set; }
        public ServiceLevelAgreement_StatusQuo()
        {
            TotalBooking = 0;
            TotalOutstanding = 0;
            TotalBookingNotReceivedInvoice = 0;
            TotalFisrtCollection = 0;
            TotalSecondCollection = 0;
            //TotalLastCallCollection = 0;
            TotalFisrtRejection = 0;
            TotalSecondRejection = 0;
            //TotalLastCallRejection = 0;
            TotalOfPhoneCall = 0;
            TotalOfPhoneCallAfter3Days = 0;
        }
    }

    public class ServiceLevelAgreement_HotelCollaboration
    {
        public string HotelName { get; set; }
        public string HotelNo { get; set; }
        public string CountryCode { get; set; }
        public long TotalRequestInvoice { get; set; }
        public long TotalReceivedInvoice { get; set; }
        public long TotalFisrtCollection { get; set; }
        public long TotalSecondCollection { get; set; }
        //public long TotalLastCallCollection { get; set; }
        public long TotalFisrtRejection { get; set; }
        public long TotalSecondRejection { get; set; }
        //public long TotalLastCallRejection { get; set; }
        public long TotalOfPhoneCall { get; set; }
        public long TotalOfRequest { get; set; }
        public ServiceLevelAgreement_HotelCollaboration()
        {
            HotelName = string.Empty;
            HotelNo = string.Empty;
            CountryCode = string.Empty;
            TotalRequestInvoice = 0;
            TotalReceivedInvoice = 0;
            TotalFisrtCollection = 0;
            TotalSecondCollection = 0;
            //TotalLastCallCollection = 0;
            TotalFisrtRejection = 0;
            TotalSecondRejection = 0;
            //TotalLastCallRejection = 0;
            TotalOfPhoneCall = 0;
            TotalOfRequest = 0;
        }

    }

    #endregion

    #region V2
    public class ServiceLevelAgreement_v2
    {
        public string FileZipOutPut { get; set; }
        public ServiceLevelAgreement_v2_DeparturePeriod DeparturePeriod { get; set; }
        public ServiceLevelAgreement_v2_StatusQuo StatusQuo { get; set; }
        public List<ServiceLevelAgreement_v2_HotelCollaboration> ListHotelCollaboration { get; set; }
        public long TotalRecords { get; set; }
        public ServiceLevelAgreement_v2()
        {
            TotalRecords = 0;
        }
    }

    public class ServiceLevelAgreement_v2_DeparturePeriod
    {
        public long TotalBooking { get; set; }
        public long TotalReceivedInvoice { get; set; }
        public long TotalBookingReceivedInvoice { get; set; }
        public long TotalFisrtCollection { get; set; }
        public long TotalSecondCollection { get; set; }
        public long TotalFisrtRejection { get; set; }
        public long TotalSecondRejection { get; set; }
        public long TotalOfPhoneCall { get; set; }
        public long TotalOfInvoiceAfterCall { get; set; }
        public long TotalOfPhoneCallAfter3Days { get; set; }
        public ServiceLevelAgreement_v2_DeparturePeriod()
        {
            TotalBooking = 0;
            TotalReceivedInvoice = 0;
            TotalBookingReceivedInvoice = 0;
            TotalFisrtCollection = 0;
            TotalSecondCollection = 0;
            TotalFisrtRejection = 0;
            TotalSecondRejection = 0;
            TotalOfPhoneCall = 0;
            TotalOfInvoiceAfterCall = 0;
            TotalOfPhoneCallAfter3Days = 0;
        }
    }

    public class ServiceLevelAgreement_v2_StatusQuo
    {
        public long TotalBooking { get; set; }
        public long TotalOutstanding { get; set; }
        public long TotalBookingNotReceivedInvoice { get; set; }
        public long TotalFisrtCollection { get; set; }
        public long TotalSecondCollection { get; set; }
        public long TotalFisrtRejection { get; set; }
        public long TotalSecondRejection { get; set; }
        public long TotalOfPhoneCall { get; set; }
        public long TotalOfPhoneCallAfter3Days { get; set; }
        public ServiceLevelAgreement_v2_StatusQuo()
        {
            TotalBooking = 0;
            TotalOutstanding = 0;
            TotalBookingNotReceivedInvoice = 0;
            TotalFisrtCollection = 0;
            TotalSecondCollection = 0;
            TotalFisrtRejection = 0;
            TotalSecondRejection = 0;
            TotalOfPhoneCall = 0;
            TotalOfPhoneCallAfter3Days = 0;
        }
    }

    public class ServiceLevelAgreement_v2_HotelCollaboration
    {
        public long ID { get; set; }
        public string HotelName { get; set; }
        public string HotelNo { get; set; }
        public string CountryCode { get; set; }
        public long TotalBooking { get; set; }
        public long TotalBookingMissingInvoice { get; set; }
        //public long TotalRequestInvoice { get; set; }
        //public long TotalReceivedInvoice { get; set; }
        public long TotalFisrtCollection { get; set; }
        public decimal PercentageFisrtCollection { get; set; }
        public long TotalSecondCollection { get; set; }
        public decimal PercentageSecondCollection { get; set; }
        public long TotalMissingInvoiceSecondCollection { get; set; }
        public long TotalFisrtRejection { get; set; }
        public decimal PercentageFisrtRejection { get; set; }
        public long TotalSecondRejection { get; set; }
        public decimal PercentageSecondRejection { get; set; }
        public long TotalMissingInvoiceSecondRejection { get; set; }
        public long TotalOfPhoneCall { get; set; }
        public decimal PercentagePhoneCall { get; set; }

        // public long TotalOfRequest { get; set; }
        public ServiceLevelAgreement_v2_HotelCollaboration()
        {
            HotelName = string.Empty;
            HotelNo = string.Empty;
            CountryCode = string.Empty;
            //TotalRequestInvoice = 0;
            // TotalReceivedInvoice = 0;
            TotalFisrtCollection = 0;
            PercentageFisrtCollection = 0;
            TotalSecondCollection = 0;
            PercentageSecondCollection = 0;
            TotalMissingInvoiceSecondCollection = 0;
            TotalFisrtRejection = 0;
            PercentageFisrtRejection = 0;
            TotalSecondRejection = 0;
            PercentageSecondRejection = 0;
            TotalMissingInvoiceSecondRejection = 0;
            TotalOfPhoneCall = 0;
            PercentagePhoneCall = 0;
            //TotalOfRequest = 0;
        }

    }
    #endregion

    #region V3
    public class ServiceLevelAgreement_v3
    {
        public string FileZipOutPut { get; set; }
        public ServiceLevelAgreement_v3_DeparturePeriod DeparturePeriod { get; set; }
        public ServiceLevelAgreement_v3_StatusQuo StatusQuo { get; set; }
        public List<ServiceLevelAgreement_v3_HotelCollaboration> ListHotelCollaboration { get; set; }
        public long TotalRecords { get; set; }
        public ServiceLevelAgreement_v3()
        {
            TotalRecords = 0;
        }
    }

    public class ServiceLevelAgreement_v3_DeparturePeriod
    {
        public long TotalBooking { get; set; }
        public long TotalReceivedInvoice { get; set; }
        public long TotalBookingReceivedInvoice { get; set; }
        public long TotalFisrtCollection { get; set; }
        public long TotalSecondCollection { get; set; }
        public long TotalFisrtRejection { get; set; }
        public long TotalSecondRejection { get; set; }
        public long TotalOfPhoneCall { get; set; }
        public long TotalOfInvoiceAfterCall { get; set; }
        public long TotalOfPhoneCallAfter3Days { get; set; }
        public ServiceLevelAgreement_v3_DeparturePeriod()
        {
            TotalBooking = 0;
            TotalReceivedInvoice = 0;
            TotalBookingReceivedInvoice = 0;
            TotalFisrtCollection = 0;
            TotalSecondCollection = 0;
            TotalFisrtRejection = 0;
            TotalSecondRejection = 0;
            TotalOfPhoneCall = 0;
            TotalOfInvoiceAfterCall = 0;
            TotalOfPhoneCallAfter3Days = 0;
        }
    }

    public class ServiceLevelAgreement_v3_StatusQuo
    {
        public long TotalBooking { get; set; }
        public long TotalOutstanding { get; set; }
        public long TotalBookingNotReceivedInvoice { get; set; }
        public long TotalFisrtCollection { get; set; }
        public long TotalSecondCollection { get; set; }
        public long TotalFisrtRejection { get; set; }
        public long TotalSecondRejection { get; set; }
        public long TotalOfPhoneCall { get; set; }
        public long TotalOfPhoneCallAfter3Days { get; set; }
        public ServiceLevelAgreement_v3_StatusQuo()
        {
            TotalBooking = 0;
            TotalOutstanding = 0;
            TotalBookingNotReceivedInvoice = 0;
            TotalFisrtCollection = 0;
            TotalSecondCollection = 0;
            TotalFisrtRejection = 0;
            TotalSecondRejection = 0;
            TotalOfPhoneCall = 0;
            TotalOfPhoneCallAfter3Days = 0;
        }
    }

    public class ServiceLevelAgreement_v3_HotelCollaboration
    {
        public long ID { get; set; }
        public string HotelName { get; set; }
        public string HotelNo { get; set; }
        public string CountryCode { get; set; }
        public long TotalBooking { get; set; }
        public long TotalBookingMissingInvoice { get; set; }
        //public long TotalRequestInvoice { get; set; }
        //public long TotalReceivedInvoice { get; set; }
        public long TotalFisrtCollection { get; set; }
        public decimal PercentageFisrtCollection { get; set; }
        public long TotalSecondCollection { get; set; }
        public decimal PercentageSecondCollection { get; set; }
        public long TotalMissingInvoiceSecondCollection { get; set; }
        public long TotalFisrtRejection { get; set; }
        public decimal PercentageFisrtRejection { get; set; }
        public long TotalSecondRejection { get; set; }
        public decimal PercentageSecondRejection { get; set; }
        public long TotalMissingInvoiceSecondRejection { get; set; }
        public long TotalOfPhoneCall { get; set; }
        public decimal PercentagePhoneCall { get; set; }

        public long M_HotelPlatformID { get; set; }

        public string HotelPlatformName { get; set; }
        private string _countryName;

        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value; }
        }
        private string _cityName;

        public string CityName
        {
            get { return _cityName; }
            set { _cityName = value; }
        }

        // public long TotalOfRequest { get; set; }
        public ServiceLevelAgreement_v3_HotelCollaboration()
        {
            HotelName = string.Empty;
            HotelNo = string.Empty;
            CountryCode = string.Empty;
            //TotalRequestInvoice = 0;
            // TotalReceivedInvoice = 0;
            TotalFisrtCollection = 0;
            PercentageFisrtCollection = 0;
            TotalSecondCollection = 0;
            PercentageSecondCollection = 0;
            TotalMissingInvoiceSecondCollection = 0;
            TotalFisrtRejection = 0;
            PercentageFisrtRejection = 0;
            TotalSecondRejection = 0;
            PercentageSecondRejection = 0;
            TotalMissingInvoiceSecondRejection = 0;
            TotalOfPhoneCall = 0;
            PercentagePhoneCall = 0;
            M_HotelPlatformID = 0;
            HotelPlatformName = string.Empty;
            //TotalOfRequest = 0;
        }

    }
    #endregion

    public enum ServiceLevelAgreementStoreProcedure
    {
        p_P_ServiceLevelArgreement_HotelCollaboration,
        p_P_ServiceLevelArgreement_StatusQuo,
        p_P_ServiceLevelArgreement_DeparturePeriod,
        p_P_ServiceLevelArgreement_DeparturePeriod_CallLog,
        p_P_ServiceLevelArgreement_StatusQuo_CallLog,
        p_P_ServiceLevelArgreement_v2_HotelCollaboration,
        p_P_ServiceLevelArgreement_v2_StatusQuo,
        p_P_ServiceLevelArgreement_v2_DeparturePeriod,
        p_P_ServiceLevelArgreement_v2_DeparturePeriod_CallLog,
        p_P_ServiceLevelArgreement_v2_StatusQuo_CallLog,
        p_P_ServiceLevelArgreement_v3_HotelCollaboration,
        p_P_ServiceLevelArgreement_v3_StatusQuo,
        p_P_ServiceLevelArgreement_v3_DeparturePeriod,
        p_P_ServiceLevelArgreement_v3_DeparturePeriod_CallLog,
        p_P_ServiceLevelArgreement_v3_StatusQuo_CallLog,
        p_P_ServiceLevelArgreement_v3_HotelCollaboration_NotReceived,
        p_P_ServiceLevelArgreement_v3_GetListBookingOfCall,
    }


    public class ServiceLevelAgreement_HotelColaboration_NotReceived
    {
        public long M_HotelPlatformID { get; set; }
        public long B_AccessID { get; set; }
        public string BookingNo { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public string CompanyName { get; set; }
        public string ListTraveller { get; set; }        
        public string HotelName { get; set; }
        public string HotelCountryCode { get; set; }
        public string HotelCountryName { get; set; }

        public ServiceLevelAgreement_HotelColaboration_NotReceived()
        {
            M_HotelPlatformID = 0;
            B_AccessID = 0;
            BookingNo = string.Empty;
            HotelName = string.Empty;
            CompanyName = string.Empty;
            ListTraveller = string.Empty;
            HotelCountryCode = string.Empty;
            HotelCountryName = string.Empty;
           ;
        }
    }   

    public class ServiceLevelAgreement_CallLog
    {
        public List<P_CallLog> ListCallLog { get; set; }
        public long TotalRecords { get; set; } 
    }


    public class P_CallLog
    {
        public long M_HotelPlatformID { get; set; }
        public long B_AccessID { get; set; }
        public string BookingNo { get; set; }
        public DateTime CheckOut { get; set; }
        public string HotelName { get; set; }
        public string HotelCountryCode { get; set; }
        public string HotelCountryName { get; set; }
        public string CompanyName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Caller { get; set; }
        public string Comment { get; set; }

        public P_CallLog()
        {
            M_HotelPlatformID = 0;
            B_AccessID = 0;
            BookingNo = string.Empty;
            HotelName = string.Empty;
            HotelCountryCode = string.Empty;
            HotelCountryName = string.Empty;
            CompanyName = string.Empty;
            Caller = string.Empty;
            Comment = string.Empty;            
        }
    }


    public class ServiceLevelAgreement_CallLogs
    {
        public List<P_CallLogs> ListCallLog { get; set; }
        public long TotalRecords { get; set; } 
    }


    public class P_CallLogs
    {
         private string hotelPlatformName;

        public string HotelPlatformName
        {
            get { return hotelPlatformName; }
            set { hotelPlatformName = value; }
        }

        private long iD;

        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }

        private DateTime callDate;

        public DateTime CallDate
        {
            get { return callDate; }
            set { callDate = value; }
        }

        private string hotelName;

        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }
        private string hotelNo;

        public string HotelNo
        {
            get { return hotelNo; }
            set { hotelNo = value; }
        }
        private string hotelAddress;

        public string HotelAddress
        {
            get { return hotelAddress; }
            set { hotelAddress = value; }
        }
        private string countryName;

        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }
        }
        private string countryCode;

        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }
        private string contact;

        public string Contact
        {
            get { return contact; }
            set { contact = value; }
        }
        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string caller;

        public string Caller
        {
            get { return caller; }
            set { caller = value; }
        }
        private int numberOfBookings;

        public int NumberOfBookings
        {
            get { return numberOfBookings; }
            set { numberOfBookings = value; }
        }

        private bool isShowListBooking;

        public bool IsShowListBooking
        {
            get { return isShowListBooking; }
            set { isShowListBooking = value; }
        }

        


        private long totalRecords;

        public long TotalRecords 
        {
            get { return totalRecords; }
            set { totalRecords = value; }
        }


        public List<P_BookingOfCall> ListBooking { get; set; }

        public P_CallLogs()
        {
            IsShowListBooking = false;
            ListBooking = new List<P_BookingOfCall>();
        }
    }

}
